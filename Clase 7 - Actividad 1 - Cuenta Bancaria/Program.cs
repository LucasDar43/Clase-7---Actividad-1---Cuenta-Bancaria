using Clase_7___Actividad_1___Cuenta_Bancaria;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace actividad12
{
    class Program
    {
        static void Main(string[] args)
        {
            Miembros miembros = new Miembros(123456789, "González", "Juan", "Calle Principal 123", "01/01/1990", 1000.0);

            Console.WriteLine("Apellido: " + miembros.GetApellido());
            Console.WriteLine("Nombre: " + miembros.GetNombre());
            Console.WriteLine("Dirección: " + miembros.GetDireccion());
            Console.WriteLine("Fecha de Nacimiento: " + miembros.GetFechaNac());
            Console.WriteLine("Saldo inicial: " + miembros.GetSaldo());

            double saldoActualizado = miembros.DepositarDinero(500.0);
            Console.WriteLine("Saldo después del depósito: " + saldoActualizado);

            saldoActualizado = miembros.RetirarDinero(200.0);
            if (saldoActualizado != -1)
            {
                Console.WriteLine("Saldo después del retiro: " + saldoActualizado);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro.");
            }
        }
    }
}
