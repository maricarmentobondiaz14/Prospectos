namespace CrudPromotores
{
    partial class VistaPromotor
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
            this.Promotores = new System.Windows.Forms.Panel();
            this.btnAgregarPromotor = new System.Windows.Forms.Button();
            this.btnEvaluacionProspecto = new System.Windows.Forms.Button();
            this.Promotores.SuspendLayout();
            this.SuspendLayout();
            // 
            // Promotores
            // 
            this.Promotores.Controls.Add(this.btnAgregarPromotor);
            this.Promotores.Controls.Add(this.btnEvaluacionProspecto);
            this.Promotores.Location = new System.Drawing.Point(1, 1);
            this.Promotores.Name = "Promotores";
            this.Promotores.Size = new System.Drawing.Size(419, 127);
            this.Promotores.TabIndex = 0;
            // 
            // btnAgregarPromotor
            // 
            this.btnAgregarPromotor.Location = new System.Drawing.Point(243, 41);
            this.btnAgregarPromotor.Name = "btnAgregarPromotor";
            this.btnAgregarPromotor.Size = new System.Drawing.Size(95, 39);
            this.btnAgregarPromotor.TabIndex = 1;
            this.btnAgregarPromotor.Text = "Agregar Promotor";
            this.btnAgregarPromotor.UseVisualStyleBackColor = true;
            this.btnAgregarPromotor.Click += new System.EventHandler(this.btnAgregarPromotor_Click);
            // 
            // btnEvaluacionProspecto
            // 
            this.btnEvaluacionProspecto.Location = new System.Drawing.Point(70, 41);
            this.btnEvaluacionProspecto.Name = "btnEvaluacionProspecto";
            this.btnEvaluacionProspecto.Size = new System.Drawing.Size(135, 39);
            this.btnEvaluacionProspecto.TabIndex = 0;
            this.btnEvaluacionProspecto.Text = "Evaluación Prospecto";
            this.btnEvaluacionProspecto.UseVisualStyleBackColor = true;
            this.btnEvaluacionProspecto.Click += new System.EventHandler(this.btnEvaluacionProspecto_Click);
            // 
            // VistaPromotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 132);
            this.Controls.Add(this.Promotores);
            this.Name = "VistaPromotor";
            this.Text = "Promotor";
            this.Promotores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Promotores;
        private System.Windows.Forms.Button btnAgregarPromotor;
        private System.Windows.Forms.Button btnEvaluacionProspecto;
    }
}