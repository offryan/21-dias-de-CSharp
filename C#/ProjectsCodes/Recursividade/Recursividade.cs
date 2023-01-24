
LerArquivos(@"C:\Users\Administrator\Desktop\21-dias-de-CSharp\C#\ProjectsCodes\Recursividade");

static void LerArquivos(string LerArquivos)
{
    string arquivoCaminho = @"C:\Users\Administrator\Desktop\21-dias-de-CSharp\C#\ProjectsCodes\Recursividade\Nomes das pessoas" + numeroArquivo + ".txt";

    using (StringReader arq = File.OpenText(arquivo))
    {

        string linha;
        while ((linha = arq.ReadLine()) != null)
        {
            System.Console.WriteLine(linha);
        }
    }
}

string arquivoCaminho = @"C:\Users\Administrator\Desktop\21-dias-de-CSharp\C#\ProjectsCodes\Recursividade\Nomes das pessoas" + numeroArquivo + ".txt";
if (File.Exists(arquivoCaminho2))
{
    LerArquivos(numeroArquivo + 1);
}

static void Main(string[] args)
{
    LerArquivos();
}
