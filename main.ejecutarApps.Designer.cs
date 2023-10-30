namespace lp_webService_consumeApps
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNotepadPLUSPLUS = new System.Windows.Forms.Button();
            this.btnCPUZ = new System.Windows.Forms.Button();
            this.btnBrave = new System.Windows.Forms.Button();
            this.btnJFLAP = new System.Windows.Forms.Button();
            this.btnWinRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elige una aplicación para abrir:";
            // 
            // btnNotepadPLUSPLUS
            // 
            this.btnNotepadPLUSPLUS.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotepadPLUSPLUS.Location = new System.Drawing.Point(18, 62);
            this.btnNotepadPLUSPLUS.Name = "btnNotepadPLUSPLUS";
            this.btnNotepadPLUSPLUS.Size = new System.Drawing.Size(176, 110);
            this.btnNotepadPLUSPLUS.TabIndex = 1;
            this.btnNotepadPLUSPLUS.Text = "Notepad++";
            this.btnNotepadPLUSPLUS.UseVisualStyleBackColor = true;
            this.btnNotepadPLUSPLUS.Click += new System.EventHandler(this.btnNotepadPLUSPLUS_Click);
            // 
            // btnCPUZ
            // 
            this.btnCPUZ.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCPUZ.Location = new System.Drawing.Point(200, 62);
            this.btnCPUZ.Name = "btnCPUZ";
            this.btnCPUZ.Size = new System.Drawing.Size(176, 110);
            this.btnCPUZ.TabIndex = 2;
            this.btnCPUZ.Text = "CPUZ";
            this.btnCPUZ.UseVisualStyleBackColor = true;
            this.btnCPUZ.Click += new System.EventHandler(this.btnCPUZ_Click);
            // 
            // btnBrave
            // 
            this.btnBrave.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrave.Location = new System.Drawing.Point(382, 62);
            this.btnBrave.Name = "btnBrave";
            this.btnBrave.Size = new System.Drawing.Size(176, 110);
            this.btnBrave.TabIndex = 3;
            this.btnBrave.Text = "Brave";
            this.btnBrave.UseVisualStyleBackColor = true;
            this.btnBrave.Click += new System.EventHandler(this.btnBrave_Click);
            // 
            // btnJFLAP
            // 
            this.btnJFLAP.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJFLAP.Location = new System.Drawing.Point(108, 178);
            this.btnJFLAP.Name = "btnJFLAP";
            this.btnJFLAP.Size = new System.Drawing.Size(176, 110);
            this.btnJFLAP.TabIndex = 4;
            this.btnJFLAP.Text = "JFLAP";
            this.btnJFLAP.UseVisualStyleBackColor = true;
            this.btnJFLAP.Click += new System.EventHandler(this.btnJFLAP_Click);
            // 
            // btnWinRAR
            // 
            this.btnWinRAR.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinRAR.Location = new System.Drawing.Point(290, 178);
            this.btnWinRAR.Name = "btnWinRAR";
            this.btnWinRAR.Size = new System.Drawing.Size(176, 110);
            this.btnWinRAR.TabIndex = 5;
            this.btnWinRAR.Text = "WinRAR";
            this.btnWinRAR.UseVisualStyleBackColor = true;
            this.btnWinRAR.Click += new System.EventHandler(this.btnWinRAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 315);
            this.Controls.Add(this.btnWinRAR);
            this.Controls.Add(this.btnJFLAP);
            this.Controls.Add(this.btnBrave);
            this.Controls.Add(this.btnCPUZ);
            this.Controls.Add(this.btnNotepadPLUSPLUS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Consumo de Web Service | Aplicaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNotepadPLUSPLUS;
        private System.Windows.Forms.Button btnCPUZ;
        private System.Windows.Forms.Button btnBrave;
        private System.Windows.Forms.Button btnJFLAP;
        private System.Windows.Forms.Button btnWinRAR;
    }
}

