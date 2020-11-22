namespace RadarTestTask
{
    partial class Form
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.graphPanel = new System.Windows.Forms.Panel();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.graphStatusStrip = new System.Windows.Forms.StatusStrip();
            this.graphToolStripCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.graphToolStripScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.graphMenuStrip = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.показатьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбратьФайлДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel.SuspendLayout();
            this.graphPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.graphStatusStrip.SuspendLayout();
            this.graphMenuStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.graphPanel);
            this.mainPanel.Controls.Add(this.dataTextBox);
            this.mainPanel.Controls.Add(this.mainMenuStrip);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(944, 501);
            this.mainPanel.TabIndex = 4;
            // 
            // graphPanel
            // 
            this.graphPanel.Controls.Add(this.graphPictureBox);
            this.graphPanel.Controls.Add(this.graphStatusStrip);
            this.graphPanel.Controls.Add(this.graphMenuStrip);
            this.graphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPanel.Location = new System.Drawing.Point(300, 24);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(644, 477);
            this.graphPanel.TabIndex = 3;
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.graphPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.graphPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphPictureBox.Location = new System.Drawing.Point(0, 24);
            this.graphPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(644, 431);
            this.graphPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.graphPictureBox.TabIndex = 1;
            this.graphPictureBox.TabStop = false;
            this.graphPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.graphPictureBox_MouseDown);
            this.graphPictureBox.MouseLeave += new System.EventHandler(this.graphPictureBox_MouseLeave);
            this.graphPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.graphPictureBox_MouseMove);
            this.graphPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.graphPictureBox_MouseUp);
            // 
            // graphStatusStrip
            // 
            this.graphStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripCoordinates,
            this.graphToolStripScale,
            this.toolStripStatusLabel1});
            this.graphStatusStrip.Location = new System.Drawing.Point(0, 455);
            this.graphStatusStrip.Name = "graphStatusStrip";
            this.graphStatusStrip.Size = new System.Drawing.Size(644, 22);
            this.graphStatusStrip.SizingGrip = false;
            this.graphStatusStrip.TabIndex = 4;
            this.graphStatusStrip.Text = "Графические данные";
            // 
            // graphToolStripCoordinates
            // 
            this.graphToolStripCoordinates.Name = "graphToolStripCoordinates";
            this.graphToolStripCoordinates.Size = new System.Drawing.Size(206, 17);
            this.graphToolStripCoordinates.Text = "Координаты: X 0000.0000 Y 0000.0000";
            // 
            // graphToolStripScale
            // 
            this.graphToolStripScale.Name = "graphToolStripScale";
            this.graphToolStripScale.Size = new System.Drawing.Size(98, 17);
            this.graphToolStripScale.Text = "Масштаб: 1:1200";
            // 
            // graphMenuStrip
            // 
            this.graphMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem});
            this.graphMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.graphMenuStrip.Name = "graphMenuStrip";
            this.graphMenuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.graphMenuStrip.Size = new System.Drawing.Size(644, 24);
            this.graphMenuStrip.TabIndex = 5;
            this.graphMenuStrip.Text = "menuStrip2";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem,
            this.показатьВсеToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.увеличитьToolStripMenuItem.Text = "Увеличить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.graphZoomIn_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.уменьшитьToolStripMenuItem.Text = "Уменьшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.graphZoomOut_Click);
            // 
            // показатьВсеToolStripMenuItem
            // 
            this.показатьВсеToolStripMenuItem.Name = "показатьВсеToolStripMenuItem";
            this.показатьВсеToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.показатьВсеToolStripMenuItem.Text = "Показать все";
            this.показатьВсеToolStripMenuItem.Click += new System.EventHandler(this.graphZoomAll_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dataTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataTextBox.Enabled = false;
            this.dataTextBox.Location = new System.Drawing.Point(0, 24);
            this.dataTextBox.Multiline = true;
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataTextBox.Size = new System.Drawing.Size(300, 477);
            this.dataTextBox.TabIndex = 2;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(944, 24);
            this.mainMenuStrip.TabIndex = 4;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выбратьФайлДанныхToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выбратьФайлДанныхToolStripMenuItem
            // 
            this.выбратьФайлДанныхToolStripMenuItem.Name = "выбратьФайлДанныхToolStripMenuItem";
            this.выбратьФайлДанныхToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выбратьФайлДанныхToolStripMenuItem.Text = "Открыть...";
            this.выбратьФайлДанныхToolStripMenuItem.Click += new System.EventHandler(this.SelectDataFile);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel1.Text = "ЛКМ: Перемещение";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приложение Windows для чтения файлов заданного формата и вывода результатов чтени" +
    "я в графическом виде";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.graphPanel.ResumeLayout(false);
            this.graphPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.graphStatusStrip.ResumeLayout(false);
            this.graphStatusStrip.PerformLayout();
            this.graphMenuStrip.ResumeLayout(false);
            this.graphMenuStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel graphPanel;
        private System.Windows.Forms.StatusStrip graphStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel graphToolStripCoordinates;
        private System.Windows.Forms.ToolStripStatusLabel graphToolStripScale;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбратьФайлДанныхToolStripMenuItem;
        private System.Windows.Forms.MenuStrip graphMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem показатьВсеToolStripMenuItem;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

