using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace ProektDron.Gmap
{
    public partial class Gmaps : UserControl
    {
        private List<PointLatLng> _points;
        public Gmaps()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
            Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double lat = Convert.ToDouble(textBox1.Text);
            double lon = Convert.ToDouble(textBox2.Text);
            map.Position = new PointLatLng(lat, lon);
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
          //  PointLatLng point;

            GMapMarker marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)), GMarkerGoogleType.red_small);

            GMapOverlay markers = new GMapOverlay("markers");

            markers.Markers.Add(marker);

            map.Overlays.Add(markers);
        }

        private void Gmaps_Load(object sender, EventArgs e)
        {
           // GMapProviders.BingHybridMap.ApiKey = @"";
            map.DragButton = MouseButtons.Left;
            // map.DragButton = MouseButtons.Right;
            map.CacheLocation = @"cache";
            map.MapProvider = GMapProviders.GoogleSatelliteMap;
            map.ShowCenter = false;
           // map.SetPositionByKeywords("Uzbekistan, Uzbek");
        }
    }
}
