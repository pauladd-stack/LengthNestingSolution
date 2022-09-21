using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LengthNestingSolution.AutoNest;

namespace LengthNestingSolution.Classes
{
    public class AllProjects
    {
        public ObservableCollection<ProjectDetails> projects { get; private set; } = new ObservableCollection<ProjectDetails>();

        public ObservableCollection<ProjectDetails> Projects
        {
            get { return projects; }
            set
            {
                //projects.Add(new Inventory());
                projects.Add(new ProjectDetails());
            }

        public class ProjectDetails
        {
            public string? FileName { get; set; }
            public string? ProjectName { get; set; }
            public string? MaterialDesc { get; set; }
            public double Length { get; set; }

            
            public void ProjectInsert(string[] lines)
            {
                

            }
        }
        public class Cuts
        {
            public void CalcCuts(int n)
            {



            }
        }
    }
}
