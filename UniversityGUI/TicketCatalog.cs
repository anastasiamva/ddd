using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UniversityGUI
{
    class TicketCatalog
    {
        private List<ReadersTicket> ticketList;
        public static string[] SpecialtyNames = { "студент", "преподаватель" };
        private int maxID = 0;
        
        public TicketCatalog()
        {
            ticketList = new List<ReadersTicket>();
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
                        ReadersTicket rt = new ReadersTicket(Convert.ToInt32(strArray[0]),
                            strArray[1], Convert.ToInt32(strArray[2]));
                        ticketList.Add(rt);
                        if (rt.Id > maxID)
                        {
                            maxID = rt.Id;
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
            }
            maxID++;
        }

        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, string.Empty);
            using (var fs = File.OpenWrite(filename))
            {
                using (var reader = new StreamWriter(fs))
                {
                    foreach (ReadersTicket rt in ticketList)
                    {
                        reader.WriteLine(rt.Id + "|" + rt.FIO + "|" + rt.Specialty);
                    }
                }
            }
        }

        public void AddTicket(string fio, int specialtyID)
        {
            ReadersTicket rt = GetTicketByParams(fio, specialtyID);
            if (rt == null)
            {
                rt = new ReadersTicket(maxID++, fio, specialtyID);
                ticketList.Add(rt);
            }
        }

        public ReadersTicket GetTicketByParams(string fio, int specialtyID)
        {
            List<ReadersTicket> temp = new List<ReadersTicket>();
            foreach (ReadersTicket rt in ticketList)
            {
                if (rt.FIO.ToLower().StartsWith(fio.ToLower()) && rt.Specialty == specialtyID)
                {
                    temp.Add(rt);
                }
            }
            if (temp.Count == 1)
                return temp[0];
            else
                return null;
        }

        public ReadersTicket GetTicketByID(int id)
        {
            foreach (ReadersTicket rt in ticketList)
            {
                if (rt.Id == id)
                {
                    return rt;
                }
            }
            return null;
        }

        public List<ReadersTicket> GetTicketList
        {
            get
            {
                return ticketList;
            }
        }
    }
}
