namespace WindowsForm_Calculadora
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            lblTitulo = new Label();
            lblIntegrantes = new Label();
            lblResumo = new Label();
            linkGithub = new LinkLabel();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(186, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CP1: Calculadora Simples";
            // 
            // lblIntegrantes
            // 
            lblIntegrantes.AutoSize = true;
            lblIntegrantes.Location = new Point(12, 50);
            lblIntegrantes.Name = "lblIntegrantes";
            lblIntegrantes.Size = new Size(250, 105);
            lblIntegrantes.TabIndex = 1;
            lblIntegrantes.Text = resources.GetString("lblIntegrantes.Text");
            // 
            // lblResumo
            // 
            lblResumo.Location = new Point(12, 178);
            lblResumo.Name = "lblResumo";
            lblResumo.Size = new Size(390, 80);
            lblResumo.TabIndex = 2;
            lblResumo.Text = resources.GetString("lblResumo.Text");
            // 
            // linkGithub
            // 
            linkGithub.AutoSize = true;
            linkGithub.ForeColor = SystemColors.ControlText;
            linkGithub.Location = new Point(12, 281);
            linkGithub.Name = "linkGithub";
            linkGithub.Size = new Size(125, 15);
            linkGithub.TabIndex = 3;
            linkGithub.TabStop = true;
            linkGithub.Text = "Repositório no GitHub";
            linkGithub.LinkClicked += linkGitHub_LinkClicked;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(322, 330);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(80, 30);
            btnFechar.TabIndex = 4;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 367);
            Controls.Add(btnFechar);
            Controls.Add(linkGithub);
            Controls.Add(lblResumo);
            Controls.Add(lblIntegrantes);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AbountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblIntegrantes;
        private Label lblResumo;
        private LinkLabel linkGithub;
        private Button btnFechar;
    }
}