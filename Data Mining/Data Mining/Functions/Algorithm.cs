﻿using Data_Mining.Classes;
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

       public static List<Cluster> Cluster(List<Cluster> Clusters)
        {
           int distance;
           for (int i = 0; i < Clusters.Count; i++)
           {
               int MinLength = Int32.MaxValue;
               int MinCluster = 0;
               string str1 = Clusters[i].Contents.First();

               for (int j = 0; j < Clusters.Count; j++)
               {
                   if ( i != j )
                   {
                       distance = CalculateLevenshtein(Clusters[j].Contents.First(), str1);
                       if (distance < MinLength)
                       {
                           MinLength = distance;
                           MinCluster = j;
                       }

                   }
               }
               Clusters[i] = MergeClusters(Clusters[i], Clusters[MinCluster]);
               Clusters.RemoveAt(MinCluster);
           }

           //Calculate Centroids
            return Clusters; 
        }
       public static Cluster MergeClusters(Cluster c1, Cluster c2)
       {
           foreach ( string t in c2.Contents)
                c1.Contents.Add( t );
           return c1;
       }
       public static int CalculateLevenshtein(string a, string b)
        {
            int n = a.Length;
            int m = b.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
                return m;
            if (m == 0)
                return n;
            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++);
            for (int j = 0; j <= m; d[0, j] = j++);

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (b[j - 1] == a[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }
    }
}
