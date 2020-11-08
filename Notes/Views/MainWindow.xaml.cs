using Aplication;
using Domain;
using Notes.Properties;
using Notes.Resources;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Notes.Resources;
using Notes.Views;
using System;

namespace Notes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IListChanged
    {

        public MainWindow()
        {
            InitializeComponent();
            this.TopBar.ConfigTopBar(this, TopBar.State.NORMAL, true, true, false);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Login();
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            Settings.Default.Reset();
            StackPanel.Children.Clear();
            Login();
        }

        private async void Login()
        {
            //Settings.Default.Reset();
            int userId = Settings.Default.UserId;
            if (userId == 0)
            {
                UserLogin userLogin = new UserLogin();
                userLogin.ShowDialog();
                if (userLogin.Success) Login();
                else Close();
            }
            else
            {
                var user = await Service.instance.GetUserFromId(userId);
                if (user != null)
                {
                    DataContext = user;
                    GetList(user);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private async void GetList(User user)
        {
            user = await Service.instance.GetListNotesFromUser(user);
            DataContext = user;
            ReloadCards();
        }

        private void ReloadCards()
        {
            User user = (User)DataContext;
            StackPanel.Children.Clear();
            foreach (var n in user.ListNotes)
            {
                AddCard(n);
            }
        }

        private void AddCard(Note note)
        {
            StackPanel.Children.Add(new CardNote(note, this.Width, this));
        }

        private async void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            User user = (User)DataContext;
            NoteDetail noteDetail = new NoteDetail();
            noteDetail.ShowDialog();

            if (noteDetail.Success)
            {
                bool response = await Service.instance.InsertNote(noteDetail.Note, user);
                if (!response)
                {
                    MessageBox.Show("Ha ocurrido un error!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    user.ListNotes.Add(noteDetail.Note);
                    AddCard(noteDetail.Note);
                }
            }
        }

        public async void EditNote(Note note)
        {
            User user = (User)DataContext;
            NoteDetail noteDetail = new NoteDetail(note);
            noteDetail.ShowDialog();

            if (noteDetail.Success)
            {
                bool response = await Service.instance.UpdateNote(noteDetail.Note);
                if (!response)
                {
                    MessageBox.Show("Ha ocurrido un error!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    int index = user.ListNotes.IndexOf(noteDetail.Note);
                    user.ListNotes[index] = noteDetail.Note;
                    ReloadCards();
                }
            }
        }

        public async void DeleteNote(Note note)
        {
            User user = (User)DataContext;
            MessageBoxResult res = MessageBox.Show("¿Desea eliminar esta nota?", note.Title, MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (res == MessageBoxResult.Yes)
            {
                bool response = await Service.instance.DeleteNote(note);
                if (!response)
                {
                    MessageBox.Show("Ha ocurrido un error!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    user.ListNotes.Remove(note);
                    ReloadCards();
                }
            }
        }

    }

}
