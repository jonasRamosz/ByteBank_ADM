
using bytebank_ADM.Funcionarios;
using bytebank_ADM.Gerencia;

Console.WriteLine("Boas vindas, ao ByteBank Administração");

Funcionario jonas = new Funcionario();
GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
jonas.Nome = "jonas";
jonas.Salario = 1000;
Console.WriteLine(jonas.Nome);
Console.WriteLine(jonas.getBonificacao()+jonas.Salario);

Funcionario hadassa = new Diretor();
hadassa.Nome = "hadassa";
hadassa.Salario = 2000;
Console.WriteLine(hadassa.Nome);
Console.WriteLine(hadassa.getBonificacao());

gerenciador.Registra(hadassa);
gerenciador.Registra(jonas);
Console.WriteLine(gerenciador.getBonificacao());
Funcionario ivani = new Funcionario();

Console.WriteLine(Funcionario.TotalDeFuncionarios);