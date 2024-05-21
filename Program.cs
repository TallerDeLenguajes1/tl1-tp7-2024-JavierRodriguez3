// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;


Console.WriteLine("Hello, World!");

Calculadora NuevaC = new Calculadora();

int Eleccion;
double num;
int repetir;

do{

Console.WriteLine("Precionar 1 si quiere sumar \n Precionar 2 si quiere restar \n Precionar 3 si quiere multiplicar \n Precionar 4 si quiere dividir \n Precionar 5 si quiere limpiar la ecuacion \n");
Eleccion = Convert.ToInt32(Console.ReadLine());
switch(Eleccion){
    case 1:
        Console.WriteLine("Ingresar el numero a sumar");
        num = Convert.ToInt32(Console.ReadLine());
        NuevaC.Sumar(num);
        break;
    case 2:
        Console.WriteLine("Ingresar el numero a restar");
        num = Convert.ToInt32(Console.ReadLine());
        NuevaC.Restar(num);
        break;
    case 3:
        Console.WriteLine("Ingresar el numero a multiplicar");
        num = Convert.ToInt32(Console.ReadLine());
        NuevaC.Multiplicar(num);
        break;
    case 4:
        Console.WriteLine("Ingresar el numero a dividir");
        num = Convert.ToInt32(Console.ReadLine());
        NuevaC.Dividir(num);
        break;
    case 5:
        Console.WriteLine("Se va a limpiar el resultado");
        NuevaC.Limpiar();
        break;
}

Console.WriteLine("Ingresar 1 si desea terminar ingresar 0 si desea seguir");
repetir = Convert.ToInt32(Console.ReadLine());
}while(repetir != 1);





Console.WriteLine(NuevaC.Resultado);