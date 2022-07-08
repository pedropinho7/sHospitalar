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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.sexoLabel = new System.Windows.Forms.Label();
            this.sexoBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.idadeLabel = new System.Windows.Forms.Label();
            this.diaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mesBox = new System.Windows.Forms.TextBox();
            this.anoBox = new System.Windows.Forms.TextBox();
            this.horaBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.Location = new System.Drawing.Point(12, 99);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(41, 19);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            // 
            // nomeBox
            // 
            this.nomeBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nomeBox.Location = new System.Drawing.Point(59, 96);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.ReadOnly = true;
            this.nomeBox.Size = new System.Drawing.Size(188, 20);
            this.nomeBox.TabIndex = 1;
            // 
            // IdBox
            // 
            this.IdBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IdBox.Location = new System.Drawing.Point(59, 53);
            this.IdBox.Name = "IdBox";
            this.IdBox.ReadOnly = true;
            this.IdBox.Size = new System.Drawing.Size(32, 20);
            this.IdBox.TabIndex = 2;
            // 
            // IdLabel
            // 
            this.IdLabel.Location = new System.Drawing.Point(23, 56);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(20, 19);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "ID";
            // 
            // sexoLabel
            // 
            this.sexoLabel.Location = new System.Drawing.Point(12, 139);
            this.sexoLabel.Name = "sexoLabel";
            this.sexoLabel.Size = new System.Drawing.Size(41, 19);
            this.sexoLabel.TabIndex = 4;
            this.sexoLabel.Text = "Sexo";
            // 
            // sexoBox
            // 
            this.sexoBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sexoBox.Location = new System.Drawing.Point(59, 139);
            this.sexoBox.Name = "sexoBox";
            this.sexoBox.ReadOnly = true;
            this.sexoBox.Size = new System.Drawing.Size(32, 20);
            this.sexoBox.TabIndex = 5;
            // 
            // ageBox
            // 
            this.ageBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ageBox.Location = new System.Drawing.Point(59, 174);
            this.ageBox.Name = "ageBox";
            this.ageBox.ReadOnly = true;
            this.ageBox.Size = new System.Drawing.Size(32, 20);
            this.ageBox.TabIndex = 7;
            // 
            // idadeLabel
            // 
            this.idadeLabel.Location = new System.Drawing.Point(12, 174);
            this.idadeLabel.Name = "idadeLabel";
            this.idadeLabel.Size = new System.Drawing.Size(41, 19);
            this.idadeLabel.TabIndex = 6;
            this.idadeLabel.Text = "Idade";
            // 
            // diaBox
            // 
            this.diaBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diaBox.Location = new System.Drawing.Point(299, 53);
            this.diaBox.Name = "diaBox";
            this.diaBox.ReadOnly = true;
            this.diaBox.Size = new System.Drawing.Size(19, 20);
            this.diaBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(262, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Data";
            // 
            // mesBox
            // 
            this.mesBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mesBox.Location = new System.Drawing.Point(340, 53);
            this.mesBox.Name = "mesBox";
            this.mesBox.ReadOnly = true;
            this.mesBox.Size = new System.Drawing.Size(24, 20);
            this.mesBox.TabIndex = 10;
            // 
            // anoBox
            // 
            this.anoBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.anoBox.Location = new System.Drawing.Point(386, 55);
            this.anoBox.Name = "anoBox";
            this.anoBox.ReadOnly = true;
            this.anoBox.Size = new System.Drawing.Size(43, 20);
            this.anoBox.TabIndex = 11;
            // 
            // horaBox
            // 
            this.horaBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horaBox.Location = new System.Drawing.Point(448, 55);
            this.horaBox.Name = "horaBox";
            this.horaBox.ReadOnly = true;
            this.horaBox.Size = new System.Drawing.Size(32, 20);
            this.horaBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(436, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(324, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(370, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(486, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "H";
            // 
            // NovaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.horaBox);
            this.Controls.Add(this.anoBox);
            this.Controls.Add(this.mesBox);
            this.Controls.Add(this.diaBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.idadeLabel);
            this.Controls.Add(this.sexoBox);
            this.Controls.Add(this.sexoLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.nomeLabel);
            this.Name = "NovaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova consulta";
            this.Load += new System.EventHandler(this.NovaConsulta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diaBox;
        private System.Windows.Forms.TextBox mesBox;
        private System.Windows.Forms.TextBox anoBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox horaBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label idadeLabel;

        private System.Windows.Forms.Label sexoLabel;
        private System.Windows.Forms.TextBox sexoBox;

        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label IdLabel;

        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.Label nomeLabel;
        #endregion
    }
}