using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IListChanged
    {
        void EditNote(Note note);
        void DeleteNote(Note note);
    }
}
