using Vehiculos;

int[] tiempos = new int[3];
string[] vehiculos = new string[3];

Monoplaza monoplaza1 = new Monoplaza();
monoplaza1.Escuderia="Mclaren";
vehiculos[0]=monoplaza1.Escuderia;

Monoplaza monoplaza2 = new Monoplaza();
monoplaza2.Escuderia="Ferrari";
vehiculos[1]=monoplaza2.Escuderia;

Monoplaza monoplaza3 = new Monoplaza();
monoplaza3.Escuderia="Redbull";
vehiculos[2]=monoplaza3.Escuderia;

Circuito circuito1 = new Circuito("Sepang", 2);

circuito1.AgregarMonoplaza(monoplaza1);
tiempos[0]=circuito1.RealizarPrueba();
circuito1.SacarMonoplaza();

circuito1.AgregarMonoplaza(monoplaza2);
tiempos[1]=circuito1.RealizarPrueba();
circuito1.SacarMonoplaza();

circuito1.AgregarMonoplaza(monoplaza3);
tiempos[2]=circuito1.RealizarPrueba();
circuito1.SacarMonoplaza();

circuito1.TablaPosiciones(tiempos, vehiculos);

