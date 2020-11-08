﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Note> ListNotes { get; set; }
        public User()
        {
        }

        User(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}