using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityGUI
{
    partial class TicketListForm : Form
    {
        private Model linkedModel;
        public TicketListForm(Model m)
        {
            InitializeComponent();
            linkedModel = m;
            m.OnChangingTicket += reloadViewTickets;
        }

        private void TicketList_Load(object sender, EventArgs e)
        {
            reloadViewTickets(sender, e);
        }

        private void reloadViewTickets(object sender, EventArgs e)
        {
            listViewAllTickets.Items.Clear();
            int i = 0;
            foreach (ReadersTicket rt in linkedModel.TicketList)
            {
                listViewAllTickets.Items.Add(rt.FIO);
                listViewAllTickets.Items[i].SubItems.Add(linkedModel.TicketSpecialtyNames[rt.Specialty]);
                listViewAllTickets.Items[i].SubItems.Add(rt.FormularsHave.Count.ToString());
                listViewAllTickets.Items[i].SubItems.Add(rt.GetOvertimedFormulars(DateTime.Now).Count.ToString());
                i++;
            }
        }
    }
}
