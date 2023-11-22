using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallo_404947_ProgII_Banco.Cuenta
{
    internal class CuentaBanco
    {
        public int CodCuenta { get; set; }
        public Int64 CBU { get; set; }
        public double Saldo { get; set; }
        public int CodCliente { get; set; }
        public int TipoCuenta { get; set; }
        public DateTime UltimoMovimiento { get; set; }
        public string StrTipoCuenta { get; set; }

        public CuentaBanco()
        {
            CodCuenta = 0;
            CBU = 0;
            Saldo = 0;
            CodCliente = 0;
            TipoCuenta = 0;
            UltimoMovimiento = DateTime.Today;
            StrTipoCuenta = string.Empty;
        }
        public CuentaBanco(int codCuenta, long cbu, double saldo, int codCliente, int tipoCuenta, string strTipoCuenta)
        {
            CodCuenta = codCuenta;
            CBU = cbu;
            Saldo = saldo;
            CodCliente = codCliente;
            TipoCuenta = tipoCuenta;
            UltimoMovimiento = DateTime.Today;
            StrTipoCuenta = string.Empty;
        }
    }
}
