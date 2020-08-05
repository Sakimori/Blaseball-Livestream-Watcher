namespace Blaseball_Livestream
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mainButtonLeft = new System.Windows.Forms.Button();
            this.mainButtonR = new System.Windows.Forms.Button();
            this.liveGameTable = new System.Windows.Forms.TableLayoutPanel();
            this.liveGameTitle = new System.Windows.Forms.Label();
            this.liveGameAwayName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.top7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelH = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.errorTop = new System.Windows.Forms.Label();
            this.errorBot = new System.Windows.Forms.Label();
            this.liveGameHomeName = new System.Windows.Forms.Label();
            this.top1 = new System.Windows.Forms.Label();
            this.top2 = new System.Windows.Forms.Label();
            this.top3 = new System.Windows.Forms.Label();
            this.top4 = new System.Windows.Forms.Label();
            this.top5 = new System.Windows.Forms.Label();
            this.top6 = new System.Windows.Forms.Label();
            this.top8 = new System.Windows.Forms.Label();
            this.top9 = new System.Windows.Forms.Label();
            this.bot1 = new System.Windows.Forms.Label();
            this.bot2 = new System.Windows.Forms.Label();
            this.bot3 = new System.Windows.Forms.Label();
            this.bot4 = new System.Windows.Forms.Label();
            this.bot5 = new System.Windows.Forms.Label();
            this.bot6 = new System.Windows.Forms.Label();
            this.bot7 = new System.Windows.Forms.Label();
            this.bot8 = new System.Windows.Forms.Label();
            this.bot9 = new System.Windows.Forms.Label();
            this.topR = new System.Windows.Forms.Label();
            this.botR = new System.Windows.Forms.Label();
            this.topH = new System.Windows.Forms.Label();
            this.botH = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loadedIndicator = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.recordIndicator = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.liveGameTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(669, 148);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mainButtonLeft
            // 
            this.mainButtonLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainButtonLeft.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainButtonLeft.Location = new System.Drawing.Point(0, 74);
            this.mainButtonLeft.Name = "mainButtonLeft";
            this.mainButtonLeft.Size = new System.Drawing.Size(165, 23);
            this.mainButtonLeft.TabIndex = 1;
            this.mainButtonLeft.Text = "Load Selected Team";
            this.mainButtonLeft.UseVisualStyleBackColor = true;
            this.mainButtonLeft.Click += new System.EventHandler(this.mainButtonLeft_Click);
            // 
            // mainButtonR
            // 
            this.mainButtonR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mainButtonR.Location = new System.Drawing.Point(182, 74);
            this.mainButtonR.Name = "mainButtonR";
            this.mainButtonR.Size = new System.Drawing.Size(165, 23);
            this.mainButtonR.TabIndex = 3;
            this.mainButtonR.Text = "Start Live Game";
            this.mainButtonR.UseVisualStyleBackColor = true;
            this.mainButtonR.Click += new System.EventHandler(this.mainButtonR_Click);
            // 
            // liveGameTable
            // 
            this.liveGameTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.liveGameTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.liveGameTable.ColumnCount = 13;
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.333074F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.334117F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.334117F));
            this.liveGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.334117F));
            this.liveGameTable.Controls.Add(this.liveGameTitle, 0, 0);
            this.liveGameTable.Controls.Add(this.liveGameAwayName, 0, 1);
            this.liveGameTable.Controls.Add(this.label1, 1, 0);
            this.liveGameTable.Controls.Add(this.label2, 2, 0);
            this.liveGameTable.Controls.Add(this.top7, 7, 1);
            this.liveGameTable.Controls.Add(this.label3, 3, 0);
            this.liveGameTable.Controls.Add(this.label4, 4, 0);
            this.liveGameTable.Controls.Add(this.label5, 5, 0);
            this.liveGameTable.Controls.Add(this.label6, 6, 0);
            this.liveGameTable.Controls.Add(this.label7, 7, 0);
            this.liveGameTable.Controls.Add(this.label8, 8, 0);
            this.liveGameTable.Controls.Add(this.label9, 9, 0);
            this.liveGameTable.Controls.Add(this.labelR, 10, 0);
            this.liveGameTable.Controls.Add(this.labelH, 11, 0);
            this.liveGameTable.Controls.Add(this.labelE, 12, 0);
            this.liveGameTable.Controls.Add(this.errorTop, 12, 1);
            this.liveGameTable.Controls.Add(this.errorBot, 12, 2);
            this.liveGameTable.Controls.Add(this.liveGameHomeName, 0, 2);
            this.liveGameTable.Controls.Add(this.top1, 1, 1);
            this.liveGameTable.Controls.Add(this.top2, 2, 1);
            this.liveGameTable.Controls.Add(this.top3, 3, 1);
            this.liveGameTable.Controls.Add(this.top4, 4, 1);
            this.liveGameTable.Controls.Add(this.top5, 5, 1);
            this.liveGameTable.Controls.Add(this.top6, 6, 1);
            this.liveGameTable.Controls.Add(this.top8, 8, 1);
            this.liveGameTable.Controls.Add(this.top9, 9, 1);
            this.liveGameTable.Controls.Add(this.bot1, 1, 2);
            this.liveGameTable.Controls.Add(this.bot2, 2, 2);
            this.liveGameTable.Controls.Add(this.bot3, 3, 2);
            this.liveGameTable.Controls.Add(this.bot4, 4, 2);
            this.liveGameTable.Controls.Add(this.bot5, 5, 2);
            this.liveGameTable.Controls.Add(this.bot6, 6, 2);
            this.liveGameTable.Controls.Add(this.bot7, 7, 2);
            this.liveGameTable.Controls.Add(this.bot8, 8, 2);
            this.liveGameTable.Controls.Add(this.bot9, 9, 2);
            this.liveGameTable.Controls.Add(this.topR, 10, 1);
            this.liveGameTable.Controls.Add(this.botR, 10, 2);
            this.liveGameTable.Controls.Add(this.topH, 11, 1);
            this.liveGameTable.Controls.Add(this.botH, 11, 2);
            this.liveGameTable.Cursor = System.Windows.Forms.Cursors.Cross;
            this.liveGameTable.Location = new System.Drawing.Point(258, 178);
            this.liveGameTable.Name = "liveGameTable";
            this.liveGameTable.RowCount = 3;
            this.liveGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.liveGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.liveGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.liveGameTable.Size = new System.Drawing.Size(776, 206);
            this.liveGameTable.TabIndex = 4;
            this.liveGameTable.Visible = false;
            // 
            // liveGameTitle
            // 
            this.liveGameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liveGameTitle.AutoSize = true;
            this.liveGameTitle.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveGameTitle.Location = new System.Drawing.Point(53, 15);
            this.liveGameTitle.Name = "liveGameTitle";
            this.liveGameTitle.Size = new System.Drawing.Size(100, 25);
            this.liveGameTitle.TabIndex = 37;
            this.liveGameTitle.Text = "Top of the 1st";
            // 
            // liveGameAwayName
            // 
            this.liveGameAwayName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liveGameAwayName.AutoSize = true;
            this.liveGameAwayName.Font = new System.Drawing.Font("DIN Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveGameAwayName.Location = new System.Drawing.Point(71, 75);
            this.liveGameAwayName.Name = "liveGameAwayName";
            this.liveGameAwayName.Size = new System.Drawing.Size(64, 34);
            this.liveGameAwayName.TabIndex = 4;
            this.liveGameAwayName.Text = "Away";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(265, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // top7
            // 
            this.top7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top7.AutoSize = true;
            this.top7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top7.Location = new System.Drawing.Point(500, 82);
            this.top7.Name = "top7";
            this.top7.Size = new System.Drawing.Size(19, 20);
            this.top7.TabIndex = 21;
            this.top7.Text = "0";
            this.top7.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "6";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "7";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "8";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(594, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "9";
            // 
            // labelR
            // 
            this.labelR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(640, 15);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(21, 25);
            this.labelR.TabIndex = 9;
            this.labelR.Text = "R";
            // 
            // labelH
            // 
            this.labelH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelH.AutoSize = true;
            this.labelH.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelH.Location = new System.Drawing.Point(687, 15);
            this.labelH.Name = "labelH";
            this.labelH.Size = new System.Drawing.Size(21, 25);
            this.labelH.TabIndex = 10;
            this.labelH.Text = "H";
            // 
            // labelE
            // 
            this.labelE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("DIN Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.Location = new System.Drawing.Point(738, 15);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(20, 25);
            this.labelE.TabIndex = 11;
            this.labelE.Text = "E";
            // 
            // errorTop
            // 
            this.errorTop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorTop.AutoSize = true;
            this.errorTop.Font = new System.Drawing.Font("DIN Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTop.Location = new System.Drawing.Point(735, 82);
            this.errorTop.Name = "errorTop";
            this.errorTop.Size = new System.Drawing.Size(25, 19);
            this.errorTop.TabIndex = 12;
            this.errorTop.Text = "NO";
            // 
            // errorBot
            // 
            this.errorBot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorBot.AutoSize = true;
            this.errorBot.Font = new System.Drawing.Font("DIN Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBot.Location = new System.Drawing.Point(735, 157);
            this.errorBot.Name = "errorBot";
            this.errorBot.Size = new System.Drawing.Size(25, 19);
            this.errorBot.TabIndex = 13;
            this.errorBot.Text = "NO";
            // 
            // liveGameHomeName
            // 
            this.liveGameHomeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liveGameHomeName.AutoSize = true;
            this.liveGameHomeName.Font = new System.Drawing.Font("DIN Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.liveGameHomeName.Location = new System.Drawing.Point(70, 150);
            this.liveGameHomeName.Name = "liveGameHomeName";
            this.liveGameHomeName.Size = new System.Drawing.Size(66, 34);
            this.liveGameHomeName.TabIndex = 14;
            this.liveGameHomeName.Text = "Home";
            // 
            // top1
            // 
            this.top1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top1.AutoSize = true;
            this.top1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top1.Location = new System.Drawing.Point(218, 82);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(19, 20);
            this.top1.TabIndex = 15;
            this.top1.Text = "0";
            this.top1.Visible = false;
            // 
            // top2
            // 
            this.top2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top2.AutoSize = true;
            this.top2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top2.Location = new System.Drawing.Point(265, 82);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(19, 20);
            this.top2.TabIndex = 16;
            this.top2.Text = "0";
            this.top2.Visible = false;
            // 
            // top3
            // 
            this.top3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top3.AutoSize = true;
            this.top3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3.Location = new System.Drawing.Point(312, 82);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(19, 20);
            this.top3.TabIndex = 17;
            this.top3.Text = "0";
            this.top3.Visible = false;
            // 
            // top4
            // 
            this.top4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top4.AutoSize = true;
            this.top4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top4.Location = new System.Drawing.Point(359, 82);
            this.top4.Name = "top4";
            this.top4.Size = new System.Drawing.Size(19, 20);
            this.top4.TabIndex = 18;
            this.top4.Text = "0";
            this.top4.Visible = false;
            // 
            // top5
            // 
            this.top5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top5.AutoSize = true;
            this.top5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top5.Location = new System.Drawing.Point(406, 82);
            this.top5.Name = "top5";
            this.top5.Size = new System.Drawing.Size(19, 20);
            this.top5.TabIndex = 19;
            this.top5.Text = "0";
            this.top5.Visible = false;
            // 
            // top6
            // 
            this.top6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top6.AutoSize = true;
            this.top6.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top6.Location = new System.Drawing.Point(453, 82);
            this.top6.Name = "top6";
            this.top6.Size = new System.Drawing.Size(19, 20);
            this.top6.TabIndex = 20;
            this.top6.Text = "0";
            this.top6.Visible = false;
            // 
            // top8
            // 
            this.top8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top8.AutoSize = true;
            this.top8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top8.Location = new System.Drawing.Point(547, 82);
            this.top8.Name = "top8";
            this.top8.Size = new System.Drawing.Size(19, 20);
            this.top8.TabIndex = 22;
            this.top8.Text = "0";
            this.top8.Visible = false;
            // 
            // top9
            // 
            this.top9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.top9.AutoSize = true;
            this.top9.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top9.Location = new System.Drawing.Point(594, 82);
            this.top9.Name = "top9";
            this.top9.Size = new System.Drawing.Size(19, 20);
            this.top9.TabIndex = 23;
            this.top9.Text = "0";
            this.top9.Visible = false;
            // 
            // bot1
            // 
            this.bot1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot1.AutoSize = true;
            this.bot1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot1.Location = new System.Drawing.Point(218, 157);
            this.bot1.Name = "bot1";
            this.bot1.Size = new System.Drawing.Size(19, 20);
            this.bot1.TabIndex = 24;
            this.bot1.Text = "0";
            this.bot1.Visible = false;
            // 
            // bot2
            // 
            this.bot2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot2.AutoSize = true;
            this.bot2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot2.Location = new System.Drawing.Point(265, 157);
            this.bot2.Name = "bot2";
            this.bot2.Size = new System.Drawing.Size(19, 20);
            this.bot2.TabIndex = 25;
            this.bot2.Text = "0";
            this.bot2.Visible = false;
            // 
            // bot3
            // 
            this.bot3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot3.AutoSize = true;
            this.bot3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot3.Location = new System.Drawing.Point(312, 157);
            this.bot3.Name = "bot3";
            this.bot3.Size = new System.Drawing.Size(19, 20);
            this.bot3.TabIndex = 26;
            this.bot3.Text = "0";
            this.bot3.Visible = false;
            // 
            // bot4
            // 
            this.bot4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot4.AutoSize = true;
            this.bot4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot4.Location = new System.Drawing.Point(359, 157);
            this.bot4.Name = "bot4";
            this.bot4.Size = new System.Drawing.Size(19, 20);
            this.bot4.TabIndex = 27;
            this.bot4.Text = "0";
            this.bot4.Visible = false;
            // 
            // bot5
            // 
            this.bot5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot5.AutoSize = true;
            this.bot5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot5.Location = new System.Drawing.Point(406, 157);
            this.bot5.Name = "bot5";
            this.bot5.Size = new System.Drawing.Size(19, 20);
            this.bot5.TabIndex = 28;
            this.bot5.Text = "0";
            this.bot5.Visible = false;
            // 
            // bot6
            // 
            this.bot6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot6.AutoSize = true;
            this.bot6.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot6.Location = new System.Drawing.Point(453, 157);
            this.bot6.Name = "bot6";
            this.bot6.Size = new System.Drawing.Size(19, 20);
            this.bot6.TabIndex = 29;
            this.bot6.Text = "0";
            this.bot6.Visible = false;
            // 
            // bot7
            // 
            this.bot7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot7.AutoSize = true;
            this.bot7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot7.Location = new System.Drawing.Point(500, 157);
            this.bot7.Name = "bot7";
            this.bot7.Size = new System.Drawing.Size(19, 20);
            this.bot7.TabIndex = 30;
            this.bot7.Text = "0";
            this.bot7.Visible = false;
            // 
            // bot8
            // 
            this.bot8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot8.AutoSize = true;
            this.bot8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot8.Location = new System.Drawing.Point(547, 157);
            this.bot8.Name = "bot8";
            this.bot8.Size = new System.Drawing.Size(19, 20);
            this.bot8.TabIndex = 31;
            this.bot8.Text = "0";
            this.bot8.Visible = false;
            // 
            // bot9
            // 
            this.bot9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bot9.AutoSize = true;
            this.bot9.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot9.Location = new System.Drawing.Point(594, 157);
            this.bot9.Name = "bot9";
            this.bot9.Size = new System.Drawing.Size(19, 20);
            this.bot9.TabIndex = 32;
            this.bot9.Text = "0";
            this.bot9.Visible = false;
            // 
            // topR
            // 
            this.topR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topR.AutoSize = true;
            this.topR.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topR.Location = new System.Drawing.Point(641, 82);
            this.topR.Name = "topR";
            this.topR.Size = new System.Drawing.Size(19, 20);
            this.topR.TabIndex = 33;
            this.topR.Text = "0";
            // 
            // botR
            // 
            this.botR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botR.AutoSize = true;
            this.botR.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botR.Location = new System.Drawing.Point(641, 157);
            this.botR.Name = "botR";
            this.botR.Size = new System.Drawing.Size(19, 20);
            this.botR.TabIndex = 34;
            this.botR.Text = "0";
            // 
            // topH
            // 
            this.topH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topH.AutoSize = true;
            this.topH.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topH.Location = new System.Drawing.Point(688, 82);
            this.topH.Name = "topH";
            this.topH.Size = new System.Drawing.Size(19, 20);
            this.topH.TabIndex = 35;
            this.topH.Text = "0";
            // 
            // botH
            // 
            this.botH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botH.AutoSize = true;
            this.botH.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botH.Location = new System.Drawing.Point(688, 157);
            this.botH.Name = "botH";
            this.botH.Size = new System.Drawing.Size(19, 20);
            this.botH.TabIndex = 36;
            this.botH.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.loadedIndicator);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.recordIndicator);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.mainButtonLeft);
            this.panel1.Controls.Add(this.mainButtonR);
            this.panel1.Location = new System.Drawing.Point(687, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 100);
            this.panel1.TabIndex = 5;
            // 
            // loadedIndicator
            // 
            this.loadedIndicator.AutoSize = true;
            this.loadedIndicator.Location = new System.Drawing.Point(3, 29);
            this.loadedIndicator.Name = "loadedIndicator";
            this.loadedIndicator.Size = new System.Drawing.Size(61, 13);
            this.loadedIndicator.TabIndex = 7;
            this.loadedIndicator.Text = "File loaded!";
            this.loadedIndicator.Visible = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(0, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Load Past Games...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // recordIndicator
            // 
            this.recordIndicator.AutoSize = true;
            this.recordIndicator.Location = new System.Drawing.Point(182, 29);
            this.recordIndicator.Name = "recordIndicator";
            this.recordIndicator.Size = new System.Drawing.Size(97, 13);
            this.recordIndicator.TabIndex = 5;
            this.recordIndicator.Text = "Waiting to record...";
            this.recordIndicator.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(182, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start Recording Games...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 395);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liveGameTable);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Blaseball Visualizer 🥜";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.liveGameTable.ResumeLayout(false);
            this.liveGameTable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button mainButtonLeft;
        private System.Windows.Forms.Button mainButtonR;
        private System.Windows.Forms.TableLayoutPanel liveGameTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelH;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label errorTop;
        private System.Windows.Forms.Label errorBot;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label liveGameAwayName;
        private System.Windows.Forms.Label liveGameHomeName;
        private System.Windows.Forms.Label top1;
        private System.Windows.Forms.Label top2;
        private System.Windows.Forms.Label top3;
        private System.Windows.Forms.Label top4;
        private System.Windows.Forms.Label top5;
        private System.Windows.Forms.Label top6;
        private System.Windows.Forms.Label top7;
        private System.Windows.Forms.Label top8;
        private System.Windows.Forms.Label top9;
        private System.Windows.Forms.Label bot1;
        private System.Windows.Forms.Label bot2;
        private System.Windows.Forms.Label bot3;
        private System.Windows.Forms.Label bot4;
        private System.Windows.Forms.Label bot5;
        private System.Windows.Forms.Label bot6;
        private System.Windows.Forms.Label bot7;
        private System.Windows.Forms.Label bot8;
        private System.Windows.Forms.Label bot9;
        private System.Windows.Forms.Label topR;
        private System.Windows.Forms.Label botR;
        private System.Windows.Forms.Label topH;
        private System.Windows.Forms.Label botH;
        private System.Windows.Forms.Label liveGameTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label recordIndicator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label loadedIndicator;
    }
}

