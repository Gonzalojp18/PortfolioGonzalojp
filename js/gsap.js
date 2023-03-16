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

let tlp = gsap.timeline({
  scrollTrigger: {
    trigger: '.main',
    start: "top top",
    pin: true,
    scrub: 4,
    repeat: 2, // number of repeats (-1 for infinite)
    repeatDelay: -1, // seconds between repeats
    repeatRefresh: true, // invalidates on each repeat
  }
})

tlp.to('.title',{
  x: -600, //each project gonna cross all the screen
  ease: 'power2.out',
  duration: 0.2,
  delay: 1
})

tlp.to('.frontEnd',{
  x: 600, //each project gonna cross all the screen
  ease: 'power2.out',
  duration: 0.2,
})

// SCROLL EACH PROJECT

tlp.to('.details',{
  x: -1500, //each project gonna cross all the screen
  ease: "slow(0.7, 0.7, false)",
  duration: 0.2,
  stagger: {
    from: 'start',
    each: 1,
    amount: .1,
  }
})


let mm = gsap.matchMedia();
    mm.add("(min-width: 768px) and (max-width: 960px)", () => {
// set up the alternating up and down movement

tlp.to('.details', {
  x: -3000, // move horizontally by 100 pixels
  });

})



