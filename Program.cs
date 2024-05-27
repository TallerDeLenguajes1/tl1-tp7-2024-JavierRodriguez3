// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;
using Administracion;


/*Console.WriteLine("Hello, World!");

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





Console.WriteLine(NuevaC.Resultado); */


/*Empleado empleado = new Empleado();

empleado.Apellido = "pepe";
empleado.FechaNacimiento = DateTime.Parse("2003-4-24");
DateTime fechaHoy = DateTime.Now;
empleado.CargoEmpleado = Cargo.Auxiliar;
empleado.FechaIngreso = DateTime.Parse("2000-4-20");

Console.WriteLine(empleado.Apellido);
Console.WriteLine(empleado.CargoEmpleado);
Console.WriteLine(empleado.antiguedadEmpleado(fechaHoy));
Console.WriteLine(empleado.edadEmpleado(fechaHoy));
Console.WriteLine(empleado.jubilarse(fechaHoy));*/

Empleado[] misEmpleados = new Empleado[3];
DateTime fechaHoy = DateTime.Now;

misEmpleados[0] = new Empleado
{
    Nombre = "Javier",
    Apellido = "Rodriguez",
    FechaNacimiento = DateTime.Parse("1975-4-20"),
    EstadoCivil = 'C',
    FechaIngreso = DateTime.Parse("1995-7-2"),
    SueldoBasico = 650000,
    CargoEmpleado = Cargo.Ingeniero
};

misEmpleados[1] = new Empleado
{
    Nombre = "Jose",
    Apellido = "Manolo",
    FechaNacimiento = DateTime.Parse("1940-7-20"),
    EstadoCivil = 'C',
    FechaIngreso = DateTime.Parse("1959-3-9"),
    SueldoBasico = 400000,
    CargoEmpleado = Cargo.Investigador
};

misEmpleados[2] = new Empleado
{
    Nombre = "Pancrasio",
    Apellido = "Jose",
    FechaNacimiento = DateTime.Parse("1950-6-14"),
    EstadoCivil = 'C',
    FechaIngreso = DateTime.Parse("1970-2-6"),
    SueldoBasico = 350000,
    CargoEmpleado = Cargo.Auxiliar
};

double montoTotalSalarios = misEmpleados.Sum(e => e.salarios(fechaHoy));
Console.WriteLine($"Dinero a pagar a empleados: ${montoTotalSalarios}");

Empleado proximoJubilacion = misEmpleados.OrderBy(e => e.jubilarse(fechaHoy)).First();
Console.WriteLine("Empleado cerca a la jubilacion");
Console.WriteLine($"Nombre: {proximoJubilacion.Nombre}");
Console.WriteLine($"Apellido: {proximoJubilacion.Apellido}");
Console.WriteLine($"Edad: {proximoJubilacion.edadEmpleado(fechaHoy)}");
Console.WriteLine($"Antigüedad: {proximoJubilacion.antiguedadEmpleado(fechaHoy)}");
if(proximoJubilacion.jubilarse(fechaHoy)<0){
    Console.WriteLine("Ya se puede jubilar");
}
else{
    Console.WriteLine($"Años para jubilación: {proximoJubilacion.jubilarse(fechaHoy)}");
}
Console.WriteLine($"Salario: {proximoJubilacion.salarios(fechaHoy)}");