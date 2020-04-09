namespace clinic_project
{
    partial class Avaliable_Timee
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
            this.LB1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 16;
            this.LB1.Location = new System.Drawing.Point(186, 73);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(574, 420);
            this.LB1.TabIndex = 0;
            // 
            // Avaliable_Timee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 559);
            this.Controls.Add(this.LB1);
            this.Name = "Avaliable_Timee";
            this.Text = "Avaliable_Timee";
            this.Load += new System.EventHandler(this.Avaliable_Timee_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LB1;
    }
}