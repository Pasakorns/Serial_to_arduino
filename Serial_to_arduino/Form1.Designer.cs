namespace Serial_to_arduino
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
            this.btnON = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.btnON.BackColor = System.Drawing.Color.Lime;
            this.btnON.Location = new System.Drawing.Point(88, 161);
            this.btnON.Name = "button1";
            this.btnON.Size = new System.Drawing.Size(83, 84);
            this.btnON.TabIndex = 0;
            this.btnON.Text = "ON LED";
            this.btnON.UseVisualStyleBackColor = false;
            this.btnON.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(307, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "OFF LED";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(539, 397);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnON);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ON;
        private System.Windows.Forms.Button btn_OFF;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button button2;
    }
}