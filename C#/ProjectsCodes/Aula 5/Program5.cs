class Program5{
    static void Main(string[] args)
    {
            Console.WriteLine("============================LÓGICA================================ =");

            for(var km = 0; km <=1000; km++){
                Console.WriteLine($"Passando pelo km {km}...");
                Thread.Sleep(10);
            }

            Console.WriteLine("================================================================== ");
    }
}