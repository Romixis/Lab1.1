
namespace dihotomia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.рассчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.labmin = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.tbFX = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // рассчитатьToolStripMenuItem
            // 
            this.рассчитатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.рассчитатьToolStripMenuItem, "рассчитатьToolStripMenuItem");
            this.рассчитатьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.рассчитатьToolStripMenuItem.Name = "рассчитатьToolStripMenuItem";
            this.рассчитатьToolStripMenuItem.Click += new System.EventHandler(this.рассчитатьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.очиститьToolStripMenuItem, "очиститьToolStripMenuItem");
            this.очиститьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рассчитатьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.закрытьToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.закрытьToolStripMenuItem, "закрытьToolStripMenuItem");
            this.закрытьToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.White;
            this.zedGraphControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.zedGraphControl1, "zedGraphControl1");
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // labmin
            // 
            resources.ApplyResources(this.labmin, "labmin");
            this.labmin.ForeColor = System.Drawing.Color.Black;
            this.labmin.Name = "labmin";
            // 
            // min
            // 
            resources.ApplyResources(this.min, "min");
            this.min.ForeColor = System.Drawing.Color.Black;
            this.min.Name = "min";
            // 
            // tbFX
            // 
            this.tbFX.BackColor = System.Drawing.Color.Silver;
            this.tbFX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbFX, "tbFX");
            this.tbFX.ForeColor = System.Drawing.Color.Black;
            this.tbFX.Name = "tbFX";
            // 
            // tbB
            // 
            this.tbB.BackColor = System.Drawing.Color.Silver;
            this.tbB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbB, "tbB");
            this.tbB.ForeColor = System.Drawing.Color.Black;
            this.tbB.Name = "tbB";
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbB_KeyPress);
            // 
            // tbE
            // 
            this.tbE.BackColor = System.Drawing.Color.Silver;
            this.tbE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbE, "tbE");
            this.tbE.ForeColor = System.Drawing.Color.Black;
            this.tbE.Name = "tbE";
            this.tbE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbE_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Name = "label6";
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.Color.Silver;
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxA, "textBoxA");
            this.textBoxA.ForeColor = System.Drawing.Color.Black;
            this.textBoxA.Name = "textBoxA";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbE);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbFX);
            this.Controls.Add(this.min);
            this.Controls.Add(this.labmin);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbFX;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label labmin;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рассчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxA;
    }
}

