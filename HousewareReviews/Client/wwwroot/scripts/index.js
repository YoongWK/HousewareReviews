// Hide Collapsable Bootstrap Navbar If Browser Width Changed From Below XL (<1200px) to Above XL (>=1200px)
let widthXL = false;
window.addEventListener('resize', function() {
    const currentWidth = window.innerWidth;
    const widthXLNow = currentWidth >= 1200;

    if (!widthXL && widthXLNow) {
        hideNavBar();
    }

    widthXL = widthXLNow;
});

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
