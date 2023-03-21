namespace CrudPromotores
{
    partial class InicioSesion
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInicioSesion);
            this.panel1.Controls.Add(this.txtbPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtbUsuario);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 191);
            this.panel1.TabIndex = 0;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Location = new System.Drawing.Point(95, 129);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(104, 23);
            this.btnInicioSesion.TabIndex = 4;
            this.btnInicioSesion.Text = "Iniciar Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(144, 91);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(140, 20);
            this.txtbPassword.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(25, 94);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(115, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Ingresar la contraseña:";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.Location = new System.Drawing.Point(144, 68);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtbUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 68);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Ingresar el Usuario:";
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 201);
            this.Controls.Add(this.panel1);
            this.Name = "InicioSesion";
            this.Text = "Inicio Sesión";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicioSesion;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}