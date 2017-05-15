using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.Clases
{
    enum EstadoCuenta { Operativa, Inmovilizada, NumerosRojos }

    public class Cuenta
    {
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
    }
}
