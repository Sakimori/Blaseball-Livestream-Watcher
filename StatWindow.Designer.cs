namespace Blaseball_Livestream
{
    partial class StatWindow
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
            this.teamStatPanel = new System.Windows.Forms.Panel();
            this.batterStatPanel = new System.Windows.Forms.Panel();
            this.pitcherStatPanel = new System.Windows.Forms.Panel();
            this.teamInfoPanel = new System.Windows.Forms.Panel();
            this.batterTable = new System.Windows.Forms.TableLayoutPanel();
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
            this.pitcherTable = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.batterStatPanel.SuspendLayout();
            this.pitcherStatPanel.SuspendLayout();
            this.batterTable.SuspendLayout();
            this.pitcherTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamStatPanel
            // 
            this.teamStatPanel.AutoScroll = true;
            this.teamStatPanel.BackColor = System.Drawing.SystemColors.Control;
            this.teamStatPanel.Location = new System.Drawing.Point(725, 14);
            this.teamStatPanel.Name = "teamStatPanel";
            this.teamStatPanel.Size = new System.Drawing.Size(558, 138);
            this.teamStatPanel.TabIndex = 0;
            // 
            // batterStatPanel
            // 
            this.batterStatPanel.AutoScroll = true;
            this.batterStatPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.batterStatPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.batterStatPanel.Controls.Add(this.batterTable);
            this.batterStatPanel.Location = new System.Drawing.Point(9, 156);
            this.batterStatPanel.Name = "batterStatPanel";
            this.batterStatPanel.Size = new System.Drawing.Size(708, 394);
            this.batterStatPanel.TabIndex = 1;
            // 
            // pitcherStatPanel
            // 
            this.pitcherStatPanel.AutoScroll = true;
            this.pitcherStatPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pitcherStatPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pitcherStatPanel.Controls.Add(this.pitcherTable);
            this.pitcherStatPanel.Location = new System.Drawing.Point(725, 156);
            this.pitcherStatPanel.Name = "pitcherStatPanel";
            this.pitcherStatPanel.Size = new System.Drawing.Size(558, 394);
            this.pitcherStatPanel.TabIndex = 4;
            this.pitcherStatPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.pitcherStatPanel_Paint);
            // 
            // teamInfoPanel
            // 
            this.teamInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teamInfoPanel.AutoScroll = true;
            this.teamInfoPanel.BackColor = System.Drawing.SystemColors.Control;
            this.teamInfoPanel.Location = new System.Drawing.Point(38, 14);
            this.teamInfoPanel.Name = "teamInfoPanel";
            this.teamInfoPanel.Size = new System.Drawing.Size(679, 138);
            this.teamInfoPanel.TabIndex = 1;
            this.teamInfoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.teamInfoPanel_Paint);
            // 
            // batterTable
            // 
            this.batterTable.AutoScroll = true;
            this.batterTable.AutoSize = true;
            this.batterTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.batterTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.batterTable.ColumnCount = 10;
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.batterTable.Controls.Add(this.label10, 9, 0);
            this.batterTable.Controls.Add(this.label9, 8, 0);
            this.batterTable.Controls.Add(this.label8, 7, 0);
            this.batterTable.Controls.Add(this.label7, 6, 0);
            this.batterTable.Controls.Add(this.label6, 5, 0);
            this.batterTable.Controls.Add(this.label5, 4, 0);
            this.batterTable.Controls.Add(this.label4, 3, 0);
            this.batterTable.Controls.Add(this.label3, 2, 0);
            this.batterTable.Controls.Add(this.label2, 1, 0);
            this.batterTable.Controls.Add(this.label1, 0, 0);
            this.batterTable.Location = new System.Drawing.Point(-2, 0);
            this.batterTable.Name = "batterTable";
            this.batterTable.RowCount = 1;
            this.batterTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.batterTable.Size = new System.Drawing.Size(706, 52);
            this.batterTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "AVG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "OBP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(317, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "SLG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "OPS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 50);
            this.label6.TabIndex = 5;
            this.label6.Text = "K";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(485, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 50);
            this.label7.TabIndex = 6;
            this.label7.Text = "W";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(541, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 50);
            this.label8.TabIndex = 7;
            this.label8.Text = "H";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(597, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 50);
            this.label9.TabIndex = 8;
            this.label9.Text = "HR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(653, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 50);
            this.label10.TabIndex = 9;
            this.label10.Text = "RBI";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pitcherTable
            // 
            this.pitcherTable.AutoScroll = true;
            this.pitcherTable.AutoSize = true;
            this.pitcherTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pitcherTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pitcherTable.ColumnCount = 8;
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.Controls.Add(this.label14, 6, 0);
            this.pitcherTable.Controls.Add(this.label15, 5, 0);
            this.pitcherTable.Controls.Add(this.label16, 4, 0);
            this.pitcherTable.Controls.Add(this.label17, 3, 0);
            this.pitcherTable.Controls.Add(this.label18, 2, 0);
            this.pitcherTable.Controls.Add(this.label19, 1, 0);
            this.pitcherTable.Controls.Add(this.label20, 0, 0);
            this.pitcherTable.Controls.Add(this.label11, 7, 0);
            this.pitcherTable.Location = new System.Drawing.Point(-2, 0);
            this.pitcherTable.Name = "pitcherTable";
            this.pitcherTable.RowCount = 1;
            this.pitcherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pitcherTable.Size = new System.Drawing.Size(549, 52);
            this.pitcherTable.TabIndex = 1;
            this.pitcherTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(450, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 50);
            this.label14.TabIndex = 6;
            this.label14.Text = "W";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(399, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 50);
            this.label15.TabIndex = 5;
            this.label15.Text = "WHIP";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(348, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 50);
            this.label16.TabIndex = 4;
            this.label16.Text = "K";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(297, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 50);
            this.label17.TabIndex = 3;
            this.label17.Text = "ERA";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(246, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(44, 50);
            this.label18.TabIndex = 2;
            this.label18.Text = "IP";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(195, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 50);
            this.label19.TabIndex = 1;
            this.label19.Text = "G";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(4, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(184, 50);
            this.label20.TabIndex = 0;
            this.label20.Text = "Name";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(501, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 50);
            this.label11.TabIndex = 7;
            this.label11.Text = "L";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 562);
            this.Controls.Add(this.teamInfoPanel);
            this.Controls.Add(this.pitcherStatPanel);
            this.Controls.Add(this.batterStatPanel);
            this.Controls.Add(this.teamStatPanel);
            this.Name = "StatWindow";
            this.Text = "StatWindow";
            this.Load += new System.EventHandler(this.StatWindow_Load);
            this.batterStatPanel.ResumeLayout(false);
            this.batterStatPanel.PerformLayout();
            this.pitcherStatPanel.ResumeLayout(false);
            this.pitcherStatPanel.PerformLayout();
            this.batterTable.ResumeLayout(false);
            this.batterTable.PerformLayout();
            this.pitcherTable.ResumeLayout(false);
            this.pitcherTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel teamStatPanel;
        private System.Windows.Forms.Panel batterStatPanel;
        private System.Windows.Forms.Panel pitcherStatPanel;
        private System.Windows.Forms.Panel teamInfoPanel;
        private System.Windows.Forms.TableLayoutPanel batterTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel pitcherTable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
    }
}