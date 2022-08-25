using bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel, IDiretor
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor");
        }
        public override double getBonificacao()
        {
            return Salario * 0.5;
        }
        public override void AumentaSalrio()
        {
            this.Salario *= 1.15;
        }


    }
}
