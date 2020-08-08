namespace Blaseball_Livestream
{
    partial class Form2
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
            this.listBoxSeasons = new System.Windows.Forms.ListBox();
            this.SeasonAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSeasons
            // 
            this.listBoxSeasons.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSeasons.FormattingEnabled = true;
            this.listBoxSeasons.ItemHeight = 17;
            this.listBoxSeasons.Location = new System.Drawing.Point(13, 13);
            this.listBoxSeasons.Name = "listBoxSeasons";
            this.listBoxSeasons.Size = new System.Drawing.Size(589, 89);
            this.listBoxSeasons.TabIndex = 0;
            this.listBoxSeasons.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // SeasonAccept
            // 
            this.SeasonAccept.Location = new System.Drawing.Point(263, 131);
            this.SeasonAccept.Name = "SeasonAccept";
            this.SeasonAccept.Size = new System.Drawing.Size(75, 23);
            this.SeasonAccept.TabIndex = 3;
            this.SeasonAccept.Text = "OK";
            this.SeasonAccept.UseVisualStyleBackColor = true;
            this.SeasonAccept.Click += new System.EventHandler(this.SeasonAccept_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 166);
            this.Controls.Add(this.SeasonAccept);
            this.Controls.Add(this.listBoxSeasons);
            this.Name = "Form2";
            this.Text = "Time Range";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSeasons;
        private System.Windows.Forms.Button SeasonAccept;
    }
}