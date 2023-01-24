LerArquivos(@"C:\Users\Administrator\Desktop\21-dias-de-CSharp\C#\ProjectsCodes\Recursividade");
void LerArquivos(int numeroArquivo){

    string arquivoComCaminho = @"C:\Users\Administrator\Desktop\21-dias-de-CSharp\C#\ProjectsCodes\Recursividade\Nomes das pessoas" + numeroArquivo + ".txt";
    if(File.Exists(arquivoComCaminho))
    {
         using (StreamReader arq = File.OpenText(nomeArquivos))
        {

        string linha;
        while ((linha = arq.ReadLine()) != null)
            {
                System.Console.WriteLine(linha);
            }
        }
    }

    string arquivoComCaminho2 = @"C:\Users\Administrator\Desktop\21-dias-de-CSharp\C#\ProjectsCodes\Recursividade\Nomes das pessoas" + (numeroArquivo + 1)+ ".txt";

    if(File.Exists(arquivoComCaminho2))
    {
        LerArquivos(numeroArquivo + 1);
    }
}