using Commandos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos.Models
{
    public class FactoryComando
    {
        private static List<Commando> Commandos = new List<Commando> { };
        private static int numName = 1;
        public static void AddCommando(string type)
        {
            Commando commando;
            switch (type)
            {
                case "air":
                    commando = new AirCommando($"avi{numName}", "a");
                    Commandos.Add(commando);
                    numName++;
                    break;
                   
                case "Sea":
                    commando = new SeaCommando($"yoni{numName}", "y");
                    Commandos.Add(commando);
                    numName++;
                    break;

                default:
                    commando = new Commando($"malca{numName}", "m");
                    Commandos.Add(commando);
                    numName++;
                    break;
            }
        }

        public List<Commando> GetList()
        {
            return Commandos;
        }
    }
}
