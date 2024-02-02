// See https://aka.ms/new-console-template for more information

// Conditional if

int totalPoints = 8;
int totalGames = 15;
string message = "";

if (totalPoints > totalGames / 2)
{
    message = "You are doing great!";
}
else if (totalPoints == totalGames / 2)
{
    message = "You are doing well!";
}
else
{
    message = "You need to practice more!";
}

Console.WriteLine(message);



Console.WriteLine("\n" + new string('-', 40) + "\n");



// Conditional switch

var age = 1.1;
var country = "";
var legalAge = "";


Console.WriteLine("Enter your country: ");
country = Console.ReadLine();

Console.WriteLine("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

switch (country)
{

    case "USA":
        legalAge = age >= 21 ? "You are of legal age!" : "You are not of legal age!";
        break;
    case "UK":
        legalAge = age >= 18 ? "You are of legal age!" : "You are not of legal age!";
        break;
    case "Canada":
        legalAge = age >= 19 ? "You are of legal age!" : "You are not of legal age!";
        break;
    default:
        legalAge = "Country not found!";
        break;

}

Console.WriteLine(legalAge);



Console.WriteLine("\n" + new string('-', 40) + "\n");



// Conditional ternary

int a = 10;
int b = 20;

string result = a > b ? "a is greater than b" : "b is greater than a";

Console.WriteLine(result);