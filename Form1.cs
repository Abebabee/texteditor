using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab3
{
    
    public partial class NoteForm : Form
    {
        protected string textContent = ""; //Sträng som håller texten i textboxen..
        protected string fileName = "namnlös.txt";
        /*
         *|||||||ATT GÖRA|||||||||||
         1. "spara", ska bara spara filen om den redan existerar.
         2. "öppna" ska visa diag där man kan välja vilken fil man ska öppna.
         3. Om texten man skrivit inte är sparad och man försöker öppna/skapa en ny fil,
            ska man få en dialogruta med ja nej eller avbryt
            Är texten oförändrad ska ingen diag komma upp


         
         */
        public NoteForm()
        {
            InitializeComponent();
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Console.WriteLine(fileName);
            File.WriteAllText(fileName, TextBox.Text);
            MessageBox.Show("Wrote to file..");
            NoteForm.ActiveForm.Text = $"{fileName}";
        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            Console.WriteLine(fileName);
            
            if (NoteForm.ActiveForm.Text.Contains("*"))
            {
                unsavedChanges();

            }
            Stream myStream;
            SaveFileDialog fileDiag = new SaveFileDialog();
            fileDiag.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDiag.FilterIndex = 2;
            fileDiag.RestoreDirectory = true;
            if (fileDiag.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = fileDiag.OpenFile()) != null)
                {
                    myStream.Close();
                    File.WriteAllText(fileDiag.FileName, TextBox.Text);
                    MessageBox.Show("Wrote to file..");
                }
            }
        }
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openDiag = new OpenFileDialog();
                openDiag.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openDiag.FilterIndex = 2;
                openDiag.RestoreDirectory = true;
                if (openDiag.ShowDialog() == DialogResult.OK)
                {
                    string file = openDiag.FileName;
                    var fileStream = openDiag.OpenFile();
                    StreamReader readStream = new StreamReader(fileStream); //Initializes an instance of StreamReader
                    TextBox.Text = $"{readStream.ReadToEnd()}"; //Prints the files text content onto the textbox
                    fileName = Path.GetFileName(file); //Using the "Path" class to access the name of the file w/o path
                    NoteForm.ActiveForm.Text = $"{fileName}"; //Changes the title of the form to the name of the selected file
                    textContent = TextBox.Text;
                    readStream.Close();
                }
            }catch(Exception err)
            {
                MessageBox.Show($"{err.Message}");
            }
        }
        private void textChanged(object sender, EventArgs e)
        {
            if (textContent != TextBox.Text)
            {
                Console.WriteLine(NoteForm.ActiveForm.Text);
                if (!NoteForm.ActiveForm.Text.Contains("*"))
                {
                    NoteForm.ActiveForm.Text = $"{fileName}*";
                }
            }
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("hej");
            string textMsg = $"Spara ändringar för {fileName}?";
            var checkResult = MessageBox.Show(textMsg, "Osparad fil", MessageBoxButtons.YesNoCancel);
            if (checkResult == DialogResult.Yes)
            {
                //Spara i aktuell fil..
            }
            if (checkResult == DialogResult.Cancel)
            {
                //Stäng ner messagebox
            }
            if (checkResult == DialogResult.No)
            {
                //Då ska man kunna spara som..????
            }
        }
    }
}
