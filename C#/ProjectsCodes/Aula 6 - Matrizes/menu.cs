﻿class menu{
    static void Main(string[] args)
    {
            Console.WriteLine("======Seja bem vindo a empresa Lina=======");

            // 0 - cadastrar o client
            // 1 - ver a conta corrente do client
            // 2 - fazer credito em conta
            // 3 - Fazer débito em conta
            // 5 - sair do sistema

            ﻿while(true){
    Console.Clear();

    Console.WriteLine("""
    ================[ Bem vindo ao programa ]=================
    O que você deseja fazer ?
    1 - Exercício da tabuada
    2 - Exercício número premiado
    3 - Sair
    """);

    var opcao = Console.ReadLine()?.Trim();
    Console.Clear();

    bool sair = false;

    switch (opcao)
    {
        case "1":

            Console.WriteLine("Prezada Luana, digite o multiplicador:");
            int multiplicador = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite a quantidade multiplicada:");
            int quantidadeMultiplicada = Convert.ToInt16(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"Tabuada do número {multiplicador}:");

            for (int i = 1; i <= quantidadeMultiplicada; i++)
            {
                Console.WriteLine($"{multiplicador} x {i} = {multiplicador * i}");
            }


            break;
        case "2":
            Console.WriteLine("Digite o número premiado para que você possa ser nosso novo ganhador:");
            int numero = Convert.ToInt16(Console.ReadLine());

            Console.Clear();

            if(numero == 2949)
                Console.WriteLine("Parabéns você acertou o número premiado");
            else
                Console.WriteLine("Infelizmente você não acertou o número premiado");

            break;
        case "3":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if(sair) break;

    Thread.Sleep(4000);
}


            Console.WriteLine("============================================");
    }
}