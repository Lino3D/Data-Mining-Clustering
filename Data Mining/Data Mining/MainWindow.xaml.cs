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
        string documenttext;
        int MaxDistance;
        public MainWindow()
        {
      //      MessageBox.Show(Algorithm.CalculateLevenshtein("Sam", "Samantha").ToString());
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
                documenttext = System.IO.File.ReadAllText(filename);
                FlowDocument document = new FlowDocument(paragraph);
                FlowDocReader.Document = document;
                Start.IsEnabled = true;

            } 
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            int MaxDistance;
       
           bool result = Int32.TryParse(MinDistanceTextBox.Text, out MaxDistance);

           if (result)
           {
               Clusters = Algorithm.InitializeClusters(documenttext);
                   Clusters = Algorithm.Cluster(Clusters, 25);

               Paragraph paragraph2 = new Paragraph();
               for (int i = 0; i < Clusters.First().Contents.Count; i++)
                   paragraph2.Inlines.Add(Clusters.First().Contents[i] + '\n');
              // FlowDocument document2 = new FlowDocument(paragraph2);
             //  ClusteredFlowDoc.Document = document2;

               int b;
      
               Algorithm.KMeans2(Clusters);
               dataGrid.ItemsSource = Clusters;
           }
              
              

           else
           {
               MessageBox.Show("Wrong number inserted");
           }

        }
    }
}
