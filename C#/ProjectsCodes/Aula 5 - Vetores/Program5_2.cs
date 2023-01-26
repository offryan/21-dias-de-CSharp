int mult, cont, num;

Console.Write("Olá Luana, digite o número do multiplicador para obter sua taboada: ");
num = Convert.ToInt32(Console.ReadLine());

for (cont = 1; cont <= 10; ++cont)
{
    mult = num * cont;
    Console.WriteLine(num + " X " + cont + " = " + mult);

}