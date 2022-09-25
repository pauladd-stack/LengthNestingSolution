using System.Collections.ObjectModel;


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
                projects.Add(new ProjectDetails());
            }
        }

        public class ProjectDetails
        {
            public string? FileName { get; set; }
            public string? ProjectName { get; set; }
            public string? MaterialDesc { get; set; }
            public double Length { get; set; }
        }
    }
}
