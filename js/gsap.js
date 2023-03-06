gsap.registerPlugin(ScrollTrigger);


let tl = gsap.timeline({
  scrollTrigger: {
    trigger: '.headingTwo',
    start: "top center",
    delay: -1,
    ease: "power1.inOut",
    scrub: true
  }

})


tl.to('.letter', {

  y: 50,
  duration: 0.2,
  color: '#3d107380',
  fontSize:'8rem',
  stagger: {
    from: 'start',
    each: 0.1,
  }

});