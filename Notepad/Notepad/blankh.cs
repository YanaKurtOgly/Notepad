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

namespace Notepad
{
    public partial class blankh : Form
    {
        public string DocName; //имя документа
        private String BufferText; //хранение буферизованного фрагмента текста
        public bool IsSaved = false; //переменная, которая будет фиксировать сохранение документа

        public blankh()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //методы стандартных действий над текстом
        public void Cut() //вырезание текста
        {
            this.BufferText = richTextBox1.SelectedText;
            richTextBox1.SelectedText = "";
        }
        public void Copy() //копирование текста
        {
            this.BufferText = richTextBox1.SelectedText;
        }
        public void Paste() //вставка текста
        {
            richTextBox1.SelectedText = this.BufferText;
        }
        public void SelectAll() //выделение всего текста
        {
            richTextBox1.SelectAll();
        }
        public void Delete() //удаление текста
        {
            richTextBox1.SelectedText = "";
            this.BufferText = "";
        }
        public void Open(String OpenFileName)
        {

            if (OpenFileName == null) { return; }
            else
            {
                StreamReader sr = new StreamReader(OpenFileName);
                richTextBox1.Text = sr.ReadToEnd(); sr.Close();
                DocName = OpenFileName;
            }
        }
        public void Save(String SaveFileName)
        {
            if (SaveFileName == null) { return; }
            else
            {
                StreamWriter sw = new StreamWriter(SaveFileName);
                sw.WriteLine(richTextBox1.Text); sw.Close(); //Устанавливаем имя документа
                DocName = SaveFileName;
            }
        }

        //методы выбора цвета текста
        public void ChangeColorBlack() //черный цвет
        {
            richTextBox1.SelectionColor = Color.Black;
        }
        public void ChangeColorRed() //красный цвет
        {
            richTextBox1.SelectionColor = Color.Red;
        }
        public void ChangeColorGreen() //зеленый цвет
        {
            richTextBox1.SelectionColor = Color.Green;
        }
        public void ChangeColorBlue() //Cиний цвет
        {
            richTextBox1.SelectionColor = Color.Blue;

        }
        //методы выбора шрифта текста
        
        public void ChangeFontCalibri()
        {
            richTextBox1.SelectionFont = new Font("Calibri", 30, FontStyle.Regular);
        }
        public void ChangeFontBell()
        {
            richTextBox1.SelectionFont = new Font("Bell", 30, FontStyle.Regular);
        }
        public void ChangeFontArial()
        {
            richTextBox1.SelectionFont = new Font("Arial", 30, FontStyle.Regular);
        }
        public void ChangeFontCandara()
        {
            richTextBox1.SelectionFont = new Font("Candara", 30, FontStyle.Regular);
        }
        
        public void ChangeFontCalisto()
        {
            richTextBox1.SelectionFont = new Font("Calisto", 30, FontStyle.Regular);
        }
        public void ChangeFontConsolas()
        {
            richTextBox1.SelectionFont = new Font("Consolas", 30, FontStyle.Regular);
        }
        public void ChangeFontCourier()
        {
            richTextBox1.SelectionFont = new Font("Courier", 80, FontStyle.Regular);
        }

        public void ChangeFontMSSans()
        {
            richTextBox1.SelectionFont = new Font("MS Sans", 80, FontStyle.Regular);
        }
        public void ChangeFontTimesNewRoman()
        {
            richTextBox1.SelectionFont = new Font("Times New Roman", 80, FontStyle.Regular);
        }
        private void blankh_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                if (IsSaved == true)
                    if (MessageBox.Show("Do you want save changes in "
                    + this.DocName + "?", "Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Save(this.DocName);
                    }
            }
        }

    }
}
