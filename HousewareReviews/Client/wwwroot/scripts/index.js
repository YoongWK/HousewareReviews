// Hide Collapsable Bootstrap NavBar
function hideNavBar() {
    let navbar = document.querySelector('#navbarNav');
    let bsCollapse = bootstrap.Collapse.getOrCreateInstance(navbar);
    bsCollapse.hide();
}

// Set Focus On Search Input Field
function SetSearchInputFocus() {
    document.getElementById('searchinput').focus();
}

// Autoplay Carousel function
function startAutoplayCarousel() {
    setTimeout(3000);
    document.getElementById("nextFurnitureCarouselBtn").click();
}

// View replies and comments
function showRepliesNComments(reviewId) {
    // the button is id = "repliesncomments"
    let container = document.getElementById(`rncContainer-${reviewId}`);
    if (container) {
        container.style.display = container.style.display === 'none' ? 'block' : 'none';
    }
}

function hideModal(modalSelector) {
    let modal = document.querySelector(modalSelector);
    let bsModal = bootstrap.Modal.getOrCreateInstance(modal);
    bsModal.hide();
}