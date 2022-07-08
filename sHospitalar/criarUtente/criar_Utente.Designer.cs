using System.ComponentModel;

namespace Agenda.criarUtente
{
    partial class CriarUtente
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
            this.utenteNameBox = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.criarUtenteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // utenteNameBox
            // 
            this.utenteNameBox.Location = new System.Drawing.Point(12, 100);
            this.utenteNameBox.Name = "utenteNameBox";
            this.utenteNameBox.Size = new System.Drawing.Size(339, 20);
            this.utenteNameBox.TabIndex = 0;
            // 
            // labelFullName
            // 
            this.labelFullName.Location = new System.Drawing.Point(12, 83);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(126, 14);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Nome completo";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Location = new System.Drawing.Point(369, 100);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayPicker.TabIndex = 2;
            // 
            // labelBirthday
            // 
            this.labelBirthday.Location = new System.Drawing.Point(369, 84);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(144, 13);
            this.labelBirthday.TabIndex = 3;
            this.labelBirthday.Text = "Data de Nascimento";
            // 
            // criarUtenteButton
            // 
            this.criarUtenteButton.Location = new System.Drawing.Point(635, 344);
            this.criarUtenteButton.Name = "criarUtenteButton";
            this.criarUtenteButton.Size = new System.Drawing.Size(123, 53);
            this.criarUtenteButton.TabIndex = 4;
            this.criarUtenteButton.Text = "Criar _utentes";
            this.criarUtenteButton.UseVisualStyleBackColor = true;
            this.criarUtenteButton.Click += new System.EventHandler(this.criarUtenteButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(589, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sexo";
            // 
            // sexBox
            // 
            this.sexBox.AllowDrop = true;
            this.sexBox.FormattingEnabled = true;
            this.sexBox.Items.AddRange(new object[] { "M", "F" });
            this.sexBox.Location = new System.Drawing.Point(589, 100);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(33, 56);
            this.sexBox.TabIndex = 6;
            // 
            // Criar_Utente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sexBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.criarUtenteButton);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.birthdayPicker);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.utenteNameBox);
            this.Name = "CriarUtente";
            this.Text = "Criar novo _utentes";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button criarUtenteButton;
        private System.Windows.Forms.ListBox sexBox;

        private System.Windows.Forms.TextBox utenteNameBox;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label labelBirthday;

        #endregion
    }
}