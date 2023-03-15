gsap.registerPlugin(ScrollTrigger);

// ABOUT SECTION
let tl = gsap.timeline({
  scrollTrigger: {
    trigger: '.headingTwo',
    start: "top center",
    delay: -1,
    ease: "power1.inOut",
  }
})

tl.to('.letter', {
  y: 50,
  duration: 0.2,
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
    start: "top",
    pin: true,
    scrub: 4,
    repeat: 2, // number of repeats (-1 for infinite)
    repeatDelay: -1, // seconds between repeats
    repeatRefresh: true, // invalidates on each repeat
  }
})

tlp.to('.title',{
  x: -1500, //each project gonna cross all the screen
  ease: 'power2.out',
  duration: 0.2
})

tlp.to('.frontEnd',{
  x: 1500, //each project gonna cross all the screen
  ease: 'power2.out',
  duration: 0.2
})

// SCROLL EACH PROJECT

tlp.to('.details',{
  x: -1200, //each project gonna cross all the screen
  ease: "slow(0.7, 0.7, false)",
  duration: 0.2,
  end: '+-800',
  stagger: {
    from: 'start',
    each: 1,
    amount: .1,
  }
})



