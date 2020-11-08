
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

namespace Notes.Resources
{
    public partial class TopBar : UserControl
    {
        Window window = null;
        bool closeQuestion = false;
        
        Double windowWidth;
        Double windowHeight;

        public enum State
        {
            NORMAL,
            MAXIMIZED,
            MINIMIZED
        }
        
        public TopBar()
        {
            InitializeComponent();
        }

        public void ConfigTopBar(Window window, State state, bool closeQuestion = false, bool canMinimize = true, bool canMaximize = true)
        {
            this.window = window;
            this.closeQuestion = closeQuestion;

            this.NameWindow.Content = window.Title;
            this.windowWidth = window.Width;
            this.windowHeight = window.Height;
            
            ConfigState(state);
            ConfigButtons(canMinimize,canMaximize);
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            if (window == null) return;
            if (closeQuestion)
            {
                MessageBoxResult rs = MessageBox.Show("Exit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (rs == MessageBoxResult.No) return;
            }
            this.window.Close();
        }

        private void BtnRestore_Click(object sender, RoutedEventArgs e)
        {
            Restore();
        }

        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            Maximize();
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            if (this.window == null) return;
            this.window.WindowState = WindowState.Minimized;
        }

        private void ConfigState(State state)
        {
            if(state == State.NORMAL)
            {
                Restore();
            }
            else if(state == State.MAXIMIZED)
            {
                Maximize();
            }
            else if (state == State.MINIMIZED)
            {
                Double left = (System.Windows.SystemParameters.WorkArea.Width - this.windowWidth) / 2;
                Double top = (System.Windows.SystemParameters.WorkArea.Height - this.windowHeight) / 2;

                this.window.Left = left;
                this.window.Top = top;
                this.window.WindowState = WindowState.Minimized;
            }
        }

        private void ConfigButtons(bool canMinimize, bool canMaximize)
        {
            if (!canMinimize)
            {
                this.BtnMinimize.Visibility = Visibility.Collapsed;
            }
            if (!canMaximize)
            {
                this.BtnRestore.Visibility = Visibility.Collapsed;
                this.BtnMaximize.Visibility = Visibility.Collapsed;
            }
        }

        private void Restore()
        {
            if (this.window == null) return;
            this.window.Width = this.windowWidth;
            this.window.Height = this.windowHeight;

            Double left = (System.Windows.SystemParameters.WorkArea.Width - this.windowWidth) / 2;
            Double top = (System.Windows.SystemParameters.WorkArea.Height - this.windowHeight) / 2;

            this.window.Left = left;
            this.window.Top = top;

            this.BtnMaximize.Visibility = Visibility.Visible;
            this.BtnRestore.Visibility = Visibility.Collapsed;
        }

        private void Maximize()
        {
            if (this.window == null) return;
            this.window.Width = System.Windows.SystemParameters.WorkArea.Width;
            this.window.Height = System.Windows.SystemParameters.WorkArea.Height;

            this.window.Left = 0;
            this.window.Top = 0;

            this.BtnMaximize.Visibility = Visibility.Collapsed;
            this.BtnRestore.Visibility = Visibility.Visible;
        }

        private void GridTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            window.DragMove();
        }
    }
}
