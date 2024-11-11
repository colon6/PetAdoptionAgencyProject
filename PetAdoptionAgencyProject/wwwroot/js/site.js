// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function popupfunction(animalId) {
    // Show the modal and the overlay
    document.getElementById(animalId).style.display = 'block';
    document.getElementById('overlay').style.display = 'block';
    document.body.classList.add('modal-open');
}

function popupclose(animalId) {
    // Hide the modal and the overlay
    document.getElementById(animalId).style.display = 'none';
    document.getElementById('overlay').style.display = 'none';
    document.body.classList.remove('modal-open');
}
