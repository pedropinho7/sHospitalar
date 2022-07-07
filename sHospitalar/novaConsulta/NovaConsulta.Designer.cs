using System.ComponentModel;

namespace sHospitalar.NovaConsulta
{
    partial class NovaConsulta
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IdBox = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.labeTeste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(32, 42);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(31, 20);
            this.IdBox.TabIndex = 0;
            this.IdBox.TextChanged += new System.EventHandler(this.labelID_TextChanged);
            // 
            // labelId
            // 
            this.labelId.Location = new System.Drawing.Point(7, 45);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(19, 17);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID";
            // 
            // labelNome
            // 
            this.labelNome.Location = new System.Drawing.Point(145, 42);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 20);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(186, 42);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(316, 20);
            this.nomeBox.TabIndex = 3;
            // 
            // labeTeste
            // 
            this.labeTeste.Location = new System.Drawing.Point(102, 147);
            this.labeTeste.Name = "labeTeste";
            this.labeTeste.Size = new System.Drawing.Size(578, 114);
            this.labeTeste.TabIndex = 4;
            this.labeTeste.Text = "label1";
            // 
            // NovaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeTeste);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.IdBox);
            this.Name = "NovaConsulta";
            this.Text = "NovaConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labeTeste;

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox nomeBox;

        private System.Windows.Forms.Label labelId;

        private System.Windows.Forms.TextBox IdBox;

        #endregion
    }
}