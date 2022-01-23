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
        private int  _bankDifficulity = 100;


        public List<TeamMember> TeamMembers = new List<TeamMember>();
        

        
//while (buildingTeam)
//{
//    var newTeamMember = factory.BuildNewTeamMember();
//    if (newTeamMember.Name != "")
//    {
//        heist.TeamMembers.Add(newTeamMember)
//    }
//    else
//    {
//        buildingTeam = false;
//    }
//}                            

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
                var newTeamMember = factory.BuildNewTeamMember();
                if (newTeamMember.Name != "")
                {
                    heist.TeamMembers.Add(newTeamMember)
                }
                else
                {
                    buildingTeam = false;
                }
            }
        }
    }
}
