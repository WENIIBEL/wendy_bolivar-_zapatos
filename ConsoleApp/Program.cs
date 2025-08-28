// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Zapatos
{
    int talla;
    String nombre;
    String color;
    int precio;
    Tipos tipo = new Tipos;
    Stock stock = new Stock;
    List<Materiales>material = new List(Materiales);

}

class Tipos
{
    String cerrado;
    String abierto;
    String deportivo ;
}

class Stock
{
    int cantidad;
    String virtual;
    String  fisico ;
}

class Materiales
{
    String cuero;
    String cuerina;
    String tela ;
}



Zapatos zapato = new Zapatos
zapato.talla = 38;
zapato.nombre = "zafiro";
zapato.color = "negro";
zapato.precio = 150000;
zapato.tipo = "deportivo";
