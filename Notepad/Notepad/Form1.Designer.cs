namespace Notepad
{
    partial class frmmain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuForrmt = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.fontArial = new System.Windows.Forms.ToolStripMenuItem();
            this.fontCandara = new System.Windows.Forms.ToolStripMenuItem();
            this.fontCalisto = new System.Windows.Forms.ToolStripMenuItem();
            this.fontCalibri = new System.Windows.Forms.ToolStripMenuItem();
            this.fontConsolas = new System.Windows.Forms.ToolStripMenuItem();
            this.fontBell = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColor = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBlack = new System.Windows.Forms.ToolStripMenuItem();
            this.colorRed = new System.Windows.Forms.ToolStripMenuItem();
            this.colorBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.colorGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuArrangeIcons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontCourier = new System.Windows.Forms.ToolStripMenuItem();
            this.fontMSSans = new System.Windows.Forms.ToolStripMenuItem();
            this.fontTimesNewRoman = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuForrmt,
            this.mnuWindow,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.menuItem5,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(59, 24);
            this.mnuFile.Text = "&Файл";
            this.mnuFile.Click += new System.EventHandler(this.mnuFile_Click);
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(293, 26);
            this.mnuNew.Text = "&Новый                 Ctrl+N";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(293, 26);
            this.mnuOpen.Text = "&Открыть               Ctrl+O";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click_1);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(293, 26);
            this.mnuSave.Text = "&Сохранить           Ctrl+S";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click_1);
            // 
            // menuItem5
            // 
            this.menuItem5.Name = "menuItem5";
            this.menuItem5.Size = new System.Drawing.Size(293, 26);
            this.menuItem5.Text = "&Сохранить как     Ctrl+Shift+S";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(293, 26);
            this.mnuExit.Text = "&Выход                   Alt+F4";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCut,
            this.mnuCopy,
            this.mnuPaste,
            this.mnuDelete,
            this.mnuSelectAll});
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(82, 24);
            this.mnuEdit.Text = "&Править";
            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.Size = new System.Drawing.Size(257, 26);
            this.mnuCut.Text = "&Вырезать             Ctrl+X";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.Size = new System.Drawing.Size(257, 26);
            this.mnuCopy.Text = "&Копировать         Ctrl+C";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.Size = new System.Drawing.Size(257, 26);
            this.mnuPaste.Text = "&Вставить               Ctrl+V";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Size = new System.Drawing.Size(257, 26);
            this.mnuDelete.Text = "&Удалить                Del";
            this.mnuDelete.Click += new System.EventHandler(this.mnuDelete_Click);
            // 
            // mnuSelectAll
            // 
            this.mnuSelectAll.Name = "mnuSelectAll";
            this.mnuSelectAll.Size = new System.Drawing.Size(257, 26);
            this.mnuSelectAll.Text = "&Выделить все       Ctrl+A";
            this.mnuSelectAll.Click += new System.EventHandler(this.mnuSelectAll_Click);
            // 
            // mnuForrmt
            // 
            this.mnuForrmt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFont,
            this.mnuColor});
            this.mnuForrmt.Name = "mnuForrmt";
            this.mnuForrmt.Size = new System.Drawing.Size(77, 24);
            this.mnuForrmt.Text = "Формат";
            // 
            // mnuFont
            // 
            this.mnuFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontArial,
            this.fontCandara,
            this.fontCalisto,
            this.fontCalibri,
            this.fontConsolas,
            this.fontBell,
            this.fontCourier,
            this.fontMSSans,
            this.fontTimesNewRoman});
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(224, 26);
            this.mnuFont.Text = "Шрифт...";
            // 
            // fontArial
            // 
            this.fontArial.Name = "fontArial";
            this.fontArial.Size = new System.Drawing.Size(224, 26);
            this.fontArial.Text = "Arial";
            this.fontArial.Click += new System.EventHandler(this.fontArial_Click);
            // 
            // fontCandara
            // 
            this.fontCandara.Name = "fontCandara";
            this.fontCandara.Size = new System.Drawing.Size(224, 26);
            this.fontCandara.Text = "Candara";
            this.fontCandara.Click += new System.EventHandler(this.fontCandara_Click);
            // 
            // fontCalisto
            // 
            this.fontCalisto.Name = "fontCalisto";
            this.fontCalisto.Size = new System.Drawing.Size(224, 26);
            this.fontCalisto.Text = "Calisto";
            this.fontCalisto.Click += new System.EventHandler(this.fontCalisto_Click);
            // 
            // fontCalibri
            // 
            this.fontCalibri.Name = "fontCalibri";
            this.fontCalibri.Size = new System.Drawing.Size(224, 26);
            this.fontCalibri.Text = "Calibri";
            this.fontCalibri.Click += new System.EventHandler(this.fontCalibri_Click);
            // 
            // fontConsolas
            // 
            this.fontConsolas.Name = "fontConsolas";
            this.fontConsolas.Size = new System.Drawing.Size(224, 26);
            this.fontConsolas.Text = "Consolas";
            this.fontConsolas.Click += new System.EventHandler(this.fontConsolas_Click);
            // 
            // fontBell
            // 
            this.fontBell.Name = "fontBell";
            this.fontBell.Size = new System.Drawing.Size(224, 26);
            this.fontBell.Text = "Bell";
            this.fontBell.Click += new System.EventHandler(this.fontBell_Click);
            // 
            // mnuColor
            // 
            this.mnuColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorBlack,
            this.colorRed,
            this.colorBlue,
            this.colorGreen});
            this.mnuColor.Name = "mnuColor";
            this.mnuColor.Size = new System.Drawing.Size(224, 26);
            this.mnuColor.Text = "Цвет...";
            // 
            // colorBlack
            // 
            this.colorBlack.Name = "colorBlack";
            this.colorBlack.Size = new System.Drawing.Size(154, 26);
            this.colorBlack.Text = "Черный";
            this.colorBlack.Click += new System.EventHandler(this.colorBlack_Click);
            // 
            // colorRed
            // 
            this.colorRed.Name = "colorRed";
            this.colorRed.Size = new System.Drawing.Size(154, 26);
            this.colorRed.Text = "Красный";
            this.colorRed.Click += new System.EventHandler(this.colorRed_Click);
            // 
            // colorBlue
            // 
            this.colorBlue.Name = "colorBlue";
            this.colorBlue.Size = new System.Drawing.Size(154, 26);
            this.colorBlue.Text = "Синий";
            this.colorBlue.Click += new System.EventHandler(this.colorBlue_Click);
            // 
            // colorGreen
            // 
            this.colorGreen.Name = "colorGreen";
            this.colorGreen.Size = new System.Drawing.Size(154, 26);
            this.colorGreen.Text = "Зеленый";
            this.colorGreen.Click += new System.EventHandler(this.colorGreen_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArrangeIcons,
            this.mnuCascade,
            this.mnuTileHorizontal,
            this.mnuTileVertical});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(59, 24);
            this.mnuWindow.Text = "&Окно";
            this.mnuWindow.Click += new System.EventHandler(this.mnuWindow_Click);
            // 
            // mnuArrangeIcons
            // 
            this.mnuArrangeIcons.Name = "mnuArrangeIcons";
            this.mnuArrangeIcons.Size = new System.Drawing.Size(199, 26);
            this.mnuArrangeIcons.Text = "&Упорядочить";
            this.mnuArrangeIcons.Click += new System.EventHandler(this.mnuArrangeIcons_Click);
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(199, 26);
            this.mnuCascade.Text = "&Каскад";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click_1);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            this.mnuTileHorizontal.Size = new System.Drawing.Size(199, 26);
            this.mnuTileHorizontal.Text = "&Горизонтально";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.mnuTileHorizontal_Click_1);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            this.mnuTileVertical.Size = new System.Drawing.Size(199, 26);
            this.mnuTileVertical.Text = "&Вертикально";
            this.mnuTileVertical.Click += new System.EventHandler(this.mnuTileVertical_Click_1);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(30, 24);
            this.mnuHelp.Text = "?";
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(196, 26);
            this.mnuAbout.Text = "О программе...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fontCourier
            // 
            this.fontCourier.Name = "fontCourier";
            this.fontCourier.Size = new System.Drawing.Size(224, 26);
            this.fontCourier.Text = "Courier";
            this.fontCourier.Click += new System.EventHandler(this.fontCourier_Click);
            // 
            // fontMSSans
            // 
            this.fontMSSans.Name = "fontMSSans";
            this.fontMSSans.Size = new System.Drawing.Size(224, 26);
            this.fontMSSans.Text = "MS Sans";
            this.fontMSSans.Click += new System.EventHandler(this.fontMSSans_Click);
            // 
            // fontTimesNewRoman
            // 
            this.fontTimesNewRoman.Name = "fontTimesNewRoman";
            this.fontTimesNewRoman.Size = new System.Drawing.Size(224, 26);
            this.fontTimesNewRoman.Text = "Times New Roman";
            this.fontTimesNewRoman.Click += new System.EventHandler(this.fontTimesNewRoman_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.Text = "NotepadC#";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem menuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuForrmt;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem fontArial;
        private System.Windows.Forms.ToolStripMenuItem fontCandara;
        private System.Windows.Forms.ToolStripMenuItem fontCalisto;
        private System.Windows.Forms.ToolStripMenuItem fontCalibri;
        private System.Windows.Forms.ToolStripMenuItem fontConsolas;
        private System.Windows.Forms.ToolStripMenuItem fontBell;
        private System.Windows.Forms.ToolStripMenuItem mnuColor;
        private System.Windows.Forms.ToolStripMenuItem colorBlack;
        private System.Windows.Forms.ToolStripMenuItem colorRed;
        private System.Windows.Forms.ToolStripMenuItem colorBlue;
        private System.Windows.Forms.ToolStripMenuItem colorGreen;
        private System.Windows.Forms.ToolStripMenuItem mnuArrangeIcons;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem fontCourier;
        private System.Windows.Forms.ToolStripMenuItem fontMSSans;
        private System.Windows.Forms.ToolStripMenuItem fontTimesNewRoman;
    }
}

