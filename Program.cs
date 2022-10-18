// Daniel Decoito
// 10-1-22 
// Mini Challenge 6 "Odd or Even
// Create a looping game that determine if the number entered is odd or even
// Peer revied by Mauricio acosta- Functions great!

Console.Clear();
bool boolOne = false;
string terminateGame = "Dan";
string userInput = "";
int intNum = 0;

Console.WriteLine("Hello lets play agame called odd or even.");

while (terminateGame != "")
{
Console.Clear();
Console.WriteLine("Input a number and I will tell you if its odd or even\n");
while (boolOne == false)
{
Console.WriteLine("Please enter a number");
userInput = Console.ReadLine();
boolOne = int.TryParse(userInput, out intNum);
}
Console.WriteLine(userInput = intNum %2 == 0 ? $"The number {intNum} is even." : $"The number {intNum} is odd.");
Console.WriteLine("Would you like to play again press any key follwed by enter.\nIf you would like to end just press enter.");
    terminateGame = Console.ReadLine();
    boolOne = false;
}