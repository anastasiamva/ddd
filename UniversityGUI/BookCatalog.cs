using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityGUI
{
    class BookCatalog
    {
        private static int id = 0;
        private List<Book> bookList;

        public BookCatalog()
        {
            bookList = new List<Book>();
        }

        public void LoadFromFile(string filename)
        {
            try
            {
                using (var fs = File.OpenRead(filename))
                using (var reader = new StreamReader(fs))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] strArray = reader.ReadLine().Split('|');
                        Book b = new Book(Convert.ToInt32(strArray[0]),
                            strArray[1], strArray[2], Convert.ToInt32(strArray[3]));
                        if (b.Id > id)
                        {
                            id = b.Id;
                        }
                        bookList.Add(b);
                    }
                }
            }
            catch (FileNotFoundException)
            {
            }
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, string.Empty);
            using (var fs = File.OpenWrite(filename))
            {
                using (var reader = new StreamWriter(fs))
                {
                    foreach (Book b in bookList)
                    {
                        reader.WriteLine(b.Id + "|" + b.Name + "|" + b.Author + "|" + b.ExemplarCount);
                    }
                }
            }
        }

        public void AddBook(string name, string author, int exemplarsAmount = 1)
        {
            foreach (Book b in bookList)
            {
                if (b.Name == name && b.Author == author)
                {
                    b.ExemplarCount += exemplarsAmount;
                    return;
                }
            }
            Book b2 = new Book(++BookCatalog.id, name, author, exemplarsAmount);
            bookList.Add(b2);
        }

        public Book GetBookByID(int id)
        {
            foreach (Book b in bookList)
            {
                if (b.Id == id)
                {
                    return b;
                }
            }
            return null;
        }

        public List<Book> GetMatchingBooks(string byName, string byAuthor)
        {
            List<Book> temp = new List<Book>();
            foreach (Book b in bookList)
            {
                if ((byName == "" || b.Name.ToLower().StartsWith(byName.ToLower()))
                    && (byAuthor == "" || b.Author.ToLower().StartsWith(byAuthor.ToLower())))
                {
                    temp.Add(b);
                }
            }
            return temp;
        }
    }
}
