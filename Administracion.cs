namespace Administracion;

public enum Cargo{
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

public class Empleado{

    private string? nombre;

    private string? apellido;

    private DateTime fechaNacimiento;

    private char? estadoCivil;

    private DateTime fechaIngreso;

    private double sueldoBasico;

    private Cargo cargoEmpleado;

    public string Nombre { get => nombre; set => nombre = value; }
    public  Cargo CargoEmpleado { get => cargoEmpleado; set => cargoEmpleado = value; }
    public string? Apellido { get => apellido; set => apellido = value; }
    public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
    public char? EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
    public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
    public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
    public int antiguedadEmpleado(DateTime now){
            return now.Year - FechaIngreso.Year;
    }
    public int edadEmpleado(DateTime now){
        return now.Year - FechaNacimiento.Year;
    }
    public int jubilarse(DateTime now){
        int edad = edadEmpleado(now);
        return 65 - edad;
    }
    public double salarios(DateTime now){
        double adicional = 0;
        int antiguedad = this.antiguedadEmpleado(now);
        if (antiguedad <= 20)
            {
                adicional = SueldoBasico * 0.01 * antiguedad;
            }
            else
            {
                adicional = SueldoBasico * 0.25;
            }
            if (CargoEmpleado == Cargo.Ingeniero || CargoEmpleado == Cargo.Especialista)
            {
                adicional *= 1.5;
            }
            if (EstadoCivil == 'C')
            {
                adicional += 150000;
            }

            return SueldoBasico + adicional;
    }
}
