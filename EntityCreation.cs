using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class EntityCreation
    {
        string Name;
        string CodeName;
        string Status;

        public EntityCreation(string name, string codeName)
        {
            Name = name;
            CodeName = codeName;
            Status = "unknown";
            string[] Tools = { "Hammer", "Water bottle", "Bag", "Rope", "Chisel" };
        }

        public void Walk()
        {
            Console.WriteLine("Walk");
            Status = "walk";
        }

        public void Hide()
        {
            Console.WriteLine("Hide");
            Status = "Hidd";
        }

        public void Attack()
        {
            Console.WriteLine($"{CodeName}: Attack");
            Status = "Attack";
        }
    }
}
