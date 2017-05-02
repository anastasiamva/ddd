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
    partial class ExpiredFormularListForm : Form
    {
        private Model linkedModel;
        public ExpiredFormularListForm(Model m)
        {
            InitializeComponent();
            linkedModel = m;
        }

        private void FormularListForm_Load(object sender, EventArgs e)
        {
            reloadViewFormulars(sender, e);
            linkedModel.OnChangingTicket += reloadViewFormulars;
        }

        private void reloadViewFormulars(object sender, EventArgs e)
        {
            listViewExpiredFormulars.Items.Clear();
            int i = 0;
            foreach (Formular frm in linkedModel.GetOvertimedFormulars(DateTime.Now))
            {
                listViewExpiredFormulars.Items.Add(frm.ReaderLink.FIO);
                listViewExpiredFormulars.Items[i].SubItems.Add(linkedModel.TicketSpecialtyNames[frm.ReaderLink.Specialty]);
                listViewExpiredFormulars.Items[i].SubItems.Add(frm.BookLink.Name);
                listViewExpiredFormulars.Items[i].SubItems.Add((DateTime.Now - frm.ReturnDate).Days.ToString());
                i++;
            }
        }
    }
}
