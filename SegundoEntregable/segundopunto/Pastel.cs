using System.Collections.Generic;
namespace pastel;

public class Pastel{
    public string nombre{get; set;}
    public int tamaño{get; set;}
    public int costo{get; set;}
    List<IIngrediente> ListaIngredientes = new List<IIngrediente>();

    public Pastel(string nombre, int tamaño){
        this.nombre=nombre;
        this.tamaño=tamaño;
        Console.WriteLine($"Pastel: {nombre} \nTamaño: {tamaño} porciones");
    }


    public void agregarIngrediente(IIngrediente ingrediente){
        ListaIngredientes.Add(ingrediente);
    }

    public int calcularCosto(){
        int Count=0;
        foreach (IIngrediente ingrediente in ListaIngredientes){
            Count=Count+(ingrediente.precio*ingrediente.cantidad);
        }
        
        //Console.WriteLine($"\nNombre del pastel: {this.nombre} De Tamaño: {this.tamaño}");
        Console.WriteLine($"Costo total del pastel: {Count}");
        return Count;
    }

    public int cantidadIngredientes(){
        int Count = ListaIngredientes.Count;
        Console.WriteLine($"Cantidad de ingredientes: {Count}");
        return Count;
    }

    public void ListarIngredientes(){
        Console.WriteLine("\nLista de ingredientes");
        int count=1;
       foreach (IIngrediente ingrediente in ListaIngredientes){
            Console.WriteLine($"{count++}. Nombre: {ingrediente.nombre}");
            Console.WriteLine($"Precio por unidad: {ingrediente.precio}");
            Console.WriteLine($"Cantidad: {ingrediente.cantidad}\n");
        }
        
    }


}