using Android.Views;

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


        DisplayAlert("Salvar", $"{caminho}", "ok");
    }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {
        CaixaEditor.Text = String.Empty ;

         if(File.Exists(caminho))
        {
            File.Delete(caminho);
           
           DisplayAlert("Arquivo apagado", "Arquivo apagado com sucesso", "OK");
        }
         else
        {
            DisplayAlert("Erro", "o arquivo não existe", "ok");
        }

        }
    }
 

