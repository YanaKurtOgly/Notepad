using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmmain : Form
    {
        private int openDoc; //счетчик числа открываемых док-тов
        public frmmain()
        {
            InitializeComponent();
            //mnuSave.Enabled = false; //отключение доступности сохранения файла
        }

       
        private void mnuExit_Click(object sender, EventArgs e)
        {

        }

        private void mnuDelete_Click(object sender, EventArgs e) //удалить

        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.Delete();
        }

        private void mnuNew_Click(object sender, EventArgs e)  //создание нового документа
        {
            blankh frm = new blankh();
            frm.DocName = "Документ " + ++openDoc;
            frm.Text = frm.DocName;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mnuWindow_Click(object sender, EventArgs e)
        {

        }
     
        private void mnuTileHorizontal_Click_1(object sender, EventArgs e) //горизонтальное выр-ие
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuCascade_Click_1(object sender, EventArgs e) //выравнивание  "каскад"
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mnuTileVertical_Click_1(object sender, EventArgs e) //вертикальное выр-ие
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuArrangeIcons_Click(object sender, EventArgs e) //перекл фокуса на выбранную форму
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void mnuCut_Click(object sender, EventArgs e) //вырезать
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.Cut();
        }

        private void mnuCopy_Click(object sender, EventArgs e) //копировать
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.Copy();
        }

        private void mnuPaste_Click(object sender, EventArgs e)  //вставить

        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.Paste();
        }

        private void mnuSelectAll_Click(object sender, EventArgs e) //выделить все
        {

            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.SelectAll();
        }
        private void mnuOpen_Click(object sender, EventArgs e)
        { 
        }
        private void mnuSave_Click(object sender, EventArgs e)
        {
            
            
        }
            private void mnuOpen_Click_1(object sender, EventArgs e)
        {
            // задание доступных расширений файлов программно
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blankh frm = new blankh(); frm.Open(openFileDialog1.FileName);
                frm.MdiParent = this; //Указываем родительскую форму 
                                      //Присваиваем переменной DocName имя открываемого файла
                frm.DocName = openFileDialog1.FileName;
                //Свойству Text формы присваиваем переменную DocName
                frm.Text = frm.DocName;
                frm.Show();
            }
            mnuSave.Enabled = true;
        }
        private void menuItem5_Click(object sender, EventArgs e)
        {
            {
                blankh frm = (blankh)(this.ActiveMdiChild);
                frm.Save(frm.DocName);
                frm.IsSaved = true;
            }
        }

        private void colorBlack_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeColorBlack();

        }

        private void colorRed_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeColorRed();
        }

        private void colorBlue_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeColorBlue();
        }

        private void colorGreen_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeColorGreen();
        }

        private void fontArial_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontArial();
        }

        private void fontCandara_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontCandara();
        }

        private void fontCalisto_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontCalisto();
        }

        private void fontCalibri_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontCalibri();
        }

        private void fontConsolas_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontConsolas();
        }

        private void fontBell_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontBell();
        }

       private void mnuSave_Click_1(object sender, EventArgs e)
       {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                blankh frm = (blankh)(this.ActiveMdiChild);
                frm.Save(saveFileDialog1.FileName);
                frm.MdiParent = this;
                frm.DocName = saveFileDialog1.FileName;
                frm.Text = frm.DocName;
                frm.Save(frm.DocName);
                frm.IsSaved = true;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void mnuFile_Click(object sender, EventArgs e)
        {

        }

        private void fontCourier_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontCourier();
        }

        private void fontMSSans_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontMSSans();
        }

        private void fontTimesNewRoman_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontTimesNewRoman();
        }

        private void consolasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blankh frm = (blankh)(this.ActiveMdiChild);
            frm.ChangeFontGeorgia();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About_programm dialoge = new About_programm();
            dialoge.ShowDialog();

        }
    }

}
