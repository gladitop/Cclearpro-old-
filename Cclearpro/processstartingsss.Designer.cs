namespace Cclearpro
{
    partial class processstartingsss
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(processstartingsss));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btkillprocess = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(174, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // btkillprocess
            // 
            this.btkillprocess.Location = new System.Drawing.Point(97, 39);
            this.btkillprocess.Name = "btkillprocess";
            this.btkillprocess.Size = new System.Drawing.Size(128, 38);
            this.btkillprocess.TabIndex = 3;
            this.btkillprocess.Text = "убить";
            this.btkillprocess.UseVisualStyleBackColor = true;
            this.btkillprocess.Click += new System.EventHandler(this.btkillprocess_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // processstartingsss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 84);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btkillprocess);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "processstartingsss";
            this.Text = "processstartingsss";
            this.Load += new System.EventHandler(this.processstartingsss_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btkillprocess;
        private System.Windows.Forms.Timer timer1;
    }
}