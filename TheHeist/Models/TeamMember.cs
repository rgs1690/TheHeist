using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeist.Models
{
    internal class TeamMember
    {   public TeamMember(string name, int skill, decimal courage)
        {
            Name = name;
            SkillLevel = skill;
            courage = CourageFactor;
        }
        public string Name { get; set; }    
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public override string ToString() // common practice to override string ToString() in some compaines.
        {
            return $@"
Name: {Name}
Skill Level: {SkillLevel}
Courage: {CourageFactor}
";
        }
//        public void Print() // override 
//        {
//            Console.WriteLine($@"
//Name: {Name}
//Skill Level: {SkillLevel}
//Courage: {CourageFactor}
//");
//        }
    }
}
