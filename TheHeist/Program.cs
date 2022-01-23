// See https://aka.ms/new-console-template for more information

using TheHeist;
using TheHeist.Models;


var title = $@"



 _______  __                          __      __                                __    __          __            __     
/       \/  |                        /  \    /  |                              /  |  /  |        /  |          /  |    
$$$$$$$  $$ | ______  _______        $$  \  /$$______  __    __  ______        $$ |  $$ | ______ $$/  _______ _$$ |_   
$$ |__$$ $$ |/      \/       \        $$  \/$$/      \/  |  /  |/      \       $$ |__$$ |/      \/  |/       / $$   |  
$$    $$/$$ |$$$$$$  $$$$$$$  |        $$  $$/$$$$$$  $$ |  $$ /$$$$$$  |      $$    $$ /$$$$$$  $$ /$$$$$$$/$$$$$$/   
$$$$$$$/ $$ |/    $$ $$ |  $$ |         $$$$/$$ |  $$ $$ |  $$ $$ |  $$/       $$$$$$$$ $$    $$ $$ $$      \  $$ | __ 
$$ |     $$ /$$$$$$$ $$ |  $$ |          $$ |$$ \__$$ $$ \__$$ $$ |            $$ |  $$ $$$$$$$$/$$ |$$$$$$  | $$ |/  |
$$ |     $$ $$    $$ $$ |  $$ |          $$ |$$    $$/$$    $$/$$ |            $$ |  $$ $$       $$ /     $$/  $$  $$/ 
$$/      $$/ $$$$$$$/$$/   $$/           $$/  $$$$$$/  $$$$$$/ $$/             $$/   $$/ $$$$$$$/$$/$$$$$$$/    $$$$/  
                                                                                                                         

";



//Build Team


var buildingTeam = true;
var successfulInput = false;

var heist = new HeistSimulator();
Console.WriteLine(title);

heist.DetermineHeistDifficulty();

successfulInput = false;
     // paraenthiesis will help with "" problem in teranry.

//Console.Clear();
//var teamMemberCountText = $"The {(teamMembers.Count == 1 ? "is" : "are")} {teamMembers.Count} {(teamMembers.Count == 1 ? "member" : "members")} team members.";
//Console.WriteLine(teamMemberCountText);

//foreach (TeamMember member in teamMembers)
//{
//    Console.WriteLine(member.ToString());
//}

//Determine # of heists



var numberofHeists = Console.ReadLine();
 successfulInput = false;
var parsedNumberofHeists = 0;

while (!successfulInput)
{
    Console.WriteLine("How many heist simulations do you want to run?");
    var numberOfHeists = Console.ReadLine();
    successfulInput = int.TryParse(numberOfHeists, out parsedNumberofHeists);
}

//display results for each heist

var successCount = 0;
var failureCount = 0;

for (int i = 0; i < parsedNumberofHeists; i++)
{
    var luck = new Random().Next(-10, 10); // get random number between -10 and 10
    var sum = 0;
    foreach (var member in teamMembers)
    {
        sum += member.SkillLevel;
    }
    var modifiedDifficulty = bankDifficulity + luck;

    var heistResult = sum >= modifiedDifficulty;
    if (heistResult)
    {
        successCount += 1;
    }
    else
    {
        failureCount++;
    }
    Console.WriteLine($"There were {successCount} successful heists and {failureCount} failures");
    //Console.WriteLine($"Your skill level is {sum} and the difficult is {bankDifficulity}");
    //Console.WriteLine($"The heist was a {(heistResult ? "success" : "failure")}");
}
//if (sum >= bankDifficulity)    // MAKE IT WORK THEN REFACTOR TO MAKE IT READABLE LIKE ABOVE LINE!
//{
//    // DisplaySuccess();
//    Console.WriteLine("The heist was successful");
//}
//else
//{
//    //DisplayFailure();
//    Console.WriteLine("The heist failed");
//}






