Console.WriteLine("Digite a qtd de litros de combustível: ");
int? QtdCombustivel = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor do combustivel em R$: ");
int? valorCombustivel = Convert.ToInt32(Console.ReadLine());

int? estoque = 8000;

int? ResEstoque = estoque - QtdCombustivel;

Console.WriteLine(
$"""
    Você colocou: {QtdCombustivel} LTS, e o valor foi de R$: {valorCombustivel}
    Estoque atual do posto de:  {ResEstoque} LTS
""");
