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
            this.dpickIni = new System.Windows.Forms.DateTimePicker();
            this.dpickFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFiltrado = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMesAct
            // 
            this.btnMesAct.Location = new System.Drawing.Point(419, 166);
            this.btnMesAct.Name = "btnMesAct";
            this.btnMesAct.Size = new System.Drawing.Size(87, 55);
            this.btnMesAct.TabIndex = 0;
            this.btnMesAct.Text = "Mes Corriente";
            this.btnMesAct.UseVisualStyleBackColor = true;
            this.btnMesAct.Click += new System.EventHandler(this.btnMesAct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(194, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 86);
            this.label1.TabIndex = 1;
            this.label1.Text = "Control de Viajes";
            // 
            // dpickIni
            // 
            this.dpickIni.Location = new System.Drawing.Point(220, 401);
            this.dpickIni.Name = "dpickIni";
            this.dpickIni.Size = new System.Drawing.Size(200, 20);
            this.dpickIni.TabIndex = 2;
            // 
            // dpickFin
            // 
            this.dpickFin.Location = new System.Drawing.Point(514, 401);
            this.dpickFin.Name = "dpickFin";
            this.dpickFin.Size = new System.Drawing.Size(200, 20);
            this.dpickFin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(279, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Desde:";
            // 
            // btnFiltrado
            // 
            this.btnFiltrado.Location = new System.Drawing.Point(718, 479);
            this.btnFiltrado.Name = "btnFiltrado";
            this.btnFiltrado.Size = new System.Drawing.Size(176, 23);
            this.btnFiltrado.TabIndex = 6;
            this.btnFiltrado.Text = "Mostrar Resultados";
            this.btnFiltrado.UseVisualStyleBackColor = true;
            this.btnFiltrado.Click += new System.EventHandler(this.btnFiltrado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(12, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Filtra los viajes por mes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(586, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hasta:";
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(919, 514);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFiltrado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpickFin);
            this.Controls.Add(this.dpickIni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMesAct);
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio  -  Control de Viajes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMesAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dpickIni;
        private System.Windows.Forms.DateTimePicker dpickFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

