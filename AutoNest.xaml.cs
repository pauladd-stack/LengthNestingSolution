using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LengthNestingSolution
{
    /// <summary>
    /// Interaction logic for AutoNest.xaml
    /// </summary>
    public partial class AutoNest : Window
    {
        public AutoNest()
        {
            InitializeComponent();
        }

        private void nest_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
