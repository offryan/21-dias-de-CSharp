
class Program3_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("=============================POSTO================================ ");

        Console.WriteLine("Digite a quantidade de litros disponíveis de combustível no posto: ");
        double? estoque = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a cotação em reais por litro: ");
        double? valorLitros = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("============================CLIENTE=============================== ");

        Console.WriteLine("Digite seu nome: ");
        String? nomeCliente = (Console.ReadLine());

        Console.WriteLine($"Olá, seja bem vindo {nomeCliente}. Digite a quantidade de litros desejado: ");
        double? qtdCombustivel = Convert.ToDouble(Console.ReadLine());

        if (qtdCombustivel > estoque)
        {
            Console.WriteLine($"Olá, {nomeCliente}. A quantidade solicitada {qtdCombustivel} litros é maior que a disponível em nosso estoque atual, que é de: {estoque} LTS");
        }
        else
        {
            Console.WriteLine("============================LÓGICA================================ =");

            double? valorResultante = valorLitros * qtdCombustivel;
            double? finalEstoque = estoque - qtdCombustivel;
            double? combustivelCliente = qtdCombustivel / valorLitros;

            Console.WriteLine("============================SAÍDA================================= =");

            Console.WriteLine(
            $"""
    {nomeCliente} você colocou: {qtdCombustivel} LTS, e o valor total foi de R$: {valorResultante},00.

    Estoque atual do posto é de: {finalEstoque} LTS
""");

            Console.WriteLine("================================================================== ");
        }
    }
}