using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Mining.Classes
{
  public  class Cluster
    {
        private int ID { get; set; }
        private int size
        { get; set; }
        public  List<string> Contents;


        public Cluster(int id, int p, List<string> tmp)
        {
            // TODO: Complete member initialization
            this.ID = id;
            this.size = p;
            this.Contents = tmp;
        }

        
    }
}
