
using p1bPoo.Clases;


static void imprimir(Carro A, Carro B)
{
    Console.WriteLine($"{A.owner}={A.GetVelocidadActual()} ===  {B.owner}={B.GetVelocidadActual()} ");
}


Tractor trac = new Tractor("Jhondeer", 30, "Juan Chapin");
string mensajes;
trac.EncenderMotor();
mensajes = trac.acelerar();
Console.WriteLine(mensajes);
mensajes = trac.levantarPala();
Console.WriteLine(mensajes);
mensajes=trac.acelerar(50);
Console.WriteLine(mensajes);


//Carro carroA     = new Carro("Honda Civic", 160,"Samuel");
//Carro carroB = new Carro("Nisan",165,"Jesus");

//// crear otro carro y hacer comparaciones;



//carroB.EncenderMotor();
//carroA.EncenderMotor();

//Random velociadRandom = new Random();
//int velCarroA;
//int velCarroB;

//for (int i = 0; i < 10; i++)
//{
//    velCarroA = velociadRandom.Next(1, 20);
//    velCarroB = velociadRandom.Next(1, 20);
//    carroA.acelerar(velCarroA);
//    carroB.acelerar(velCarroB);
//    imprimir(carroA, carroB);
//    //Console.WriteLine("enter para seguir");
//    //Console.ReadLine();
//}


//if (carroA.GetVelocidadActual() > carroB.GetVelocidadActual())
//{
//    Console.WriteLine($"{carroA.owner} Wins!!");
//}
//else
//{
//    Console.WriteLine($"{carroB.owner} Wins!!");
//}




//carrito.EncenderMotor();
//mensaje=carrito.acelerar();
//Console.WriteLine(mensaje);



//carrito.acelerar();
//carrito.acelerar();
//carrito.acelerar();
//carrito.acelerar();
//carrito.acelerar();
////Console.WriteLine(carrito.GetVelocidadActual());
//Console.WriteLine(carrito.DameInformacion());

