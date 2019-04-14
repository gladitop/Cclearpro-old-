namespace Cclearpro
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btclose = new System.Windows.Forms.Label();
            this.btmini = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.btsavename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(489, 184);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btmini);
            this.panel1.Controls.Add(this.btclose);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 26);
            this.panel1.TabIndex = 1;
            // 
            // btclose
            // 
            this.btclose.AutoSize = true;
            this.btclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btclose.Location = new System.Drawing.Point(778, 0);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(25, 24);
            this.btclose.TabIndex = 3;
            this.btclose.Text = "X";
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // btmini
            // 
            this.btmini.AutoSize = true;
            this.btmini.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btmini.Location = new System.Drawing.Point(751, -3);
            this.btmini.Name = "btmini";
            this.btmini.Size = new System.Drawing.Size(21, 24);
            this.btmini.TabIndex = 4;
            this.btmini.Text = "_";
            this.btmini.Click += new System.EventHandler(this.btmini_Click);
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbname.Location = new System.Drawing.Point(256, 223);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(260, 39);
            this.lbname.TabIndex = 2;
            this.lbname.Text = "Как вас зовут?";
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.Color.Gray;
            this.tbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbname.Location = new System.Drawing.Point(191, 285);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(372, 40);
            this.tbname.TabIndex = 3;
            this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
            // 
            // btsavename
            // 
            this.btsavename.BackColor = System.Drawing.Color.DimGray;
            this.btsavename.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btsavename.Location = new System.Drawing.Point(276, 363);
            this.btsavename.Name = "btsavename";
            this.btsavename.Size = new System.Drawing.Size(203, 57);
            this.btsavename.TabIndex = 4;
            this.btsavename.Text = "Вход";
            this.btsavename.UseVisualStyleBackColor = false;
            this.btsavename.Click += new System.EventHandler(this.btsavename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsavename);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Cclearpro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btclose;
        private System.Windows.Forms.Label btmini;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Button btsavename;
    }
}

