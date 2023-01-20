async Task<List<Cliente>> TodosClientes(){
    return await clienteServico.Persistencia.Todos();
}

async Task<List<ContaCorrente>> TodosExtratos(){
    return await contaCorrenteServico.Persistencia.Todos();
}

while (true){
    Console.Clear();

    Console.WriteLine("""
    =================[Seja bem-vindo à empresa Lina]=================
    O que você deseja fazer?
    1 - Cadastrar cliente
    2 - Extrato cliente
    3 - Créditar
    4 - Débitar
    5 - Sair
    """);

    var opcao = Console.ReadLine()?.Trim();
    Console.Clear();
    bool sair = false;

    switch (opcao){
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

async Task mostrarContaCorrente(){
    Console.Clear();

    var clientes = await TodosClientes();
    var dadosNoExtrato = await TodosExtratos();
    if(clientes.Count == 0 || dadosNoExtrato.Count == 0){
        mensagem("Não existe clientes ou não existe movimentações em conta correte, cadastre o cliente e faça crédito em conta");
        return;
    }

    var cliente = await capturaCliente();
    var contaCorrenteCliente = await contaCorrenteServico.ExtratoCliente(cliente.Id);
    Console.Clear();
    Console.WriteLine("----------------------");

    foreach(var contaCorrente in contaCorrenteCliente){
        Console.WriteLine("Data: " + contaCorrente.Data.ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine("Valor: " + contaCorrente.Valor);
        Console.WriteLine("----------------------");
    }

    Console.WriteLine($"""
    O valor total da conta do cliente {cliente.Nome} é de:
    R$ {await contaCorrenteServico.SaldoCliente(cliente.Id, contaCorrenteCliente)}
    """);

    Console.WriteLine("Digite enter para continuar");
    Console.ReadLine();
}

async Task listarClientesCadastrados(){
    if((await TodosClientes()).Count == 0){
        await menuCadastraClienteSeNaoExiste();
    }

    await mostrarClientes(false, 0, "===============[ Selecione um cliente da lista ]===================");
}

async Task mostrarClientes(
    bool sleep = true,
    int timerSleep = 2000,
    string header = "===============[ Lista de clientes ]==================="){
    Console.Clear();
    Console.WriteLine(header);

    foreach(var cliente in (await TodosClientes())){
        Console.WriteLine("Id:" + cliente.Id);
        Console.WriteLine("Nome:" + cliente.Nome);
        Console.WriteLine("Telefone:" + cliente.Telefone);
        Console.WriteLine("Email:" + cliente.Email);
        Console.WriteLine("----------------------------");

        if(sleep){
            Thread.Sleep(timerSleep);
            Console.Clear();
        }
    }
}

async Task cadastrarCliente(){

    var id = Guid.NewGuid().ToString();

    Console.WriteLine("Informe o nome do cliente:");
    var nomeCliente = Console.ReadLine();

    Console.WriteLine($"Informe o telefone do cliente {nomeCliente}: ");
    var telefone = Console.ReadLine();

    Console.WriteLine($"Informe o email do cliente {nomeCliente}: ");
    var email = Console.ReadLine();

    if((await TodosClientes()).Count > 0){

        Cliente? cli = (await TodosClientes()).Find(c => c.Telefone == telefone);

        if(cli != null){

            mensagem($"Cliente já cadastrado com este telefone {telefone}, cadastre novamente");
            await cadastrarCliente();
        }
    }

    await clienteServico.Persistencia.Salvar(new Cliente{

        Id = id,
        Nome = nomeCliente ?? "[Sem Nome]",
        Telefone = telefone != null ? telefone : "[Sem Telefone]",
        Email = email ?? "[Sem Email]"
    });
    mensagem($""" {nomeCliente} cadastrado com sucesso. """);
}

void mensagem(string msg){

    Console.Clear();
    Console.WriteLine(msg);
    Thread.Sleep(1500);
}