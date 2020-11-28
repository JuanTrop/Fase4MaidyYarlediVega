namespace Fase4MaidyYarlediVega
{
    partial class Escenario1
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
            this.lblRecorrido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gráficaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recorridosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postordenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecorrido
            // 
            this.lblRecorrido.AutoSize = true;
            this.lblRecorrido.Location = new System.Drawing.Point(12, 375);
            this.lblRecorrido.Name = "lblRecorrido";
            this.lblRecorrido.Size = new System.Drawing.Size(53, 13);
            this.lblRecorrido.TabIndex = 1;
            this.lblRecorrido.Text = "Recorrido";
            this.lblRecorrido.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 38);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gráficaToolStripMenuItem,
            this.recorridosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gráficaToolStripMenuItem
            // 
            this.gráficaToolStripMenuItem.Name = "gráficaToolStripMenuItem";
            this.gráficaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.gráficaToolStripMenuItem.Text = "Gráfica";
            this.gráficaToolStripMenuItem.Click += new System.EventHandler(this.gráficaToolStripMenuItem_Click_1);
            // 
            // recorridosToolStripMenuItem
            // 
            this.recorridosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inordenToolStripMenuItem,
            this.preordenToolStripMenuItem,
            this.postordenToolStripMenuItem});
            this.recorridosToolStripMenuItem.Name = "recorridosToolStripMenuItem";
            this.recorridosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.recorridosToolStripMenuItem.Text = "Recorridos";
            // 
            // inordenToolStripMenuItem
            // 
            this.inordenToolStripMenuItem.Name = "inordenToolStripMenuItem";
            this.inordenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inordenToolStripMenuItem.Text = "Inorden";
            this.inordenToolStripMenuItem.Click += new System.EventHandler(this.inordenToolStripMenuItem_Click_1);
            // 
            // preordenToolStripMenuItem
            // 
            this.preordenToolStripMenuItem.Name = "preordenToolStripMenuItem";
            this.preordenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preordenToolStripMenuItem.Text = "Preorden";
            this.preordenToolStripMenuItem.Click += new System.EventHandler(this.preordenToolStripMenuItem_Click_1);
            // 
            // postordenToolStripMenuItem
            // 
            this.postordenToolStripMenuItem.Name = "postordenToolStripMenuItem";
            this.postordenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.postordenToolStripMenuItem.Text = "Postorden";
            this.postordenToolStripMenuItem.Click += new System.EventHandler(this.postordenToolStripMenuItem_Click_1);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Escenario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(973, 425);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRecorrido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Escenario1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESCENARIO1";
            this.Load += new System.EventHandler(this.Escenario1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Escenario1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Label lblRecorrido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gráficaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recorridosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postordenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}