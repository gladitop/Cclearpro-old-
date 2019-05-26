namespace Cclearpro
{
    partial class processnewkill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(processnewkill));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btkillprocessnew = new System.Windows.Forms.Button();
            this.checkkillprocess = new System.Windows.Forms.CheckBox();
            this.processget = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox2.Location = new System.Drawing.Point(3, 16);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(627, 356);
            this.listBox2.TabIndex = 1;
            // 
            // btkillprocessnew
            // 
            this.btkillprocessnew.Location = new System.Drawing.Point(361, 382);
            this.btkillprocessnew.Name = "btkillprocessnew";
            this.btkillprocessnew.Size = new System.Drawing.Size(128, 38);
            this.btkillprocessnew.TabIndex = 4;
            this.btkillprocessnew.Text = "убить";
            this.btkillprocessnew.UseVisualStyleBackColor = true;
            this.btkillprocessnew.Click += new System.EventHandler(this.btkillprocessnew_Click);
            // 
            // checkkillprocess
            // 
            this.checkkillprocess.AutoSize = true;
            this.checkkillprocess.Checked = true;
            this.checkkillprocess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkkillprocess.Location = new System.Drawing.Point(91, 394);
            this.checkkillprocess.Name = "checkkillprocess";
            this.checkkillprocess.Size = new System.Drawing.Size(87, 17);
            this.checkkillprocess.TabIndex = 6;
            this.checkkillprocess.Text = "Обновлять?";
            this.checkkillprocess.UseVisualStyleBackColor = true;
            // 
            // processget
            // 
            this.processget.Tick += new System.EventHandler(this.processget_Tick);
            // 
            // processnewkill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 428);
            this.Controls.Add(this.checkkillprocess);
            this.Controls.Add(this.btkillprocessnew);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "processnewkill";
            this.Text = "Диспечер задач (новый режим)";
            this.Load += new System.EventHandler(this.processstartingkill_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btkillprocessnew;
        private System.Windows.Forms.CheckBox checkkillprocess;
        private System.Windows.Forms.Timer processget;
    }
}