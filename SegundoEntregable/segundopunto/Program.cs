using pastel;

Ingrediente ingrediente1 = new Ingrediente();
ingrediente1.nombre="Harina";
ingrediente1.cantidad=1;
ingrediente1.precio=2000;

Ingrediente ingrediente2 = new Ingrediente();
ingrediente2.nombre="huevos";
ingrediente2.cantidad=4;
ingrediente2.precio=700;

Ingrediente ingrediente3 = new Ingrediente();
ingrediente3.nombre="Leche";
ingrediente3.cantidad=1;
ingrediente3.precio=3000;

Pastel pastel = new Pastel("Tradicional", 6);

pastel.agregarIngrediente(ingrediente1);
pastel.agregarIngrediente(ingrediente2);
pastel.agregarIngrediente(ingrediente3);

pastel.cantidadIngredientes();
pastel.ListarIngredientes();
pastel.calcularCosto();