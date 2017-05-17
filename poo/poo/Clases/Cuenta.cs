using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.Clases
{
    enum EstadoCuenta
    {
        Operativa,
        Inmovilizada,
        NumerosRojos
    }

    public class Cuenta: ICloneable
    {
        // Realiza la copia superficial
        public object Clone()
        {
            return MemberwiseClone();
        }
        // Constante
        private const int MaxOperaciones = 20;
        // Atributo de clase
        private static int _ultimoCodigo = 0;
        // Atributos de instancia
        private int _codigo;
        private double _saldo = 100;
        private readonly Persona _titular;
        private EstadoCuenta _estado;
        private double[] _ultimasOperaciones;

        // Constructor
        public Cuenta(Persona titular, double saldo) {
            this._codigo = ++_ultimoCodigo;
            this._titular = titular;
            this._saldo = saldo;
            _estado = EstadoCuenta.Operativa;
            _ultimasOperaciones = new double[MaxOperaciones];
        }

        // Propiedades
        public double Saldo
        {
           get { return _saldo; } 
           private set { _saldo = value; }
        }

        public Persona Titular => _titular;
        public int Codigo => _codigo;

        public double SaldoDolar => _saldo * Banco.CambioDolar();

        // Metodos de instancia
        public void Ingreso(double cantidad)
        {
            _saldo = _saldo + cantidad;
        }

        public void Reintegro(double cantidad)
        {
            if (cantidad <= _saldo)
                _saldo = _saldo - cantidad;
        }

        public static bool operator >(Cuenta cuenta1, Cuenta cuenta2)
        {
            return (cuenta1.Saldo > cuenta2.Saldo);
        }
        public static bool operator <(Cuenta cuenta1, Cuenta cuenta2)
        {
            return (cuenta1.Saldo < cuenta2.Saldo);
        }

        // A partir de una persona crea una cuenta
        public static implicit operator Cuenta(Persona titular)
        {
            return new Cuenta(titular, 500);
        }
        // Si es asignado a un double, se toma el saldo
        public static implicit operator double(Cuenta cuenta)
        {
            return cuenta.Saldo;
        }

        // Metodos de clase
        public static int GetNumeroCuentas()
        {
            return _ultimoCodigo;
        }
    }
}
