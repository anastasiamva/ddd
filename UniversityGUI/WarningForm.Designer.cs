namespace UniversityGUI
{
    partial class WarningForm
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
            this.labelDesc = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Location = new System.Drawing.Point(12, 9);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(265, 13);
            this.labelDesc.TabIndex = 0;
            this.labelDesc.Text = "В процессе загрузки модели обнаружены ошибки:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(106, 83);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(12, 33);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 2;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Location = new System.Drawing.Point(68, 55);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(151, 13);
            this.labelClose.TabIndex = 3;
            this.labelClose.Text = "Приложение будет закрыто.";
            // 
            // WarningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 118);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WarningForm";
            this.Text = "Warning";
            this.Load += new System.EventHandler(this.Warning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDesc;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelClose;
    }
}