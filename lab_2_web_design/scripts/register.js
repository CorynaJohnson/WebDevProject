function register() {
    var Fname = document.getElementById("FirstName");
    var Lname = document.getElementById("LastName");
    var Age = document.getElementById("Age");
    var Year = document.getElementById("Year");

    var result = Fname.toString() + Lname.toString() + Age.toString() + Year.toString();

    var resultElement = document.getElementById("result");

    resultElement.innerHTML = result;
}