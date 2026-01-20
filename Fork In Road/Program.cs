// Steps 1 and 2
Console.WriteLine("You reach a fork in the road.");
Console.WriteLine("Say LEFT to go towards a town.");
Console.WriteLine("Say RIGHT to go towards a mountain.");

//Step 3: Get user response, remember it in string variable
string userInput;               //Declare
userInput= Console.ReadLine()!; //Initialize

//Step 4: Check player response for LEFT or RIGHT
if (userInput == "LEFT")
{
    Console.WriteLine("You arrive at the town of...");
}
else if (userInput == "RIGHT")
{
    Console.WriteLine("You arrive at a mountain called...");
}
else
{
    Console.WriteLine("The only valid options to type are LEFT AND RIGHT!");
}