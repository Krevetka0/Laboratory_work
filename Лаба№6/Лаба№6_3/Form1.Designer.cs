namespace Лаба_6_3
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
            this.components = new System.ComponentModel.Container();
            this.TimerChangeColor = new System.Windows.Forms.Timer(this.components);
            this.TimerChangeFont = new System.Windows.Forms.Timer(this.components);
            this.buttoStartAnimation = new System.Windows.Forms.Button();
            this.buttonStopAnimation = new System.Windows.Forms.Button();
            this.panelGraf = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rightStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bothStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerChangeColor
            // 
            this.TimerChangeColor.Tick += new System.EventHandler(this.TimerChangeColor_Tick);
            // 
            // TimerChangeFont
            // 
            this.TimerChangeFont.Tick += new System.EventHandler(this.TimerChangeFont_Tick);
            // 
            // buttoStartAnimation
            // 
            this.buttoStartAnimation.Location = new System.Drawing.Point(26, 27);
            this.buttoStartAnimation.Name = "buttoStartAnimation";
            this.buttoStartAnimation.Size = new System.Drawing.Size(99, 38);
            this.buttoStartAnimation.TabIndex = 1;
            this.buttoStartAnimation.Text = "Начать";
            this.buttoStartAnimation.UseVisualStyleBackColor = true;
            this.buttoStartAnimation.Click += new System.EventHandler(this.buttoStartAnimation_Click);
            // 
            // buttonStopAnimation
            // 
            this.buttonStopAnimation.Location = new System.Drawing.Point(131, 27);
            this.buttonStopAnimation.Name = "buttonStopAnimation";
            this.buttonStopAnimation.Size = new System.Drawing.Size(99, 38);
            this.buttonStopAnimation.TabIndex = 2;
            this.buttonStopAnimation.Text = "Стоп";
            this.buttonStopAnimation.UseVisualStyleBackColor = true;
            this.buttonStopAnimation.Click += new System.EventHandler(this.buttonStopAnimation_Click);
            // 
            // panelGraf
            // 
            this.panelGraf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelGraf.Location = new System.Drawing.Point(131, 152);
            this.panelGraf.Name = "panelGraf";
            this.panelGraf.Size = new System.Drawing.Size(533, 353);
            this.panelGraf.TabIndex = 3;
            this.panelGraf.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraf_Paint);
            this.panelGraf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelGraf_MouseDoubleClick);
            this.panelGraf.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelGraf_MouseDown);
            this.panelGraf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelGraf_MouseMove);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightStripMenuItem,
            this.leftStripMenuItem,
            this.bothStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(280, 76);
            // 
            // rightStripMenuItem
            // 
            this.rightStripMenuItem.Name = "rightStripMenuItem";
            this.rightStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.rightStripMenuItem.Text = "Поменять цвет правой зоны";
            this.rightStripMenuItem.Click += new System.EventHandler(this.rightStripMenuItem_Click);
            // 
            // leftStripMenuItem
            // 
            this.leftStripMenuItem.Name = "leftStripMenuItem";
            this.leftStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.leftStripMenuItem.Text = "Поменять цвет левой зоны";
            this.leftStripMenuItem.Click += new System.EventHandler(this.leftStripMenuItem_Click);
            // 
            // bothStripMenuItem
            // 
            this.bothStripMenuItem.Name = "bothStripMenuItem";
            this.bothStripMenuItem.Size = new System.Drawing.Size(279, 24);
            this.bothStripMenuItem.Text = "Поменять цвет обеих зон";
            this.bothStripMenuItem.Click += new System.EventHandler(this.bothStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelGraf);
            this.Controls.Add(this.buttonStopAnimation);
            this.Controls.Add(this.buttoStartAnimation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer TimerChangeColor;
        private System.Windows.Forms.Timer TimerChangeFont;
        private System.Windows.Forms.Button buttoStartAnimation;
        private System.Windows.Forms.Button buttonStopAnimation;
        private System.Windows.Forms.FlowLayoutPanel panelGraf;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rightStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bothStripMenuItem;
    }
}

