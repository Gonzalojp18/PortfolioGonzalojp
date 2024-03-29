.navBar {
  position: absolute;
  top: 2rem;
  width: 90%;
  border-radius: 1rem;
  transition: all 1s ease-in-out;
  clip-path: circle(0% at 100% 0%);
  z-index: 999;
  background: linear-gradient(120deg, #4c3279 30.71%, #23153c);
}
.navBar .link {
  all: unset;
  display: flex;
  height: 90vh;
  flex-direction: column;
  align-items: center;
  justify-content: space-around;
  list-style: none;
}
.navBar .link li a {
  color: #f6f9ff;
  text-decoration: none;
  font-weight: bold;
  font-size: 0.9rem;
  letter-spacing: 0.3em;
  font-family: "Roboto Flex", sans-serif;
}
.navBar .link li a:hover {
  background: linear-gradient(100deg, #dfc22c 20.71%, #e8ca35);
  border-radius: 1rem;
  transition: all 0.2s ease-in-out;
  padding: 0.5rem;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .navBar {
    top: 1rem;
  }
  .navBar .link li a {
    font-size: 0.6rem;
    letter-spacing: 0.2em;
  }
}
html * {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  background-color: #24153e;
}

.header {
  width: 97%;
  height: 100vh;
}
.header .homeName {
  text-align: left;
  width: 70%;
  visibility: visible;
  padding: 15% 0 0 2%;
}
.header .homeName .name .hi {
  font-size: 2.5rem;
  font-weight: 400;
  color: #cad6dd;
  font-family: "apercu", sans-serif;
  -webkit-text-stroke: 1px #cad6dd;
  font-weight: bold;
  color: transparent;
}
.header .homeName .name h1 {
  color: #dd0d2c;
  font-size: 3.5rem;
  font-weight: 700;
  min-width: 50%;
}
.header .homeName .name .quote {
  text-align: left;
  color: rgba(221, 13, 44, 0.8);
  font-size: 1.6rem;
  width: 60%;
  padding: 0.5rem 0 0.5rem 0;
  font-weight: 700;
  font-family: "apercu" sans-serif;
}
.header .homeName .name .intro {
  width: 45%;
  font-size: 1rem;
  margin: 0 0 2rem 0;
  font-weight: 400;
  color: #cad6dd;
}
.header .homeName .name .btn {
  border-radius: 4rem;
  border: 2px solid #23153c;
  width: 15%;
  padding: 0.3rem;
  margin-bottom: 4rem;
  color: #cad6dd;
  background: linear-gradient(100deg, rgb(181, 5, 61) 20.71%, #88051d);
}
.header .homeName .name .btn:hover {
  background: linear-gradient(100deg, #bfe8e2 20.71%, #ccdedc);
  box-shadow: rgb(181, 5, 61) 0px 15px 15px -5px;
  transition: all 0.4s ease-in-out;
  color: #c50a2d;
  border: 2px solid #c50a2d;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .header {
    width: 96%;
  }
  .header .homeName {
    width: 80%;
    visibility: visible;
    padding: 90% 0 0 2%;
  }
  .header .homeName .name .hi {
    font-size: 1rem;
    font-weight: 300;
    color: transparent;
  }
  .header .homeName .name h1 {
    color: #dd0d2c;
    font-size: 1.5rem;
    font-weight: 600;
  }
  .header .homeName .name .quote {
    font-size: 1rem;
    width: 80%;
    padding: 0;
    font-weight: 600;
  }
  .header .homeName .name .intro {
    width: 100%;
    font-size: 0.6rem;
    margin: 0;
    font-weight: 200;
  }
  .header .homeName .name .btn {
    width: 50%;
    margin-bottom: 0;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .header .homeName {
    width: 80%;
    padding: 90% 0 0 2%;
  }
  .header .homeName .name .hi {
    font-size: 2rem;
    font-weight: 500;
  }
  .header .homeName .name h1 {
    font-size: 2.5rem;
  }
  .header .homeName .name .quote {
    font-size: 1.5rem;
    padding: 0;
  }
  .header .homeName .name .intro {
    width: 80%;
    font-size: 1rem;
    margin: 0 0 0.5rem 0;
  }
  .header .homeName .name .btn {
    width: 50%;
    margin-bottom: 0.5rem;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .header .homeName {
    width: 80%;
    padding: 60% 0 0 2%;
  }
  .header .homeName .name .hi {
    font-size: 3rem;
    font-weight: 600;
  }
  .header .homeName .name h1 {
    font-size: 3.5rem;
    font-weight: 700;
  }
  .header .homeName .name .quote {
    font-size: 2rem;
    font-weight: 600;
    padding: 0;
  }
  .header .homeName .name .intro {
    width: 70%;
    font-size: 1.2rem;
    margin: 0 0 1rem 0;
  }
  .header .homeName .name .btn {
    width: 30%;
    margin-bottom: 0.5rem;
  }
}
@media all and (min-width: 60rem) and (max-width: 70rem) {
  .header .homeName {
    width: 80%;
    padding: 95% 0 0 2%;
  }
  .header .homeName .name .hi {
    font-size: 2rem;
    font-weight: 600;
  }
  .header .homeName .name h1 {
    font-size: 2.5rem;
    font-weight: 700;
  }
  .header .homeName .name .quote {
    font-size: 2rem;
    font-weight: 600;
  }
  .header .homeName .name .intro {
    width: 70%;
    font-size: 0.9rem;
    margin: 0 0 1rem 0;
  }
  .header .homeName .name .btn {
    width: 30%;
    margin-bottom: 0.5rem;
  }
}

.menu {
  position: absolute;
  left: 95%;
  top: 3%;
  cursor: pointer;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .menu {
    left: 87%;
    top: 1%;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .menu {
    left: 90%;
    top: 1%;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .menu {
    left: 92%;
    top: 1.5rem;
  }
}

.sticky {
  position: fixed;
  top: 90%;
  left: 40%;
  width: 25%;
  height: 8%;
  padding-top: 0.8rem;
  border-radius: 100px;
  z-index: 9999;
  visibility: hidden;
}
.sticky .iconMenu {
  display: flex;
  list-style: none;
  justify-content: space-around;
  align-items: center;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .sticky {
    width: 80%;
    left: 10%;
    padding-top: 0.5rem;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .sticky {
    width: 80%;
    left: 10%;
    padding-top: 0.6rem;
    height: 5%;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .sticky {
    width: 80%;
    left: 10%;
    padding-top: 0.8rem;
  }
}

.NavScroll {
  background-color: rgba(223, 194, 44, 0.7);
  color: #fff;
  box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.2);
}

.stickProject {
  position: sticky;
}

.active {
  clip-path: circle(115% at 16% 120%);
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .active {
    clip-path: circle(90% at 0% 50%);
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .active {
    clip-path: circle(90% at 0% 50%);
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .active {
    clip-path: circle(90% at 20% 50%);
  }
}

#loading {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  color: #cad6dd;
  font-size: 1.5rem;
}

.custom-loader {
  width: 50px;
  height: 50px;
  display: grid;
}

.custom-loader::before,
.custom-loader::after {
  content: "";
  grid-area: 1/1;
  --c: radial-gradient(farthest-side,#711FD5 92%,#0000);
  background: var(--c) 50% 0, var(--c) 50% 100%, var(--c) 100% 50%, var(--c) 0 50%;
  background-size: 12px 12px;
  background-repeat: no-repeat;
  animation: s2 1s infinite;
}

.custom-loader::before {
  margin: 4px;
  filter: hue-rotate(45deg);
  background-size: 8px 8px;
  animation-timing-function: linear;
}

@keyframes s2 {
  100% {
    transform: rotate(0.5turn);
  }
}
.scrollDownleft {
  position: absolute;
  writing-mode: vertical-rl;
  box-orient: vertical;
  direction: rtl;
  transform: rotate(180deg);
  top: 80%;
  left: 0%;
}
@media all and (min-width: 20rem) and (max-width: 29rem) {
  .scrollDownleft {
    display: none;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .scrollDownleft {
    left: 0;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .scrollDownleft {
    left: 0;
  }
}

.scrollDownright {
  position: absolute;
  writing-mode: vertical-rl;
  box-orient: vertical;
  direction: rtl;
  transform: rotate(180deg);
  top: 80%;
  left: 98.5%;
}
@media all and (min-width: 20rem) and (max-width: 29rem) {
  .scrollDownright {
    display: none;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .scrollDownright {
    left: 97%;
  }
}
.description * {
  padding-bottom: 0 0 1rem 0;
}

.scrollDownLeftProject {
  position: relative;
  writing-mode: vertical-rl;
  box-orient: vertical;
  direction: rtl;
  transform: rotate(180deg);
  top: 60%;
  left: 0.3%;
  height: 50%;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .scrollDownLeftProject {
    left: 0;
    height: 70%;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .scrollDownLeftProject {
    left: 0%;
    height: 70%;
  }
}
.scrollDownRightProject {
  position: relative;
  writing-mode: vertical-rl;
  box-orient: vertical;
  direction: rtl;
  transform: rotate(180deg);
  top: 80%;
  left: 19%;
  height: 50%;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .scrollDownRightProject {
    left: 22%;
    height: 70%;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .scrollDownRightProject {
    left: 18%;
    height: 70%;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .scrollDownRightProject {
    left: 23%;
    height: 70%;
  }
}

.access {
  margin-top: 1.5rem;
}
.access a {
  text-decoration: none;
  background-color: #f90041;
  border-radius: 5%;
  padding: 0.5rem;
  margin: 1rem;
  color: #f3f3f3;
}
.access a:hover {
  background-color: #f3f3f3;
  color: #f90041;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .access {
    margin-top: 0.3rem;
  }
  .access a {
    padding: 0.2rem;
    font-size: 0.7rem;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .access {
    margin-top: 1.5rem;
  }
  .access a {
    padding: 0.5rem;
    font-size: 1rem;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .access {
    margin-top: 1.5rem;
  }
  .access a {
    padding: 0.5rem;
    font-size: 1rem;
  }
}

.sectionMain {
  margin: auto;
  padding: 2rem 0 0 0;
  border-radius: 10px;
  width: 95%;
}
.sectionMain .bitMe {
  margin: 0;
  width: 70%;
  font-size: 2.5rem;
  color: #f2f7f7;
  font-weight: 200;
  height: 10%;
  padding: 1rem;
}
.sectionMain .bitMe span {
  background-color: #dfc22c;
  color: #f2f7f7;
  padding: 0.5rem;
  border-radius: 10px;
  font-size: 2.2rem;
  letter-spacing: 0.4rem;
  font-weight: bold;
}
.sectionMain .whoIam {
  display: flex;
  justify-content: space-between;
  width: 100%;
  padding: 1rem;
  margin: auto;
  color: #f2f7f7;
}
.sectionMain .whoIam .headingTwo {
  display: flex;
  font-size: 7.5rem;
  font-weight: bold;
  color: rgba(223, 194, 44, 0.9);
  position: relative;
  top: 2%;
  width: 60%;
}
.sectionMain .whoIam .description {
  font-size: 1.2rem;
  width: 50%;
  text-align: justify;
  padding: 0 1rem 0 1rem;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .sectionMain {
    margin: 0;
  }
  .sectionMain .bitMe {
    width: 100%;
    font-size: 1.3rem;
  }
  .sectionMain .bitMe span {
    color: #e5edf1;
    padding: 0.2rem;
    border-radius: 10px;
    font-size: 1.5rem;
    letter-spacing: 0.4rem;
  }
  .sectionMain .whoIam {
    width: 100%;
  }
  .sectionMain .whoIam .headingTwo {
    flex-direction: column;
    margin: 0;
    font-size: 2.5rem;
    font-weight: bold;
    top: 1%;
    left: 2%;
    width: 20%;
    box-orient: vertical;
  }
  .sectionMain .whoIam .description {
    font-size: 0.8rem;
    width: 100%;
    margin: 0;
    text-align: justify;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .sectionMain {
    margin: 0;
  }
  .sectionMain .bitMe {
    width: 90%;
    font-size: 1.5rem;
    height: 5%;
  }
  .sectionMain .bitMe span {
    color: #e5edf1;
    padding: 0.2rem;
    border-radius: 10px;
    font-size: 2rem;
    letter-spacing: 0.4rem;
  }
  .sectionMain .whoIam {
    width: 100%;
  }
  .sectionMain .whoIam .headingTwo {
    flex-direction: column;
    margin: 0;
    font-size: 4rem;
    font-weight: bold;
    top: 1%;
    left: 3%;
    box-orient: vertical;
  }
  .sectionMain .whoIam .description {
    font-size: 1rem;
    width: 80%;
    text-align: justify;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .sectionMain {
    margin: 0;
  }
  .sectionMain .bitMe {
    width: 90%;
    font-size: 1.8rem;
    height: 5%;
  }
  .sectionMain .bitMe span {
    color: #e5edf1;
    padding: 0.2rem;
    border-radius: 10px;
    font-size: 2.2rem;
    letter-spacing: 0.4rem;
    font-weight: bold;
  }
  .sectionMain .whoIam {
    width: 100%;
  }
  .sectionMain .whoIam .headingTwo {
    flex-direction: column;
    margin: 0;
    font-size: 3rem;
    font-weight: bold;
    top: 0;
    left: 10%;
    box-orient: vertical;
  }
  .sectionMain .whoIam .description {
    font-size: 1.2rem;
    width: 90%;
    text-align: justify;
  }
}

.main {
  overflow: hidden;
  height: 330vh;
  margin-top: 4rem;
}
.main .mainProject {
  width: 500vw;
  height: 100vh;
  background-color: #dfc22c;
}
.main .mainProject .infoProject {
  width: 30%;
  height: 50%;
  position: relative;
  left: 7%;
  color: #f3f3f3;
  display: flex;
}
.main .mainProject .infoProject .details {
  border-radius: 5%;
  margin: 2rem;
  width: 15%;
  text-align: center;
  position: relative;
}
.main .mainProject .infoProject .details .titlePorject {
  padding: 1rem;
}
.main .mainProject .infoProject .details img {
  width: 100%;
}
.main .mainProject .title {
  position: relative;
  padding-top: 0%;
  left: 13%;
  font-size: 8rem;
  font-weight: bold;
  color: #f3f3f3;
}
.main .mainProject .frontEnd {
  position: absolute;
  top: 75%;
  left: 2%;
}
.main .mainProject .frontEnd h4 {
  font-size: 5rem;
  font-weight: bold;
  -webkit-text-stroke: 1px rgb(35, 21, 60);
  color: transparent;
  font-family: Neuemontreal, sans-serif;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .main .mainProject .infoProject {
    font-size: 0.8rem;
    width: 100%;
    top: 1%;
    left: 2%;
  }
  .main .mainProject .infoProject .details {
    margin: 2rem;
    width: 50%;
    height: 100%;
  }
  .main .mainProject .infoProject .details .titlePorject {
    padding: 0.2rem;
  }
  .main .mainProject .infoProject .details img {
    width: 100%;
  }
  .main .mainProject .title {
    font-size: 4rem;
    left: 2%;
  }
  .main .mainProject .frontEnd {
    position: absolute;
    top: 19%;
    left: 12%;
  }
  .main .mainProject .frontEnd h4 {
    font-size: 2.5rem;
  }
}
@media all and (min-width: 31rem) and (max-width: 48rem) {
  .main .mainProject .infoProject {
    font-size: 0.8rem;
    width: 90%;
  }
  .main .mainProject .infoProject .details {
    margin: 2rem;
    width: 40%;
  }
  .main .mainProject .infoProject .details .titlePorject {
    padding: 0.5rem;
  }
  .main .mainProject .infoProject .details img {
    width: 100%;
  }
  .main .mainProject .title {
    font-size: 4rem;
    left: 2%;
  }
  .main .mainProject .frontEnd {
    position: absolute;
    top: 19%;
    left: 19%;
  }
  .main .mainProject .frontEnd h4 {
    font-size: 4rem;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .main .mainProject .infoProject {
    font-size: 0.8rem;
    width: 90%;
  }
  .main .mainProject .infoProject .details {
    margin: 1rem;
    width: 40%;
  }
  .main .mainProject .infoProject .details .titlePorject {
    padding: 0.5rem;
  }
  .main .mainProject .infoProject .details img {
    width: 100%;
  }
  .main .mainProject .title {
    font-size: 6rem;
    left: 2%;
  }
  .main .mainProject .frontEnd {
    position: absolute;
    top: 19%;
    left: 12%;
  }
  .main .mainProject .frontEnd h4 {
    font-size: 6rem;
  }
}

.boxSkill {
  display: flex;
  flex-wrap: wrap;
  width: 80%;
  height: 30%;
  border-radius: 1rem;
  position: relative;
  left: 15%;
  top: 4%;
}
.boxSkill .titleSkill {
  color: #dfc22c;
  font-weight: bold;
}
.boxSkill .titleSkill .tech {
  font-size: 6rem;
  margin-bottom: 0.3rem;
  position: absolute;
  bottom: 90%;
}
.boxSkill .titleSkill .tools {
  writing-mode: vertical-rl;
  box-orient: vertical;
  direction: ltr;
  transform: rotate(180deg);
  position: absolute;
  right: 98.6%;
  font-size: 5rem;
  font-weight: 500;
  -webkit-text-stroke: 1px #dfc22c;
  color: transparent;
}
.boxSkill .skill {
  background-color: #dfc22c;
  width: 18%;
  height: 20%;
  margin: 2rem 0.5rem 0 1rem;
  border-radius: 1rem;
  padding: 0.5rem;
  box-shadow: #dfc22c 0px 2px 5px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}
.boxSkill .skill .textSkil {
  text-align: center;
  font-size: 0.8rem;
  color: #23153c;
  width: 80%;
  margin: 0.5rem auto 0 auto;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  .boxSkill {
    height: 60%;
  }
  .boxSkill .titleSkill .tech {
    font-size: 3rem;
    bottom: 100%;
  }
  .boxSkill .titleSkill .tools {
    right: 99%;
    font-size: 2.5rem;
  }
  .boxSkill .skill {
    width: 28%;
    height: 20%;
    margin: 1rem 0.5rem 0 1rem;
  }
  .boxSkill .skill .textSkil {
    text-align: center;
    font-size: 0.6rem;
    width: 90%;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  .boxSkill {
    height: 40%;
  }
  .boxSkill .titleSkill .tech {
    font-size: 4rem;
    bottom: 100%;
    margin-bottom: 0.5rem;
  }
  .boxSkill .titleSkill .tools {
    right: 99%;
    font-size: 4rem;
  }
  .boxSkill .skill {
    width: 40%;
    height: 15%;
    margin: 0 0.2rem 0 1rem;
  }
  .boxSkill .skill .textSkil {
    text-align: center;
    font-size: 0.9rem;
    width: 90%;
  }
}
@media all and (min-width: 48rem) and (max-width: 60rem) {
  .boxSkill {
    height: 35%;
  }
  .boxSkill .titleSkill .tech {
    font-size: 4rem;
    bottom: 100%;
    margin-bottom: 0.5rem;
  }
  .boxSkill .titleSkill .tools {
    right: 99%;
    font-size: 4rem;
  }
  .boxSkill .skill {
    width: 35%;
    height: 10%;
    margin: 0 0.2rem 0 0.2rem;
  }
  .boxSkill .skill .textSkil {
    text-align: center;
    font-size: 0.8rem;
    width: 90%;
  }
}
@media all and (min-width: 60rem) and (max-width: 70rem) {
  .boxSkill {
    height: 35%;
  }
  .boxSkill .titleSkill .tech {
    font-size: 4rem;
    bottom: 100%;
    margin-bottom: 0.5rem;
  }
  .boxSkill .titleSkill .tools {
    right: 99%;
    font-size: 4rem;
  }
  .boxSkill .skill {
    width: 35%;
    height: 10%;
    margin: 0 0.2rem 0 0.2rem;
  }
  .boxSkill .skill .textSkil {
    text-align: center;
    font-size: 0.8rem;
    width: 90%;
  }
}

#contactMe {
  background-color: #dfc22c;
  margin: 0 auto 0 30%;
  width: 60%;
  height: 80vh;
  border: 0.5em solid #f3f3f3;
  display: flex;
  flex-direction: column;
  align-items: center;
}
#contactMe .boxContact {
  position: relative;
  bottom: 23%;
  color: #f3f3f3;
}
#contactMe .boxContact .contactHeading {
  font-size: 5rem;
  font-weight: 700;
}
#contactMe .boxForm {
  position: relative;
  bottom: 10%;
  display: flex;
  flex-direction: column;
}
#contactMe .boxForm .contactParragraph {
  margin-bottom: 2rem;
  font-size: 1rem;
  text-align: center;
}
#contactMe .boxForm .form {
  display: flex;
  flex-direction: column;
  margin: auto;
}
#contactMe .boxForm .form .name {
  display: flex;
}
#contactMe .boxForm .form .name .lname {
  margin-left: 1rem;
}
#contactMe .boxForm .form .textarea {
  height: 15vh;
}
@media all and (min-width: 20rem) and (max-width: 30rem) {
  #contactMe {
    background-color: #dfc22c;
    margin: 5% auto 0 20%;
  }
  #contactMe .boxContact {
    bottom: 10%;
  }
  #contactMe .boxContact .contactHeading {
    font-size: 2rem;
    margin-top: 4rem;
  }
  #contactMe .boxContact .boxForm {
    bottom: 2%;
  }
}
@media all and (min-width: 30rem) and (max-width: 48rem) {
  #contactMe {
    margin: 10% auto 0 20%;
  }
  #contactMe .boxContact {
    bottom: 10%;
  }
  #contactMe .boxContact .contactHeading {
    font-size: 3rem;
  }
  #contactMe .boxContact .boxForm {
    bottom: 2%;
  }
}
.boxFooter {
  display: flex;
  flex-direction: column;
  align-items: center;
  height: 40vh;
  margin-top: 4rem;
}
.boxFooter h2 {
  color: #f3f3f3;
  font-weight: 200;
  font-size: 2rem;
}
.boxFooter .socialMedia {
  display: flex;
  justify-content: space-around;
  margin-top: 3rem;
  width: 30%;
}
.boxFooter .socialMedia li {
  list-style: none;
}

/*# sourceMappingURL=style.cs.map */
