namespace Principal
{
    partial class Principal
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
            this.avisoRojo = new System.Windows.Forms.Button();
            this.avisoNORMAL = new System.Windows.Forms.Button();
            this.avisoAMARILLO = new System.Windows.Forms.Button();
            this.avisoVERDE = new System.Windows.Forms.Button();
            this.panelAvisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAvisos
            // 
            this.panelAvisos.Location = new System.Drawing.Point(0, 400);
            this.panelAvisos.Size = new System.Drawing.Size(800, 50);
            // 
            // labelAvisos
            // 
            this.labelAvisos.Size = new System.Drawing.Size(800, 50);
            // 
            // btInfo
            // 
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // avisoRojo
            // 
            this.avisoRojo.Location = new System.Drawing.Point(37, 137);
            this.avisoRojo.Name = "avisoRojo";
            this.avisoRojo.Size = new System.Drawing.Size(75, 23);
            this.avisoRojo.TabIndex = 3;
            this.avisoRojo.Text = "ROJO";
            this.avisoRojo.UseVisualStyleBackColor = true;
            this.avisoRojo.Click += new System.EventHandler(this.avisoRojo_Click);
            // 
            // avisoNORMAL
            // 
            this.avisoNORMAL.Location = new System.Drawing.Point(280, 137);
            this.avisoNORMAL.Name = "avisoNORMAL";
            this.avisoNORMAL.Size = new System.Drawing.Size(75, 23);
            this.avisoNORMAL.TabIndex = 4;
            this.avisoNORMAL.Text = "NORMAL";
            this.avisoNORMAL.UseVisualStyleBackColor = true;
            this.avisoNORMAL.Click += new System.EventHandler(this.avisoNORMAL_Click);
            // 
            // avisoAMARILLO
            // 
            this.avisoAMARILLO.Location = new System.Drawing.Point(199, 137);
            this.avisoAMARILLO.Name = "avisoAMARILLO";
            this.avisoAMARILLO.Size = new System.Drawing.Size(75, 23);
            this.avisoAMARILLO.TabIndex = 5;
            this.avisoAMARILLO.Text = "AMARILLO";
            this.avisoAMARILLO.UseVisualStyleBackColor = true;
            this.avisoAMARILLO.Click += new System.EventHandler(this.avisoAMARILLO_Click);
            // 
            // avisoVERDE
            // 
            this.avisoVERDE.Location = new System.Drawing.Point(118, 137);
            this.avisoVERDE.Name = "avisoVERDE";
            this.avisoVERDE.Size = new System.Drawing.Size(75, 23);
            this.avisoVERDE.TabIndex = 6;
            this.avisoVERDE.Text = "VERDE";
            this.avisoVERDE.UseVisualStyleBackColor = true;
            this.avisoVERDE.Click += new System.EventHandler(this.avisoVERDE_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avisoVERDE);
            this.Controls.Add(this.avisoAMARILLO);
            this.Controls.Add(this.avisoNORMAL);
            this.Controls.Add(this.avisoRojo);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Controls.SetChildIndex(this.panelAvisos, 0);
            this.Controls.SetChildIndex(this.btSalir, 0);
            this.Controls.SetChildIndex(this.btInfo, 0);
            this.Controls.SetChildIndex(this.avisoRojo, 0);
            this.Controls.SetChildIndex(this.avisoNORMAL, 0);
            this.Controls.SetChildIndex(this.avisoAMARILLO, 0);
            this.Controls.SetChildIndex(this.avisoVERDE, 0);
            this.panelAvisos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button avisoRojo;
        private System.Windows.Forms.Button avisoNORMAL;
        private System.Windows.Forms.Button avisoAMARILLO;
        private System.Windows.Forms.Button avisoVERDE;
    }
}

