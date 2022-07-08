using System.ComponentModel;

namespace sHospitalar.UCs.UC_ContainerDia
{
    partial class UcContainerDia
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.labelDiaTexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDiaTexto
            // 
            this.labelDiaTexto.AutoSize = true;
            this.labelDiaTexto.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelDiaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiaTexto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDiaTexto.Location = new System.Drawing.Point(44, 40);
            this.labelDiaTexto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiaTexto.Name = "labelDiaTexto";
            this.labelDiaTexto.Size = new System.Drawing.Size(36, 25);
            this.labelDiaTexto.TabIndex = 0;
            this.labelDiaTexto.Text = "00";
            this.labelDiaTexto.Click += new System.EventHandler(this.labelDiaTexto_Click);
            // 
            // UcContainerDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelDiaTexto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "UcContainerDia";
            this.Size = new System.Drawing.Size(123, 106);
            this.Click += new System.EventHandler(this.UcContainerDia_Click);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelDiaTexto;
    }
}