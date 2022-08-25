using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.ParceiriaComercial
{
    internal class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool IAutenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}
