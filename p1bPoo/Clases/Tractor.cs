using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bPoo.Clases
{
    internal class Tractor : Carro
    {
        public int medidaPala { get; set; }
        public int capacidadCarga { get; set; } = 0;
        public Tractor(string _marca, int maxvel, string dueno) :base(_marca, maxvel,dueno)
        {

        }
        public Tractor(string _marca, int _modelo, string _color, int maxvel) : base(_marca, _modelo, _color, maxvel)
        {
        }

        public string levantarPala()
        {
            return "La pala se levanto";
        }

    }
}
