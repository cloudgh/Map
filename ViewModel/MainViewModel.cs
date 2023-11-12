using Mapsui.Layers;
using Mapsui.Providers;
using Mapsui.Styles;
using Mapsui.UI.Wpf;
using BruTile.Predefined;

using BruTile.Web;
using Mapsui.Tiling.Layers;

namespace Map.ViewModel
{
    public class MainViewModel
    {
        public MapControl MapControl { get; }

        public MainViewModel()
        {
            // Создаем карту
            var map = new Mapsui.Map();

            // Добавляем слой OpenStreetMap
            var osmLayer = new TileLayer(
                new HttpTileSource(new GlobalSphericalMercator(), "https://www.openstreetmap.org/{z}/{x}/{y}.png"))
            {
                Name = "OpenStreetMap"
            };
            map.Layers.Add(osmLayer);

            // Инициализируем MapControl
            MapControl = new MapControl { Map = map };
        }
    }
}
