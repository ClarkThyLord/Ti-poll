using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Ti_poll.Clases
{
    class Product
    {
        public string Name;
        public int Cost;
        public Image Image;

        public Product (string Name, int Cost, Image image)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Image = image;
        }
    }
}
