namespace Blaseball_Livestream
{
    partial class Day_Selector
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
            this.listBoxSelector = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSelector
            // 
            this.listBoxSelector.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSelector.FormattingEnabled = true;
            this.listBoxSelector.ItemHeight = 16;
            this.listBoxSelector.Location = new System.Drawing.Point(12, 12);
            this.listBoxSelector.Name = "listBoxSelector";
            this.listBoxSelector.Size = new System.Drawing.Size(505, 228);
            this.listBoxSelector.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(224, 256);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // Day_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 291);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.listBoxSelector);
            this.Name = "Day_Selector";
            this.Text = "Pick Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelector;
        private System.Windows.Forms.Button OK;
    }
}