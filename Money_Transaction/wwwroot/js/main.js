const anchors = document.querySelectorAll(".sidebar a");

console.log(anchors)

anchors.forEach(a => {
  a.addEventListener("click", () => {
    console.log(anchors)
    anchors.forEach(a => {
      a.classList.remove("active");
    })
    a.classList.add("active")
  });
});




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
    let label = option.firstElementChild.nextElementSibling.innerText.toLowerCase();
    if (label.indexOf(searchTerm) != -1) {
      option.style.display = "block";
    } else {
      option.style.display = "none";
    }
  });
};



