// Hide Collapsable Bootstrap NavBar Function
function hideNavBar() {
    let navbar = document.querySelector('#navbarNav');
    let bsCollapse = bootstrap.Collapse.getOrCreateInstance(navbar);
    bsCollapse.hide();
}

// Set Focus On Search Input Field Function
function SetSearchInputFocus() {
    document.getElementById('searchinput').focus();
}

// Autoplay Carousel Function
function startAutoplayCarousel() {
    setTimeout(3000);
    document.getElementById("nextFurnitureCarouselBtn").click();
}

// Hide Modal Function
function hideModal(modalSelector) {
    let modal = document.querySelector(modalSelector);
    let bsModal = bootstrap.Modal.getOrCreateInstance(modal);
    bsModal.hide();
}

// Update Input Text Area Character Count Function
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

// Store Image Resize Handlers
window.ImgHandlers = {};
window.ModalImgHandlers = {};

// Update Image Height According to Aspect Ratio Function
function updateImgHeight(imgId, hwRatio) {
    var image = document.getElementById(imgId);
    image.style.height = `${image.width * hwRatio}px`;
}

// Add Listener for Adjusting Image Height Function
function addImgHeightListener(imgId, hwRatio) {
    function imgHandler() {
        updateImgHeight(imgId, hwRatio);
    }
    window.addEventListener('resize', imgHandler);
    window.ImgHandlers[imgId] = imgHandler;
}

// Remove Listener for Adjusting Image Height Function
function removeImgHeightListener(imgId) {
    var imgHandler = window.ImgHandlers[imgId];
    if (imgHandler) {
        window.removeEventListener('resize', imgHandler);
        delete window.ImgHandlers[imgId];
    }
}

// Add Listener for Adjusting Image Height in Modal Function
function addModalImgHeightListener(modalId, imgId, hwRatio) {
    var modal = document.getElementById(modalId);
    function imgHandler() {
        updateImgHeight(imgId, hwRatio);
    }
    window.addEventListener('resize', imgHandler);
    modal.addEventListener('shown.bs.modal', imgHandler);
    window.ModalImgHandlers[modalId] = imgHandler;
}

// Remove Listener for Adjusting Image Height in Modal Function
function removeModalImgHeightListener(modalId) {
    var modal = document.getElementById(modalId);
    var imgHandler = window.ModalImgHandlers[modalId];
    if (imgHandler) {
        window.removeEventListener('resize', imgHandler);
        modal.removeEventListener('shown.bs.modal', imgHandler);
        delete window.ModalImgHandlers[modalId];
    }
}
