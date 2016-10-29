function register() {
    var Fname = document.getElementById("FirstName");
    var Lname = document.getElementById("LastName");
    var Age = document.getElementById("Age");
    var Year;
    if (document.getElementById('Year1').checked) {
        Year = document.getElementById('Year1').value;
    }
    else if (document.getElementById('Year2').checked) {
        Year = document.getElementById('Year2').value;
    }
    else if (document.getElementById('Year3').checked) {
        Year = document.getElementById('Year3').value;
    }
    else if (document.getElementById('Year4').checked) {
        Year = document.getElementById('Year4').value;
    }

    var result = Fname.value + " " + Lname.value + " is " + Age.value + " years old and is a " + Year;

    var resultElement = document.getElementById("result");

    resultElement.innerHTML = result;
}