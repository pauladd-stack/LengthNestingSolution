using LengthNestingSolution.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using static LengthNestingSolution.AutoNest;
using static LengthNestingSolution.Classes.Nesting;

namespace LengthNestingSolution
{
    /// <summary>
    /// Interaction logic for AutoNest.xaml
    /// </summary>
    public partial class AutoNest : Window, INotifyPropertyChanged
    {
        public class Inventory 
        {
            public double Qty { get; set; }
            public double Length { get; set; }
            public override string ToString()
            {
                return "Qty: " + Qty.ToString() + " Length:" + Length.ToString();
            }
        }

        public ObservableCollection<Inventory> inventory = new ObservableCollection<Inventory>();

        public ObservableCollection<Inventory> InventoryList
        {
            get { return inventory; }
            set
            {
                inventory.Add(new Inventory());
                NotifyPropertyChanged(value.ToString());
            }


        }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string? propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        
        public AutoNest()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void nest_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            InventoryList.Add(new Inventory()
            {
                Qty = Convert.ToDouble(qtyValue.Text),
                Length = Convert.ToDouble(lengthValue.Text),
            });

        }
        
        
    }
}
