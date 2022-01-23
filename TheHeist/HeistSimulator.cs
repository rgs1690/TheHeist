using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheHeist.Models;

namespace TheHeist
{
    internal class HeistSimulator
    {
        //difficulty - a way of setting it
        private int _bankDifficulity = 100;
        private TeamMemberFactory _teamMemberFactory = new TeamMemberFactory();
        private int _numberOfHeists = 0;

        public List<TeamMember> TeamMembers = new List<TeamMember>();                          

        public void DetermineHeistDifficulty()
        {
            var successfulInput = false;

            while (!successfulInput)
            {
                Console.WriteLine("Enter the difficulty of your bank heist:");
                var difficulty = Console.ReadLine();
                successfulInput = int.TryParse(difficulty, out _bankDifficulity);
            }

        }
        public void CreateTeam()
        {
            var buildingTeam = true;
            while (buildingTeam)
            {
                var newTeamMember = _teamMemberFactory.BuildNewTeamMember();
                if (newTeamMember.Name != "")
                {
                    TeamMembers.Add(newTeamMember);
                }
                else
                {
                    buildingTeam = false;
                }
            }
        }



        public void DetermineNumberofTests() // Abstraction - hiding a complicated process behind a simple facade
        {
            var successfulInput = false;
            while (!successfulInput)
            {
                Console.WriteLine("how many heist simulations do you want to run?");
                var numberofheists = Console.ReadLine();
                successfulInput = int.TryParse(numberofheists, out _numberOfHeists);
            }

        }
        public void ShowResults()
        {
            var successCount = 0;
            var failureCount = 0;

            for (int i = 0; i < _numberOfHeists; i++)
            {
                var luck = new Random().Next(-10, 10); // get random number between -10 and 10
                var sum = 0;
                foreach (var member in TeamMembers)
                {
                    sum += member.SkillLevel;
                }
                var modifiedDifficulty = _bankDifficulity + luck;

                var heistResult = sum >= modifiedDifficulty;
                if (heistResult)
                {
                    successCount += 1;
                }
                else
                {
                    failureCount+= 1;
                }
                Console.WriteLine($"There were {successCount} successful heists and {failureCount} failures");
            }
        }
    }
}
