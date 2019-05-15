namespace AplicacionMultiProyecto
{
    partial class FormBase
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
            this.panelAvisos = new System.Windows.Forms.Panel();
            this.btSalir = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.labelAvisos = new System.Windows.Forms.Label();
            this.panelAvisos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAvisos
            // 
            this.panelAvisos.Controls.Add(this.labelAvisos);
            this.panelAvisos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAvisos.Location = new System.Drawing.Point(0, 411);
            this.panelAvisos.Name = "panelAvisos";
            this.panelAvisos.Size = new System.Drawing.Size(784, 50);
            this.panelAvisos.TabIndex = 0;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(672, 12);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 50);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btInfo
            // 
            this.btInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInfo.Location = new System.Drawing.Point(12, 12);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(100, 50);
            this.btInfo.TabIndex = 2;
            this.btInfo.Text = "Info ...";
            this.btInfo.UseVisualStyleBackColor = true;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // labelAvisos
            // 
            this.labelAvisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAvisos.Location = new System.Drawing.Point(0, 0);
            this.labelAvisos.Name = "labelAvisos";
            this.labelAvisos.Size = new System.Drawing.Size(784, 50);
            this.labelAvisos.TabIndex = 3;
            this.labelAvisos.Text = "INFO";
            this.labelAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btInfo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.panelAvisos);
            this.Name = "FormBase";
            this.Text = "BASE";
            this.panelAvisos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelAvisos;
        protected System.Windows.Forms.Button btSalir;
        protected System.Windows.Forms.Button btInfo;
        protected System.Windows.Forms.Label labelAvisos;
    }
}

