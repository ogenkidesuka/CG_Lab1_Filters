namespace LabOne_Filter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точечныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инверсияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чернобелыйGrayScaleFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сепияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яркостьBrightFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффектСтеклаWindowFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.матричныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеBlurFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеGaussianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.резкостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.медианныйФильтрMedianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тиснениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.размытиеДвиженияMotionBlurFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выделениеГраницToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.щарраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прюиттToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.собеляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.цветоваяКоррекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.линейнаяКоррекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.серыйМирToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.идеальныйОтражательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.коррекцияСОпорнымЦветомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.математическаяМорфологияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шумСиПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackHatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переносToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.шагНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.структурныйЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BACK = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.статистическаяКоррекцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фильтрыToolStripMenuItem,
            this.редактированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(126, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // фильтрыToolStripMenuItem
            // 
            this.фильтрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точечныеToolStripMenuItem,
            this.матричныеToolStripMenuItem,
            this.toolStripMenuItem3,
            this.цветоваяКоррекцияToolStripMenuItem,
            this.математическаяМорфологияToolStripMenuItem});
            this.фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            this.фильтрыToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            this.точечныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.инверсияToolStripMenuItem,
            this.чернобелыйGrayScaleFilterToolStripMenuItem,
            this.сепияToolStripMenuItem,
            this.яркостьBrightFilterToolStripMenuItem,
            this.эффектСтеклаWindowFilterToolStripMenuItem});
            this.точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            this.точечныеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // инверсияToolStripMenuItem
            // 
            this.инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            this.инверсияToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.инверсияToolStripMenuItem.Text = "Инверсия";
            this.инверсияToolStripMenuItem.Click += new System.EventHandler(this.инверсияToolStripMenuItem_Click);
            // 
            // чернобелыйGrayScaleFilterToolStripMenuItem
            // 
            this.чернобелыйGrayScaleFilterToolStripMenuItem.Name = "чернобелыйGrayScaleFilterToolStripMenuItem";
            this.чернобелыйGrayScaleFilterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.чернобелыйGrayScaleFilterToolStripMenuItem.Text = "Черно-белый";
            this.чернобелыйGrayScaleFilterToolStripMenuItem.Click += new System.EventHandler(this.чернобелыйGrayScaleFilterToolStripMenuItem_Click);
            // 
            // сепияToolStripMenuItem
            // 
            this.сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            this.сепияToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.сепияToolStripMenuItem.Text = "Сепия";
            this.сепияToolStripMenuItem.Click += new System.EventHandler(this.сепияToolStripMenuItem_Click);
            // 
            // яркостьBrightFilterToolStripMenuItem
            // 
            this.яркостьBrightFilterToolStripMenuItem.Name = "яркостьBrightFilterToolStripMenuItem";
            this.яркостьBrightFilterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.яркостьBrightFilterToolStripMenuItem.Text = "Яркость+";
            this.яркостьBrightFilterToolStripMenuItem.Click += new System.EventHandler(this.яркостьBrightFilterToolStripMenuItem_Click);
            // 
            // эффектСтеклаWindowFilterToolStripMenuItem
            // 
            this.эффектСтеклаWindowFilterToolStripMenuItem.Name = "эффектСтеклаWindowFilterToolStripMenuItem";
            this.эффектСтеклаWindowFilterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.эффектСтеклаWindowFilterToolStripMenuItem.Text = "Стекло";
            this.эффектСтеклаWindowFilterToolStripMenuItem.Click += new System.EventHandler(this.эффектСтеклаWindowFilterToolStripMenuItem_Click);
            // 
            // матричныеToolStripMenuItem
            // 
            this.матричныеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.размытиеBlurFilterToolStripMenuItem,
            this.размытиеGaussianFilterToolStripMenuItem,
            this.резкостьToolStripMenuItem,
            this.медианныйФильтрMedianFilterToolStripMenuItem,
            this.собельToolStripMenuItem,
            this.тиснениеToolStripMenuItem,
            this.размытиеДвиженияMotionBlurFilterToolStripMenuItem,
            this.выделениеГраницToolStripMenuItem});
            this.матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            this.матричныеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // размытиеBlurFilterToolStripMenuItem
            // 
            this.размытиеBlurFilterToolStripMenuItem.Name = "размытиеBlurFilterToolStripMenuItem";
            this.размытиеBlurFilterToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.размытиеBlurFilterToolStripMenuItem.Text = "Размытие";
            this.размытиеBlurFilterToolStripMenuItem.Click += new System.EventHandler(this.размытиеBlurFilterToolStripMenuItem_Click);
            // 
            // размытиеGaussianFilterToolStripMenuItem
            // 
            this.размытиеGaussianFilterToolStripMenuItem.Name = "размытиеGaussianFilterToolStripMenuItem";
            this.размытиеGaussianFilterToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.размытиеGaussianFilterToolStripMenuItem.Text = "Гауссово размытие";
            this.размытиеGaussianFilterToolStripMenuItem.Click += new System.EventHandler(this.размытиеGaussianFilterToolStripMenuItem_Click);
            // 
            // резкостьToolStripMenuItem
            // 
            this.резкостьToolStripMenuItem.Name = "резкостьToolStripMenuItem";
            this.резкостьToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.резкостьToolStripMenuItem.Text = "Резкость";
            this.резкостьToolStripMenuItem.Click += new System.EventHandler(this.резкостьToolStripMenuItem_Click);
            // 
            // медианныйФильтрMedianFilterToolStripMenuItem
            // 
            this.медианныйФильтрMedianFilterToolStripMenuItem.Name = "медианныйФильтрMedianFilterToolStripMenuItem";
            this.медианныйФильтрMedianFilterToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.медианныйФильтрMedianFilterToolStripMenuItem.Text = "Медианный";
            this.медианныйФильтрMedianFilterToolStripMenuItem.Click += new System.EventHandler(this.медианныйФильтрMedianFilterToolStripMenuItem_Click);
            // 
            // собельToolStripMenuItem
            // 
            this.собельToolStripMenuItem.Name = "собельToolStripMenuItem";
            this.собельToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.собельToolStripMenuItem.Text = "Собель";
            this.собельToolStripMenuItem.Click += new System.EventHandler(this.собельToolStripMenuItem_Click);
            // 
            // тиснениеToolStripMenuItem
            // 
            this.тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            this.тиснениеToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.тиснениеToolStripMenuItem.Text = "Тиснение";
            this.тиснениеToolStripMenuItem.Click += new System.EventHandler(this.тиснениеToolStripMenuItem_Click);
            // 
            // размытиеДвиженияMotionBlurFilterToolStripMenuItem
            // 
            this.размытиеДвиженияMotionBlurFilterToolStripMenuItem.Name = "размытиеДвиженияMotionBlurFilterToolStripMenuItem";
            this.размытиеДвиженияMotionBlurFilterToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.размытиеДвиженияMotionBlurFilterToolStripMenuItem.Text = "Размытие движения (Motion Blur Filter)";
            this.размытиеДвиженияMotionBlurFilterToolStripMenuItem.Visible = false;
            this.размытиеДвиженияMotionBlurFilterToolStripMenuItem.Click += new System.EventHandler(this.размытиеДвиженияMotionBlurFilterToolStripMenuItem_Click);
            // 
            // выделениеГраницToolStripMenuItem
            // 
            this.выделениеГраницToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.щарраToolStripMenuItem,
            this.прюиттToolStripMenuItem,
            this.собеляToolStripMenuItem});
            this.выделениеГраницToolStripMenuItem.Name = "выделениеГраницToolStripMenuItem";
            this.выделениеГраницToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.выделениеГраницToolStripMenuItem.Text = "Выделение границ (Borderline Filter)";
            this.выделениеГраницToolStripMenuItem.Visible = false;
            // 
            // щарраToolStripMenuItem
            // 
            this.щарраToolStripMenuItem.Name = "щарраToolStripMenuItem";
            this.щарраToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.щарраToolStripMenuItem.Text = "Щарра";
            this.щарраToolStripMenuItem.Click += new System.EventHandler(this.щарраToolStripMenuItem_Click);
            // 
            // прюиттToolStripMenuItem
            // 
            this.прюиттToolStripMenuItem.Name = "прюиттToolStripMenuItem";
            this.прюиттToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.прюиттToolStripMenuItem.Text = "Прюитт";
            this.прюиттToolStripMenuItem.Visible = false;
            this.прюиттToolStripMenuItem.Click += new System.EventHandler(this.прюиттToolStripMenuItem_Click);
            // 
            // собеляToolStripMenuItem
            // 
            this.собеляToolStripMenuItem.Name = "собеляToolStripMenuItem";
            this.собеляToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.собеляToolStripMenuItem.Text = "Собеля";
            this.собеляToolStripMenuItem.Click += new System.EventHandler(this.собеляToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(178, 6);
            // 
            // цветоваяКоррекцияToolStripMenuItem
            // 
            this.цветоваяКоррекцияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линейнаяКоррекцияToolStripMenuItem,
            this.серыйМирToolStripMenuItem,
            this.идеальныйОтражательToolStripMenuItem,
            this.коррекцияСОпорнымЦветомToolStripMenuItem,
            this.статистическаяКоррекцияToolStripMenuItem});
            this.цветоваяКоррекцияToolStripMenuItem.Name = "цветоваяКоррекцияToolStripMenuItem";
            this.цветоваяКоррекцияToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.цветоваяКоррекцияToolStripMenuItem.Text = "Цветовая коррекция";
            // 
            // линейнаяКоррекцияToolStripMenuItem
            // 
            this.линейнаяКоррекцияToolStripMenuItem.Name = "линейнаяКоррекцияToolStripMenuItem";
            this.линейнаяКоррекцияToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.линейнаяКоррекцияToolStripMenuItem.Text = "Линейная коррекция";
            this.линейнаяКоррекцияToolStripMenuItem.Click += new System.EventHandler(this.линейнаяКоррекцияToolStripMenuItem_Click_1);
            // 
            // серыйМирToolStripMenuItem
            // 
            this.серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            this.серыйМирToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.серыйМирToolStripMenuItem.Text = "Серый мир";
            this.серыйМирToolStripMenuItem.Click += new System.EventHandler(this.серыйМирToolStripMenuItem_Click_1);
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            this.идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            this.идеальныйОтражательToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
            this.идеальныйОтражательToolStripMenuItem.Click += new System.EventHandler(this.идеальныйОтражательToolStripMenuItem_Click);
            // 
            // коррекцияСОпорнымЦветомToolStripMenuItem
            // 
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Name = "коррекцияСОпорнымЦветомToolStripMenuItem";
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Text = "Коррекция с опорным цветом";
            this.коррекцияСОпорнымЦветомToolStripMenuItem.Click += new System.EventHandler(this.коррекцияСОпорнымЦветомToolStripMenuItem_Click);
            // 
            // математическаяМорфологияToolStripMenuItem
            // 
            this.математическаяМорфологияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.шумСиПToolStripMenuItem,
            this.dialationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.openingToolStripMenuItem,
            this.closingToolStripMenuItem,
            this.gradToolStripMenuItem,
            this.topHatToolStripMenuItem,
            this.blackHatToolStripMenuItem});
            this.математическаяМорфологияToolStripMenuItem.Name = "математическаяМорфологияToolStripMenuItem";
            this.математическаяМорфологияToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.математическаяМорфологияToolStripMenuItem.Text = "Удаление шумов";
            // 
            // шумСиПToolStripMenuItem
            // 
            this.шумСиПToolStripMenuItem.Name = "шумСиПToolStripMenuItem";
            this.шумСиПToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.шумСиПToolStripMenuItem.Text = "Шум СиП";
            this.шумСиПToolStripMenuItem.Click += new System.EventHandler(this.шумСиПToolStripMenuItem_Click);
            // 
            // dialationToolStripMenuItem
            // 
            this.dialationToolStripMenuItem.Name = "dialationToolStripMenuItem";
            this.dialationToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.dialationToolStripMenuItem.Text = "Расширение";
            this.dialationToolStripMenuItem.Click += new System.EventHandler(this.dialationToolStripMenuItem_Click);
            // 
            // erosionToolStripMenuItem
            // 
            this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
            this.erosionToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.erosionToolStripMenuItem.Text = "Сужение";
            this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
            // 
            // openingToolStripMenuItem
            // 
            this.openingToolStripMenuItem.Name = "openingToolStripMenuItem";
            this.openingToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openingToolStripMenuItem.Text = "Открытие";
            this.openingToolStripMenuItem.Click += new System.EventHandler(this.openingToolStripMenuItem_Click);
            // 
            // closingToolStripMenuItem
            // 
            this.closingToolStripMenuItem.Name = "closingToolStripMenuItem";
            this.closingToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.closingToolStripMenuItem.Text = "Закрытие";
            this.closingToolStripMenuItem.Click += new System.EventHandler(this.closingToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.gradToolStripMenuItem.Text = "Grad";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // topHatToolStripMenuItem
            // 
            this.topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            this.topHatToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.topHatToolStripMenuItem.Text = "TopHat";
            this.topHatToolStripMenuItem.Click += new System.EventHandler(this.topHatToolStripMenuItem_Click);
            // 
            // blackHatToolStripMenuItem
            // 
            this.blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            this.blackHatToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.blackHatToolStripMenuItem.Text = "BlackHat";
            this.blackHatToolStripMenuItem.Click += new System.EventHandler(this.blackHatToolStripMenuItem_Click);
            // 
            // редактированиеToolStripMenuItem
            // 
            this.редактированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переносToolStripMenuItem,
            this.поворотToolStripMenuItem,
            this.toolStripMenuItem1,
            this.шагНазадToolStripMenuItem,
            this.toolStripMenuItem4,
            this.структурныйЭлементToolStripMenuItem});
            this.редактированиеToolStripMenuItem.Name = "редактированиеToolStripMenuItem";
            this.редактированиеToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.редактированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // переносToolStripMenuItem
            // 
            this.переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            this.переносToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.переносToolStripMenuItem.Text = "Перенос";
            this.переносToolStripMenuItem.Click += new System.EventHandler(this.переносToolStripMenuItem_Click);
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.поворотToolStripMenuItem.Text = "Поворот";
            this.поворотToolStripMenuItem.Visible = false;
            this.поворотToolStripMenuItem.Click += new System.EventHandler(this.поворотToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // шагНазадToolStripMenuItem
            // 
            this.шагНазадToolStripMenuItem.Name = "шагНазадToolStripMenuItem";
            this.шагНазадToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.шагНазадToolStripMenuItem.Text = "Шаг назад";
            this.шагНазадToolStripMenuItem.Click += new System.EventHandler(this.шагНазадToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(184, 6);
            // 
            // структурныйЭлементToolStripMenuItem
            // 
            this.структурныйЭлементToolStripMenuItem.Name = "структурныйЭлементToolStripMenuItem";
            this.структурныйЭлементToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.структурныйЭлементToolStripMenuItem.Text = "Структурный элемент";
            this.структурныйЭлементToolStripMenuItem.Click += new System.EventHandler(this.структурныйЭлементToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(9, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(820, 492);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Стоп";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(9, 492);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(800, 27);
            this.progressBar1.TabIndex = 3;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // BACK
            // 
            this.BACK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BACK.Enabled = false;
            this.BACK.Location = new System.Drawing.Point(820, 458);
            this.BACK.Margin = new System.Windows.Forms.Padding(2);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(86, 29);
            this.BACK.TabIndex = 4;
            this.BACK.Text = "Шаг назад";
            this.BACK.UseVisualStyleBackColor = true;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // SAVE
            // 
            this.SAVE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SAVE.Enabled = false;
            this.SAVE.Location = new System.Drawing.Point(820, 34);
            this.SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(86, 28);
            this.SAVE.TabIndex = 5;
            this.SAVE.Text = "Сохранить";
            this.SAVE.UseVisualStyleBackColor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // статистическаяКоррекцияToolStripMenuItem
            // 
            this.статистическаяКоррекцияToolStripMenuItem.Name = "статистическаяКоррекцияToolStripMenuItem";
            this.статистическаяКоррекцияToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.статистическаяКоррекцияToolStripMenuItem.Text = "Статистическая коррекция";
            this.статистическаяКоррекцияToolStripMenuItem.Click += new System.EventHandler(this.статистическаяКоррекцияToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(922, 540);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.BACK);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(930, 567);
            this.Name = "Form1";
            this.Text = "CompGraphics | Lab One | Filters";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точечныеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инверсияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem матричныеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem размытиеBlurFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеGaussianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem чернобелыйGrayScaleFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сепияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яркостьBrightFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem резкостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тиснениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шагНазадToolStripMenuItem;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem переносToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выделениеГраницToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem щарраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прюиттToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem размытиеДвиженияMotionBlurFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффектСтеклаWindowFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem цветоваяКоррекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem линейнаяКоррекцияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem серыйМирToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem коррекцияСОпорнымЦветомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem математическаяМорфологияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem медианныйФильтрMedianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собеляToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem структурныйЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackHatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem собельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шумСиПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистическаяКоррекцияToolStripMenuItem;
    }
}

