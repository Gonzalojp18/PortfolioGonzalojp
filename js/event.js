let next = document.querySelector('.btn');
let send = document.getElementById('sendName');
let userName = document.getElementById('name');
let home = document.getElementById('home');
let boxName = document.getElementById('mensagge');
let welcome = document.querySelector('.welcome');
let mensagge = document.getElementById('mensagge');
let label = document.getElementById('label');
let inputName = document.querySelector('[data-input-name]');


next.addEventListener('click', (e) => {
    e.preventDefault();
    let tlCard = gsap.timeline({ delay: .1, ease: 'elastic'});
    tlCard.to(".welcome", { scale: (1.1),  translateX:(-20), translateY:(-20), duration: 1,  x: -100, y: -180})
    welcome.style.visibility = 'visible';
    home.style.visibility = 'hidden';
});

send.addEventListener("click", (e) => {
    e.preventDefault();
    let name = userName.value;
    if(name == ''){
        mensage('Hello User World!');
    }else{
        label.innerHTML =
        `<p>Bienvenido!</p>`;
        inputName.innerHTML = `<span>${name}</span>`;
    }
    send.textContent = 'Continuar';
});

send.addEventListener('click', () =>{
    setTimeout(() => {
        nav.classList.toggle('active');
}, 100);
if((nav.style.visibility === 'visible')){
    mensagge.style.visibility = 'hidden';
}
});



function mensage(mensaje){
    label.innerHTML =
    `<span>${mensaje}</span>`;
}