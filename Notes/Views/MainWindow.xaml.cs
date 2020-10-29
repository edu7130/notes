using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Todo_List.Resources;

namespace Todo_List
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.TopBar.ConfigTopBar(this, TopBar.State.NORMAL, true, true, false);
            Edu s = new Edu(name: "asd", age: 0);
        }
    }
}

class Edu
{
    String name;
    public Edu(string name = "", int age = 0)
    {

    }
}