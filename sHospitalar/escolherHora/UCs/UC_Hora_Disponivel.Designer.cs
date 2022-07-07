namespace sHospitalar.escolherHora.UCs
{
    partial class UcHoraDisponivel
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelHoraHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelHoraHora
            // 
            this.labelHoraHora.AutoSize = true;
            this.labelHoraHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHoraHora.Location = new System.Drawing.Point(44, 0);
            this.labelHoraHora.Name = "labelHoraHora";
            this.labelHoraHora.Size = new System.Drawing.Size(92, 29);
            this.labelHoraHora.TabIndex = 0;
            this.labelHoraHora.Text = "00 - 24";
            this.labelHoraHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHoraHora.Click += new System.EventHandler(this.labelHoraHora_Click);
            // 
            // UcHoraDisponivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.labelHoraHora);
            this.Name = "UcHoraDisponivel";
            this.Size = new System.Drawing.Size(196, 31);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelHoraHora;
    }
}
