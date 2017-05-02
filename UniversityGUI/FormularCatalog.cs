using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityGUI
{
    class FormularCatalog
    {
        private List<Formular> formularList;

        public FormularCatalog()
        {
            formularList = new List<Formular>();
        }

        public List<Tuple<int, int, DateTime>> LoadDataFromFile(string filename)
        {
            List<Tuple<int, int, DateTime>> temp = new List<Tuple<int, int, DateTime>>();
            try
            {
                using (var fs = File.OpenRead(filename))
                using (var reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] strArray = reader.ReadLine().Split('|');
                        int bookId = Convert.ToInt32(strArray[0]);
                        int ticketId = Convert.ToInt32(strArray[1]);
                        DateTime dt = Convert.ToDateTime(strArray[2]);
                        Tuple<int, int, DateTime> tup = new Tuple<int, int, DateTime>(bookId, ticketId, dt);
                        temp.Add(tup);
                    }
                }
            }
            catch (FileNotFoundException)
            {
            }
            return temp;
        }

        public Formular GetFormularByLinks(Book bookLink, ReadersTicket ticketLink)
        {
            foreach (Formular frm in formularList)
            {
                if (frm.BookLink == bookLink && frm.ReaderLink == ticketLink)
                {
                    return frm;
                }
            }
            return null;
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, string.Empty);
            using (var fs = File.OpenWrite(filename))
            {
                using (var reader = new StreamWriter(fs))
                {
                    foreach (Formular frm in formularList)
                    {
                        reader.WriteLine(frm.BookLink.Id + "|" + frm.ReaderLink.Id + "|" + frm.ReturnDate.ToString());
                    }
                }
            }
        }

        public void AddFormular(Formular frm)
        {
            formularList.Add(frm);
        }

        public void RemoveFormular(Formular frm)
        {
            formularList.Remove(frm);
        }

        public List<Formular> GetOvertimedFormulars(DateTime currentDate)
        {
            List<Formular> temp = new List<Formular>();
            foreach (Formular frm in formularList)
            {
                if (frm.IsExpired(currentDate))
                {
                    temp.Add(frm);
                }
            }
            return temp;
        }
    }
}
