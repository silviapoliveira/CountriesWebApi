using CountriesWebApi.Modelos;
using System.Collections.ObjectModel;

namespace CountriesWebApi
{
    public class MainViewModel
    {
        public ObservableCollection<MapMarker> Markers { get; set; }

        public MainViewModel()
        {
            Markers = new ObservableCollection<MapMarker>();
        }
    }
}
