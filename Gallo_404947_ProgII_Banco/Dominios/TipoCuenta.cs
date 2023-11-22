using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallo_404947_ProgII_Banco.Cuenta
{
    internal class TipoCuenta
    {
        public int CodTipoCuenta { get; set; }

        public string TipoCuentaDesc { get; set; }
        public TipoCuenta()
        {
            CodTipoCuenta = 0;
            TipoCuentaDesc = string.Empty;
        }

        public TipoCuenta(int codTipoCuenta, string tipoCuenta)
        {
            CodTipoCuenta = codTipoCuenta;
            TipoCuentaDesc = tipoCuenta;
        }
    }
}
