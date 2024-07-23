using System.Windows;

namespace CountriesWebApi.Servicos
{
    public class DialogService
    {
        public void ShowMessage(string title, string message)
        {
            MessageBox.Show(message, title);
        }
    }
}
