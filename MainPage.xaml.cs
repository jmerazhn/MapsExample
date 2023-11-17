
using Map = Microsoft.Maui.Controls.Maps.Map;
namespace MapsExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            Map map = new Map();
            Content = map;
        }

    }
}