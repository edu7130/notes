using Aplication;
using Domain;
using Notes.Views;
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

namespace Notes.Resources
{
    /// <summary>
    /// Lógica de interacción para CardNote.xaml
    /// </summary>
    public partial class CardNote : UserControl
    {
        IListChanged listChanged;
        public CardNote(Note note, double width, IListChanged listChanged)
        {
            InitializeComponent();
            DataContext = note;

            Width = width * .9;
            Margin = new Thickness()
            {
                Top = 10
            };
            this.listChanged = listChanged;
        }


        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Note n = (Note)DataContext;
            listChanged.EditNote(n);
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            Note n = (Note)DataContext;
            listChanged.DeleteNote(n);
        }
    }
}
