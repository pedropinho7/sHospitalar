using System.ComponentModel;

namespace sHospitalar
{
    partial class Criar_consulta
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
            this.labelNomeUtente = new System.Windows.Forms.Label();
            this.labelIDUtente = new System.Windows.Forms.Label();
            this.utenteIDBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.gridResultadosPesquisa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadosPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // utenteNameBox
            // 
            this.utenteNameBox.Location = new System.Drawing.Point(12, 45);
            this.utenteNameBox.Name = "utenteNameBox";
            this.utenteNameBox.Size = new System.Drawing.Size(401, 20);
            this.utenteNameBox.TabIndex = 0;
            // 
            // labelNomeUtente
            // 
            this.labelNomeUtente.Location = new System.Drawing.Point(12, 30);
            this.labelNomeUtente.Name = "labelNomeUtente";
            this.labelNomeUtente.Size = new System.Drawing.Size(126, 12);
            this.labelNomeUtente.TabIndex = 1;
            this.labelNomeUtente.Text = "Nome do Utente";
            // 
            // labelIDUtente
            // 
            this.labelIDUtente.Location = new System.Drawing.Point(454, 30);
            this.labelIDUtente.Name = "labelIDUtente";
            this.labelIDUtente.Size = new System.Drawing.Size(57, 21);
            this.labelIDUtente.TabIndex = 2;
            this.labelIDUtente.Text = "ID Utente";
            // 
            // utenteIDBox
            // 
            this.utenteIDBox.Location = new System.Drawing.Point(454, 44);
            this.utenteIDBox.Name = "utenteIDBox";
            this.utenteIDBox.Size = new System.Drawing.Size(102, 20);
            this.utenteIDBox.TabIndex = 3;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(625, 30);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(120, 38);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Pesquisar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // gridResultadosPesquisa
            // 
            this.gridResultadosPesquisa.AllowUserToAddRows = false;
            this.gridResultadosPesquisa.AllowUserToDeleteRows = false;
            this.gridResultadosPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultadosPesquisa.Location = new System.Drawing.Point(12, 109);
            this.gridResultadosPesquisa.Name = "gridResultadosPesquisa";
            this.gridResultadosPesquisa.ReadOnly = true;
            this.gridResultadosPesquisa.Size = new System.Drawing.Size(401, 186);
            this.gridResultadosPesquisa.TabIndex = 5;
            // 
            // Criar_consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridResultadosPesquisa);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.utenteIDBox);
            this.Controls.Add(this.labelIDUtente);
            this.Controls.Add(this.labelNomeUtente);
            this.Controls.Add(this.utenteNameBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Criar_consulta";
            ((System.ComponentModel.ISupportInitialize)(this.gridResultadosPesquisa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn sexoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idadeColumn;

        private System.Windows.Forms.DataGridView gridResultadosPesquisa;

        private System.Windows.Forms.TextBox utenteNameBox;
        private System.Windows.Forms.Label labelNomeUtente;
        private System.Windows.Forms.Label labelIDUtente;
        private System.Windows.Forms.TextBox utenteIDBox;
        private System.Windows.Forms.Button searchButton;

        #endregion
    }
}