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
    partial class View : Form
    {
        private Model linkedModel;
        private ReadersTicket selectedTicket;
        private ListViewItem selectedBookItem;
        private int selectedFormularItemIndex;
        public event EventHandler OnChangingSelectedTicket;
        private TicketListForm myTicketListForm;
        private ExpiredFormularListForm myExpiredFormularListForm;

        public View(Model model)
        {
            InitializeComponent();
            linkedModel = model;

            model.OnChangingBookList += reloadViewBooks;
            textBooksByName.TextChanged += reloadViewBooks;
            textBooksByAuthor.TextChanged += reloadViewBooks;
            OnChangingSelectedTicket += reloadViewTickets;
            model.OnChangingTicket += reloadViewTickets;
        }

        //===============
        //VIEW PART
        //===============

        private void View_Load(object sender, EventArgs e)
        {
            reloadViewBooks(sender, e);
            foreach (string specialtyName in linkedModel.TicketSpecialtyNames)
            {
                comboTicketSearchSpecialty.Items.Add(specialtyName);
                if (comboTicketSearchSpecialty.Text == "")
                {
                    comboTicketSearchSpecialty.Text = specialtyName;
                    comboTicketSearchSpecialty.SelectedIndex = 0;
                }
            }
        }

        private void reloadViewBooks(object sender, EventArgs e)
        {
            listBooksName.Items.Clear();
            string bname = textBooksByName.Text.Replace('|', ' ');
            string bauthor = textBooksByAuthor.Text.Replace('|', ' ');
            foreach (Book b in linkedModel.GetMatchingBooks(bname, bauthor))
            {
                ListViewItem lvi = new ListViewItem(b.Name);
                lvi.SubItems.Add(b.Author);
                lvi.SubItems.Add(Convert.ToString(b.FreeExemplarsCount) + "/" + Convert.ToString(b.ExemplarCount));
                listBooksName.Items.Add(lvi);
            }
        }

        private void View_FormClosing(object sender, FormClosingEventArgs e)
        {
            linkedModel.Save();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            btnAuth.Visible = false;
            panelBooks.Location = new Point(panelBooks.Location.X, 12);
            panelBooks.Size = new Size(panelBooks.Size.Width, 423);
            listBooksName.Location = new Point(listBooksName.Location.X, 100);
            buttonBookAdd.Visible = true;
            labelBookExemplars.Visible = true;
            textBookExemplars.Visible = true;
            this.Size = new Size(822, this.Size.Height);
            panelTickets.Visible = true;
            this.Name = "Библиотека (редактирование)";
        }

        private void reloadViewTickets(object sender, EventArgs e)
        {
            labelTicketName.Text = selectedTicket.FIO;
            labelTicketSpecialty.Text = linkedModel.TicketSpecialtyNames[selectedTicket.Specialty];
            selectedFormularItemIndex = -1;
            listTicketTakenBooks.Items.Clear();
            int i = 0;
            foreach (Formular frm in selectedTicket.FormularsHave)
            {
                listTicketTakenBooks.Items.Add(frm.BookLink.Name);
                if (frm.IsExpired(DateTime.Now))
                {
                    listTicketTakenBooks.Items[i].SubItems.Add("ПРОСРОЧКА");
                }
                else
                {
                    int restDays = (frm.ReturnDate - DateTime.Now).Days;
                    listTicketTakenBooks.Items[i].SubItems.Add("" + restDays);
                }
                i++;
            }
        }

        private void notify(string s)
        {
            labelTicketSearchNotification.Text = s;
        }

        private void listBooksName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                selectedBookItem = ((ListView)sender).SelectedItems[0];
            }
            else
            {
                selectedBookItem = null;
            }
        }

        private void listTicketTakenBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ListView)sender).SelectedItems.Count > 0)
            {
                selectedFormularItemIndex = ((ListView)sender).SelectedItems[0].Index;
                //notify(selectedTicket.FormularsHave[selectedFormularItemIndex].ReturnDate.ToString());
            }
            else
            {
                selectedFormularItemIndex = -1;
            }
        }

        private void refreshFormVars(object sender, EventArgs e)
        {
            if ((Form)sender == myTicketListForm)
            {
                myTicketListForm = null;
            }
            else if ((Form)sender == myExpiredFormularListForm)
            {
                myExpiredFormularListForm = null;
            }
        }

        private void buttonOpenTicketList_Click(object sender, EventArgs e)
        {
            if (myTicketListForm == null)
            {
                myTicketListForm = new TicketListForm(linkedModel);
                myTicketListForm.Show();
                myTicketListForm.FormClosing += refreshFormVars;
            }
            else
            {
                myTicketListForm.BringToFront();
            }
        }

        private void buttonOpenFormularList_Click(object sender, EventArgs e)
        {
            if (myExpiredFormularListForm == null)
            {
                myExpiredFormularListForm = new ExpiredFormularListForm(linkedModel);
                myExpiredFormularListForm.Show();
                myExpiredFormularListForm.FormClosing += refreshFormVars;
            }
            else
            {
                myExpiredFormularListForm.BringToFront();
            }
        }

        //==========================
        //CONTROLLER PART
        //==========================

        private void buttonBookAdd_Click(object sender, EventArgs e)
        {
            if (textBookExemplars.Text == "")
            {
                textBookExemplars.Text = "01";
            }
            if (selectedBookItem == null)
            {
                linkedModel.AddBook(textBooksByName.Text, textBooksByAuthor.Text,
                    Convert.ToInt32(textBookExemplars.Text));
            }
            else
            {
                linkedModel.AddBook(selectedBookItem.Text, selectedBookItem.SubItems[1].Text,
                    Convert.ToInt32(textBookExemplars.Text));
            }
        }

        private void buttonTicketSearch_Click(object sender, EventArgs e)
        {
            string fio = textTicketSearchName.Text;
            int spec = comboTicketSearchSpecialty.SelectedIndex;
            ReadersTicket rt = linkedModel.FindMatchingTicket(fio, spec);
            if (rt == null)
            {
                notify("Не найдено ни одного билета с указанными параметрами");
            }
            else
            {
                notify("Билет найден.");
                selectedTicket = rt;
                OnChangingSelectedTicket?.Invoke(this, null);
            }
        }

        private void buttonTicketAdd_Click(object sender, EventArgs e)
        {
            string fio = textTicketSearchName.Text;
            int spec = comboTicketSearchSpecialty.SelectedIndex;
            ReadersTicket rt = linkedModel.FindMatchingTicket(fio, spec);
            if (rt != null)
            {
                notify("Билет с указанными параметрами уже находится в базе.");
            }
            else
            {
                notify("Билет добавлен в базу и выбран в панели.");
                selectedTicket = linkedModel.AddTicket(fio, spec);
                OnChangingSelectedTicket?.Invoke(this, null);
            }
        }

        private void buttonBookMakeFormular_Click(object sender, EventArgs e)
        {
            if (selectedBookItem == null || selectedTicket == null)
            {
                notify("Чтобы оформить формуляр, выберите книгу и читательский билет.");
                return;
            }
            string bookName = selectedBookItem.Text;
            string bookAuthor = selectedBookItem.SubItems[1].Text;
            Book selectedBook = linkedModel.GetMatchingBooks(bookName, bookAuthor)[0];
            try
            {
                linkedModel.AddFormular(selectedBook, selectedTicket);
                notify("Книга выдана читателю.");
            }
            catch (ReturningException exc)
            {
                notify(exc.Message);
            }
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            if (selectedFormularItemIndex < 0)
            {
                notify("Чтобы отметить возврат книги, вам необходимо выбрать книгу.");
                return;
            }
            Formular frm = selectedTicket.FormularsHave[selectedFormularItemIndex];
            linkedModel.ReturnFormular(frm);
            notify("Книга возвращена в библиотеку.");
        }
    }
}