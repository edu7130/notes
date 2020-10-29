using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Note
    {
        int id;
        string what;
        bool done;

        public Note()
        {
        }

        public Note(int id, string what, bool done)
        {
            this.id = id;
            this.what = what;
            this.done = done;
        }

        public int Id { get => id; set => id = value; }
        public string What { get => what; set => what = value; }
        public bool Done { get => done; set => done = value; }
    }
}
