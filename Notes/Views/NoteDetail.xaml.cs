using Aplication;
using Domain;
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
using Notes.Resources;

namespace Notes.Views
{
    /// <summary>
    /// Lógica de interacción para NoteDetail.xaml
    /// </summary>
    public partial class NoteDetail : Window
    {
        bool success = false;

        public NoteDetail()
        {
            InitializeComponent();
            DataContext = new Note();
        }
        public NoteDetail(Note note)
        {
            InitializeComponent();
            DataContext = note;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TopBar.ConfigTopBar(this, TopBar.State.NORMAL, false, false, false);
            TxtTitle.Focus();
        }

        public bool Success => success;
        public Note Note => (Note)DataContext;

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            Note n = (Note)DataContext;
            if (n.Title.Length == 0 || n.Body.Length == 0)
            {
                MessageBox.Show("Completa los campos requeridos", "Advertencia", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                success = true;
                Close();
            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            success = false;
            Close();
        }

        
    }
}
