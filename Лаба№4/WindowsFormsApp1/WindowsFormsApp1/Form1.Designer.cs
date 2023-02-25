namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ColorMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Fontexm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.XtextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.slagtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(422, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorMenu,
            this.FontMenu,
            this.PrintMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ColorMenu
            // 
            this.ColorMenu.Name = "ColorMenu";
            this.ColorMenu.Size = new System.Drawing.Size(59, 24);
            this.ColorMenu.Text = "Color";
            this.ColorMenu.Click += new System.EventHandler(this.ColorMenu_Click);
            // 
            // FontMenu
            // 
            this.FontMenu.Name = "FontMenu";
            this.FontMenu.Size = new System.Drawing.Size(52, 24);
            this.FontMenu.Text = "Font";
            this.FontMenu.Click += new System.EventHandler(this.FontMenu_Click);
            // 
            // PrintMenu
            // 
            this.PrintMenu.Name = "PrintMenu";
            this.PrintMenu.Size = new System.Drawing.Size(53, 24);
            this.PrintMenu.Text = "Print";
            this.PrintMenu.Click += new System.EventHandler(this.PrintMenu_Click);
            // 
            // Fontexm
            // 
            this.Fontexm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fontexm.Location = new System.Drawing.Point(499, 54);
            this.Fontexm.Multiline = true;
            this.Fontexm.Name = "Fontexm";
            this.Fontexm.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Fontexm.Size = new System.Drawing.Size(487, 122);
            this.Fontexm.TabIndex = 2;
            this.Fontexm.Text = "Текст для изменения шрифта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "x =";
            // 
            // XtextBox
            // 
            this.XtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XtextBox.Location = new System.Drawing.Point(87, 249);
            this.XtextBox.Name = "XtextBox";
            this.XtextBox.Size = new System.Drawing.Size(106, 34);
            this.XtextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Кол-во слагаемых";
            // 
            // slagtxt
            // 
            this.slagtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slagtxt.Location = new System.Drawing.Point(232, 335);
            this.slagtxt.Name = "slagtxt";
            this.slagtxt.Size = new System.Drawing.Size(96, 34);
            this.slagtxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(664, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Результат";
            // 
            // res
            // 
            this.res.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.res.Location = new System.Drawing.Point(590, 306);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(315, 75);
            this.res.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(367, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 66);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1002, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slagtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.XtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Fontexm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ColorMenu;
        private System.Windows.Forms.ToolStripMenuItem FontMenu;
        private System.Windows.Forms.TextBox Fontexm;
        private System.Windows.Forms.ToolStripMenuItem PrintMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox XtextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox slagtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.Button button1;
    }
}

