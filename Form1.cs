using System;
using System.Data;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteApp : Form
    {
        DataTable notes = new DataTable();   
        bool editing = false;
        public NoteApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notes.Columns.Add("Title");
            notes.Columns.Add("Text");
            AllNotes.DataSource = notes;
            AllNotes.Columns[0].Width = 60;
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[AllNotes.CurrentCell.RowIndex].Delete();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void newNote_Click(object sender, EventArgs e)
        {
            TitleBox.Text = "";
            NoteBox.Text = "";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[AllNotes.CurrentCell.RowIndex]["Title"] = TitleBox.Text;
                notes.Rows[AllNotes.CurrentCell.RowIndex]["Text"] = NoteBox.Text;

            }
            else
            {
                notes.Rows.Add(TitleBox.Text, NoteBox.Text);
            }
            TitleBox.Text = "";
            NoteBox.Text = "";
            editing = false;
        }


        private void AllNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TitleBox.Text = notes.Rows[AllNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[AllNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }

        private void LoadButton_Click_1(object sender, EventArgs e)
        {
            TitleBox.Text = notes.Rows[AllNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            NoteBox.Text = notes.Rows[AllNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}
