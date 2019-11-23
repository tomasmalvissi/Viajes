namespace ViajesController.Formularios
{
    partial class Tabla
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
            this.lblMes = new System.Windows.Forms.Label();
            this.btnAgViaje = new System.Windows.Forms.Button();
            this.btnCloseMes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnMarcar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Nirmala UI", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMes.Location = new System.Drawing.Point(2, 2);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(146, 68);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "label";
            // 
            // btnAgViaje
            // 
            this.btnAgViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnAgViaje.Location = new System.Drawing.Point(832, 7);
            this.btnAgViaje.Name = "btnAgViaje";
            this.btnAgViaje.Size = new System.Drawing.Size(75, 32);
            this.btnAgViaje.TabIndex = 1;
            this.btnAgViaje.Text = "+";
            this.btnAgViaje.UseVisualStyleBackColor = true;
            this.btnAgViaje.Click += new System.EventHandler(this.btnAgViaje_Click);
            // 
            // btnCloseMes
            // 
            this.btnCloseMes.Location = new System.Drawing.Point(386, 474);
            this.btnCloseMes.Name = "btnCloseMes";
            this.btnCloseMes.Size = new System.Drawing.Size(83, 28);
            this.btnCloseMes.TabIndex = 2;
            this.btnCloseMes.Text = "Cerrar Mes";
            this.btnCloseMes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD 533 TA";
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(751, 7);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(75, 23);
            this.btnModif.TabIndex = 5;
            this.btnModif.Text = "Modificar";
            this.btnModif.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(832, 47);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(670, 7);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 7;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(902, 381);
            this.dataGridView1.TabIndex = 8;
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(919, 514);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCloseMes);
            this.Controls.Add(this.btnAgViaje);
            this.Controls.Add(this.lblMes);
            this.MaximizeBox = false;
            this.Name = "Tabla";
            this.Text = "Control de Viajes ";
            this.Load += new System.EventHandler(this.Tabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnCloseMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgViaje;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}