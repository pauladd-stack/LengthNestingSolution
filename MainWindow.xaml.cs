using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LengthNestingSolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void nc1Menu_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                foreach (string file in openFileDialog.SafeFileNames)
                {
                    TreeViewItem treeViewItem = new TreeViewItem();
                    treeViewItem.Header = file;
                    treeViewItem.DataContext = file;
                    treeView.Items.Add(treeViewItem);
                }
                foreach (string file in openFileDialog.FileNames)
                {
                    string[] lines = System.IO.File.ReadAllLines(file);
                    Classes.AllProjects.ProjectDetails.ProjectInsert(lines);
                    Debug.WriteLine(lines[10]);
                }
            }

        }

        private void autoNest_Click(object sender, RoutedEventArgs e)
        {
            AutoNest popup = new AutoNest();
            var dialog = popup.ShowDialog();
            
            if (dialog == true)
            {
                Debug.WriteLine("OK");
            }
            else
            {
                Debug.WriteLine("No");
            }

            
            popup.Close();
        }

        //        private void nc1ToolStripMenuItem_Click(object sender, EventArgs e)
        //        {
        //            var node = treeView1.Nodes[0]; //root node
        //            if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //            {

        //                foreach (string file in openFileDialog1.FileNames)
        //                {
        //                    string[] lines = System.IO.File.ReadAllLines(file);
        //                    AllProjects.ProjectDetails.ProjectInsert(lines);
        //                }
        //                foreach (AllProjects.ProjectDetails proj in AllProjects.Project)
        //                {

        //                    node.Nodes.Add(proj.FileName);
        //                    Debug.WriteLine(proj.FileName);
        //                }
        //                treeView1.ExpandAll();
        //                if (backgroundWorker1.IsBusy != true)
        //                {
        //                    // Start the asynchronous operation.
        //                    backgroundWorker1.RunWorkerAsync();
        //                }

        //            }

        //        }

        //        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        //        {
        //            Nesting.InsertLengths();
        //        }

        //        private void treeview1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        //        {
        //            if (e.Button == MouseButtons.Right)
        //            {
        //                menuStrip1.Show();
        //            }
        //        }

        //        private void button1_Click(object sender, EventArgs e)
        //        {
        //            Form2 popup = new Form2();
        //            DialogResult dialogresult = popup.ShowDialog();
        //            if (dialogresult == DialogResult.OK)
        //            {
        //                Console.WriteLine("You clicked OK");
        //            }
        //            else if (dialogresult == DialogResult.Cancel)
        //            {
        //                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
        //            }
        //            popup.Dispose();
        //        }
        //    }
    }
}
