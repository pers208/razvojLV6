using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppoonlv6
{
    class Program
    {
        static void Main(string[] args)
        {   //prvi
            Note schoolNote = new Note("Study schedule", "programming, english");
            Note gymNote = new Note("no pain no gain", "100 push ups, 100 sit ups");
            Note morningNote = new Note("Good morning!","You can do this!"); 
            Notebook notebook = new Notebook();
            notebook.AddNote(schoolNote);
            notebook.AddNote(gymNote);
            notebook.AddNote(morningNote);
            IAbstractIterator iterator = notebook.GetIterator();
            for (Note note = iterator.First(); iterator.IsDone == false; note = iterator.Next())
            {
                note.Show();
            }
        }
    }
}
