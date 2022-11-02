// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Navbar Drop Dopwn Trigger
$(".dropdown-trigger").dropdown();
	
// Dark Mode Icon Toggle
$('.dark-toggle').on('click', function () {
	if ($(this).find('i').text() == 'brightness_4') {
		$(this).find('i').text('brightness_high');
	} else {
		$(this).find('i').text('brightness_4');
	}
});


// Dark Mode Function
function DarkMode() {
	var element = document.body;
	element.classList.toggle("dark-mode");
	console.log(element.classList.contains("dark-mode"));
}