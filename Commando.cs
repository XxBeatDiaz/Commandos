using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class Commando
    {
        private string Name;
        public string CodeName { get; set; }
        string Status;

        public Commando(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Status = "unknown";
            string[] Tools = { "Hammer", "Water bottle", "Bag", "Rope", "Chisel" };
        }

        public string SayName(string commanderRank)
        {
            if (commanderRank.ToUpper() == "GENERAL")
            {
                return Name;
            }

            else if (commanderRank.ToUpper() == "COLONEL")
            {
                return CodeName;
            }

            else
            {
                return "The information is classified.";
            }
        }

        public void Walk()
        {
            Console.WriteLine("Walk");
            Status = "walk.";
        }

        public void Hide()
        {
            Console.WriteLine("Hide");
            Status = "Hidd.";
        }

        public void Attack()
        {
            Console.WriteLine($"{CodeName}: Attack");
            Status = "Attack.";
        }
    }
}
