namespace EspacioCalculadora;

public class Calculadora{
    private double dato;
    public double Resultado{
            get { return dato;}
    }
    
    public void Sumar(double datoEntrada){
        dato += datoEntrada;
    }

    public void Restar(double datoEntrada){
        dato -= datoEntrada;
    }

    public void Multiplicar(double datoEntrada){
        dato *= datoEntrada;
    }

    public void Dividir( double datoEntrada){
        dato /= datoEntrada;
    }

    public void Limpiar(){
        dato = 0;
    }
}
