using Clase_7___Actividad_1___Cuenta_Bancaria;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace actividad12
{
    class Program
    {
        static void Main(string[] args)
        {
            Miembros miembros = new Miembros();

            /*Console.WriteLine("Apellido: " + miembros.GetApellido());
            Console.WriteLine("Nombre: " + miembros.GetNombre());
            Console.WriteLine("Dirección: " + miembros.GetDireccion());
            Console.WriteLine("Fecha de Nacimiento: " + miembros.GetFechaNac());
            Console.WriteLine("Saldo inicial: " + miembros.GetSaldo());*/


            Console.WriteLine("Ingrese el número de cuenta:");
            long numeroCuenta;
            bool numeroValido = long.TryParse(Console.ReadLine(), out numeroCuenta);
            while (!numeroValido)
            {
                Console.WriteLine("Número de cuenta inválido. Ingrese un número válido:");
                numeroValido = long.TryParse(Console.ReadLine(), out numeroCuenta);
            }
            miembros.SetNumeroCuenta(numeroCuenta);
            //miembros.SetNumeroCuenta(Convert.ToInt64(Console.ReadLine()));

            Console.WriteLine("Ingrese el apellido:");
            miembros.SetApellido(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre:");
            miembros.SetNombre(Console.ReadLine());

            Console.WriteLine("Ingrese la dirección:");
            miembros.SetDireccion(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/aaaa):");
            miembros.SetFechaNac(Console.ReadLine());

            Console.WriteLine("Ingrese el saldo inicial:");
            //miembros.SetSaldo(Convert.ToDouble(Console.ReadLine()));
            double Saldo;
            bool saldoValido = double.TryParse(Console.ReadLine(), out Saldo);
            while (!saldoValido)
            {
                Console.WriteLine("Ingreso Incorrecto. Vuelva a Ingresar:");
                saldoValido = double.TryParse(Console.ReadLine(), out Saldo);
            }
            miembros.SetSaldo(Saldo);

            Console.WriteLine("\nDatos del cliente:");
            Console.WriteLine("Número de cuenta: " + miembros.GetNumeroCuenta());
            Console.WriteLine("Apellido: " + miembros.GetApellido());
            Console.WriteLine("Nombre: " + miembros.GetNombre());
            Console.WriteLine("Dirección: " + miembros.GetDireccion());
            Console.WriteLine("Fecha de nacimiento: " + miembros.GetFechaNac());
            Console.WriteLine("Saldo: " + miembros.GetSaldo());

            bool realizarOtraOperacion = true;

            while (realizarOtraOperacion)
            {
                Console.WriteLine("\nRealice una operación:");
                Console.WriteLine("1. Depositar");
                Console.WriteLine("2. Retirar");
                Console.WriteLine("3. Salir");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese el monto a depositar:");
                    double monto = Convert.ToDouble(Console.ReadLine());
                    double saldoActualizado = miembros.DepositarDinero(monto);
                    Console.WriteLine("Saldo después del depósito: " + saldoActualizado);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese el monto a retirar:");
                    double monto = Convert.ToDouble(Console.ReadLine());
                    double saldoActualizado = miembros.RetirarDinero(monto);

                    if (saldoActualizado != -1)
                    {
                        Console.WriteLine("Saldo después del retiro: " + saldoActualizado);
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente para realizar el retiro.");
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Cerrando Consola...");
                    return;
                }
                else
                {
                    Console.WriteLine("Opción inválida.");
                }        

                Console.WriteLine("\n¿Desea realizar otra operación? (S/N)");
                string respuesta = Console.ReadLine();

                if (respuesta.ToUpper() != "S")
                {
                    Console.WriteLine("Ingreso Incorrecto.Vuelva a Ingresar: ");
                    realizarOtraOperacion = true;
                }
            }
        }
    }
}
