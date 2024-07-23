using CountriesWebApi.Modelos;
using System.Data.SQLite;
using System.IO;
using System.Net;
using static CountriesWebApi.Modelos.Country;

namespace CountriesWebApi.Servicos
{
    public class DataService
    {
        private SQLiteConnection connection;

        private SQLiteCommand command;

        private DialogService dialogService;

        public DataService()
        {
            dialogService = new DialogService();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            var path = @"Data\Countries.sqlite";

            try
            {
                connection = new SQLiteConnection("Data Source =" + path);
                connection.Open();

                string sql = "create table if not exists Countries (Name varchar(250), Capital varchar(250), Region varchar(250), SubRegion varchar(250), Population int, Gini real, Latitude real, Longitude real)";

                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
            }
        }

        public void SaveData(List<Country> Countries)
        {
            try
            {
                foreach (var country in Countries)
                {
                    string sql = "insert into Countries (Name, Capital, Region, SubRegion, Population, Gini, Latitude, Longitude) values (@Name, @Capital, @Region, @SubRegion, @Population, @Gini, @Latitude, @Longitude)";

                    command = new SQLiteCommand(sql, connection);
                    command.Parameters.AddWithValue("@Name", country.DisplayName);
                    command.Parameters.AddWithValue("@Capital", country.DisplayCapital);
                    command.Parameters.AddWithValue("@Region", country.DisplayRegion);
                    command.Parameters.AddWithValue("@SubRegion", country.DisplaySubRegion);
                    command.Parameters.AddWithValue("@Population", country.DisplayPopulation);
                    command.Parameters.AddWithValue("@Gini", country.DisplayGini);
                    command.Parameters.AddWithValue("@Latitude", country.latlng[0]);
                    command.Parameters.AddWithValue("@Longitude", country.latlng[1]);

                    command.ExecuteNonQuery();

                    // Obter o caminho para a pasta do projeto
                    string projectFolder = AppDomain.CurrentDomain.BaseDirectory;

                    // Definir o caminho para a pasta Images
                    string imagesFolder = Path.Combine(projectFolder, "Images");

                    // Verificar se a pasta Images já existe. Se não existir, criar
                    if (!Directory.Exists(imagesFolder))
                    {
                        Directory.CreateDirectory(imagesFolder);
                    }

                    // Definir o caminho para guardar a imagem
                    string imagePath = Path.Combine(imagesFolder, country.DisplayName + ".png");

                    // Verificar se a imagem já existe. Se não existir, fazer download e guardar a imagem
                    if (!File.Exists(imagePath))
                    {
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(new Uri(country.DisplayFlag), imagePath);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
            }
        }

        public List<Country> GetData()
        {
            List<Country> countries = new List<Country>();

            try
            {
                string sql = "select Name, Capital, Region, SubRegion, Population, Gini, Latitude, Longitude from Countries";

                command = new SQLiteCommand(sql, connection);

                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    countries.Add(new Country
                    {
                        name = new Name { common = (string)reader["Name"] },
                        capital = new List<string> { (string)reader["Capital"] },
                        region = (string)reader["Region"],
                        subregion = (string)reader["SubRegion"],
                        population = (int)reader["Population"],
                        gini = new Gini { _2019 = (double?)reader["Gini"] },
                        latlng = new List<double> { (double)reader["Latitude"], (double)reader["Longitude"] }
                    });
                }

                connection.Close();

                return countries;
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
                return null;
            }
        }

        public void DeleteData()
        {
            try
            {
                string sql = "delete from Countries";

                command = new SQLiteCommand(sql, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
            }
        }
    }
}
