using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7___Actividad_1___Cuenta_Bancaria
{
    internal class Miembros
    {

        private long NumeroCuenta;
        private string Apellido;
        private string Nombre;
        private string Direccion;
        private string FechaNac;
        private double Saldo;

        public Miembros()
        {
        }

        public Miembros(long numeroCuenta, string apellido, string nombre, string direccion, string fechaNac, double saldo)
        {
            this.NumeroCuenta = numeroCuenta;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.FechaNac = fechaNac;
            this.Saldo = saldo;
        }

        public void SetApellido(string Apellido)
        {
            this.Apellido = Apellido;
        }

        public String GetApellido()
        {
            return Apellido;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public String GetNombre()
        {
            return Nombre;
        }

        public void SetDireccion(string Direccion)
        {
            this.Direccion = Direccion;
        }

        public String GetDireccion()
        {
            return Direccion;
        }

        public void SetFechaNac(string FechaNac)
        {
            this.FechaNac = FechaNac;
        }

        public String GetFechaNac()
        {
            return FechaNac;
        }

        public double GetSaldo()
        {
            return Saldo;
        }
     
        public double DepositarDinero(double amount) 
        {
            Saldo += amount;
            return Saldo;
        }

        public double RetirarDinero(double amount)
        {
            if(amount < Saldo)
            {
                Saldo -= amount;
                return Saldo;
            }
            else
            {
                return -1; //saldo insuficiente
            }
        }

    }
}