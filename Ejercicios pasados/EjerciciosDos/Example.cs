public class Example
{

    const double PRECIO = 15.90;
    public int sumar(int num1, int num2)
    {
        return (num1 + num2);
    }

    public void PracticaDos(){
        
        Console.Write("Hola, ingresa la cantidad de productos: ");
        var productos = Convert.ToInt32(Console.ReadLine());
        var normales = (productos%5);
        var descuentos = productos - normales;
        var pagarNormal = normales * PRECIO;
        var plumas = (descuentos/5);
        var pagarDescuento = ((descuentos)*PRECIO)-((descuentos*PRECIO) * 0.10)  ;
        var sumaTotal = pagarNormal + pagarDescuento;
        Console.WriteLine($"Total a pagar por los productos {descuentos} con descuento: {pagarDescuento}");
        Console.WriteLine($"Precio a pagar por los productos {normales} sin descuento: {pagarNormal}");
        Console.WriteLine($"Te regalamos un total de {plumas} plumas");
        Console.WriteLine($"La suma total de los productos es de {sumaTotal}");
        
    }

    public static void Main()
    {
        /*Console.Write("Hola, ingresa tu nombre: ");
        string? name = Console.ReadLine();
        Console.WriteLine("Buen día " + name);
        var currentDate = DateTime.Now;
        Console.WriteLine($"Date {currentDate:d}");
        Console.WriteLine($"Time {currentDate:t}");
        Console.WriteLine($"Month {currentDate:m}");
        Console.WriteLine("Ingresa un numero: ");
        var numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingresa otro numero: ");
        var numero2 = Convert.ToInt32(Console.ReadLine());
        var example = new Example();
        var suma = example.sumar(numero, numero2);
        Console.WriteLine($"La suma es {suma}");
        //Constante de 15.90fee
        //Cada 5 productos es un descuento de 10% y 1 pluma*/
        var example = new Example();
        example.PracticaDos();
    }
}
