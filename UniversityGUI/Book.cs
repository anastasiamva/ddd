using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class Book
    {
        public readonly int Id;
        public readonly string Name;
        public readonly string Author;
        protected List<Formular> FormularList;
        public int ExemplarCount;
        public int FreeExemplarsCount
        {
            get
            {
                return ExemplarCount - FormularList.Count;
            }
        }

        public Book(int id, string name, string author, int exemplarAmount = 1)
        {
            Id = id;
            Name = name;
            Author = author;
            FormularList = new List<Formular>();
            ExemplarCount = exemplarAmount;
        }

        public void AddFormular(Formular frm)
        {
            FormularList.Add(frm);
        }

        public void RemoveFormular(Formular frm)
        {
            FormularList.Remove(frm);
        }

        public bool Equals(Book b)
        {
            return (Name == b.Name && Author == b.Author);
        }
    }
}
