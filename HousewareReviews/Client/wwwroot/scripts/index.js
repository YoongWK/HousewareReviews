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

function updateCharCount(inputField, maxlLength) {
    var formGroupDiv = inputField.closest('.form-group');
    var pElement = formGroupDiv.querySelector('p');
    var charCountSpan = pElement.querySelector('span');
    var charCount = inputField.value.length;
    charCountSpan.textContent = charCount;
    if (charCount > maxlLength) {
        charCountSpan.classList.add("text-danger");
    } else {
        charCountSpan.classList.remove("text-danger");
    }
}

window.ImgHandlers = {};
window.ModalImgHandlers = {};

function updateImgHeight(imgId, hwRatio) {
    var image = document.getElementById(imgId);
    image.style.height = `${image.width * hwRatio}px`;
}

function addImgHeightListener(imgId, hwRatio) {
    function imgHandler() {
        updateImgHeight(imgId, hwRatio);
    }
    window.addEventListener('resize', imgHandler);
    window.ImgHandlers[imgId] = imgHandler;
}

function removeImgHeightListener(imgId) {
    var imgHandler = window.ImgHandlers[imgId];
    if (imgHandler) {
        window.removeEventListener('resize', imgHandler);
        delete window.ImgHandlers[imgId];
    }
}

function addModalImgHeightListener(modalId, imgId, hwRatio) {
    var modal = document.getElementById(modalId);
    function imgHandler() {
        updateImgHeight(imgId, hwRatio);
    }
    window.addEventListener('resize', imgHandler);
    modal.addEventListener('shown.bs.modal', imgHandler);
    window.ModalImgHandlers[modalId] = imgHandler;
}

function removeModalImgHeightListener(modalId) {
    var modal = document.getElementById(modalId);
    var imgHandler = window.ModalImgHandlers[modalId];
    if (imgHandler) {
        window.removeEventListener('resize', imgHandler);
        modal.removeEventListener('shown.bs.modal', imgHandler);
        delete window.ModalImgHandlers[modalId];
    }
}
