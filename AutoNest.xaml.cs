using LengthNestingSolution.Classes;
using System;
using System.Diagnostics;
using System.Windows;


namespace LengthNestingSolution
{
    /// <summary>
    /// Interaction logic for AutoNest.xaml
    /// </summary>
   
    public partial class AutoNest : Window
    {
        public Classes.AllProjects? newProject { get; set; }
        Inventory newInventory = new Inventory();

        public AutoNest()
        {
            InitializeComponent();
            DataContext = this.newInventory;
        }

        private void nest_Click(object sender, RoutedEventArgs e)
        {
            Nesting nesting = new Nesting();
            foreach (AllProjects.ProjectDetails job in newProject!.Projects)
            {
                nesting.LengthList.Add(job.Length);
            }
            foreach (Inventory.InventoryItems inv in newInventory!.InventoryList)
            {
                nesting.Inventory.Add(inv.Length);
            }
            nesting.Nest();
            foreach (double item in nesting.Nested)
            {
                Debug.WriteLine(item);
            }
            
            DialogResult = true;
            Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            
            newInventory.InventoryList.Add(new Inventory.InventoryItems()
            {
                Qty = Convert.ToDouble(qtyValue.Text),
                Length = Convert.ToDouble(lengthValue.Text),
            });

            foreach (AllProjects.ProjectDetails job in newProject!.Projects)
            {
                Debug.WriteLine(job.Length.ToString());
            }
                

        }
        
        
    }   
}
