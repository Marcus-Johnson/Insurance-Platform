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
            var allMessages = await _iGroupRoomMessageRepository.GetMessages();

            MessagesViewModel messagesViewModel = new MessagesViewModel()
            {
                groupRooms = allRooms,
                groupRoomMessages = allMessages,
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


        // Post Form Input From View
        [HttpPost]
        public async Task<ActionResult> CreateMessage([Bind(include: "GroupRoomMessageMUID, GroupRoomMUID, SenderMUID, Message")] GroupRoomMessage model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _iGroupRoomMessageRepository.InsertMessage(model);
                    _iGroupRoomMessageRepository.Save();

                    return RedirectToAction("Message", "Home");

                }
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException(paramName: nameof(e), message: "Parameter can't be null");
            }

            return View("Not Found");
        }
    }
}

