namespace Vehiculos;

public class Monoplaza : IMonoplaza{
    public string Escuderia{get; set;}
    public bool Encendido=false;
    public bool Movimiento=false;

    public void Encender(){
        if (this.Encendido==false){
            this.Encendido=true;
            Console.WriteLine("Monoplaza encendido");
        }
    }
    public void Apagar(){
        if (this.Encendido==true & this.Movimiento==false){
            this.Encendido=false;
            Console.WriteLine("Se Apaga Monoplaza");
        }else if (this.Movimiento==true){
            Console.WriteLine("Monoplaza en movimiento, no se puede apagar");
        }
    }
    public void Mover(){
        if (this.Movimiento==false & this.Encendido==true){
            this.Movimiento=true;
            Console.WriteLine("Monoplaza en movimiento");
        }else if (this.Movimiento==true){
            Console.WriteLine("Continua en movimiento");
        }
    }
    public void Detener(){
        if (this.Movimiento==true & this.Encendido==true){
            this.Movimiento=false;
            Console.WriteLine("Deteniendo monoplaza");
        }
    }

}