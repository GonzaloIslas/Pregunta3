function verify (answer){
    let res = document.querySelector('#'+ answer.path[0].id)
    if(answer.target.key == 'false'){
      res.style.backgroundColor = 'red'
      for (let index = 1; index <= 4; index++) {
        let res = document.querySelector([`#res${index}`])
          if(res.key== 'true'){
            res.style.backgroundColor = 'green'
          }
      }
    }else{
      res.style.backgroundColor = 'green'
    }
  }
  
  function change (){
    window.location.replace(`../html/gamepage.html`);
  }
  
  
  axios.get('http://localhost:5000/api/Question/GetQuestion',{
    params: {
      type: 6
    }
  })
  .then(function(response) {
    console.log(response)
    let preg = document.querySelector('#tilte')
    preg.innerHTML = `${response.data.questionName}`
    let res1 = document.querySelector('#res1')
    res1.innerHTML = `${response.data.answerList[0].answerName}`
    res1.key = `${response.data.answerList[0].isCorrect}`
    res1.onclick = verify
    let res2 = document.querySelector('#res2')
    res2.innerHTML =  `${response.data.answerList[1].answerName}`
    res2.key = `${response.data.answerList[1].isCorrect}`
    res2.onclick = verify
    let res3 = document.querySelector('#res3')
    res3.innerHTML = `${response.data.answerList[2].answerName}`
    res3.key = `${response.data.answerList[2].isCorrect}`
    res3.onclick = verify
    let res4 = document.querySelector('#res4')
    res4.innerHTML = `${response.data.answerList[3].answerName}`
    res4.key = `${response.data.answerList[3].isCorrect}`
    res4.onclick = verify
  
    let info = document.querySelector('#detail')
    let back = document.querySelector('#volver')
    let padre = document.querySelector('#padre')
  
  
    padre.onclick = function(){
      info.innerHTML = `${response.data.finalInfo}`
      back.innerHTML = 'VOLVER'
      back.onclick = change
      res1.onclick= change
      res2.onclick= change
      res3.onclick= change
      res4.onclick= change
    }
    
  
  
  
  }).catch(function(error) {  
    console.log('Request failed', error)  
  });
  