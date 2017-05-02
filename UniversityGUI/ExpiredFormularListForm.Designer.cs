namespace UniversityGUI
{
    partial class ExpiredFormularListForm
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
            this.listViewExpiredFormulars = new System.Windows.Forms.ListView();
            this.columnTicketFIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTicketSpecialty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBookExpired = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBookExpiredDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewExpiredFormulars
            // 
            this.listViewExpiredFormulars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTicketFIO,
            this.columnTicketSpecialty,
            this.columnBookExpired,
            this.columnBookExpiredDays});
            this.listViewExpiredFormulars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewExpiredFormulars.Location = new System.Drawing.Point(12, 12);
            this.listViewExpiredFormulars.MultiSelect = false;
            this.listViewExpiredFormulars.Name = "listViewExpiredFormulars";
            this.listViewExpiredFormulars.Size = new System.Drawing.Size(360, 412);
            this.listViewExpiredFormulars.TabIndex = 1;
            this.listViewExpiredFormulars.UseCompatibleStateImageBehavior = false;
            this.listViewExpiredFormulars.View = System.Windows.Forms.View.Details;
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
            // columnBookExpired
            // 
            this.columnBookExpired.Text = "Название книги";
            this.columnBookExpired.Width = 98;
            // 
            // columnBookExpiredDays
            // 
            this.columnBookExpiredDays.Text = "Просрочка (дней)";
            this.columnBookExpiredDays.Width = 103;
            // 
            // ExpiredFormularListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 436);
            this.Controls.Add(this.listViewExpiredFormulars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ExpiredFormularListForm";
            this.Text = "Список просроченных формуляров";
            this.Load += new System.EventHandler(this.FormularListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewExpiredFormulars;
        private System.Windows.Forms.ColumnHeader columnTicketFIO;
        private System.Windows.Forms.ColumnHeader columnTicketSpecialty;
        private System.Windows.Forms.ColumnHeader columnBookExpired;
        private System.Windows.Forms.ColumnHeader columnBookExpiredDays;
    }
}