internal class Program5_3
{
    private static void Main(string[] args)
    {
        List<string[]> matrizDeNomes = new List<string[]>();

        string[] cliente = new string[3];
        cliente[0] = "Danilo";
        cliente[1] = "(00)0000-0000";
        cliente[2] = "000.000.000-00";
        matrizDeNomes.Add(cliente);

        string[] cliente2 = new string[3];
        cliente2[0] = "Michele";
        cliente2[1] = "(00)0000-0001";
        cliente2[2] = "000.000.000-01";
        matrizDeNomes.Add(cliente2);

        foreach (string[] cli in matrizDeNomes)
        {
            Console.WriteLine($"Nome: {cli[0]}");
            Console.WriteLine($"Telefone: {cli[1]}");
            Console.WriteLine($"CPF: {cli[2]}");
        }
    }
}