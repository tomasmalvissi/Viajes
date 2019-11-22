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
            this.btnDel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Nirmala UI", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblMes.Location = new System.Drawing.Point(12, 9);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(146, 68);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "label";
            // 
            // btnAgViaje
            // 
            this.btnAgViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgViaje.Location = new System.Drawing.Point(713, 13);
            this.btnAgViaje.Name = "btnAgViaje";
            this.btnAgViaje.Size = new System.Drawing.Size(75, 44);
            this.btnAgViaje.TabIndex = 1;
            this.btnAgViaje.Text = "+";
            this.btnAgViaje.UseVisualStyleBackColor = true;
            // 
            // btnCloseMes
            // 
            this.btnCloseMes.Location = new System.Drawing.Point(360, 410);
            this.btnCloseMes.Name = "btnCloseMes";
            this.btnCloseMes.Size = new System.Drawing.Size(83, 28);
            this.btnCloseMes.TabIndex = 2;
            this.btnCloseMes.Text = "Cerrar Mes";
            this.btnCloseMes.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(713, 72);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Borrar";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(336, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "AD 533 TA";
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCloseMes);
            this.Controls.Add(this.btnAgViaje);
            this.Controls.Add(this.lblMes);
            this.MaximizeBox = false;
            this.Name = "Tabla";
            this.Text = "Control de Viajes ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnAgViaje;
        private System.Windows.Forms.Button btnCloseMes;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label label1;
    }
}