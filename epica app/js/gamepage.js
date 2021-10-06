// Variables
var degree = 1800;
var clicks = 0;
var color = ''

// $(document).onclick(function() {
//   $('#spin').click(function() {

// Eventos
var pregunta = document.querySelector('#pregunta')
var ruleta = document.querySelector('#inner-wheel')
var boton = document.querySelector('#spin')
boton.addEventListener('click', onClick, false);
color.addEventListener('change', change)


// Funciones
function pageRedirect() {
  window.location.replace(`../html/preguntas${color}.html`);
} 

function onClick() {
  if(clicks === 0){
  ruleta.removeAttribute('style');
  
  var deg = 1500 + Math.round(Math.random() * 1500);
  console.log("deg", deg)
  
  var css = '-webkit-transform: rotate(' + deg + 'deg);';
  
  ruleta.setAttribute(
      'style', css
  );

  
  if ( deg > 1520 && deg < 1600 || deg > 1900 && deg < 1960 || deg > 2250 && deg < 2300 || deg > 2610 && deg < 2650){
    color = 'amarillas'
    console.log("amarillo")
  }
  if ( deg > 1600 && deg < 1660 || deg > 1960 && deg < 2050 || deg > 2300 && deg < 2370 || deg > 2650 && deg < 2750){
    color = 'azules'
    console.log("azul")
  }
  if ( deg > 1700 && deg < 1760 || deg > 2100 && deg < 2185 || deg > 2410 && deg < 2485 || deg > 2800 && deg < 2850){
    color = 'verdes'
    console.log("verde")
  }
  if ( deg > 1760 && deg < 1840 || deg > 2485 && deg < 2580 || deg > 2850 && deg < 2910){
    color = 'rojas'
    console.log ("rojo")
  }
  if ( deg > 1660 && deg < 1700 || deg > 2050 && deg < 2100 || deg > 2370 && deg < 2410 || deg > 2750 && deg < 2800){
    color = 'celestes'
    console.log("celeste")
  }
  if ( deg > 1450 && deg < 1520 || deg > 1840 && deg < 1900 || deg > 2185 && deg < 2250 || deg > 2910 && deg < 3000 || deg > 2550 && deg < 2610){
    color = 'naranjas'
    console.log("naranja")
  }

  // setTimeout(function() { 
  //   console.log('mouseleave')
  //   document.body.innerHTML = `./preguntas${color}.html` // "./preguntas" + color + ".html"
  // } , 5500);
  setTimeout("pageRedirect()", 5500);

}

     

  // document.body.href ="preguntasAzules.html"
  //  document.body.innerHTML("./preguntasAzules.html")
  
}

function change () {
  console.log('color', color)
  document.body.innerHTML = `./preguntas${color}.html` // "./preguntas" + color + ".html"
}


  //   boton.onclick = function(){
  //   clicks ++;
  //   var newDegree = degree * clicks;
  //   var extraDegree = Math.floor(Math.random() * (360 - 1 + 1)) + 1;
  //   totalDegree = newDegree + extraDegree; 
    
  //   '#wheel .sec'.each(function() {
  //     var t = $(this);
  //     var noY = 0;
      
  //     var c = 0;
  //     var n = 700;
  //     var interval =  setInterval(function () {
  //       c++;
  //       if (c === n) {
  //         clearInterval(interval);
  //       }
        
  //       var aoY = t.offset().top;
  //       $('#txt').html(aoY);
        
  //       if(aoY < 23.89) {
  //         $('#spin').addClass('spin');
  //         setTimeout(function () {
  //           $("#spin").removeClass('spin');
  //         }, 100);
  //       }
  //     }, 10);
      
  //     $('#inner-wheel').css({'transform' : 'rotate(' + totalDegree + 'deg)'});
      
  //     noY = t.offset().top;
  //   });
  // };



