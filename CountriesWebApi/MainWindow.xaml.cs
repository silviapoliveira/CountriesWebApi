using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Syncfusion.Windows.Tools.Controls;
using CountriesWebApi.Modelos;
using CountriesWebApi.Servicos;

namespace CountriesWebApi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Atributos

        private List<Country> Countries;

        private NetworkService networkService;

        private ApiService apiService;

        private DialogService dialogService;

        private DataService dataService;

        #endregion

        #region Propriedades

        public ObservableCollection<MapMarker> Markers { get; set; }

        #endregion

        public MainWindow()
        {

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cWWJCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXhfdXRTR2lfVEFxXEo=");

            InitializeComponent();

            this.DataContext = this;

            networkService = new NetworkService();

            apiService = new ApiService();

            dialogService = new DialogService();

            dataService = new DataService();

            var progress = new Progress<double>(value => progressBar.Value = value * 100);

            LoadCountries(progress);

            lblBandeira.Visibility = Visibility.Collapsed;
            searchBox.IsEnabled = false;
        }

        public async void LoadCountries(IProgress<double> progress)
        {
            bool load;

            // Verificar ligação à internet

            var connection = networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                await LoadLocalCountries(progress);
                load = false;
            }
            else
            {
                await LoadApiCountries(progress);
                load = true;
            }

            if (Countries.Count == 0)
            {
                lblStatus.Content = "Não há ligação à Internet e os países não foram previamente carregados." + Environment.NewLine +
                    "Tente novamente mais tarde.";

                return;
            }

            foreach (var country in Countries)
            {
                country.IsInternetAvailable = load;
            }

            var orderedCountries = Countries.OrderBy(c => c.CountryName).ToList();
            lbCountries.ItemsSource = orderedCountries;

            if (load)
            {
                lblStatus.Content = string.Format("Países carregados da Internet em {0:F}.", DateTime.Now);
            }
            else
            {
                lblStatus.Content = string.Format("Países carregados da Base de Dados.");
            }

            searchBox.IsEnabled = true;
        }

        private async Task LoadLocalCountries(IProgress<double> progress)
        {
            lblStatus.Content = string.Format("A carregar os países da base de dados...");

            // Atualizar a barra de progresso
            for (int i = 0; i <= 100; i++)
            {
                progress.Report(i / 100.0);
                await Task.Delay(50);  // Simular tempo de carregamento
            }
            Countries = dataService.GetData();
        }

        private async Task LoadApiCountries(IProgress<double> progress)
        {
            var response = await apiService.GetCountries("https://restcountries.com", "/v3.1/all");

            Countries = (List<Country>)response.Result;

            lblStatus.Content = string.Format("A apagar os dados anteriores...");

            // Atualizar a barra de progresso
            for (int i = 0; i <= 25; i++)
            {
                progress.Report(i / 100.0);
                await Task.Delay(50);  // Simular tempo de carregamento
            }

            dataService.DeleteData();

            lblStatus.Content = string.Format("A gravar os dados actualizados...");

            // Atualizar a barra de progresso
            for (int i = 25; i <= 50; i++)
            {
                progress.Report(i / 100.0);
                await Task.Delay(50);  // Simular tempo de carregamento
            }

            dataService.SaveData(Countries);

            lblStatus.Content = string.Format("A carregar os países da API...");

            // Atualizar a barra de progresso
            for (int i = 50; i <= 100; i++)
            {
                progress.Report(i / 100.0);
                await Task.Delay(50);  // Simular tempo de carregamento
            }
        }

        private void CheckListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Verificar se um país foi selecionado
            if (e.AddedItems.Count > 0 && e.AddedItems[0] is Country)
            {
                // Obter o item que foi selecionado
                var selectedItem = e.AddedItems[0];

                // Desmarcar todos os outros itens
                foreach (var item in lbCountries.Items)
                {
                    if (item != selectedItem && lbCountries.SelectedItems.Contains(item))
                    {
                        lbCountries.SelectedItems.Remove(item);
                    }
                }

                lblBandeira.Visibility = Visibility.Collapsed;
                imgFlag.Visibility = Visibility.Visible;
                lblStatus.Visibility = Visibility.Collapsed;
                progressBar.Visibility = Visibility.Collapsed;

                var checkListBox = (CheckListBox)sender;
                var country = (Country)checkListBox.SelectedItem;

                txtName.Text = country.DisplayName;
                txtCapital.Text = country.DisplayCapital;
                txtRegion.Text = country.DisplayRegion;
                txtSubregion.Text = country.DisplaySubRegion;
                txtPopulation.Text = country.DisplayPopulation;
                txtGini.Text = country.DisplayGini;

                if (networkService.CheckConnection().IsSuccess)
                {
                    // Se houver uma conexão com a internet, carregar a imagem da URL
                    imgFlag.Source = new BitmapImage(new Uri(country.DisplayFlag));
                }
                else
                {
                    // Se não houver uma conexão com a internet, carregar a imagem do armazenamento local
                    string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", country.DisplayName + ".png");
                    if (File.Exists(imagePath))
                    {
                        imgFlag.Source = new BitmapImage(new Uri(imagePath));
                    }
                    else
                    {
                        imgFlag.Visibility = Visibility.Collapsed;
                        lblBandeira.Visibility = Visibility.Visible;
                        lblBandeira.Content = "Sem imagem disponível";
                    }
                }

                // Verificar se as coordenadas de latitude e longitude estão disponíveis
                if (country.latlng == null || country.latlng.Count < 2)
                {
                    map.Visibility = Visibility.Collapsed;
                    lblStatus.Visibility = Visibility.Visible;
                    lblStatus.Content = "Não é possível mostrar este país no mapa de momento.";
                }
                else
                {
                    // Mostrar marcador do país selecionado
                    ((MainViewModel)map.DataContext).Markers.Clear();
                    ((MainViewModel)map.DataContext).Markers.Add(new MapMarker() { Label = country.DisplayName, Latitude = country.latlng[0], Longitude = country.latlng[1] });
                }
            }
            else
            {
                // Se nenhum país foi selecionado, limpar as informações mostradas
                txtName.Text = "";
                txtCapital.Text = "";
                txtRegion.Text = "";
                txtSubregion.Text = "";
                txtPopulation.Text = "";
                txtGini.Text = "";
                imgFlag.Source = null;
                ((MainViewModel)map.DataContext).Markers.Clear();
            }
        }

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchBox = (TextBox)sender;
            var searchText = searchBox.Text.ToLower();

            // Filtrar os países com base no texto de pesquisa e ordená-los alfabeticamente
            var filteredCountries = Countries
                .Where(country => country.DisplayName.ToLower().Contains(searchText))
                .OrderBy(country => country.DisplayName)
                .ToList();

            // Atualizar a CheckListBox com os países filtrados
            lbCountries.ItemsSource = filteredCountries;
        }
    }
}