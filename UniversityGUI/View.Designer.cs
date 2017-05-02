namespace UniversityGUI
{
    partial class View
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTickets = new System.Windows.Forms.GroupBox();
            this.buttonOpenFormularList = new System.Windows.Forms.Button();
            this.buttonOpenTicketList = new System.Windows.Forms.Button();
            this.labelTicketSearchNotification = new System.Windows.Forms.Label();
            this.buttonBookMakeFormular = new System.Windows.Forms.Button();
            this.buttonTicketAdd = new System.Windows.Forms.Button();
            this.buttonTicketSearch = new System.Windows.Forms.Button();
            this.comboTicketSearchSpecialty = new System.Windows.Forms.ComboBox();
            this.textTicketSearchName = new System.Windows.Forms.TextBox();
            this.labelTicketSearchSpecialty = new System.Windows.Forms.LinkLabel();
            this.labelTicketSearchFIO = new System.Windows.Forms.LinkLabel();
            this.labelTicketSearch = new System.Windows.Forms.Label();
            this.panelActiveTicket = new System.Windows.Forms.GroupBox();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.listTicketTakenBooks = new System.Windows.Forms.ListView();
            this.columnBookName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBookDaysRemain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTicketSpecialty = new System.Windows.Forms.Label();
            this.labelTicketName = new System.Windows.Forms.Label();
            this.labelTicketSpecialtyDesc = new System.Windows.Forms.LinkLabel();
            this.labelTicketNameDesc = new System.Windows.Forms.LinkLabel();
            this.btnAuth = new System.Windows.Forms.Button();
            this.panelBooks = new System.Windows.Forms.GroupBox();
            this.buttonBookAdd = new System.Windows.Forms.Button();
            this.textBookExemplars = new System.Windows.Forms.MaskedTextBox();
            this.labelBookExemplars = new System.Windows.Forms.LinkLabel();
            this.listBooksName = new System.Windows.Forms.ListView();
            this.columnBooksName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBooksAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBooksAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelBooksAuthor = new System.Windows.Forms.LinkLabel();
            this.labelBooksName = new System.Windows.Forms.LinkLabel();
            this.labelBookSearch = new System.Windows.Forms.Label();
            this.textBooksByAuthor = new System.Windows.Forms.TextBox();
            this.textBooksByName = new System.Windows.Forms.TextBox();
            this.panelTickets.SuspendLayout();
            this.panelActiveTicket.SuspendLayout();
            this.panelBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTickets
            // 
            this.panelTickets.Controls.Add(this.buttonOpenFormularList);
            this.panelTickets.Controls.Add(this.buttonOpenTicketList);
            this.panelTickets.Controls.Add(this.labelTicketSearchNotification);
            this.panelTickets.Controls.Add(this.buttonBookMakeFormular);
            this.panelTickets.Controls.Add(this.buttonTicketAdd);
            this.panelTickets.Controls.Add(this.buttonTicketSearch);
            this.panelTickets.Controls.Add(this.comboTicketSearchSpecialty);
            this.panelTickets.Controls.Add(this.textTicketSearchName);
            this.panelTickets.Controls.Add(this.labelTicketSearchSpecialty);
            this.panelTickets.Controls.Add(this.labelTicketSearchFIO);
            this.panelTickets.Controls.Add(this.labelTicketSearch);
            this.panelTickets.Controls.Add(this.panelActiveTicket);
            this.panelTickets.Location = new System.Drawing.Point(406, 12);
            this.panelTickets.Name = "panelTickets";
            this.panelTickets.Size = new System.Drawing.Size(388, 423);
            this.panelTickets.TabIndex = 1;
            this.panelTickets.TabStop = false;
            this.panelTickets.Text = "Панель читательских билетов";
            this.panelTickets.Visible = false;
            // 
            // buttonOpenFormularList
            // 
            this.buttonOpenFormularList.Location = new System.Drawing.Point(172, 354);
            this.buttonOpenFormularList.Name = "buttonOpenFormularList";
            this.buttonOpenFormularList.Size = new System.Drawing.Size(184, 23);
            this.buttonOpenFormularList.TabIndex = 10;
            this.buttonOpenFormularList.Text = "Просроченные формуляры";
            this.buttonOpenFormularList.UseVisualStyleBackColor = true;
            this.buttonOpenFormularList.Click += new System.EventHandler(this.buttonOpenFormularList_Click);
            // 
            // buttonOpenTicketList
            // 
            this.buttonOpenTicketList.Location = new System.Drawing.Point(35, 354);
            this.buttonOpenTicketList.Name = "buttonOpenTicketList";
            this.buttonOpenTicketList.Size = new System.Drawing.Size(131, 23);
            this.buttonOpenTicketList.TabIndex = 9;
            this.buttonOpenTicketList.Text = "Список билетов";
            this.buttonOpenTicketList.UseVisualStyleBackColor = true;
            this.buttonOpenTicketList.Click += new System.EventHandler(this.buttonOpenTicketList_Click);
            // 
            // labelTicketSearchNotification
            // 
            this.labelTicketSearchNotification.AutoSize = true;
            this.labelTicketSearchNotification.ForeColor = System.Drawing.Color.Red;
            this.labelTicketSearchNotification.Location = new System.Drawing.Point(14, 331);
            this.labelTicketSearchNotification.Name = "labelTicketSearchNotification";
            this.labelTicketSearchNotification.Size = new System.Drawing.Size(0, 13);
            this.labelTicketSearchNotification.TabIndex = 8;
            // 
            // buttonBookMakeFormular
            // 
            this.buttonBookMakeFormular.Location = new System.Drawing.Point(35, 383);
            this.buttonBookMakeFormular.Name = "buttonBookMakeFormular";
            this.buttonBookMakeFormular.Size = new System.Drawing.Size(321, 34);
            this.buttonBookMakeFormular.TabIndex = 6;
            this.buttonBookMakeFormular.Text = "Выдать выделенную книгу читателю под активным билетом";
            this.buttonBookMakeFormular.UseVisualStyleBackColor = true;
            this.buttonBookMakeFormular.Click += new System.EventHandler(this.buttonBookMakeFormular_Click);
            // 
            // buttonTicketAdd
            // 
            this.buttonTicketAdd.Location = new System.Drawing.Point(218, 298);
            this.buttonTicketAdd.Name = "buttonTicketAdd";
            this.buttonTicketAdd.Size = new System.Drawing.Size(158, 27);
            this.buttonTicketAdd.TabIndex = 7;
            this.buttonTicketAdd.Text = "Добавить билет в базу";
            this.buttonTicketAdd.UseVisualStyleBackColor = true;
            this.buttonTicketAdd.Click += new System.EventHandler(this.buttonTicketAdd_Click);
            // 
            // buttonTicketSearch
            // 
            this.buttonTicketSearch.Location = new System.Drawing.Point(65, 298);
            this.buttonTicketSearch.Name = "buttonTicketSearch";
            this.buttonTicketSearch.Size = new System.Drawing.Size(147, 27);
            this.buttonTicketSearch.TabIndex = 6;
            this.buttonTicketSearch.Text = "Найти билет в базе";
            this.buttonTicketSearch.UseVisualStyleBackColor = true;
            this.buttonTicketSearch.Click += new System.EventHandler(this.buttonTicketSearch_Click);
            // 
            // comboTicketSearchSpecialty
            // 
            this.comboTicketSearchSpecialty.FormattingEnabled = true;
            this.comboTicketSearchSpecialty.Location = new System.Drawing.Point(255, 272);
            this.comboTicketSearchSpecialty.Name = "comboTicketSearchSpecialty";
            this.comboTicketSearchSpecialty.Size = new System.Drawing.Size(121, 21);
            this.comboTicketSearchSpecialty.TabIndex = 5;
            // 
            // textTicketSearchName
            // 
            this.textTicketSearchName.Location = new System.Drawing.Point(65, 272);
            this.textTicketSearchName.Name = "textTicketSearchName";
            this.textTicketSearchName.Size = new System.Drawing.Size(184, 20);
            this.textTicketSearchName.TabIndex = 4;
            // 
            // labelTicketSearchSpecialty
            // 
            this.labelTicketSearchSpecialty.AutoSize = true;
            this.labelTicketSearchSpecialty.LinkColor = System.Drawing.Color.Black;
            this.labelTicketSearchSpecialty.Location = new System.Drawing.Point(252, 248);
            this.labelTicketSearchSpecialty.Name = "labelTicketSearchSpecialty";
            this.labelTicketSearchSpecialty.Size = new System.Drawing.Size(62, 13);
            this.labelTicketSearchSpecialty.TabIndex = 3;
            this.labelTicketSearchSpecialty.TabStop = true;
            this.labelTicketSearchSpecialty.Text = "должность";
            // 
            // labelTicketSearchFIO
            // 
            this.labelTicketSearchFIO.AutoSize = true;
            this.labelTicketSearchFIO.LinkColor = System.Drawing.Color.Black;
            this.labelTicketSearchFIO.Location = new System.Drawing.Point(62, 248);
            this.labelTicketSearchFIO.Name = "labelTicketSearchFIO";
            this.labelTicketSearchFIO.Size = new System.Drawing.Size(49, 13);
            this.labelTicketSearchFIO.TabIndex = 2;
            this.labelTicketSearchFIO.TabStop = true;
            this.labelTicketSearchFIO.Text = "по ФИО";
            // 
            // labelTicketSearch
            // 
            this.labelTicketSearch.AutoSize = true;
            this.labelTicketSearch.Location = new System.Drawing.Point(14, 248);
            this.labelTicketSearch.Name = "labelTicketSearch";
            this.labelTicketSearch.Size = new System.Drawing.Size(42, 13);
            this.labelTicketSearch.TabIndex = 1;
            this.labelTicketSearch.Text = "Поиск:";
            // 
            // panelActiveTicket
            // 
            this.panelActiveTicket.Controls.Add(this.buttonReturnBook);
            this.panelActiveTicket.Controls.Add(this.listTicketTakenBooks);
            this.panelActiveTicket.Controls.Add(this.labelTicketSpecialty);
            this.panelActiveTicket.Controls.Add(this.labelTicketName);
            this.panelActiveTicket.Controls.Add(this.labelTicketSpecialtyDesc);
            this.panelActiveTicket.Controls.Add(this.labelTicketNameDesc);
            this.panelActiveTicket.Location = new System.Drawing.Point(7, 35);
            this.panelActiveTicket.Name = "panelActiveTicket";
            this.panelActiveTicket.Size = new System.Drawing.Size(375, 201);
            this.panelActiveTicket.TabIndex = 0;
            this.panelActiveTicket.TabStop = false;
            this.panelActiveTicket.Text = "Выбранный билет";
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(221, 19);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(148, 32);
            this.buttonReturnBook.TabIndex = 5;
            this.buttonReturnBook.Text = "Отметить возврат книги";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // listTicketTakenBooks
            // 
            this.listTicketTakenBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBookName,
            this.columnBookDaysRemain});
            this.listTicketTakenBooks.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listTicketTakenBooks.Location = new System.Drawing.Point(10, 65);
            this.listTicketTakenBooks.MultiSelect = false;
            this.listTicketTakenBooks.Name = "listTicketTakenBooks";
            this.listTicketTakenBooks.Size = new System.Drawing.Size(359, 130);
            this.listTicketTakenBooks.TabIndex = 4;
            this.listTicketTakenBooks.UseCompatibleStateImageBehavior = false;
            this.listTicketTakenBooks.View = System.Windows.Forms.View.Details;
            this.listTicketTakenBooks.SelectedIndexChanged += new System.EventHandler(this.listTicketTakenBooks_SelectedIndexChanged);
            // 
            // columnBookName
            // 
            this.columnBookName.Text = "Название книги";
            this.columnBookName.Width = 240;
            // 
            // columnBookDaysRemain
            // 
            this.columnBookDaysRemain.Text = "Осталось дней";
            this.columnBookDaysRemain.Width = 111;
            // 
            // labelTicketSpecialty
            // 
            this.labelTicketSpecialty.AutoSize = true;
            this.labelTicketSpecialty.Location = new System.Drawing.Point(80, 39);
            this.labelTicketSpecialty.Name = "labelTicketSpecialty";
            this.labelTicketSpecialty.Size = new System.Drawing.Size(41, 13);
            this.labelTicketSpecialty.TabIndex = 3;
            this.labelTicketSpecialty.Text = "(пусто)";
            // 
            // labelTicketName
            // 
            this.labelTicketName.AutoSize = true;
            this.labelTicketName.Location = new System.Drawing.Point(80, 20);
            this.labelTicketName.Name = "labelTicketName";
            this.labelTicketName.Size = new System.Drawing.Size(41, 13);
            this.labelTicketName.TabIndex = 2;
            this.labelTicketName.Text = "(пусто)";
            // 
            // labelTicketSpecialtyDesc
            // 
            this.labelTicketSpecialtyDesc.AutoSize = true;
            this.labelTicketSpecialtyDesc.LinkColor = System.Drawing.Color.Black;
            this.labelTicketSpecialtyDesc.Location = new System.Drawing.Point(7, 39);
            this.labelTicketSpecialtyDesc.Name = "labelTicketSpecialtyDesc";
            this.labelTicketSpecialtyDesc.Size = new System.Drawing.Size(68, 13);
            this.labelTicketSpecialtyDesc.TabIndex = 1;
            this.labelTicketSpecialtyDesc.TabStop = true;
            this.labelTicketSpecialtyDesc.Text = "Должность:";
            // 
            // labelTicketNameDesc
            // 
            this.labelTicketNameDesc.AutoSize = true;
            this.labelTicketNameDesc.LinkColor = System.Drawing.Color.Black;
            this.labelTicketNameDesc.Location = new System.Drawing.Point(7, 20);
            this.labelTicketNameDesc.Name = "labelTicketNameDesc";
            this.labelTicketNameDesc.Size = new System.Drawing.Size(32, 13);
            this.labelTicketNameDesc.TabIndex = 0;
            this.labelTicketNameDesc.TabStop = true;
            this.labelTicketNameDesc.Text = "Имя:";
            // 
            // btnAuth
            // 
            this.btnAuth.Location = new System.Drawing.Point(12, 12);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(227, 29);
            this.btnAuth.TabIndex = 3;
            this.btnAuth.Text = "Использовать версию для библиотекаря";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // panelBooks
            // 
            this.panelBooks.Controls.Add(this.buttonBookAdd);
            this.panelBooks.Controls.Add(this.textBookExemplars);
            this.panelBooks.Controls.Add(this.labelBookExemplars);
            this.panelBooks.Controls.Add(this.listBooksName);
            this.panelBooks.Controls.Add(this.labelBooksAuthor);
            this.panelBooks.Controls.Add(this.labelBooksName);
            this.panelBooks.Controls.Add(this.labelBookSearch);
            this.panelBooks.Controls.Add(this.textBooksByAuthor);
            this.panelBooks.Controls.Add(this.textBooksByName);
            this.panelBooks.Location = new System.Drawing.Point(12, 47);
            this.panelBooks.Name = "panelBooks";
            this.panelBooks.Size = new System.Drawing.Size(388, 388);
            this.panelBooks.TabIndex = 2;
            this.panelBooks.TabStop = false;
            this.panelBooks.Text = "Панель книг";
            // 
            // buttonBookAdd
            // 
            this.buttonBookAdd.Location = new System.Drawing.Point(243, 65);
            this.buttonBookAdd.Name = "buttonBookAdd";
            this.buttonBookAdd.Size = new System.Drawing.Size(139, 23);
            this.buttonBookAdd.TabIndex = 7;
            this.buttonBookAdd.Text = "Добавить книгу в базу";
            this.buttonBookAdd.UseVisualStyleBackColor = true;
            this.buttonBookAdd.Visible = false;
            this.buttonBookAdd.Click += new System.EventHandler(this.buttonBookAdd_Click);
            // 
            // textBookExemplars
            // 
            this.textBookExemplars.Location = new System.Drawing.Point(208, 67);
            this.textBookExemplars.Mask = "00";
            this.textBookExemplars.Name = "textBookExemplars";
            this.textBookExemplars.Size = new System.Drawing.Size(19, 20);
            this.textBookExemplars.TabIndex = 8;
            this.textBookExemplars.Visible = false;
            // 
            // labelBookExemplars
            // 
            this.labelBookExemplars.AutoSize = true;
            this.labelBookExemplars.LinkColor = System.Drawing.Color.Black;
            this.labelBookExemplars.Location = new System.Drawing.Point(67, 70);
            this.labelBookExemplars.Name = "labelBookExemplars";
            this.labelBookExemplars.Size = new System.Drawing.Size(139, 13);
            this.labelBookExemplars.TabIndex = 9;
            this.labelBookExemplars.TabStop = true;
            this.labelBookExemplars.Text = "количество экземпляров:";
            this.labelBookExemplars.Visible = false;
            // 
            // listBooksName
            // 
            this.listBooksName.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnBooksName,
            this.columnBooksAuthor,
            this.columnBooksAmount});
            this.listBooksName.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listBooksName.HideSelection = false;
            this.listBooksName.Location = new System.Drawing.Point(6, 65);
            this.listBooksName.MultiSelect = false;
            this.listBooksName.Name = "listBooksName";
            this.listBooksName.Size = new System.Drawing.Size(376, 317);
            this.listBooksName.TabIndex = 2;
            this.listBooksName.UseCompatibleStateImageBehavior = false;
            this.listBooksName.View = System.Windows.Forms.View.Details;
            this.listBooksName.SelectedIndexChanged += new System.EventHandler(this.listBooksName_SelectedIndexChanged);
            // 
            // columnBooksName
            // 
            this.columnBooksName.Text = "Название";
            this.columnBooksName.Width = 194;
            // 
            // columnBooksAuthor
            // 
            this.columnBooksAuthor.Text = "Автор";
            this.columnBooksAuthor.Width = 112;
            // 
            // columnBooksAmount
            // 
            this.columnBooksAmount.Text = "В наличии";
            this.columnBooksAmount.Width = 63;
            // 
            // labelBooksAuthor
            // 
            this.labelBooksAuthor.AutoSize = true;
            this.labelBooksAuthor.LinkColor = System.Drawing.Color.Black;
            this.labelBooksAuthor.Location = new System.Drawing.Point(224, 19);
            this.labelBooksAuthor.Name = "labelBooksAuthor";
            this.labelBooksAuthor.Size = new System.Drawing.Size(56, 13);
            this.labelBooksAuthor.TabIndex = 5;
            this.labelBooksAuthor.TabStop = true;
            this.labelBooksAuthor.Text = "по автору";
            // 
            // labelBooksName
            // 
            this.labelBooksName.AutoSize = true;
            this.labelBooksName.LinkColor = System.Drawing.Color.Black;
            this.labelBooksName.Location = new System.Drawing.Point(67, 19);
            this.labelBooksName.Name = "labelBooksName";
            this.labelBooksName.Size = new System.Drawing.Size(72, 13);
            this.labelBooksName.TabIndex = 4;
            this.labelBooksName.TabStop = true;
            this.labelBooksName.Text = "по названию";
            // 
            // labelBookSearch
            // 
            this.labelBookSearch.AutoSize = true;
            this.labelBookSearch.Location = new System.Drawing.Point(19, 19);
            this.labelBookSearch.Name = "labelBookSearch";
            this.labelBookSearch.Size = new System.Drawing.Size(42, 13);
            this.labelBookSearch.TabIndex = 3;
            this.labelBookSearch.Text = "Поиск:";
            // 
            // textBooksByAuthor
            // 
            this.textBooksByAuthor.Location = new System.Drawing.Point(227, 39);
            this.textBooksByAuthor.Name = "textBooksByAuthor";
            this.textBooksByAuthor.Size = new System.Drawing.Size(155, 20);
            this.textBooksByAuthor.TabIndex = 2;
            // 
            // textBooksByName
            // 
            this.textBooksByName.Location = new System.Drawing.Point(70, 39);
            this.textBooksByName.Name = "textBooksByName";
            this.textBooksByName.Size = new System.Drawing.Size(151, 20);
            this.textBooksByName.TabIndex = 1;
            // 
            // View
            // 
            this.ClientSize = new System.Drawing.Size(410, 447);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.panelBooks);
            this.Controls.Add(this.panelTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "View";
            this.Text = "Библиотека (просмотр)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.View_FormClosing);
            this.Load += new System.EventHandler(this.View_Load);
            this.panelTickets.ResumeLayout(false);
            this.panelTickets.PerformLayout();
            this.panelActiveTicket.ResumeLayout(false);
            this.panelActiveTicket.PerformLayout();
            this.panelBooks.ResumeLayout(false);
            this.panelBooks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox panelTickets;
        private System.Windows.Forms.GroupBox panelBooks;
        private System.Windows.Forms.Button btnAuth;
        private System.Windows.Forms.LinkLabel labelBooksAuthor;
        private System.Windows.Forms.LinkLabel labelBooksName;
        private System.Windows.Forms.Label labelBookSearch;
        private System.Windows.Forms.TextBox textBooksByAuthor;
        private System.Windows.Forms.TextBox textBooksByName;
        private System.Windows.Forms.ListView listBooksName;
        private System.Windows.Forms.ColumnHeader columnBooksName;
        private System.Windows.Forms.ColumnHeader columnBooksAuthor;
        private System.Windows.Forms.ColumnHeader columnBooksAmount;
        private System.Windows.Forms.Button buttonTicketAdd;
        private System.Windows.Forms.Button buttonTicketSearch;
        private System.Windows.Forms.ComboBox comboTicketSearchSpecialty;
        private System.Windows.Forms.TextBox textTicketSearchName;
        private System.Windows.Forms.LinkLabel labelTicketSearchSpecialty;
        private System.Windows.Forms.LinkLabel labelTicketSearchFIO;
        private System.Windows.Forms.Label labelTicketSearch;
        private System.Windows.Forms.GroupBox panelActiveTicket;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.ListView listTicketTakenBooks;
        private System.Windows.Forms.ColumnHeader columnBookName;
        private System.Windows.Forms.ColumnHeader columnBookDaysRemain;
        private System.Windows.Forms.Label labelTicketSpecialty;
        private System.Windows.Forms.Label labelTicketName;
        private System.Windows.Forms.LinkLabel labelTicketSpecialtyDesc;
        private System.Windows.Forms.LinkLabel labelTicketNameDesc;
        private System.Windows.Forms.Button buttonBookMakeFormular;
        private System.Windows.Forms.Label labelTicketSearchNotification;
        private System.Windows.Forms.Button buttonBookAdd;
        private System.Windows.Forms.MaskedTextBox textBookExemplars;
        private System.Windows.Forms.LinkLabel labelBookExemplars;
        private System.Windows.Forms.Button buttonOpenFormularList;
        private System.Windows.Forms.Button buttonOpenTicketList;
    }
}