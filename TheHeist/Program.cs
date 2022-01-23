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






Console.WriteLine(title);
var heist = new HeistSimulator();
heist.DetermineHeistDifficulty();
heist.CreateTeam();
heist.DetermineNumberofTests();
heist.ShowResults();




//successfulInput = false;
     // paraenthiesis will help with "" problem in teranry.

//Console.Clear();
//var teamMemberCountText = $"The {(teamMembers.Count == 1 ? "is" : "are")} {teamMembers.Count} {(teamMembers.Count == 1 ? "member" : "members")} team members.";
//Console.WriteLine(teamMemberCountText);

//foreach (TeamMember member in teamMembers)
//{
//    Console.WriteLine(member.ToString());
//}

//Determine # of heists



//var successfulInput = false;
//var parsedNumberofHeists = 0;
//var numberofHeists = Console.ReadLine();
// successfulInput = false;

//while (!successfulInput)
//{
//    Console.WriteLine("how many heist simulations do you want to run?");
//    var numberofheists = Console.ReadLine();
//    successfulInput = int.TryParse(numberofheists, out parsedNumberofHeists);
//}

//display results for each heist


    //Console.WriteLine($"Your skill level is {sum} and the difficult is {bankDifficulity}");

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






