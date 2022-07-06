using System.ComponentModel;
using System.Windows.Forms;

namespace sHospitalar
{
    partial class criar_Consulta
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
            this.labelID = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(23, 52);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(19, 19);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(72, 49);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(37, 20);
            this.idBox.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(23, 84);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nome";
            // 
            // nameBox
            // 
            this.nameBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nameBox.Location = new System.Drawing.Point(72, 84);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 20);
            this.nameBox.TabIndex = 3;
            // 
            // criar_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.labelID);
            this.Name = "criar_Consulta";
            this.Text = "Nova consulta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelID;

        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;

        private System.Windows.Forms.Label labelName;

        #endregion
    }
}