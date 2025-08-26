namespace Notes;
   
    public partial class MainPage : ContentPage
    {
    int count = 0;
    string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");
    public MainPage()
        {

          InitializeComponent();
        if(File.Exists(caminho))
        CaixaEditor.Text = File.ReadAllText(caminho);
        


    }

    private void SalvarBtn_Clicked(object sender, EventArgs e)
    {
        string conteudo = CaixaEditor.Text;
        File.WriteAllText(caminho, conteudo);


        Console.WriteLine($"Arquivo salvo: {CaixaEditor}");
        Console.WriteLine($"Localização: {caminho}");
    }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
          File.Delete(caminho);
        DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso", "OK");

         if(File.Exists(caminho))
        {
            File.Delete(caminho);
            CaixaEditor.Text = null;
            DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso", "OK");
        }
         else
        {
            DisplayAlert("Erro", "o arquivo não existe", "ok");
        }

        }
    }
 

