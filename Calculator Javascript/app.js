var firstnum = "";
var secondnum = "";
var operation;
var result;

function clickNum1()
{
    document.getElementById("calcOutput").innerHTML += 1;
}
function clickNum2()
{
    document.getElementById("calcOutput").innerHTML += 2;
}
function clickNum3()
{
    document.getElementById("calcOutput").innerHTML += 3;
}
function clickNum4()
{
    document.getElementById("calcOutput").innerHTML += 4;
}
function clickNum5()
{
    document.getElementById("calcOutput").innerHTML += 5;
}
function clickNum6()
{
    document.getElementById("calcOutput").innerHTML += 6;
}
function clickNum7()
{
    document.getElementById("calcOutput").innerHTML += 7;
}
function clickNum8()
{
    document.getElementById("calcOutput").innerHTML += 8;
}
function clickNum9()
{
    document.getElementById("calcOutput").innerHTML += 9;
}
function clickNum0()
{
    document.getElementById("calcOutput").innerHTML += 0;
}

function clickPlus()
{
    firstnum =parseInt(document.getElementById("calcOutput").innerHTML);
    document.getElementById("calcOutput").innerHTML= "";
    operation = "+";
}

function clickMinus()
{
    firstnum = parseInt(document.getElementById("calcOutput").innerHTML);
    document.getElementById("calcOutput").innerHTML = "";
    operation = "-"
}

function clickMultiply()
{
    firstnum = parseInt(document.getElementById("calcOutput").innerHTML);
    document.getElementById("calcOutput").innerHTML = "";
    operation = "*";
}

function clickDivide()
{
    firstnum = parseInt(document.getElementById("calcOutput").innerHTML);
    document.getElementById("calcOutput").innerHTML = "";
    operation = "/";
}

function clickClear() {
    document.getElementById("calcOutput").innerHTML = "";
    document.getElementById("calcEquation").innerHTML = "";
    firstnum = "";
    secondnum = "";
}

function equal()
{
    secondnum = parseInt(document.getElementById("calcOutput").innerHTML);
    document.getElementById("calcOutput").innerHTML = "";

    

    switch (operation)
    {
        case "+":           
            result = secondnum + firstnum;
            document.getElementById("calcOutput").innerHTML = result;
            document.getElementById("calcEquation").innerHTML = firstnum + "+" + secondnum;
            break;

        case "-":
            result = secondnum - firstnum;
            document.getElementById("calcOutput").innerHTML = result;
            document.getElementById("calcEquation").innerHTML = firstnum + " - " + secondnum;
            break;
        
        case "*":     
            result = secondnum * firstnum;
            document.getElementById("calcOutput").innerHTML = result;
            document.getElementById("calcEquation").innerHTML = firstnum + " x " + secondnum;
            break;
        
        case "/":       
            result = secondnum / firstnum;
            document.getElementById("calcOutput").innerHTML = result;
            document.getElementById("calcEquation").innerHTML = firstnum + " / " + secondnum;
            break;
    }
}