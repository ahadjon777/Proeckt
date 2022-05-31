using ProektDron.InTextSplit.Display;
using ProektDron.InTextSplit.Fayl;
using ProektDron.InTextSplit.Ornatish;
using ProektDron.InTextSplit.Parvozdan_oldin_tekshirish;
using ProektDron.InTextSplit.Vazifa;
using ProektDron.InTextSplit.Xarita;
using ProektDron.InTextSplit.Yordam;
using ProektDron.RightInstrument;
using ProektDron.Uskunalar_Paneli;
using ProektDron.video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using ProektDron.Gmap;

namespace ProektDron
{
    public partial class Form1 : Form
    {
       // private List<PointLatLng> _points;
       
        public Form1()
        {
            InitializeComponent();
            pnlUskuna.Controls.Add(new uskunalarPaneli());
           // _points = new List<PointLatLng>();
            pnlGMap.Controls.Add(new Gmaps());
          
        }

        private void ekranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GCSDisplay f1 = new GCSDisplay();
            f1.ShowDialog();
        }

        private void yozibOlishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YozibOlish f2 = new YozibOlish();
            f2.ShowDialog();
        }

        private void chiqishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importXaritasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportXarita f3 = new ImportXarita();
            f3.ShowDialog();
        }

        private void yuklabOlishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.ShowDialog();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.ShowDialog();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void tozalashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O'chirishni hohlaysizmi");
        }

        private void xaritaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            XaritagaO_tish f4 = new XaritagaO_tish();
            f4.ShowDialog();

        }

        private void gCSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GCSSozlamalar f5 = new GCSSozlamalar();
            f5.ShowDialog();
        }

        private void tekshirishniSozlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TekshirishSozlamalari f6 = new TekshirishSozlamalari();
            f6.ShowDialog();
        }

        private void rFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RFTarmoqKengligi f7 = new RFTarmoqKengligi();
            f7.ShowDialog();
        }

        private void favqulodDastagiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FavqulotdaDastasi f8 = new FavqulotdaDastasi();
            f8.ShowDialog();
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoshqaruvParametrlari f9 = new BoshqaruvParametrlari();
            f9.ShowDialog();
        }

        private void aPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APniOrnatish f10 = new APniOrnatish();
            f10.ShowDialog();
        }

        private void tC200ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JostikniYoqish f11 = new JostikniYoqish();
            f11.ShowDialog();
        }

        private void parvozTelemetriyasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParvozTemplamenti f12 = new ParvozTemplamenti();
            f12.ShowDialog();
        }

        private void sensorliTelemetriyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SensorTemplamenti f13 = new SensorTemplamenti();
            f13.ShowDialog();
        }

        private void qaytaIshlanmaganMalumotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QaytaIshlanmaganMalumot f14 = new QaytaIshlanmaganMalumot();
            f14.ShowDialog();
        }

        private void tizimHolatiTelemetriyasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TzimStatusTemplamenti f15 = new TzimStatusTemplamenti();
            f15.ShowDialog();
        }

        private void dGPSStatuslariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGPSStatuslari f16 = new DGPSStatuslari();
            f16.ShowDialog();
        }

        private void smartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AqilliBatareya f17 = new AqilliBatareya();
            f17.ShowDialog();
        }

        private void vizualQonishHolatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisualXolatniQoshish f18 = new VisualXolatniQoshish();
            f18.ShowDialog();
        }

        private void tC200StatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TC200Status f19 = new TC200Status();
            f19.ShowDialog();
        }

        private void mGSeriyaliGimbalNazoratiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MGSeriyaGimbalNazorat f20 = new MGSeriyaGimbalNazorat();
            f20.ShowDialog();

        }

        private void parvozRejasiniImportQilishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.ShowDialog();
        }

        private void importniRejalashtirishHududiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.ShowDialog();
        }

        private void eksportniRejalashtirishHududiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void eksportYolNuqtasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.ShowDialog();
        }

        private void fotosuratVazifasiniSozlashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FotoVazifaniSozlash f21 = new FotoVazifaniSozlash();
            f21.ShowDialog();
        }

        private void pOSMalumotlariniImportQilishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.ShowDialog();
        }

        private void barqarorPlatformaBoshqaruviToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BarqarorPlatformaBoshqaruvi f22 = new BarqarorPlatformaBoshqaruvi();
            f22.ShowDialog();
        }

        private void parvozdanOldinTekshirishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParOlTekshirish f23 = new ParOlTekshirish();
            f23.ShowDialog();
        }

        private void haqidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Haqida f24 = new Haqida();
            f24.ShowDialog();
        }

        private void litsenziyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Litsenziya f25 = new Litsenziya();
            f25.ShowDialog();
        }

        private void yuklabOlishUchunLitsenziyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YuklabOlishUchunLitsenziya f26 = new YuklabOlishUchunLitsenziya();
            f26.ShowDialog();
        }

        //private void button6_Click(object sender, EventArgs e)
        //{
            
           
        //    double lat = Convert.ToDouble(txtLat.Text);
        //    double lon = Convert.ToDouble(txtLon.Text);

        //    map.Position = new PointLatLng(lat, lon);
            
            
        //}

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    GMaps.Instance.Mode = AccessMode.ServerAndCache;
        //    map.CacheLocation = @"cache";
        //    map.DragButton = MouseButtons.Left;
        //    map.MapProvider = GMapProviders.GoogleMap;
        //    map.ShowCenter = false;
        //    map.Zoom = 10;
        //    map.MinZoom = 5;
        //    map.MaxZoom = 100;
        //}
    }
}
