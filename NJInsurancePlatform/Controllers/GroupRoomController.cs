using Microsoft.AspNetCore.Mvc;
using NJInsurancePlatform.Models;
using NJInsurancePlatform.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol;
using NJInsurancePlatform.InterfaceImplementation;

namespace NJInsurancePlatform.Controllers
{
    [AllowAnonymous]
    public class GroupRoomController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly iRoomRepository _roomRepository;
        private readonly iGroupRoomMessageRepository _iGroupRoomMessageRepository;
        public GroupRoomController(iRoomRepository iroomRepository, iGroupRoomMessageRepository iGroupRoomMessageRepository, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this._roomRepository = iroomRepository;
            _iGroupRoomMessageRepository = iGroupRoomMessageRepository;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> AddGroupRoom(GroupRoom model)
        {
            GroupRoom _GroupRoom = new GroupRoom()
            {
                GroupMUID = model.GroupMUID,
                Name = model.Name
            };

            _roomRepository.InsertGroupRoom(_GroupRoom);
            _roomRepository.Save();

            return RedirectToAction("","");
        }

        [HttpPost]
        public async Task<IActionResult> AddGroupRoomMessage(GroupRoomMessage model)
        {
            Guid newGuid = Guid.NewGuid();
            GroupRoomMessage _GroupRoomMessage = new GroupRoomMessage()
            {
                GroupRoomMessageMUID = newGuid,
                GroupRoomMUID = model.GroupRoomMUID,
                SenderMUID = model.SenderMUID,
                Message = model.Message
            };

            _iGroupRoomMessageRepository.InsertMessage(_GroupRoomMessage);
            _iGroupRoomMessageRepository.Save();

            return RedirectToAction("", "");
        }

        // Route To Create Group View
        [HttpGet]
        public async Task<ActionResult> Message()
        {
            // If Not Logged In, Reroute To Access Denied
            if(User.Identity.Name == null)
            {
                return RedirectToAction("AccessDenied", "Administration");
            }

            var identityUser = User.Identity?.Name;
            var user = await _userManager.FindByNameAsync(identityUser);
            var allRooms = await _roomRepository.GetGroupRooms();


            MessagesViewModel messagesViewModel = new MessagesViewModel()
            {
                groupRooms = allRooms,
                applicationUser = user,
            };

            return View(messagesViewModel);
        }       
        


        // Post Form Input From View
        [HttpPost]
        public async Task<ActionResult> CreateGroup(MessagesViewModel model)
        {
            try
            {
                    GroupRoom groupRoom = new GroupRoom()
                    {
                        GroupMUID = model.groupRoom.GroupMUID,
                        Name = model.groupRoom.Name,
                    };

                    _roomRepository.InsertGroupRoom(groupRoom);
                    _roomRepository.Save();

                    return RedirectToAction("Message", "GroupRoom");

            }
            catch(ArgumentNullException e)
            {
                throw new ArgumentNullException(paramName: nameof(e), message: "Parameter can't be null"); 
            }
            
            return View("Not Found"); 
        }


        // Populate Field with Messages in Selected Group
        [HttpGet]
        public async Task<ActionResult> PopulateMessages(string Id)
        {

            var identityUser = User.Identity?.Name;
            var user = await _userManager.FindByNameAsync(identityUser);
            var roomMessages = await _iGroupRoomMessageRepository.GetMessages();
            var messageByRoomID = roomMessages.FindAll(m => m.GroupRoomMUID.ToString() == Id);  // Assign All Columns Within This Room ID
            var allRooms = await _roomRepository.GetGroupRooms();
            var roomName = allRooms.FirstOrDefault(n => n.GroupMUID.ToString() == Id);

            // using tempData to pass information to the view
            TempData["RoomId"] = Id;
            TempData["RoomName"] = roomName.Name;

            // sort by date
            messageByRoomID.Sort((x, y) => DateTime.Compare(x.CreatedDate, y.CreatedDate));

            MessagesViewModel messagesViewModel = new MessagesViewModel()
            {
                groupRooms = allRooms,
                groupRoomMessages = messageByRoomID,
                applicationUser = user,
            };

            return View("Message", messagesViewModel);
        }


        // Post Form Input From View
        [HttpPost]
        public async Task<ActionResult> CreateMessage(MessagesViewModel model)
        {
            try
            {
                //Get current User MUID
                var customerIdentity = User.Identity.Name;
                var user = await _userManager.FindByNameAsync(customerIdentity);

                GroupRoomMessage roomMessage = new GroupRoomMessage()
                {
                    GroupRoomMessageMUID = model.groupRoomMessage.GroupRoomMessageMUID,
                    GroupRoomMUID = model.groupRoom.GroupMUID,
                    SenderMUID = (Guid)user.CustomerMUID,
                    Message = model.groupRoomMessage.Message,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    CreatedDate = DateTime.Now
                };


                    _iGroupRoomMessageRepository.InsertMessage(roomMessage);
                    _iGroupRoomMessageRepository.Save();

                // redirect to current group chat
                return RedirectToAction("PopulateMessages", new {id = model.groupRoom.GroupMUID});

            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException(paramName: nameof(e), message: "Parameter can't be null");
            }

            return View("Not Found");
        }
    }
}

