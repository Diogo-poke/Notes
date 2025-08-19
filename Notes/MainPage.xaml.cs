namespace Notes;

    public partial class MainPage : ContentPage
    {
    int count = 0;
    string caminho = Path.Combine(FileSystem.AppDataDirectory,"arquivo");

        public MainPage()
        {

          InitializeComponent();

        }

        private void SalvarBtn_Clicked(object sender, EventArgs e)
        {
        string conteudo = CaixaEditor.Text;
        File.WriteAllText(caminho, conteudo);
        }

        private void ApagarBtn_Clicked(object sender, EventArgs e)
        {

        }
    }


