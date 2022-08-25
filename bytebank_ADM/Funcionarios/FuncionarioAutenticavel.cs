using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {   
        public FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }
        public string senha { get; set; }

        public bool IAutenticar(string senha)
        {
            return senha == senha;
        }
    }
}
