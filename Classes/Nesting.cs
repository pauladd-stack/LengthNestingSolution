using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthNestingSolution.Classes
{
    public class Nesting
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

       

    }
}
