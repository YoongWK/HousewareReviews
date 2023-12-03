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