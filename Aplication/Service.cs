using DataAccess;
using DataAccess.Entities;
using Domain;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;

namespace Aplication
{
    public class Service
    {
        public static Service instance = new Service();

        public async Task<User> GetUserFromId(int id)
        {
            return await Task.Run(() => DaoUser.GetUserfromId(id));
        }

        public async Task<User> GetUserFromName(string name)
        {
            name = name.Trim();
            return await Task.Run(() => DaoUser.GetUserfromName(name));
        }

        public async Task<User> InsertUser(string name)
        {
            name = name.Trim();
            return await Task.Run(() => {
                var response = DaoUser.InsertUser(name);
                if (!response) return null;
                else
                {
                    return DaoUser.GetUserfromName(name);
                }
            });
        }

        public async Task<User> GetListNotesFromUser(User user)
        {
            return await Task.Run(() =>
            {
                user.ListNotes = DaoNote.GetNotesFromUser(user);
                foreach (var el in user.ListNotes)
                {
                    Console.WriteLine(el.Title);
                }

                return user;
            });
        }

        public async Task<bool> InsertNote(Note note, User user)
        {
            note.Created = DateTime.Now;
            return await Task.Run(() =>
            {
                return DaoNote.InsertNote(note, user);
            });
        }

        public async Task<bool> UpdateNote(Note note)
        {
            return await Task.Run(() =>
            {
                return DaoNote.UpdateNote(note);
            });
        }

        public async Task<bool> DeleteNote(Note note)
        {
            return await Task.Run(() =>
            {
                return DaoNote.DeleteNote(note);
            });
        }


        /*
        #region NOTES
        public async Task<List<Note>> GetNotes(int id)
        {
            return await Task.Run(() =>
            {
                return DaoNote.GetNotesfromUserId(id);
            });
        }

        public async Task<Tuple<bool, string>> InsertNote(Note note)
        {
            note.Created = DateTime.Now;
            return await Task.Run(() =>
            {
                return DaoNote.InsertNote(note);
            });
        }

        public async Task<Tuple<bool, string>> UpdateNote(Note note)
        {
            return await Task.Run(() =>
            {
                return DaoNote.UpdatetNote(note);
            });
        }

        public async Task<Tuple<bool, string>> DeleteNote(Note note)
        {
            return await Task.Run(() =>
            {
                return DaoNote.DeleteNote(note);
            });
        }

        #endregion

        #region USER

        public async Task<Tuple<bool, User, string>> LoginUser(string name)
        {
            return await Task.Run(() => {
                return DaoUser.GetUserfromName(name);
            });
        }

        public async Task<Tuple<bool, User, string>> InsertUser(User user)
        {
            return await Task.Run(() =>
            {

                var insUser = DaoUser.InsertUser(user);
                if (insUser.Item1)
                {
                    var u = DaoUser.GetUserfromName(user.Name);
                    if (u.Item1)
                    {
                        return Tuple.Create(true, u.Item2, "");
                    }
                    else
                    {
                        return Tuple.Create(false, u.Item2, $"No se ha podido recuperar el usuario {user.Name}");
                    }
                }

                return Tuple.Create(false, new User(), insUser.Item2);
            });
        }

        #endregion
        */
    }
}
