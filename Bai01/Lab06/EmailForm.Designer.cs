namespace Lab06
{
    partial class EmailForm
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
            listViewEmails = new ListView();
            NumberColumn = new ColumnHeader();
            From = new ColumnHeader();
            Subject = new ColumnHeader();
            Datetime = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewEmails
            // 
            listViewEmails.Columns.AddRange(new ColumnHeader[] { NumberColumn, From, Subject, Datetime });
            listViewEmails.Location = new Point(12, 12);
            listViewEmails.Name = "listViewEmails";
            listViewEmails.Size = new Size(718, 429);
            listViewEmails.TabIndex = 0;
            listViewEmails.UseCompatibleStateImageBehavior = false;
            listViewEmails.View = View.Details;
            // 
            // NumberColumn
            // 
            NumberColumn.Tag = "#";
            NumberColumn.Text = "#";
            // 
            // From
            // 
            From.Text = "From";
            From.Width = 200;
            // 
            // Subject
            // 
            Subject.Text = "Subject";
            Subject.Width = 200;
            // 
            // Datetime
            // 
            Datetime.Text = "Datetime";
            Datetime.Width = 251;
            // 
            // EmailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Lab3_NT132;
            ClientSize = new Size(734, 448);
            Controls.Add(listViewEmails);
            Name = "EmailForm";
            Text = "EmailForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewEmails;
        private ColumnHeader NumberColumn;
        private ColumnHeader From;
        private ColumnHeader Subject;
        private ColumnHeader Datetime;
    }
}