namespace Vehiculos;

public class Circuito{
    public IMonoplaza[] monoplazas = new IMonoplaza[3];
    int NumVueltas;
    string NombreCircuito;
    private Random random;

    public Circuito(string Nombre,int NumVueltas){
        this.NombreCircuito=Nombre;
        this.NumVueltas=NumVueltas;
    }
    
    public void AgregarMonoplaza(IMonoplaza monoplaza){
        if (this.monoplazas[0]==null){
            this.monoplazas[0]=monoplaza;
        }else if (this.monoplazas[1]==null){
            this.monoplazas[1]=monoplaza;
        }else if (this.monoplazas[2]==null){
            this.monoplazas[2]=monoplaza;
        }
    }

    public int RealizarPrueba(){
        
        int TiempoVuelta = random.Next(100000, 999999);

        return 4;

    }

    public void SacarMonoplaza(){

    }


}