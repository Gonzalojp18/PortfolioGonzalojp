window.addEventListener("load", function () {
    const loading = document.getElementById("loading");
    loading.style.display = "none";
});

document.addEventListener("DOMContentLoaded", function () {
    const loading = document.getElementById("loading");
    loading.style.display = "flex";
});

window.addEventListener("scroll", function () {
    const nav = document.querySelector(".sticky");
    if (window.pageYOffset > nav.offsetTop + 700) {
        nav.classList.add("NavScroll");
        nav.style.visibility = 'visible';
    } else {
        nav.classList.remove("NavScroll");
        nav.style.visibility = 'hidden'
    }
});
