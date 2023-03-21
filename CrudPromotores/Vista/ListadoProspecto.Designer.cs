namespace CrudPromotores
{
    partial class ListadoProspecto
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
            this.dtgvProspectos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProspectos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvProspectos
            // 
            this.dtgvProspectos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProspectos.Location = new System.Drawing.Point(18, 13);
            this.dtgvProspectos.Name = "dtgvProspectos";
            this.dtgvProspectos.Size = new System.Drawing.Size(543, 150);
            this.dtgvProspectos.TabIndex = 0;
            this.dtgvProspectos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProspectos_CellContentClick);
            this.dtgvProspectos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProspectos_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvProspectos);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 218);
            this.panel1.TabIndex = 1;
            // 
            // ListadoProspecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.panel1);
            this.Name = "ListadoProspecto";
            this.Text = "Listado Prospectos";
            this.Load += new System.EventHandler(this.ListadoProspecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProspectos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvProspectos;
        private System.Windows.Forms.Panel panel1;
    }
}