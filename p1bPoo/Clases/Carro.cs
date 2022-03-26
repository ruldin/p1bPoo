using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bPoo.Clases
{
    internal class Carro
    {
        public string Marca { get;  }
       
        public int Modelo { get; }

        public string owner { get; set; }

        public String Color { get; set; }

        private  int Encendido = 0;
        private int velocidad_actual = 0;
        // private const int MAXVELOCIDAD = 150;
        public int MAXVELOCIDAD { get;  }





        //CONSTRUCTOR
        public Carro(string _marca,int _modelo, string _color, int maxvel)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            MAXVELOCIDAD = maxvel;
            this.velocidad_actual = 0;
        }


        public Carro(string _marca, int maxvel, string dueno)
        {
            Marca= _marca;
            MAXVELOCIDAD= maxvel;
            owner = dueno;
        }




        public string acelerar()
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, asi no se puede";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += 10;
                mensaje = $"Esta es la velocidad {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
            }

            //Console.WriteLine(mensaje);
            return mensaje;

        }



        public string acelerar(int AcekerarAkph)
        {
            if (Encendido == 0)
            {
                return $"El carro esta apagado, asi no se puede";
            }


            string mensaje = "";
            if (velocidad_actual <= MAXVELOCIDAD)
            {
                velocidad_actual += AcekerarAkph;
                mensaje = $"vas a {velocidad_actual} KPH";
            }
            else
            {
                velocidad_actual = MAXVELOCIDAD;
                mensaje = "Aguas, vas a maxima velocidad, rapido y furioso???";
            }

            //Console.WriteLine(mensaje);
            return mensaje;

        }



        public  int GetVelocidadActual()
        {
            return velocidad_actual;
        }


        public void EncenderMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
               // Console.WriteLine("Brururururururu carro encendido!!");
                velocidad_actual = 0;

            } else
            {
               // Console.WriteLine("ups el carro ya estaba encendido");
            }
        }

        




        public String DameInformacion()
        {
            return $"Soy un carro marca {Marca} y mi modelo es {Modelo}";
           // Console.WriteLine($"Soy un carro marca {Marca} y mi modelo es {Modelo}");
        }

    }
}
