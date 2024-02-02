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