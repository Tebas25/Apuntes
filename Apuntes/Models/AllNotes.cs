using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes.Models
{
    internal class AllNotes
    {
        public ObservableCollection<Notes> Notes { get; set; } = new ObservableCollection<Notes>();
        public AllNotes() => 
            LoadNotes();
        public void LoadNotes()
        {
            Notes.Clear();
            string appDataPath = FileSystem.AppDataDirectory;
            IEnumerable<Notes> notes = Directory
                .EnumerateFiles(appDataPath, "*apuntes.txt")
                .Select(fileName => new Notes()
                {
                    FileName = fileName,
                    Text = File.ReadAllText(fileName),
                    Date = File.GetLastWriteTime(fileName)
                })
                .OrderBy(note => note.Date);
            foreach (Notes note in notes)
            {
                Notes.Add(note);
            }
        }
    }

}
