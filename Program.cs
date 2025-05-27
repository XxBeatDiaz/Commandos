using Commandos.Models;

namespace Commandos
{
    class Program
    {
        static void Main(string[] args)
        {
            Factories.weapons.Add(new Weapon("AK", "Rusia", 27));
        }
    }
}
