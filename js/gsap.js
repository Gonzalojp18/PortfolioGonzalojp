gsap.registerPlugin(ScrollTrigger);


// ABOUT SECTION
let tl = gsap.timeline({
  scrollTrigger: {
    trigger: '.headingTwo',
    start: "top center",
    ease: "power1.inOut",
    scrub: 1
  }
})

tl.to('.letter', {
  y: 80,
  duration: 0.1,
  color: '#3d107380',
  stagger: {
    from: 'start',
    each: 0.1,
  }
});

// PROJECT SECTION



// gsap.set(".mainProject", {opacity: 1});

// gsap.timeline().from('.infoProject', {scale: 1})


let tlp = gsap.timeline({
  duration: 3,
  scrollTrigger: {
    trigger: '.infoProject',
    start: "top top",
    pin: true,
    paused: true,
    scrub: 2,
    repeat: 2, // number of repeats (-1 for infinite)
    repeatDelay: -1, // seconds between repeats
    repeatRefresh: true, // invalidates on each repeat
  }
})

tlp.to('.title',{
  x: -800, //each project gonna cross all the screen
  ease: 'power2.out',
  duration: 4,
  delay: 1
})

tlp.to('.frontEnd',{
  x: 900, //each project gonna cross all the screen
  ease: 'power2.out',
  duration: 4,
  delay: -1
})

// SCROLL EACH PROJECT

tlp.to('.details',{
  x: -1200, //each project gonna cross all the screen
  stagger: {
    each: 2,
    amount: .2,
    duration: 2,
    scrub: 1
  }
})


let mm = gsap.matchMedia();
    mm.add("(min-width: 480px) and (max-width: 768px)", () => {
// set up the alternating up and down movement

tlp.to('.details', {
  x: -2500, // move horizontally by 100 pixels
  });

})

// ScrollTrigger on section skill

tlp.to(".skill", {
  y: 50,
  scrub: 2,
  duration: .3,
  stagger: { // wrap advanced options in an object
    each: 4,
    amount: .3,
    from: 'start'
  }
});



