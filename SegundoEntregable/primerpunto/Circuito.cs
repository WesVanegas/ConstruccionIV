namespace Vehiculos;

public class Circuito{
    public Monoplaza monoplaza = new Monoplaza();
    int NumVueltas;
    string NombreCircuito;
    private Random random;

    public Circuito(string Nombre,int NumVueltas){
        this.NombreCircuito=Nombre;
        this.NumVueltas=NumVueltas;
        this.random = new Random();
        Console.WriteLine($"\nInicia Circuito {this.NombreCircuito}");
    }
    
    public void AgregarMonoplaza(Monoplaza monoplaza){
        this.monoplaza=monoplaza;
        Console.WriteLine($"\nEntra monoplaza: {this.monoplaza.Escuderia}");
    }

    public int TiempoVuelta(){
        return this.random.Next(100000, 999999);
    }

    public int RealizarPrueba(){
        int vueltas=this.NumVueltas;
        int mejorTiempo=999999;
        int tiempo;
        
        Console.WriteLine("Estado inicial: ");
        Console.WriteLine("Monoplaza Encendido: "+this.monoplaza.Encendido);
        Console.WriteLine("Monoplaza Movimiento: "+this.monoplaza.Movimiento);

        Console.WriteLine("\nInicia Prueba de: "+this.monoplaza.Escuderia);

        this.monoplaza.Encender();
        this.monoplaza.Mover();

        for (int i = 0; i < vueltas; i++){
            tiempo=this.TiempoVuelta();
            if (mejorTiempo>=tiempo){
                mejorTiempo=tiempo;
            }
            Console.WriteLine("\nVuelta numero: "+(i+1));
            Console.WriteLine("Tiempo de vuelta: "+tiempo);
            Console.WriteLine("Monoplaza En movimiento: "+this.monoplaza.Movimiento);
        }
        Console.WriteLine("\nTermina la prueba");
        this.monoplaza.Detener();
        this.monoplaza.Apagar();
        Console.WriteLine("Estado Final: ");
        Console.WriteLine("Monoplaza Encendido: "+this.monoplaza.Encendido);
        Console.WriteLine("Monoplaza Movimiento: "+this.monoplaza.Movimiento);
        Console.WriteLine($"Mejor tiempo de vuelta de: {this.monoplaza.Escuderia} es: {mejorTiempo}");

        
        return mejorTiempo;
    }


    public void SacarMonoplaza(){
        Console.WriteLine("Se retira monoplaza: "+this.monoplaza.Escuderia);
        this.monoplaza=null;
    }

    public void TablaPosiciones(int[] tiempos, string[]vehiculos){
        Console.WriteLine("\nTABLA DE POSICIONES");

        List<(int index, int value)> indexedTiempos = tiempos.Select((value, index) => (index, value)).ToList();

        List<(int index, int value)> sortedTiempos = indexedTiempos.OrderBy(x => x.value).ToList();

        List<int> sortedPosiciones = sortedTiempos.Select(x => x.index).ToList();

        for (int i = 0; i < sortedPosiciones.Count; i++)
        {
            int pos = sortedPosiciones[i];
            Console.WriteLine($"{i + 1}. {vehiculos[pos]} - Tiempo: {tiempos[pos]}");
        }
    }
    



}