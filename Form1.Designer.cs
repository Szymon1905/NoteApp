namespace NoteApp
{
    partial class NoteApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteApp));
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.AllNotes = new System.Windows.Forms.DataGridView();
            this.LoadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.newNote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(77, 64);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(288, 22);
            this.TitleBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title";
            // 
            // NoteBox
            // 
            this.NoteBox.Location = new System.Drawing.Point(19, 112);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(346, 271);
            this.NoteBox.TabIndex = 3;
            // 
            // AllNotes
            // 
            this.AllNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllNotes.Location = new System.Drawing.Point(424, 44);
            this.AllNotes.Margin = new System.Windows.Forms.Padding(1);
            this.AllNotes.Name = "AllNotes";
            this.AllNotes.RowHeadersWidth = 51;
            this.AllNotes.RowTemplate.Height = 24;
            this.AllNotes.Size = new System.Drawing.Size(351, 338);
            this.AllNotes.TabIndex = 4;
            this.AllNotes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AllNotes_CellDoubleClick);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(424, 401);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(64, 32);
            this.LoadButton.TabIndex = 5;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click_1);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(494, 401);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(64, 32);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(564, 401);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(64, 32);
            this.DeleteButton.TabIndex = 7;
            this.DeleteButton.Text = "delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // newNote
            // 
            this.newNote.Location = new System.Drawing.Point(634, 401);
            this.newNote.Name = "newNote";
            this.newNote.Size = new System.Drawing.Size(64, 32);
            this.newNote.TabIndex = 8;
            this.newNote.Text = "New";
            this.newNote.UseVisualStyleBackColor = true;
            this.newNote.Click += new System.EventHandler(this.newNote_Click);
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newNote);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.AllNotes);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteApp";
            this.Text = "NoteApp 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.DataGridView AllNotes;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button newNote;
    }
}

