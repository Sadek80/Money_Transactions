var nav = document.querySelector("nav");
var closeBtn = document.getElementById('close-btn');
var menu = document.getElementById('menu-btn');

const startQueries = () => {
  let newQuery = window.matchMedia( 'screen and (max-width: 1200px)' )
  console.log(nav);
  
    var dates = document.querySelectorAll(".date");

    if (newQuery.matches) {
        nav.style.display = 'block';
    }

    if(dates.length > 0){
      done = false;
      if(newQuery.matches && done == false){  
        dates.forEach(d => {
         d.innerHTML = d.innerHTML.substring(0,12)
         done = true;
        });
      }
      else{
        dates.forEach(d => {
         d.innerHTML = d.innerHTML;
         done = false;
        });
      }
    }
}


const startMobileQueries = () => {
  let newQuery = window.matchMedia( 'screen and (max-width: 736px)' )
  console.log(nav);

    if (newQuery.matches) {
        nav.style.display = 'none';
    }

    var transactio_main = document.querySelector(".transactions-main");
    console.log(transactio_main);
    if(transactio_main != undefined){
      transactio_main.setAttribute('class', '')
    }
}

window.addEventListener('resize', () => {
 startQueries();
 startMobileQueries();

});


window.addEventListener('load', () => {
  startQueries();
  startMobileQueries();
 
 });


menu.addEventListener('click', () => {
  nav.style.display = 'block'
});

closeBtn.addEventListener('click', () =>{
  nav.style.display = 'none';
})



const selected = document.querySelector(".selected");
const optionsContainer = document.querySelector(".options-container");
const searchBox = document.querySelector(".search-box input");
const sendAmount = document.getElementById("amount");

const optionsList = document.querySelectorAll(".option");

selected.addEventListener("click", () => {
  optionsContainer.classList.toggle("active");

  searchBox.value = "";
  filterList("");

  if (optionsContainer.classList.contains("active")) {
    searchBox.focus();
  }
});


function validate() {
    var form = document.transaction_form;
    var amount = form.amount.value;
    console.log(amount);
    console.log(form.recieverId)
    var balance = document.getElementById("balance").innerText;
    var validation = document.getElementById("validation");
    console.log(validation);

    validation.innerHTML = "";

    var amount = form.amount.value;
    console.log(amount);

    valid = true;

    if (amount == "") {
        validation.innerHTML += "<li>Amount is required<li>";
        valid = false
    }


    if (+amount > +balance && amount != "") {
        validation.innerHTML += "<li>Amount exceeds the balance</li>";
        valid = false
    }

    var recipient = document.getElementById("recipient").value;


    if ((+recipient <= 0  || +amount <= 0 ) && amount != "") {
        validation.innerHTML += "<li>Unrecognized Amount Value</li>";
        valid = false;
    }

    var reciverValid = false;
    var reciverId = form.recieverId;


    for (var i = 0; i < reciverId.length; i++) {
        if (reciverId[i].checked) {
            reciverValid = true;
            break;
        }

    }

    if (!reciverValid) {
        validation.innerHTML += "<li>Choose Reciever First</li>";
        valid = false;
    }

    if (!valid) {
        return false;
    }

}

function amountCalc(){
  // var balance = document.getElementById("balance").innerHTML.value;

  var ele = document.getElementsByName("type");
  var fee = "";

  for(i = 0; i < ele.length; i++) {
    if(ele[i].checked){
      fee = ele[i].value;
    }       
}

  if(sendAmount.value == ""){
    document.getElementById("recipient").value = "";
  }
  else{
    if(fee == "standard")
        var amount = (+sendAmount.value - +0.99);
    else
        var amount = (+sendAmount.value - +1.50);

    if(amount > 0){
    document.getElementById("recipient").value = ""+ (amount);

    }
  }
}

optionsList.forEach(o => {
  o.addEventListener("click", () => {
    selected.innerHTML = o.querySelector("label").innerHTML;
    optionsContainer.classList.remove("active");
  });
});

searchBox.addEventListener("keyup", function(e) {
  filterList(e.target.value);
});

const filterList = searchTerm => {
  searchTerm = searchTerm.toLowerCase();
  optionsList.forEach(option => {
    let label = option.innerText.toLowerCase();
    if (label.indexOf(searchTerm) != -1) {
      option.style.display = "block";
    } else {
      option.style.display = "none";
    }
  });
};



