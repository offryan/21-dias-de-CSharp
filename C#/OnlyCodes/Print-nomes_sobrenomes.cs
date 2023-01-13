Console.WriteLine("========================================");
Console.WriteLine("   Bem vindo, ao meu 1°s código em C#   ");
Console.WriteLine("=======================================");

Console.WriteLine("Digite o 1° nome: ");
String? nome1 = Console.ReadLine();

Console.WriteLine("Digite o 1° sobrenome: ");
String? sobrenome1 = Console.ReadLine();

Console.WriteLine("Digite o 2° nome: ");
String? nome2 = Console.ReadLine();

Console.WriteLine("Digite o 2° sobrenome: ");
String? sobrenome2 = Console.ReadLine();

Console.WriteLine("Digite o 3° nome: ");
String? nome3 = Console.ReadLine();

Console.WriteLine("Digite o 3° sobrenome: ");
String? sobrenome3 = Console.ReadLine();

Console.WriteLine(
$"""
    O primeiro nome completo é: {nome1} {sobrenome1}
    O segundo  nome completo é: {nome2} {sobrenome2}
    O terceiro nome completo é: {nome3} {sobrenome3}
""");

Console.WriteLine("========================================");
Console.WriteLine("   ============== FINAL=============   ");
Console.WriteLine("=======================================");
