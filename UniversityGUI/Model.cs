using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class Model
    {
        private readonly BookCatalog linkedBC;
        private readonly TicketCatalog linkedTC;
        private readonly FormularCatalog linkedFC;
        private string filenameBooks, filenameTickets, filenameFormulars;
        public event EventHandler OnChangingBookList;
        public event EventHandler OnChangingTicket;

        public Model(string filenameBooks, string filenameTickets, string filenameFormulars)
        {
            this.filenameBooks = filenameBooks;
            this.filenameTickets = filenameTickets;
            this.filenameFormulars = filenameFormulars;
            linkedBC = new BookCatalog();
            linkedBC.LoadFromFile(filenameBooks);
            linkedTC = new TicketCatalog();
            linkedTC.LoadFromFile(filenameTickets);
            linkedFC = new FormularCatalog();
            buildFormularsFromData();
        }

        private void buildFormularsFromData()
        {
            foreach (Tuple<int, int, DateTime> tup in linkedFC.LoadDataFromFile(filenameFormulars))
            {
                Book b = linkedBC.GetBookByID(tup.Item1);
                if (b == null)
                {
                    throw new WrongIDException("Loading formulars: no such book in catalog", tup.Item1);
                }
                ReadersTicket rt = linkedTC.GetTicketByID(tup.Item2);
                if (rt == null)
                {
                    throw new WrongIDException("Loading formulars: no such ticket in catalog", tup.Item2);
                }
                Formular frm = new Formular(b, rt, tup.Item3);
                b.AddFormular(frm);
                rt.AddFormular(frm);
                linkedFC.AddFormular(frm);
            }
        }

        public List<Book> GetMatchingBooks(string byName, string byAuthor)
        {
            return linkedBC.GetMatchingBooks(byName, byAuthor);
        }

        public void AddBook(string name, string author, int exemplarsAmount = 1)
        {
            name = name.Replace('|', ' ');
            author = author.Replace('|', ' ');
            linkedBC.AddBook(name, author, exemplarsAmount);
            OnChangingBookList?.Invoke(null, null); 
        }

        public ReadersTicket FindMatchingTicket(string fio, int specialtyID)
        {
            return linkedTC.GetTicketByParams(fio, specialtyID);
        }

        public string[] TicketSpecialtyNames
        {
            get
            {
                return TicketCatalog.SpecialtyNames;
            }
        }

        public ReadersTicket AddTicket(string fio, int specialty)
        {
            linkedTC.AddTicket(fio, specialty);
            return linkedTC.GetTicketByParams(fio, specialty);
        }

        public void AddFormular(Book b, ReadersTicket rt)
        {
            if (b.FreeExemplarsCount == 0)
            {
                throw new ReturningException("У этой книги больше нет свободных экземпляров.");
            }
            if (rt.Quote == 0)
            {
                throw new ReturningException("У этого читателя закончилась квота, он не может брать больше книг.");
            }
            Formular frm = new Formular(b, rt, DateTime.Now, rt.GiveDays);
            linkedFC.AddFormular(frm);
            b.AddFormular(frm);
            rt.AddFormular(frm);
            OnChangingBookList?.Invoke(null, null);
            OnChangingTicket?.Invoke(null, null);
        }

        public void ReturnFormular(Formular frm)
        {
            frm.BookLink.RemoveFormular(frm);
            frm.ReaderLink.RemoveFormular(frm);
            linkedFC.RemoveFormular(frm);
            OnChangingBookList?.Invoke(null, null);
            OnChangingTicket?.Invoke(null, null);
        }
        
        public List<ReadersTicket> TicketList
        {
            get
            {
                return linkedTC.GetTicketList;
            }
        }

        public List<Formular> GetOvertimedFormulars(DateTime currentDate)
        {
            return linkedFC.GetOvertimedFormulars(currentDate);
        }

        public void Save()
        {
            linkedBC.SaveToFile(filenameBooks);
            linkedTC.SaveToFile(filenameTickets);
            linkedFC.SaveToFile(filenameFormulars);
        }
    }
}
