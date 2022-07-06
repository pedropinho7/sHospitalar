using System;
using System.ComponentModel;

namespace sHospitalar
{
    partial class DatasDisponiveis
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
            this.labelSegunda = new System.Windows.Forms.Label();
            this.labelTerca = new System.Windows.Forms.Label();
            this.labelQuarta = new System.Windows.Forms.Label();
            this.labelQuinta = new System.Windows.Forms.Label();
            this.labelSexta = new System.Windows.Forms.Label();
            this.labelDomingo = new System.Windows.Forms.Label();
            this.labelSabado = new System.Windows.Forms.Label();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.anteriorButton = new System.Windows.Forms.Button();
            this.seguinteButton = new System.Windows.Forms.Button();
            this.labelMesAno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSegunda
            // 
            this.labelSegunda.Location = new System.Drawing.Point(177, 41);
            this.labelSegunda.Name = "labelSegunda";
            this.labelSegunda.Size = new System.Drawing.Size(84, 25);
            this.labelSegunda.TabIndex = 0;
            this.labelSegunda.Text = "Segunda-Feira";
            // 
            // labelTerca
            // 
            this.labelTerca.Location = new System.Drawing.Point(320, 41);
            this.labelTerca.Name = "labelTerca";
            this.labelTerca.Size = new System.Drawing.Size(64, 25);
            this.labelTerca.TabIndex = 1;
            this.labelTerca.Text = "Terça-Feira";
            // 
            // labelQuarta
            // 
            this.labelQuarta.Location = new System.Drawing.Point(443, 41);
            this.labelQuarta.Name = "labelQuarta";
            this.labelQuarta.Size = new System.Drawing.Size(68, 25);
            this.labelQuarta.TabIndex = 2;
            this.labelQuarta.Text = "Quarta-Feira";
            // 
            // labelQuinta
            // 
            this.labelQuinta.Location = new System.Drawing.Point(569, 41);
            this.labelQuinta.Name = "labelQuinta";
            this.labelQuinta.Size = new System.Drawing.Size(62, 25);
            this.labelQuinta.TabIndex = 3;
            this.labelQuinta.Text = "Quinta-feira";
            // 
            // labelSexta
            // 
            this.labelSexta.Location = new System.Drawing.Point(704, 41);
            this.labelSexta.Name = "labelSexta";
            this.labelSexta.Size = new System.Drawing.Size(59, 25);
            this.labelSexta.TabIndex = 4;
            this.labelSexta.Text = "Sexta-feira";
            // 
            // labelDomingo
            // 
            this.labelDomingo.Location = new System.Drawing.Point(60, 41);
            this.labelDomingo.Name = "labelDomingo";
            this.labelDomingo.Size = new System.Drawing.Size(54, 25);
            this.labelDomingo.TabIndex = 8;
            this.labelDomingo.Text = "Domingo";
            // 
            // labelSabado
            // 
            this.labelSabado.Location = new System.Drawing.Point(829, 41);
            this.labelSabado.Name = "labelSabado";
            this.labelSabado.Size = new System.Drawing.Size(47, 25);
            this.labelSabado.TabIndex = 9;
            this.labelSabado.Text = "Sábado";
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(24, 69);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(945, 646);
            this.dayContainer.TabIndex = 5;
            // 
            // anteriorButton
            // 
            this.anteriorButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.anteriorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.anteriorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.anteriorButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.anteriorButton.Location = new System.Drawing.Point(763, 721);
            this.anteriorButton.Name = "anteriorButton";
            this.anteriorButton.Size = new System.Drawing.Size(113, 38);
            this.anteriorButton.TabIndex = 6;
            this.anteriorButton.Text = "Anterior";
            this.anteriorButton.UseVisualStyleBackColor = false;
            this.anteriorButton.Click += new System.EventHandler(this.anteriorButton_Click);
            // 
            // seguinteButton
            // 
            this.seguinteButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.seguinteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.seguinteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seguinteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.seguinteButton.Location = new System.Drawing.Point(923, 721);
            this.seguinteButton.Name = "seguinteButton";
            this.seguinteButton.Size = new System.Drawing.Size(113, 38);
            this.seguinteButton.TabIndex = 7;
            this.seguinteButton.Text = "Seguinte";
            this.seguinteButton.UseVisualStyleBackColor = false;
            this.seguinteButton.Click += new System.EventHandler(this.seguinteButton_Click);
            // 
            // labelMesAno
            // 
            this.labelMesAno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMesAno.AutoSize = true;
            this.labelMesAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesAno.Location = new System.Drawing.Point(429, 9);
            this.labelMesAno.Name = "labelMesAno";
            this.labelMesAno.Size = new System.Drawing.Size(105, 25);
            this.labelMesAno.TabIndex = 10;
            this.labelMesAno.Text = "MES ANO";
            // 
            // DatasDisponiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1073, 791);
            this.Controls.Add(this.labelMesAno);
            this.Controls.Add(this.labelDomingo);
            this.Controls.Add(this.labelSabado);
            this.Controls.Add(this.seguinteButton);
            this.Controls.Add(this.anteriorButton);
            this.Controls.Add(this.dayContainer);
            this.Controls.Add(this.labelSexta);
            this.Controls.Add(this.labelQuinta);
            this.Controls.Add(this.labelQuarta);
            this.Controls.Add(this.labelTerca);
            this.Controls.Add(this.labelSegunda);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "DatasDisponiveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.datas_disponiveis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }




        private System.Windows.Forms.Button seguinteButton;

        private System.Windows.Forms.Button anteriorButton;

        private System.Windows.Forms.FlowLayoutPanel dayContainer;

        private System.Windows.Forms.Label labelSegunda;
        private System.Windows.Forms.Label labelTerca;
        private System.Windows.Forms.Label labelQuarta;
        private System.Windows.Forms.Label labelQuinta;
        private System.Windows.Forms.Label labelSexta;
        private System.Windows.Forms.Label labelSabado;
        private System.Windows.Forms.Label labelDomingo;

        #endregion

        private System.Windows.Forms.Label labelMesAno;
    }
}