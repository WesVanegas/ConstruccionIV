
/*1.*/
/*
Console.WriteLine("Declaración de renta\n");

Console.WriteLine("Escribe el valor de tu renta en el primer trimestre");
double PrimerSemeste = double.Parse(Console.ReadLine());
Console.WriteLine("Escribe el valor de tu renta en el segundo trimestre");
double SegundoSemeste = double.Parse(Console.ReadLine());
Console.WriteLine("Escribe el valor de tu renta en el Tercer trimestre");
double TercerSemeste = double.Parse(Console.ReadLine());
Console.WriteLine("Escribe el valor de tu renta en el Cuarto trimestre");
double CuartoSemeste = double.Parse(Console.ReadLine());

double RentaAnual = PrimerSemeste+SegundoSemeste+TercerSemeste+CuartoSemeste;
double Impuesto=0;
double TotalRenta=0;


if(RentaAnual<10000){
    Impuesto=0.05;
    TotalRenta=RentaAnual+(RentaAnual*Impuesto);
}
if(RentaAnual>=10000 & RentaAnual<20000){
    Impuesto=0.1;
    TotalRenta=RentaAnual+(RentaAnual*Impuesto);
}
if(RentaAnual>=20000 & RentaAnual<35000){
    Impuesto=0.15;
    TotalRenta=RentaAnual+(RentaAnual*Impuesto);
}
if(RentaAnual>=35000 & RentaAnual<45000){
    Impuesto=0.20;
    TotalRenta=RentaAnual+(RentaAnual*Impuesto);
}
if(RentaAnual>=45000){
    Impuesto=0.30;
    TotalRenta=RentaAnual+(RentaAnual*Impuesto);
}

Console.WriteLine("Su renta anual es:"+ RentaAnual+"$");
Console.WriteLine("Total de renta a pagar: $"+ TotalRenta);
Console.WriteLine("Impuesto agregado: %"+ Impuesto*100);
*/


/*2.*/
/*
Console.WriteLine("Costo entrada a sala de juegos");
Console.WriteLine("Escriba su nombre: ");
string name = Console.ReadLine();
Console.WriteLine("Escriba su edad: ");
int age = Int32.Parse(Console.ReadLine());
double ticket = 15000;
double descuento = 0;
if(age<4){
    ticket = 0;
}
if(age>=4 & age<18){
    descuento=0.05;
    ticket = ticket*0.95;
}

if(age>=18){
    descuento=0.03;
    ticket = ticket*0.97;
}

Console.WriteLine("Nombre: "+name);
Console.WriteLine("Costo Entrada: "+ticket);
Console.WriteLine("Descuento: "+descuento*100+"%");
*/


/*3.*/
/*
Console.WriteLine("Pizzas El Fercho");
Console.WriteLine("Elige el tipo de pizza 1.Vegetariana 2.No vegetariana");
int TipoPizza = Int32.Parse(Console.ReadLine());
string Pizza = "";
int ingredientes = 0;
string ingrediente = "";

if (TipoPizza==1){
    Pizza = "Vegetariana";
    Console.WriteLine("Elige uno de los siguientes Ingredientes disponibles: 1. Pimiento 2. Champiñones");
    ingredientes = Int32.Parse(Console.ReadLine());
    if (ingredientes==1){
        ingrediente="Pimiento";
    }
    if (ingredientes==2){
        ingrediente="Champiñones";
    }
    if (ingredientes!=1 & ingredientes!=2){
    Console.WriteLine("Incorrecto! Debes elegir una de las opciones.");
    Environment.Exit(0);
    }
}
if (TipoPizza==2){
    Pizza = "No Vegetariana";
    Console.WriteLine("Elige uno de los siguientes Ingredientes disponibles: 1. Pepperoni 2. Salami 3. Pollo");
    ingredientes = Int32.Parse(Console.ReadLine());
    if (ingredientes==1){
        ingrediente="Pepperoni";
    }
    if (ingredientes==2){
        ingrediente="Salami";
    }
    if (ingredientes==3){
        ingrediente="Pollo";
    }
    if (ingredientes!=1 & ingredientes!=2 & ingredientes!=3){
    Console.WriteLine("Incorrecto! Debes elegir una de las opciones.");
    Environment.Exit(0);
    }
}
if (TipoPizza!=1 & TipoPizza!=2){
    Console.WriteLine("Incorrecto! Debes elegir una de las opciones.");
    Environment.Exit(0);
}

Console.WriteLine("La pizza es: "+Pizza+"\nlos ingredientes son: Mozzarella, tomate y "+ ingrediente);
*/


/*4.*/
/*
Console.WriteLine("Elija el nivel de evaluacion: 1.Inaceptable (0.0)  2.Aceptable (0.4)  3.Meritorio (0.6) ");
int nivel = Int32.Parse(Console.ReadLine());
string nivelEvaluacion="";
double bonificacion = 50000;
double bonificacionGanada=0;

if (nivel==1){
    bonificacionGanada=bonificacion*0.0;
    nivelEvaluacion="Inaceptable";
}
if (nivel==2){
    bonificacionGanada=bonificacion*0.4;
    nivelEvaluacion="Aceptable";
}
if (nivel==3){
    bonificacionGanada=bonificacion*0.6;
    nivelEvaluacion="Meritorio";
}

Console.WriteLine("Nivel de evaluacion: "+nivelEvaluacion+"\nBonificacion ganada: "+bonificacionGanada);
*/