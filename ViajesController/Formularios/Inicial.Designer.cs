namespace ViajesController
{
    partial class Inicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMesAct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTarif = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMesAct
            // 
            this.btnMesAct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMesAct.FlatAppearance.BorderSize = 0;
            this.btnMesAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesAct.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesAct.ForeColor = System.Drawing.Color.White;
            this.btnMesAct.Location = new System.Drawing.Point(249, 183);
            this.btnMesAct.Name = "btnMesAct";
            this.btnMesAct.Size = new System.Drawing.Size(245, 39);
            this.btnMesAct.TabIndex = 0;
            this.btnMesAct.Text = "Iniciar";
            this.btnMesAct.UseVisualStyleBackColor = false;
            this.btnMesAct.Click += new System.EventHandler(this.btnMesAct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Viajes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 98);
            this.panel1.TabIndex = 9;
            // 
            // btnTarif
            // 
            this.btnTarif.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTarif.FlatAppearance.BorderSize = 0;
            this.btnTarif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarif.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarif.ForeColor = System.Drawing.Color.White;
            this.btnTarif.Location = new System.Drawing.Point(249, 244);
            this.btnTarif.Name = "btnTarif";
            this.btnTarif.Size = new System.Drawing.Size(245, 39);
            this.btnTarif.TabIndex = 10;
            this.btnTarif.Text = "Actualizar Tarifas";
            this.btnTarif.UseVisualStyleBackColor = false;
            this.btnTarif.Click += new System.EventHandler(this.btnTarif_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(733, 394);
            this.Controls.Add(this.btnTarif);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMesAct);
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio  -  Control de Viajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Inicial_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTarif;
    }
}

