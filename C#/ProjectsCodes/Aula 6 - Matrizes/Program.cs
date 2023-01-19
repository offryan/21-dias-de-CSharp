class Program{
    static void Main(string[] args)
    {

                        ﻿while(true){
    Console.Clear();

    Console.WriteLine("""
    ================[ Bem vindo ao programa ]=================

    O que você deseja fazer ?
    1 - Cadastrar o cliente
    2 - Ver extrato cliente
    3 - Crédito em conta
    4 - Débito em conta
    5 - Sair do sistema
    """);

while (true)
{
    Console.Clear();

    Console.WriteLine("""
    =================[Seja bem-vindo à empresa Lina]=================
    O que você deseja fazer?
    1 - Cadastrar o cliente
    2 - Ver extrato cliente
    3 - Crédito em conta
    4 - Retirada
    5 - Sair do sistema
    """);

    var opcao = Console.ReadLine()?.Trim();
    Console.Clear();
    bool sair = false;

    switch (opcao)
    {
        case "1":
            Console.Clear();
            await cadastrarCliente();
            break;
        case "2":
            Console.Clear();
            await mostrarContaCorrente();
            break;
        case "3":
            Console.Clear();
            await adicionarCreditoCliente();
            break;
        case "4":
            Console.Clear();
            await fazendoDebitoCliente();
            break;
        case "5":
            sair = true;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    if (sair) break;
}

    Thread.Sleep(4000);
}
        Console.WriteLine("============================================");
    }
}