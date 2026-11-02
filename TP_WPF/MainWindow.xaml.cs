using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TP_WPF.NewFolder;

namespace TP_WPF
{
    public partial class MainWindow : Window
    {
        public LesVilles Villes { get; set; }

        public MainWindow ()
        {
            InitializeComponent();

            Villes = new LesVilles();

            Villes.Add(new Ville("Tokyo", 37435191, "Japon", "..\\images\\japon_flag.png"));
            Villes.Add(new Ville("New Delhi", 33807141, "Inde", "..\\images\\India_flag.png"));
            Villes.Add(new Ville("Shanghai", 29868104, "Chine", "..\\images\\China_flag.png"));
            Villes.Add(new Ville("Dhaka", 23936000, "Bangladesh", "..\\images\\Bangladesh_flag.png"));
            Villes.Add(new Ville("Sao Paulo", 22806700, "Brésil", "..\\images\\Brésil_flag.png"));
            Villes.Add(new Ville("Le Caire", 22623874, "Egypte", "..\\images\\Egypte_flag.png"));
            Villes.Add(new Ville("Mexico City", 21511908, "Mexique", "..\\images\\Mexique_flag.png"));
            Villes.Add(new Ville("Pékin", 21335455, "Chine", "..\\images\\China_flag  .png"));
            Villes.Add(new Ville("Mumbai", 21673000, "Inde", "..\\images\\India_flag.png"));
            Villes.Add(new Ville("Osaka", 19222665, "Japon", "..\\images\\japon_flag.png"));

            DataContext = this;
        }
    }
}