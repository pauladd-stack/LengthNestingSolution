using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthNestingSolution.Classes
{
    public static class AllProjects
    {
        public static List<ProjectDetails> Project { get; private set; } = new List<ProjectDetails>();
        public class ProjectDetails
        {
            public string FileName { get; private set; }
            public string ProjectName { get; private set; }
            public string MaterialDesc { get; private set; }
            public double Length { get; private set; }
            public static void ProjectInsert(string[] lines)
            {
                Project.Add(new ProjectDetails()
                {
                    FileName = lines[1],
                    ProjectName = lines[2],
                    MaterialDesc = lines[6],
                    Length = double.Parse(lines[10]),
                });

            }
        }
        public class Cuts
        {
            public static void CalcCuts(int n)
            {
                int[] bitArray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    bitArray[i] = 0;
                }

                foreach (var bit in bitArray)
                {
                }


            }
        }
    }
}
