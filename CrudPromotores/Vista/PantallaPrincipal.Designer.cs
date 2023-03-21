namespace CrudPromotores
{
    partial class PantallaPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnAgregarProspecto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIniciarSesion);
            this.panel1.Controls.Add(this.btnAgregarProspecto);
            this.panel1.Location = new System.Drawing.Point(5, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 148);
            this.panel1.TabIndex = 0;
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(147, 40);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(80, 50);
            this.btnIniciarSesion.TabIndex = 2;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnAgregarProspecto
            // 
            this.btnAgregarProspecto.Location = new System.Drawing.Point(27, 40);
            this.btnAgregarProspecto.Name = "btnAgregarProspecto";
            this.btnAgregarProspecto.Size = new System.Drawing.Size(93, 50);
            this.btnAgregarProspecto.TabIndex = 0;
            this.btnAgregarProspecto.Text = "Agregar Prospecto";
            this.btnAgregarProspecto.UseVisualStyleBackColor = true;
            this.btnAgregarProspecto.Click += new System.EventHandler(this.btnAgregarProspecto_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 158);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaPrincipal";
            this.Text = "Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnAgregarProspecto;
    }
}