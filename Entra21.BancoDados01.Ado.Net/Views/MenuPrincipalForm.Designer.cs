namespace Entra21.BancoDados01.Ado.Net.Views
{
    partial class MenuPrincipalForm
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
            this.buttonEditoras = new System.Windows.Forms.Button();
            this.buttonPersonagens = new System.Windows.Forms.Button();
            this.buttonTipoPersonagens = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditoras
            // 
            this.buttonEditoras.Location = new System.Drawing.Point(12, 27);
            this.buttonEditoras.Name = "buttonEditoras";
            this.buttonEditoras.Size = new System.Drawing.Size(149, 311);
            this.buttonEditoras.TabIndex = 0;
            this.buttonEditoras.Text = "Editoras";
            this.buttonEditoras.UseVisualStyleBackColor = true;
            this.buttonEditoras.Click += new System.EventHandler(this.buttonEditoras_Click);
            // 
            // buttonPersonagens
            // 
            this.buttonPersonagens.Location = new System.Drawing.Point(167, 27);
            this.buttonPersonagens.Name = "buttonPersonagens";
            this.buttonPersonagens.Size = new System.Drawing.Size(149, 311);
            this.buttonPersonagens.TabIndex = 1;
            this.buttonPersonagens.Text = "Personagens";
            this.buttonPersonagens.UseVisualStyleBackColor = true;
            this.buttonPersonagens.Click += new System.EventHandler(this.buttonPersonagens_Click);
            // 
            // buttonTipoPersonagens
            // 
            this.buttonTipoPersonagens.Location = new System.Drawing.Point(322, 27);
            this.buttonTipoPersonagens.Name = "buttonTipoPersonagens";
            this.buttonTipoPersonagens.Size = new System.Drawing.Size(149, 311);
            this.buttonTipoPersonagens.TabIndex = 2;
            this.buttonTipoPersonagens.Text = "Tipos de Personagens";
            this.buttonTipoPersonagens.UseVisualStyleBackColor = true;
            this.buttonTipoPersonagens.Click += new System.EventHandler(this.buttonTipoPersonagens_Click);
            // 
            // MenuPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 363);
            this.Controls.Add(this.buttonTipoPersonagens);
            this.Controls.Add(this.buttonPersonagens);
            this.Controls.Add(this.buttonEditoras);
            this.Name = "MenuPrincipalForm";
            this.Text = "MenuPrincipalForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonEditoras;
        private Button buttonPersonagens;
        private Button buttonTipoPersonagens;
    }
}