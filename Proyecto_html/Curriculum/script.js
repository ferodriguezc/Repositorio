



function cambiarDiv1() {
    var div1 = document.getElementById('div1');
    var div2 = document.getElementById('div2');
    var div3 = document.getElementById('div3');
    var div4 = document.getElementById('div4');
  
    if (div1.style.display !== 'none') {
      
      div1.style.display = 'block';
      div2.style.display = 'none';
      div3.style.display = 'none';
      div4.style.display = 'none';
      

    } else {
        div1.style.display = 'block';
        div2.style.display = 'none';
        div3.style.display = 'none';
        div4.style.display = 'none';
        div.style.opacity = '1';
    div.style.maxHeight = '500px'; // Ajusta la altura máxima según tus necesidades

      }
    
  }

  function cambiarDiv2() {
    var div1 = document.getElementById('div1');
    var div2 = document.getElementById('div2');
    var div3 = document.getElementById('div3');
    var div4 = document.getElementById('div4');
  
    if (div2.style.display !== 'none') {
        div1.style.display = 'none';
        div2.style.display = 'block';
        div3.style.display = 'none';
        div4.style.display = 'none';
      } else {
        div1.style.display = 'none';
        div2.style.display = 'block';
        div3.style.display = 'none';
        div4.style.display = 'none';
      }
    }

  function cambiarDiv3() {
    var div1 = document.getElementById('div1');
    var div2 = document.getElementById('div2');
    var div3 = document.getElementById('div3');
    var div4 = document.getElementById('div4');
  
    if (div3.style.display !== 'none') {
        div1.style.display = 'none';
        div2.style.display = 'none';
        div3.style.display = 'block';
        div4.style.display = 'none';
    } else {
        div1.style.display = 'none';
        div2.style.display = 'none';
        div3.style.display = 'block';
        div4.style.display = 'none';
    }
  }


  function cambiarDiv4() {

    var div1 = document.getElementById('div1');
    var div2 = document.getElementById('div2');
    var div3 = document.getElementById('div3');
    var div4 = document.getElementById('div4');

    if (div1.style.display !== 'none') {
        div1.style.display = 'none';
        div2.style.display = 'none';
        div3.style.display = 'none';
        div4.style.display = 'block';
    } else {
        div1.style.display = 'none';
        div2.style.display = 'none';
        div3.style.display = 'none';
        div4.style.display = 'block';
    }
  }





