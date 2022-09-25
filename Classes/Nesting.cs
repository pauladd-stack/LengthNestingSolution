using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace LengthNestingSolution.Classes
{
    public class Nesting
    {

        public List<double>? LengthList { get; set; } = new List<double>();
        public List<double>? Inventory { get; set; } = new List<double>();
        public List<double>? Nested { get; set; } = new List<double>();

        public void Nest()
        {
            double itemCmp = 0;

            foreach (double item in Inventory)
            {
                itemCmp = item;
                foreach (double length in LengthList)
                {
                    if (itemCmp > length)
                    {
                        Nested.Add(length);
                        itemCmp = item - length;
                    }
                }
            }
        }

        
       

    }
}
