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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _312576Whilestringexample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string myWord = "Bonjour mon ami";
            string output = "";
            while(myWord.Length > 0)
            {
                output += myWord.Substring(0, 1) + Environment.NewLine;
                myWord = myWord.Substring(1);

            }
            lblOutput.Content = output;
        }
    }
}
