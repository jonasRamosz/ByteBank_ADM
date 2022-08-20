using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {
            this.senha = senha;
            
        }

        public string senha { get; set; }
        public string login { get; set; }


        public bool Autenticar(string senha, string login)
        {
            return (this.senha == senha && this.login == login);
        }   
               
    }
}