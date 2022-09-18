using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthNestingSolution.Classes
{
    class Nesting
    {
        public static List<double> LengthList { get; private set; } = new List<double>();
        public static double TotalLength { get; private set; }

        private static void AddLength(double value)
        {
            TotalLength = TotalLength + value;
        }
        public static void InsertLengths()
        {
            foreach (AllProjects.ProjectDetails proj in AllProjects.Project)
            {
                LengthList.Add(proj.Length);
                AddLength(proj.Length);
            }
        }

        public class Inventory
        {
            public static List<Inventory> InventoryList { get; private set; }
            public int Qty { get; private set; }
            public double Length { get; private set; }
            public static void InsertInventory(int qty, double length)
            {
                InventoryList = new List<Inventory>();
                InventoryList.Add(new Inventory()
                {
                    Qty = Convert.ToInt16(qty),
                    Length = Convert.ToDouble(length),
                });
            }
        }

    }
}
