using construtor;

Funcionario f1 = new Funcionario();
f1.ImprimeValores();
Funcionario f2 = new Funcionario(32, "João Paulo");
f2.ImprimeValores();
Console.Write("Precione uma tecla para sair!");
Console.ReadKey();