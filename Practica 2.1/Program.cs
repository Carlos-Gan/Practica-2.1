using System;

struct Producto
{
    public string nombre;
    public float precio;
    public int existencia;
}

class Tienda
{
    static void Main(string[] args)
    {
        Producto queso = new Producto();
        queso.nombre = "Queso";
        queso.precio = 30;
        queso.existencia = 10;

        Producto leche = new Producto();
        leche.nombre = "Leche";
        leche.precio = 48;
        leche.existencia = 20;

        Producto crema = new Producto();
        crema.nombre = "Crema";
        crema.precio = 25;
        crema.existencia = 15;

        Producto yogurt = new Producto();
        yogurt.nombre = "Yogurt";
        yogurt.precio = 15;
        yogurt.existencia = 18;

        Producto refresco = new Producto();
        refresco.nombre = "Refresco";
        refresco.precio = 18;
        refresco.existencia = 30;

        Producto Papas = new Producto();
        Papas.nombre = "Papas";
        Papas.precio = 24;
        Papas.existencia = 45;

        Producto Galletas = new Producto();
        Galletas.nombre = "Galletas";
        Galletas.precio = 22;
        Galletas.existencia = 34;

        Console.WriteLine("Productos:");
        Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", queso.nombre, queso.precio, queso.existencia);
        Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", leche.nombre, leche.precio, leche.existencia);
        Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", crema.nombre, crema.precio, crema.existencia);
        Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", yogurt.nombre, yogurt.precio, yogurt.existencia);
        Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", refresco.nombre, refresco.precio, refresco.existencia);
        Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", Papas.nombre, Papas.precio, Papas.existencia);
        Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", Galletas.nombre, Galletas.precio, Galletas.existencia);

        Console.WriteLine("\n");
        Console.Write("Ingrese el precio a buscar: ");
        float precioBuscado = float.Parse(Console.ReadLine());

        bool encontrado = false;

        if (queso.precio == precioBuscado)
        {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", queso.nombre, queso.precio, queso.existencia);
            encontrado = true;
        }

        if (leche.precio == precioBuscado)
        {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", leche.nombre, leche.precio, leche.existencia);
            encontrado = true;
        }

        if (crema.precio == precioBuscado)
        {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", crema.nombre, crema.precio, crema.existencia);
            encontrado = true;
        }

        if (yogurt.precio == precioBuscado)
        {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", yogurt.nombre, yogurt.precio, yogurt.existencia);
            encontrado = true;
        }
        if (Papas.precio == precioBuscado)
        {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", Papas.nombre, Papas.precio, Papas.existencia);
            encontrado = true;
        }
        if(Galletas.precio == precioBuscado)
        {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", Galletas.nombre, Galletas.precio, Galletas.existencia);
            encontrado = true;
        }
        if(refresco.precio == precioBuscado)
        {
            Console.WriteLine("Nombre: {0}, Precio: {1}, Existencia: {2}", refresco.nombre, refresco.precio, refresco.existencia);
            encontrado = true;
        }


        if (!encontrado)
        {
            Console.WriteLine("No se encontraron productos con ese precio.");
        }


        Console.ReadKey();
    }
}
