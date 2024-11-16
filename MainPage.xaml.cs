
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace cMainatoS6
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://127.0.0.2/moviles/post.php";
        private readonly HttpClient cliente = new HttpClient();
        private ObservableCollection<Estudiante> estud;
        public MainPage()
        {
            InitializeComponent();
            Obtener();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           
        }
        private async void Obtener()
        {
            var contect = await cliente.GetStringAsync(Url);
            List<Estudiante> mostrarEst = JsonConvert.DeserializeObject<List<Estudiante>>(contect);
            estud = new ObservableCollection<Estudiante>(mostrarEst);
            listaEstudiantes.ItemsSource = estud;

        }
    }

}
