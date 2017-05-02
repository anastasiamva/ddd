namespace UniversityGUI
{
    partial class TicketListForm
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
            this.listViewAllTickets = new System.Windows.Forms.ListView();
            this.columnTicketFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTicketSpecialty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTicketBooksTaken = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTicketBooksExpired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewAllTickets
            // 
            this.listViewAllTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTicketFIO,
            this.columnTicketSpecialty,
            this.columnTicketBooksTaken,
            this.columnTicketBooksExpired});
            this.listViewAllTickets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAllTickets.Location = new System.Drawing.Point(12, 12);
            this.listViewAllTickets.MultiSelect = false;
            this.listViewAllTickets.Name = "listViewAllTickets";
            this.listViewAllTickets.Size = new System.Drawing.Size(318, 314);
            this.listViewAllTickets.TabIndex = 0;
            this.listViewAllTickets.UseCompatibleStateImageBehavior = false;
            this.listViewAllTickets.View = System.Windows.Forms.View.Details;
            // 
            // columnTicketFIO
            // 
            this.columnTicketFIO.Text = "ФИО";
            this.columnTicketFIO.Width = 91;
            // 
            // columnTicketSpecialty
            // 
            this.columnTicketSpecialty.Text = "Должность";
            this.columnTicketSpecialty.Width = 73;
            // 
            // columnTicketBooksTaken
            // 
            this.columnTicketBooksTaken.Text = "Книг взято";
            this.columnTicketBooksTaken.Width = 75;
            // 
            // columnTicketBooksExpired
            // 
            this.columnTicketBooksExpired.Text = "Просрочено";
            this.columnTicketBooksExpired.Width = 75;
            // 
            // TicketListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 338);
            this.Controls.Add(this.listViewAllTickets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TicketListForm";
            this.Text = "Список билетов";
            this.Load += new System.EventHandler(this.TicketList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllTickets;
        private System.Windows.Forms.ColumnHeader columnTicketFIO;
        private System.Windows.Forms.ColumnHeader columnTicketSpecialty;
        private System.Windows.Forms.ColumnHeader columnTicketBooksTaken;
        private System.Windows.Forms.ColumnHeader columnTicketBooksExpired;
    }
}