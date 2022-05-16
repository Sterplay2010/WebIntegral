public class Program
{
    private const string PASSWORD = "123456";
    public static void Main()
    {
        var candidatoUno = new Candidato("Peje Nieto", 0);
        var candidatoDos = new Candidato("Felipe Tomadon", 0);
        var candidatoTres = new Candidato("Bronco de la Tos", 0);

        var cierre = false;
        var intentos = 0;

        while (!cierre)
        {
            Console.WriteLine($"1. Votar por {candidatoUno.name}");
            Console.WriteLine($"2. Votar por {candidatoDos.name}");
            Console.WriteLine($"3. Votar por {candidatoTres.name}");
            Console.WriteLine("4. Cerrar la casilla de votación");
            var opc = Convert.ToInt32(Console.ReadLine());
            intentos = 0;
            switch (opc)
            {
                case 1:
                    candidatoUno.amount += 1;
                    Console.WriteLine($"Gracias por votar por {candidatoUno.name}");
                    break;
                case 2:
                    candidatoDos.amount += 1;
                    Console.WriteLine($"Gracias por votar por {candidatoDos.name}");
                    break;
                case 3:
                    candidatoTres.amount += 1;
                    Console.WriteLine($"Gracias por votar por {candidatoTres.name}");
                    break;
                case 4:
                    while (intentos!=3)
                    {
                        Console.WriteLine("Ingrese la contraseña: ");
                        var pass = Console.ReadLine();
                        switch (pass)
                        {
                            case PASSWORD:
                                switch (cierre)
                                {
                                    case false when candidatoUno.amount > candidatoDos.amount || candidatoUno.amount > candidatoTres.amount:
                                        Console.WriteLine($"El ganador es {candidatoUno.name} con {candidatoUno.amount} votos");
                                        cierre = true;
                                        intentos = 3;
                                        break;
                                    case false when candidatoDos.amount > candidatoUno.amount || candidatoDos.amount > candidatoTres.amount:
                                        Console.WriteLine($"El ganador es {candidatoUno.name} con {candidatoUno.amount} votos");
                                        cierre = true;
                                        intentos = 3;
                                        break;
                                    case false when candidatoTres.amount > candidatoDos.amount || candidatoTres.amount > candidatoDos.amount:
                                        Console.WriteLine($"El ganador es {candidatoUno.name} con {candidatoUno.amount} votos");
                                        cierre = true;
                                        intentos = 3;
                                        break;
                                    default:
                                        Console.WriteLine("Se cayo el sistema");
                                        intentos = 3;
                                        cierre = true;
                                        break;
                                }
                                break;
                            default:
                                intentos += 1;
                                Console.WriteLine($"Contraseña incorrecta, lleva {intentos} intentos");
                                break;
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Ingrese un numero correcto");
                    break;
            }
        }
    }
}