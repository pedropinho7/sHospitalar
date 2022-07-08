namespace Agenda.MainPage
{
    partial class MainPage
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
            this.criarConsultaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criarConsultaButton
            // 
            this.criarConsultaButton.Location = new System.Drawing.Point(197, 226);
            this.criarConsultaButton.Name = "criarConsultaButton";
            this.criarConsultaButton.Size = new System.Drawing.Size(165, 63);
            this.criarConsultaButton.TabIndex = 0;
            this.criarConsultaButton.Text = "Entrar";
            this.criarConsultaButton.UseVisualStyleBackColor = true;
            this.criarConsultaButton.Click += new System.EventHandler(this.CriarConsultaButton_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 358);
            this.Controls.Add(this.criarConsultaButton);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button criarConsultaButton;

        #endregion
    }
}