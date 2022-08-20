using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    public class Funcionario
    {

        public Funcionario()
        {
            TotalDeFuncionarios++;
        }
        
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public double Salario { get; set; }

        public static int TotalDeFuncionarios { get; private set; }

        public virtual double getBonificacao()
        { 
                return Salario * 0.1;
            
        }

        
    }
}

