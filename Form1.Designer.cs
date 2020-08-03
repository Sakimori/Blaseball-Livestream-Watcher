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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pastGameTable = new System.Windows.Forms.TableLayoutPanel();
            this.pastGameAway = new System.Windows.Forms.Label();
            this.pastGameHome = new System.Windows.Forms.Label();
            this.pastAwayScore = new System.Windows.Forms.Label();
            this.pastHomeScore = new System.Windows.Forms.Label();
            this.liveGameTable.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pastGameTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 65);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(423, 148);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // mainButtonLeft
            // 
            this.mainButtonLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mainButtonLeft.Location = new System.Drawing.Point(0, 45);
            this.mainButtonLeft.Name = "mainButtonLeft";
            this.mainButtonLeft.Size = new System.Drawing.Size(165, 23);
            this.mainButtonLeft.TabIndex = 1;
            this.mainButtonLeft.Text = "Load Last Game";
            this.mainButtonLeft.UseVisualStyleBackColor = true;
            this.mainButtonLeft.Click += new System.EventHandler(this.mainButtonLeft_Click);
            // 
            // mainButtonR
            // 
            this.mainButtonR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mainButtonR.Location = new System.Drawing.Point(182, 45);
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
            this.liveGameTable.Controls.Add(this.label1, 1, 0);
            this.liveGameTable.Controls.Add(this.label2, 2, 0);
            this.liveGameTable.Controls.Add(this.label3, 3, 0);
            this.liveGameTable.Controls.Add(this.label4, 4, 0);
            this.liveGameTable.Controls.Add(this.label5, 5, 0);
            this.liveGameTable.Controls.Add(this.label6, 6, 0);
            this.liveGameTable.Controls.Add(this.label7, 7, 0);
            this.liveGameTable.Controls.Add(this.label8, 8, 0);
            this.liveGameTable.Controls.Add(this.label9, 9, 0);
            this.liveGameTable.Controls.Add(this.label10, 10, 0);
            this.liveGameTable.Controls.Add(this.label11, 11, 0);
            this.liveGameTable.Controls.Add(this.label12, 12, 0);
            this.liveGameTable.Controls.Add(this.label13, 12, 1);
            this.liveGameTable.Controls.Add(this.label14, 12, 2);
            this.liveGameTable.Cursor = System.Windows.Forms.Cursors.Cross;
            this.liveGameTable.Location = new System.Drawing.Point(13, 231);
            this.liveGameTable.Name = "liveGameTable";
            this.liveGameTable.RowCount = 3;
            this.liveGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.liveGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.liveGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.liveGameTable.Size = new System.Drawing.Size(776, 206);
            this.liveGameTable.TabIndex = 4;
            this.liveGameTable.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(358, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(453, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "6";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "7";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(546, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "8";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(594, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "9";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(641, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "R";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(687, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "H";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(738, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "#";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(731, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "NO";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(731, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "NO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mainButtonLeft);
            this.panel1.Controls.Add(this.mainButtonR);
            this.panel1.Location = new System.Drawing.Point(441, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 100);
            this.panel1.TabIndex = 5;
            // 
            // pastGameTable
            // 
            this.pastGameTable.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pastGameTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.pastGameTable.ColumnCount = 2;
            this.pastGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.05489F));
            this.pastGameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.94511F));
            this.pastGameTable.Controls.Add(this.pastHomeScore, 1, 1);
            this.pastGameTable.Controls.Add(this.pastAwayScore, 1, 0);
            this.pastGameTable.Controls.Add(this.pastGameAway, 0, 0);
            this.pastGameTable.Controls.Add(this.pastGameHome, 0, 1);
            this.pastGameTable.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pastGameTable.Location = new System.Drawing.Point(13, 232);
            this.pastGameTable.Name = "pastGameTable";
            this.pastGameTable.RowCount = 2;
            this.pastGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pastGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pastGameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pastGameTable.Size = new System.Drawing.Size(422, 206);
            this.pastGameTable.TabIndex = 6;
            this.pastGameTable.Visible = false;
            // 
            // pastGameAway
            // 
            this.pastGameAway.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pastGameAway.AutoSize = true;
            this.pastGameAway.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastGameAway.Location = new System.Drawing.Point(132, 34);
            this.pastGameAway.Name = "pastGameAway";
            this.pastGameAway.Size = new System.Drawing.Size(85, 36);
            this.pastGameAway.TabIndex = 0;
            this.pastGameAway.Text = "Away";
            // 
            // pastGameHome
            // 
            this.pastGameHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pastGameHome.AutoSize = true;
            this.pastGameHome.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastGameHome.Location = new System.Drawing.Point(131, 135);
            this.pastGameHome.Name = "pastGameHome";
            this.pastGameHome.Size = new System.Drawing.Size(86, 36);
            this.pastGameHome.TabIndex = 1;
            this.pastGameHome.Text = "Home";
            // 
            // pastAwayScore
            // 
            this.pastAwayScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pastAwayScore.AutoSize = true;
            this.pastAwayScore.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastAwayScore.Location = new System.Drawing.Point(368, 34);
            this.pastAwayScore.Name = "pastAwayScore";
            this.pastAwayScore.Size = new System.Drawing.Size(32, 36);
            this.pastAwayScore.TabIndex = 2;
            this.pastAwayScore.Text = "0";
            this.pastAwayScore.Visible = false;
            // 
            // pastHomeScore
            // 
            this.pastHomeScore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pastHomeScore.AutoSize = true;
            this.pastHomeScore.Font = new System.Drawing.Font("Ink Free", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastHomeScore.Location = new System.Drawing.Point(368, 135);
            this.pastHomeScore.Name = "pastHomeScore";
            this.pastHomeScore.Size = new System.Drawing.Size(32, 36);
            this.pastHomeScore.TabIndex = 3;
            this.pastHomeScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pastGameTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.liveGameTable);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Blaseball Visualizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.liveGameTable.ResumeLayout(false);
            this.liveGameTable.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pastGameTable.ResumeLayout(false);
            this.pastGameTable.PerformLayout();
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
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel pastGameTable;
        private System.Windows.Forms.Label pastGameAway;
        private System.Windows.Forms.Label pastGameHome;
        private System.Windows.Forms.Label pastHomeScore;
        private System.Windows.Forms.Label pastAwayScore;
    }
}

