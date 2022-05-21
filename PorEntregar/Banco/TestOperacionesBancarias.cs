namespace Banco;

public class TestOperacionesBancarias
{
    private List<CuentaBancaria> Persons = new List<CuentaBancaria>();
    private Random random = new Random();
    
    public string RandomString()
    {
        const string chars = "0123456789";
        return new string(Enumerable.Repeat(chars, 8)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    
    public void addUsers()
    {
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Ingrese el nombre del Usuario:");
            var name = Console.ReadLine();
            Console.WriteLine("Ingrese el saldo inicial del usuario:");
            var balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el nip del usuario: ");
            var nip = Console.ReadLine();
            var numberAccount = RandomString();
            CuentaBancaria user = new CuentaBancaria(name, balance,numberAccount, nip);
            Persons.Add(user);
        }
    }

    public void validation(CuentaBancaria UserOne, CuentaBancaria UserTwo, bool flag, double saldo, int opc)
    {
        switch (flag)
        {
            case false when saldo>0 && opc==2:
                UserOne.depositar(saldo);
                UserOne.mensaje("El saldo se deposito exitosamente");
                break;
            case false when saldo>0 && opc==3 && saldo<=UserOne.SaldoCuenta:
                UserOne.retirar(saldo);
                UserOne.mensaje("El saldo se retiro exitosamente");
                break;
            case false when saldo>0 && opc==4 && saldo<=UserOne.SaldoCuenta:
                UserOne.transferir(UserTwo, saldo);
                UserOne.mensaje("La transferencia se hizo exitosamente");
                break;
            default:
                Console.WriteLine("Compruebe que sus datos sean correctos");
                break;
        }
    }

    public void utilities(CuentaBancaria UserOne, CuentaBancaria UserTwo)
    {
        var flag = false;
        var opc = 0;
        var balance = 0.0;
        while (!flag)
        {
            Console.WriteLine("1. Consultar Saldo");
            Console.WriteLine("2. Depositar Efectivo");
            Console.WriteLine("3. Retirar Efectivo");
            Console.WriteLine("4. Transferir entre cuentas");
            Console.WriteLine("5. Cambiar NIP");
            Console.WriteLine("6. Cerrar Sesion");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    UserOne.mensaje($"Tu saldo actual es de {UserOne.SaldoCuenta}");
                    break;
                case 2:
                    UserOne.mensaje("Ingrese el saldo a depositar:");
                    balance = Convert.ToDouble(Console.ReadLine());
                    validation(UserOne,UserTwo,flag,balance,2);
                    break;
                case 3:
                    UserOne.mensaje("Ingrese el saldo a retirar:");
                    balance = Convert.ToDouble(Console.ReadLine());
                    validation(UserOne,UserTwo,flag,balance,3);
                    break;
                case 4:
                    UserOne.mensaje("Ingrese el saldo a transferir:");
                    balance = Convert.ToDouble(Console.ReadLine());
                    validation(UserOne,UserTwo,flag,balance,4);
                    break;
                case 5:
                    UserOne.mensaje("Ingrese su NIP actual");
                    var actual = Console.ReadLine();
                    switch (flag)
                    {
                        case false when actual == UserOne.Nip:
                            UserOne.mensaje("Ingrese un nuevo nip");
                            var nuevo = Console.ReadLine();
                            UserOne.Nip = nuevo;
                            UserOne.mensaje("El cambio de NIP se hizo correctamente");
                            break;
                        default:
                            UserOne.mensaje("Compruebe sus datos nuevamente");
                            break;
                    }
                    break;
                case 6:
                    flag = true;
                    break;
            }
        }
    }
    
    public void menu()
    {
        var opc = 0;
        var index = 0;
        var flag = false;
        var op = 0;
        addUsers();
        while (!flag)
        {
            foreach (var Cuenta in Persons)
            {
                Console.WriteLine($"{(index += 1)}. Numero de cuenta {Cuenta.NumeroCuenta}");
            }

            index = 0;
            op = 0;
            Console.WriteLine("3. Salir del cajero");
            opc = Convert.ToInt32(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    while (op != 3)
                    {
                        Console.WriteLine("Ingresa tu NIP: ");
                        var password = Console.ReadLine();
                        switch (flag)
                        {
                            case false when password == Persons.ElementAt(0).Nip:
                                Console.WriteLine($"Hola {Persons.ElementAt(0).NombreTitular}");
                                utilities(Persons.ElementAt(0),Persons.ElementAt(1));
                                op = 3;
                                break;
                            default:
                                op++;
                                Console.WriteLine($"Lleva {op} intento");
                                break;
                        }
                        
                    }
                    break;
                case 2:
                    while (op != 3)
                    {
                        Console.WriteLine("Ingresa tu NIP: ");
                        var password = Console.ReadLine();
                        switch (flag)
                        {
                            case false when password == Persons.ElementAt(1).Nip:
                                Console.WriteLine($"Hola {Persons.ElementAt(1).NombreTitular}");
                                utilities(Persons.ElementAt(1),Persons.ElementAt(0));
                                op = 3;
                                break;
                            default:
                                op++;
                                Console.WriteLine($"Lleva {op} intento");
                                break;
                        }
                        
                    }
                    break;
                case 3:
                    flag = true;
                    break;
                default:
                    Console.WriteLine("Ingresa un numero valido");
                    break;
            }
        }
    }

    
    
    
    public static void Main(string[] args)
    {
        TestOperacionesBancarias app = new TestOperacionesBancarias();
        app.menu();
    }
}