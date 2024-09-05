namespace ProgressQuest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pB1 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pB2 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pB3 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.pB4 = new ExtendedDotNET.Controls.Progress.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.questTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button6 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.DimGray;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(526, 88);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(160, 36);
            this.materialFlatButton2.TabIndex = 1;
            this.materialFlatButton2.Text = "Окно по центру";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(22, 88);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(151, 36);
            this.materialFlatButton3.TabIndex = 2;
            this.materialFlatButton3.Text = "Свернуть окно";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.сохранитьИгруToolStripMenuItem,
            this.загрузитьИгруToolStripMenuItem,
            this.паузаToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // сохранитьИгруToolStripMenuItem
            // 
            this.сохранитьИгруToolStripMenuItem.Name = "сохранитьИгруToolStripMenuItem";
            this.сохранитьИгруToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.сохранитьИгруToolStripMenuItem.Text = "Сохранить игру";
            this.сохранитьИгруToolStripMenuItem.Click += new System.EventHandler(this.сохранитьИгруToolStripMenuItem_Click);
            // 
            // загрузитьИгруToolStripMenuItem
            // 
            this.загрузитьИгруToolStripMenuItem.Name = "загрузитьИгруToolStripMenuItem";
            this.загрузитьИгруToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.загрузитьИгруToolStripMenuItem.Text = "Загрузить игру";
            this.загрузитьИгруToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИгруToolStripMenuItem_Click);
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.паузаToolStripMenuItem.Text = "Пауза";
            this.паузаToolStripMenuItem.Click += new System.EventHandler(this.паузаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(83, 26);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
            // 
            // pB1
            // 
            this.pB1.BarOffset = 1;
            this.pB1.Caption = "Progress";
            this.pB1.CaptionColor = System.Drawing.Color.Black;
            this.pB1.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pB1.CaptionShadowColor = System.Drawing.Color.White;
            this.pB1.ChangeByMouse = false;
            this.pB1.DashSpace = 2;
            this.pB1.DashWidth = 5;
            this.pB1.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.pB1.EdgeColor = System.Drawing.Color.Gray;
            this.pB1.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pB1.EdgeWidth = 1;
            this.pB1.FloodPercentage = 0.2F;
            this.pB1.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pB1.Invert = true;
            this.pB1.Location = new System.Drawing.Point(58, 200);
            this.pB1.MainColor = System.Drawing.Color.Red;
            this.pB1.Margin = new System.Windows.Forms.Padding(2);
            this.pB1.Maximum = 100;
            this.pB1.Minimum = 0;
            this.pB1.Name = "pB1";
            this.pB1.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Vertical;
            this.pB1.ProgressBackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB1.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pB1.SecondColor = System.Drawing.Color.Yellow;
            this.pB1.Shadow = true;
            this.pB1.ShadowOffset = 1;
            this.pB1.Size = new System.Drawing.Size(92, 321);
            this.pB1.Step = 1;
            this.pB1.TabIndex = 4;
            this.pB1.TextAntialias = true;
            this.pB1.Value = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pB2
            // 
            this.pB2.BarOffset = 1;
            this.pB2.Caption = "Progress";
            this.pB2.CaptionColor = System.Drawing.Color.Black;
            this.pB2.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pB2.CaptionShadowColor = System.Drawing.Color.White;
            this.pB2.ChangeByMouse = false;
            this.pB2.DashSpace = 2;
            this.pB2.DashWidth = 5;
            this.pB2.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.pB2.EdgeColor = System.Drawing.Color.Gray;
            this.pB2.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pB2.EdgeWidth = 1;
            this.pB2.FloodPercentage = 0.2F;
            this.pB2.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pB2.Invert = true;
            this.pB2.Location = new System.Drawing.Point(201, 200);
            this.pB2.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pB2.Margin = new System.Windows.Forms.Padding(2);
            this.pB2.Maximum = 100;
            this.pB2.Minimum = 0;
            this.pB2.Name = "pB2";
            this.pB2.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Vertical;
            this.pB2.ProgressBackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB2.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pB2.SecondColor = System.Drawing.Color.Yellow;
            this.pB2.Shadow = true;
            this.pB2.ShadowOffset = 1;
            this.pB2.Size = new System.Drawing.Size(92, 321);
            this.pB2.Step = 1;
            this.pB2.TabIndex = 4;
            this.pB2.TextAntialias = true;
            this.pB2.Value = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(188, 540);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pB3
            // 
            this.pB3.BarOffset = 1;
            this.pB3.Caption = "Progress";
            this.pB3.CaptionColor = System.Drawing.Color.Black;
            this.pB3.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pB3.CaptionShadowColor = System.Drawing.Color.White;
            this.pB3.ChangeByMouse = false;
            this.pB3.DashSpace = 2;
            this.pB3.DashWidth = 5;
            this.pB3.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.pB3.EdgeColor = System.Drawing.Color.Gray;
            this.pB3.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pB3.EdgeWidth = 1;
            this.pB3.FloodPercentage = 0.2F;
            this.pB3.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pB3.Invert = true;
            this.pB3.Location = new System.Drawing.Point(352, 200);
            this.pB3.MainColor = System.Drawing.Color.Violet;
            this.pB3.Margin = new System.Windows.Forms.Padding(2);
            this.pB3.Maximum = 100;
            this.pB3.Minimum = 0;
            this.pB3.Name = "pB3";
            this.pB3.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Vertical;
            this.pB3.ProgressBackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB3.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pB3.SecondColor = System.Drawing.Color.Yellow;
            this.pB3.Shadow = true;
            this.pB3.ShadowOffset = 1;
            this.pB3.Size = new System.Drawing.Size(92, 321);
            this.pB3.Step = 1;
            this.pB3.TabIndex = 4;
            this.pB3.TextAntialias = true;
            this.pB3.Value = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(348, 540);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pB4
            // 
            this.pB4.BarOffset = 1;
            this.pB4.Caption = "Progress";
            this.pB4.CaptionColor = System.Drawing.Color.Black;
            this.pB4.CaptionMode = ExtendedDotNET.Controls.Progress.ProgressCaptionMode.None;
            this.pB4.CaptionShadowColor = System.Drawing.Color.White;
            this.pB4.ChangeByMouse = false;
            this.pB4.DashSpace = 2;
            this.pB4.DashWidth = 5;
            this.pB4.Edge = ExtendedDotNET.Controls.Progress.ProgressBarEdge.None;
            this.pB4.EdgeColor = System.Drawing.Color.Gray;
            this.pB4.EdgeLightColor = System.Drawing.Color.LightGray;
            this.pB4.EdgeWidth = 1;
            this.pB4.FloodPercentage = 0.2F;
            this.pB4.FloodStyle = ExtendedDotNET.Controls.Progress.ProgressFloodStyle.Standard;
            this.pB4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pB4.Invert = true;
            this.pB4.Location = new System.Drawing.Point(1075, 231);
            this.pB4.MainColor = System.Drawing.Color.DarkGoldenrod;
            this.pB4.Margin = new System.Windows.Forms.Padding(2);
            this.pB4.Maximum = 100;
            this.pB4.Minimum = 0;
            this.pB4.Name = "pB4";
            this.pB4.Orientation = ExtendedDotNET.Controls.Progress.ProgressBarDirection.Vertical;
            this.pB4.ProgressBackColor = System.Drawing.SystemColors.ButtonFace;
            this.pB4.ProgressBarStyle = ExtendedDotNET.Controls.Progress.ProgressStyle.Solid;
            this.pB4.SecondColor = System.Drawing.Color.Aqua;
            this.pB4.Shadow = true;
            this.pB4.ShadowOffset = 1;
            this.pB4.Size = new System.Drawing.Size(110, 290);
            this.pB4.Step = 1;
            this.pB4.TabIndex = 4;
            this.pB4.TextAntialias = true;
            this.pB4.Value = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1056, 540);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(481, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 39);
            this.label5.TabIndex = 6;
            this.label5.Text = "Доход (₽):";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.BackColor = System.Drawing.Color.White;
            this.lblMoney.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMoney.Location = new System.Drawing.Point(630, 139);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(136, 39);
            this.lblMoney.TabIndex = 6;
            this.lblMoney.Text = "0000000";
            // 
            // questTextBox
            // 
            this.questTextBox.BackColor = System.Drawing.Color.MistyRose;
            this.questTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questTextBox.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questTextBox.Location = new System.Drawing.Point(482, 404);
            this.questTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.questTextBox.Name = "questTextBox";
            this.questTextBox.ReadOnly = true;
            this.questTextBox.Size = new System.Drawing.Size(555, 186);
            this.questTextBox.TabIndex = 7;
            this.questTextBox.Text = "";
            this.questTextBox.SelectionChanged += new System.EventHandler(this.questTextBox_SelectionChanged);
            this.questTextBox.Enter += new System.EventHandler(this.questTextBox_Enter);
            // 
            // timer1
            // 
            this.timer1.Interval = 1400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DoorEx.png");
            this.imageList1.Images.SetKeyName(1, "Boleet.png");
            this.imageList1.Images.SetKeyName(2, "Radost.png");
            this.imageList1.Images.SetKeyName(3, "Dengi.png");
            this.imageList1.Images.SetKeyName(4, "Umneet.png");
            this.imageList1.Images.SetKeyName(5, "GB.png");
            this.imageList1.Images.SetKeyName(6, "Zhulik.jpg");
            this.imageList1.Images.SetKeyName(7, "Stradaet.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(41, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Лечиться (A)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(185, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Работать (S)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(335, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Учиться (D)";
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(38, 676);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1148, 58);
            this.button3.TabIndex = 22;
            this.button3.Tag = "2";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(38, 739);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1148, 58);
            this.button4.TabIndex = 23;
            this.button4.Tag = "3";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(38, 802);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(1148, 58);
            this.button5.TabIndex = 24;
            this.button5.Tag = "4";
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(38, 612);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1148, 58);
            this.button2.TabIndex = 22;
            this.button2.Tag = "1";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1056, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 28);
            this.label9.TabIndex = 6;
            this.label9.Text = "Подавить (W)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button6
            // 
            this.button6.Image = global::ProgressQuest.Properties.Resources.Invaderz_press;
            this.button6.Location = new System.Drawing.Point(681, 219);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(160, 160);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(500, 219);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(862, 219);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Image = global::ProgressQuest.Properties.Resources.DoorEx;
            this.button1.Location = new System.Drawing.Point(1086, 54);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 122);
            this.button1.TabIndex = 9;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 884);
            this.ControlBox = false;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.questTextBox);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pB4);
            this.Controls.Add(this.pB3);
            this.Controls.Add(this.pB2);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяИграToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private ExtendedDotNET.Controls.Progress.ProgressBar pB1;
        private System.Windows.Forms.Label label1;
        private ExtendedDotNET.Controls.Progress.ProgressBar pB2;
        private System.Windows.Forms.Label label2;
        private ExtendedDotNET.Controls.Progress.ProgressBar pB3;
        private System.Windows.Forms.Label label3;
        private ExtendedDotNET.Controls.Progress.ProgressBar pB4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.RichTextBox questTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem паузаToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Timer timer1;
    }
}

