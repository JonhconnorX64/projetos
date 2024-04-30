int n1;
Console.WriteLine("Digite um número: ");
n1 = int.Parse(Console.ReadLine());
for (int i = 1; i <= 9; i++)
{
    Console.WriteLine(n1 + "x" +i+ "=" +(n1*i));    
}
Console.ReadKey();

