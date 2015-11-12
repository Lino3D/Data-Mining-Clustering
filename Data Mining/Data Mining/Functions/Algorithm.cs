using Data_Mining.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining.Functions
{
   public static class Algorithm
    {
        public static List<Cluster> InitializeClusters (string document)
        {

            char[] delimiters = new char[] { '\r', '\n', ' ', '\t' };
            string[] w = document.Split(delimiters,
				     StringSplitOptions.RemoveEmptyEntries);
            int id=0;
            List<Cluster> Clusters = new List<Cluster>();

            foreach (string s in w)
            {
              
                List<string> tmp= new List<string>();
                tmp.Add(s);
                Cluster c = new Cluster(id, s.Length, tmp);
                Clusters.Add(c);
                id++;
               
            }
            return Clusters;

        }
    }
}
