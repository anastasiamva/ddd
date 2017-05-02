using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class Formular
    {
        public readonly Book BookLink;
        public readonly ReadersTicket ReaderLink;
        public DateTime ReturnDate
        {
            get; protected set;
        }

        public Formular(Book bookLink, ReadersTicket readerLink, DateTime currentDate, int returnDays)
        {
            BookLink = bookLink;
            ReaderLink = readerLink;
            ReturnDate = currentDate.AddDays(returnDays);
        }

        public Formular(Book bookLink, ReadersTicket readerLink, DateTime returnDate)
        {
            BookLink = bookLink;
            ReaderLink = readerLink;
            ReturnDate = returnDate;
        }

        public bool IsExpired(DateTime currentDate)
        {
            return !(currentDate <= ReturnDate);
        }
    }
}
