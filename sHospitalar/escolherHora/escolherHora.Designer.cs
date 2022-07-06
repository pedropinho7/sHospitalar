namespace sHospitalar.escolherHora
{
    partial class EscolherHora
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
            this.labelhorarios = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelhorarios
            // 
            this.labelhorarios.AutoSize = true;
            this.labelhorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhorarios.Location = new System.Drawing.Point(75, 9);
            this.labelhorarios.Name = "labelhorarios";
            this.labelhorarios.Size = new System.Drawing.Size(85, 25);
            this.labelhorarios.TabIndex = 11;
            this.labelhorarios.Text = "Horários";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 35);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 405);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // EscolherHora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(214, 447);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelhorarios);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EscolherHora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "escolherHora";
            this.Deactivate += new System.EventHandler(this.EscolherHora_Deactivate);
            this.Load += new System.EventHandler(this.nova_Consulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label labelhorarios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}