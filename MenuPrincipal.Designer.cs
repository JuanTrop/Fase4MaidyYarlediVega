namespace Fase4MaidyYarlediVega
{
    partial class MenuPrincipal
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
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEscenario2 = new System.Windows.Forms.Button();
            this.btnEscenario1 = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            this.panelOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.lblSubTitulo);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Location = new System.Drawing.Point(196, 12);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(323, 89);
            this.panelTitulo.TabIndex = 0;
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Location = new System.Drawing.Point(80, 51);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(173, 13);
            this.lblSubTitulo.TabIndex = 1;
            this.lblSubTitulo.Text = "DISEÑO DE ARBOLES BINARIOS";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(51, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(224, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ESTRUCTURA DE DATOS";
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnSalir);
            this.panelOpciones.Controls.Add(this.btnEscenario2);
            this.panelOpciones.Controls.Add(this.btnEscenario1);
            this.panelOpciones.Controls.Add(this.lblTitulo1);
            this.panelOpciones.Location = new System.Drawing.Point(38, 149);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(639, 112);
            this.panelOpciones.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(484, 48);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 34);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEscenario2
            // 
            this.btnEscenario2.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEscenario2.Location = new System.Drawing.Point(273, 48);
            this.btnEscenario2.Name = "btnEscenario2";
            this.btnEscenario2.Size = new System.Drawing.Size(99, 34);
            this.btnEscenario2.TabIndex = 2;
            this.btnEscenario2.Text = "ESCENARIO 2";
            this.btnEscenario2.UseVisualStyleBackColor = false;
            this.btnEscenario2.Click += new System.EventHandler(this.btnEscenario2_Click);
            // 
            // btnEscenario1
            // 
            this.btnEscenario1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEscenario1.Location = new System.Drawing.Point(61, 48);
            this.btnEscenario1.Name = "btnEscenario1";
            this.btnEscenario1.Size = new System.Drawing.Size(99, 34);
            this.btnEscenario1.TabIndex = 1;
            this.btnEscenario1.Text = "ESCENARIO 1";
            this.btnEscenario1.UseVisualStyleBackColor = false;
            this.btnEscenario1.Click += new System.EventHandler(this.btnEscenario1_Click);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTitulo1.Location = new System.Drawing.Point(43, 13);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(555, 13);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "BIENVENIDO AL MENU PRINCIPAL, SELECCIONE A QUE ESCENARIO QUIERE ACCEDER O SI DESE" +
    "A SALIR ";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(718, 310);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.Name = "MenuPrincipal";
            this.Text = "Menú";
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEscenario2;
        private System.Windows.Forms.Button btnEscenario1;
        private System.Windows.Forms.Label lblTitulo1;
    }
}