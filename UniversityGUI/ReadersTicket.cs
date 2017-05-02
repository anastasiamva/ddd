using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityGUI
{
    class ReadersTicket
    {
        public static int[] DefaultQuote = { 3, 5 }, DefaultGiveDays = { 14, 30 };
        public readonly int Id;
        public readonly int Specialty;
        public readonly string FIO;
        public readonly int GiveDays;
        public int Quote
        {
            get; protected set;
        }
        public List<Formular> FormularsHave
        {
            get; protected set;
        }

        public ReadersTicket(int id, string fio, int specialtyID)
        {
            Id = id;
            FIO = fio;
            Specialty = specialtyID;
            FormularsHave = new List<Formular>();
            Quote = DefaultQuote[specialtyID];
            GiveDays = DefaultGiveDays[specialtyID];
        }

        public void AddFormular(Formular frm)
        {
            FormularsHave.Add(frm);
            Quote--;
        }

        public void RemoveFormular(Formular takenFormular)
        {
            FormularsHave.Remove(takenFormular);
            Quote++;
        }

        public List<Formular> GetOvertimedFormulars(DateTime currentDate)
        {
            List<Formular> temp = new List<Formular>();
            foreach (Formular frm in FormularsHave)
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
