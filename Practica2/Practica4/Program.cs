using System;

public class Program
{
    private const int HAWAIANA = 150; 
    private const int PEPPERONI = 150; 
    private const int QUESOS = 150; 
    private const int MARGARITA = 150; 
    private const int SALAMI = 150; 
    private const int BONOHIJOS = 150; 
    private const double SALARIOMINIMO = 172.87; 

    private void Cadena()
    {
        Console.WriteLine("Ingrese una palabra: ");
        var palabra = Console.ReadLine();
        Console.WriteLine((palabra.Length>10) ? palabra.ToLower():palabra);
    }

    private void PizzaPagos()
    {
        var totalPagar = 0.0;
        Console.WriteLine("Menu de pizzas");
        Console.WriteLine("1. Hawaiana");
        Console.WriteLine("2. Pepperoni");
        Console.WriteLine("3. Quesos");
        Console.WriteLine("4. Margarita");
        Console.WriteLine("5. Salami");
        Console.WriteLine("Ingrese que pizza desea comprar [1-4]");
        var pizza = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿Desea pagar con tarjeta de credito/debito? [Si, No]");
        var tarjeta = Console.ReadLine().ToLower();
        Console.WriteLine("¿Desea el servicio a domicilio? [Si, No]");
        var domicilio = Console.ReadLine().ToLower();
        switch (pizza)
        {
            case 1 when tarjeta == "si" && domicilio == "si":
                totalPagar = ((HAWAIANA * 0.03) + HAWAIANA) + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 1 when tarjeta == "no" && domicilio == "no":
                Console.WriteLine($"El total a pagar es: {HAWAIANA}");
                break;
            case 1 when tarjeta == "si" && domicilio == "no":
                totalPagar = ((HAWAIANA * 0.03) + HAWAIANA);
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 1 when tarjeta == "no" && domicilio == "si":
                totalPagar = HAWAIANA + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 2 when tarjeta == "si" && domicilio == "si":
                totalPagar = ((PEPPERONI * 0.03) + PEPPERONI) + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 2 when tarjeta == "no" && domicilio == "no":
                Console.WriteLine($"El total a pagar es: {PEPPERONI}");
                break;
            case 2 when tarjeta == "si" && domicilio == "no":
                totalPagar = ((PEPPERONI * 0.03) + PEPPERONI);
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 2 when tarjeta == "no" && domicilio == "si":
                totalPagar = PEPPERONI + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 3 when tarjeta == "si" && domicilio == "si":
                totalPagar = ((QUESOS * 0.03) + QUESOS) + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 3 when tarjeta == "no" && domicilio == "no":
                Console.WriteLine($"El total a pagar es: {QUESOS}");
                break;
            case 3 when tarjeta == "si" && domicilio == "no":
                totalPagar = ((QUESOS * 0.03) + QUESOS);
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 3 when tarjeta == "no" && domicilio == "si":
                totalPagar = QUESOS + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 4 when tarjeta == "si" && domicilio == "si":
                totalPagar = ((MARGARITA * 0.03) + MARGARITA) + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 4 when tarjeta == "no" && domicilio == "no":
                Console.WriteLine($"El total a pagar es: {MARGARITA}");
                break;
            case 4 when tarjeta == "si" && domicilio == "no":
                totalPagar = ((MARGARITA * 0.03) + MARGARITA);
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 4 when tarjeta == "no" && domicilio == "si":
                totalPagar = MARGARITA + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 5 when tarjeta == "si" && domicilio == "si":
                totalPagar = ((SALAMI * 0.03) + SALAMI) + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 5 when tarjeta == "no" && domicilio == "no":
                Console.WriteLine($"El total a pagar es: {SALAMI}");
                break;
            case 5 when tarjeta == "si" && domicilio == "no":
                totalPagar = ((SALAMI * 0.03) + SALAMI);
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            case 5 when tarjeta == "no" && domicilio == "si":
                totalPagar = SALAMI + 45;
                Console.WriteLine($"El total a pagar es: {totalPagar}");
                break;
            default:
                Console.WriteLine("Ingrese un numero de pizza correcto");
                break;
        }
    }

    public void BonosEmpleados()
    {
        var totalBono = 0.0;
        var bonoExtra = 0.0;
        Console.WriteLine("Ingrese el departamento [A,B,C]");
        var departamento = Console.ReadLine().ToLower();
        Console.WriteLine("Años de antigüedad (en meses): ");
        var ant = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Cantidad de hijos: ");
        var hijos = Convert.ToInt32(Console.ReadLine());
        switch (departamento)
        {
            case "a" when ant < 24:
                totalBono = (5 * SALARIOMINIMO);
                bonoExtra = (hijos * BONOHIJOS);
                Console.WriteLine($"Bono: {totalBono} | Bono extra por hijos: {bonoExtra}");
                break;
            case "a" when ant >= 24:
                totalBono = (8 * SALARIOMINIMO);
                bonoExtra = (hijos * BONOHIJOS);
                Console.WriteLine($"Bono: {totalBono} | Bono extra por hijos: {bonoExtra}");
                break;
            case "b" when ant < 32:
                totalBono = (9 * SALARIOMINIMO);
                bonoExtra = (hijos * BONOHIJOS);
                Console.WriteLine($"Bono: {totalBono} | Bono extra por hijos: {bonoExtra}");
                break;
            case "b" when ant >=32:
                totalBono = (12 * SALARIOMINIMO);
                bonoExtra = (hijos * BONOHIJOS);
                Console.WriteLine($"Bono: {totalBono} | Bono extra por hijos:{bonoExtra}");
                break;
            case "c" when ant < 60:
                totalBono = (14 * SALARIOMINIMO);
                bonoExtra = (hijos * BONOHIJOS);
                Console.WriteLine($"Bono: {totalBono} | Bono extra por hijos: {bonoExtra}");
                break;
            case "c" when ant >= 60:
                totalBono = (17 * SALARIOMINIMO);
                bonoExtra = (hijos * BONOHIJOS);
                Console.WriteLine($"Bono: {totalBono} | Bono extra por hijos: {bonoExtra}");
                break;
            default:
                Console.WriteLine("Departamento inexistente");
                break;
        }
    }

    public void Operaciones()
    {
        var area = 0.0;
        var perimetro = 0.0;
        var lado = 0.0;
        Console.WriteLine("Menu de operaciones");
        Console.WriteLine("1. Área y Perímetro de un círculo");
        Console.WriteLine("2. Área y Perímetro de un hexágono");
        Console.WriteLine("3. Área y Perímetro de un rombo");
        Console.WriteLine("Ingrese que operación desea hacer [1-3]");
        var operacion = Convert.ToInt32(Console.ReadLine());
        switch (operacion)
        {
            case 1:
                Console.WriteLine("Ingrese el radio del círculo:");
                var radio = Convert.ToInt32(Console.ReadLine());
                area = 3.14 * (radio * radio);
                perimetro = 2 * 3.14 * radio;
                Console.WriteLine($"Area: {area} | Perímetro: {perimetro}");
                break;
            case 2:
                Console.WriteLine("Ingrese cuando miden los lados del hexágono:");
                lado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el apotema del hexágono:");
                var apotema = Convert.ToInt32(Console.ReadLine());
                perimetro = 6 * lado;
                area = (perimetro * apotema) / 2;
                Console.WriteLine($"Area: {area} | Perímetro: {perimetro}");
                break;
            case 3:
                Console.WriteLine("Ingrese cuando miden los lados del rombo:");
                lado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese cuando miden la diagonal mayor:");
                var mayor = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese cuando miden la diagonal menor:");
                var menor = Convert.ToInt32(Console.ReadLine());
                perimetro = 4 * lado;
                area = (mayor * menor) / 2;
                Console.WriteLine($"Area: {area} | Perímetro: {perimetro}");
                break;
            default:
                Console.WriteLine("Ingrese una opcion correcta");
                break;
        }
    }
    
    
    public static void Main(string[] args)
    {
        var app = new Program();
        /*app.Cadena();
        app.PizzaPagos();*/
        app.BonosEmpleados();
    }
}
