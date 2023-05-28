namespace _2D_GAME
{
    partial class StartForm
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
            this.starbtn = new System.Windows.Forms.Label();
            this.exitbtn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // starbtn
            // 
            this.starbtn.AutoSize = true;
            this.starbtn.Font = new System.Drawing.Font("Marcellus SC", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starbtn.Location = new System.Drawing.Point(353, 160);
            this.starbtn.Name = "starbtn";
            this.starbtn.Size = new System.Drawing.Size(160, 66);
            this.starbtn.TabIndex = 0;
            this.starbtn.Tag = "startbtn";
            this.starbtn.Text = "Start";
            this.starbtn.Click += new System.EventHandler(this.starbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.AutoSize = true;
            this.exitbtn.Font = new System.Drawing.Font("Marcellus SC", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(366, 268);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(133, 71);
            this.exitbtn.TabIndex = 1;
            this.exitbtn.Tag = "exitbtn";
            this.exitbtn.Text = "Exit";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_2D_GAME.Properties.Resources.darkPurple;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.starbtn);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label starbtn;
        private System.Windows.Forms.Label exitbtn;
    }
}