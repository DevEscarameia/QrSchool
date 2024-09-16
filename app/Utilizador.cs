using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    public class Utilizador
    {
        public Int32 N_IDUTILIZADOR;
        public string T_NOMEUTILIZADOR;
        public string T_SENHAUTILIZADOR;
        public byte[] I_FTUTILIZADOR;
        public Int32 N_NIVELUTILIZADOR;
        internal string UtilizadorLogado;
    }
}
