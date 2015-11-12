using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using System.IO;
using Data_Mining.Classes;
using Data_Mining.Functions;

namespace Data_Mining
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        List<Cluster> Clusters;
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void DocumentButton_Click(object sender, RoutedEventArgs e)
        {
     
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text documents (.txt)|*.txt";

            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {

                string filename = dlg.FileName;
                Paragraph paragraph = new Paragraph();
                paragraph.Inlines.Add(System.IO.File.ReadAllText(filename));
                string documenttext = System.IO.File.ReadAllText(filename);

                Clusters = Algorithm.InitializeClusters(documenttext);

                FlowDocument document = new FlowDocument(paragraph);
                FlowDocReader.Document = document;
            } 
        }
    }
}
