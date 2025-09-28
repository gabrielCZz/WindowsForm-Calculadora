namespace WindowsForm_Calculadora
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            btnSobre = new ToolStripTextBox();
            txtVisorCalc = new ToolStripTextBox();
            txtVisor = new TextBox();
            painelBotoes = new TableLayoutPanel();
            btnLimpar = new Button();
            btnMaisMenos = new Button();
            btnRaiz = new Button();
            btnDividir = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicar = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnSubtrair = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSomar = new Button();
            btn0 = new Button();
            btnVirgula = new Button();
            btnPotencia = new Button();
            btnIgual = new Button();
            toolTip1 = new ToolTip(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1.SuspendLayout();
            painelBotoes.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AllowMerge = false;
            menuStrip1.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnSobre, txtVisorCalc });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 49);
            menuStrip1.TabIndex = 1;
            // 
            // btnSobre
            // 
            btnSobre.Name = "btnSobre";
            btnSobre.ReadOnly = true;
            btnSobre.Size = new Size(100, 45);
            btnSobre.Text = "Sobre";
            btnSobre.Click += sobreToolStripMenuItem_Click;
            // 
            // txtVisorCalc
            // 
            txtVisorCalc.Alignment = ToolStripItemAlignment.Right;
            txtVisorCalc.Font = new Font("Consolas", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVisorCalc.Name = "txtVisorCalc";
            txtVisorCalc.ReadOnly = true;
            txtVisorCalc.Size = new Size(100, 45);
            txtVisorCalc.Text = "0";
            txtVisorCalc.TextBoxTextAlign = HorizontalAlignment.Right;
            // 
            // txtVisor
            // 
            txtVisor.Location = new Point(0, 60);
            txtVisor.Name = "txtVisor";
            txtVisor.ReadOnly = true;
            txtVisor.Size = new Size(100, 25);
            txtVisor.TabIndex = 2;
            txtVisor.Text = "0";
            txtVisor.TextAlign = HorizontalAlignment.Right;
            // 
            // painelBotoes
            // 
            painelBotoes.CellBorderStyle = TableLayoutPanelCellBorderStyle.OutsetPartial;
            painelBotoes.ColumnCount = 5;
            painelBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            painelBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            painelBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            painelBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            painelBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            painelBotoes.Controls.Add(btnLimpar, 0, 0);
            painelBotoes.Controls.Add(btnMaisMenos, 1, 0);
            painelBotoes.Controls.Add(btnRaiz, 2, 0);
            painelBotoes.Controls.Add(btnDividir, 3, 0);
            painelBotoes.Controls.Add(btn7, 0, 1);
            painelBotoes.Controls.Add(btn8, 1, 1);
            painelBotoes.Controls.Add(btn9, 2, 1);
            painelBotoes.Controls.Add(btnMultiplicar, 3, 1);
            painelBotoes.Controls.Add(btn4, 0, 2);
            painelBotoes.Controls.Add(btn5, 1, 2);
            painelBotoes.Controls.Add(btn6, 2, 2);
            painelBotoes.Controls.Add(btnSubtrair, 3, 2);
            painelBotoes.Controls.Add(btn1, 0, 3);
            painelBotoes.Controls.Add(btn2, 1, 3);
            painelBotoes.Controls.Add(btn3, 2, 3);
            painelBotoes.Controls.Add(btnSomar, 3, 3);
            painelBotoes.Controls.Add(btn0, 0, 4);
            painelBotoes.Controls.Add(btnVirgula, 1, 4);
            painelBotoes.Controls.Add(btnPotencia, 2, 4);
            painelBotoes.Controls.Add(btnIgual, 3, 4);
            painelBotoes.Dock = DockStyle.Fill;
            painelBotoes.Location = new Point(0, 49);
            painelBotoes.Name = "painelBotoes";
            painelBotoes.RowCount = 6;
            painelBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 56.42458F));
            painelBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 43.57542F));
            painelBotoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            painelBotoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            painelBotoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            painelBotoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            painelBotoes.Size = new Size(800, 567);
            painelBotoes.TabIndex = 3;
            painelBotoes.Click += btnNumero_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Dock = DockStyle.Fill;
            btnLimpar.Location = new Point(6, 6);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(150, 129);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnMaisMenos
            // 
            btnMaisMenos.Dock = DockStyle.Fill;
            btnMaisMenos.Location = new Point(165, 6);
            btnMaisMenos.Name = "btnMaisMenos";
            btnMaisMenos.Size = new Size(150, 129);
            btnMaisMenos.TabIndex = 5;
            btnMaisMenos.Text = "±";
            btnMaisMenos.UseVisualStyleBackColor = true;
            btnMaisMenos.Click += btnMaisMenos_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.Dock = DockStyle.Fill;
            btnRaiz.Location = new Point(324, 6);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(150, 129);
            btnRaiz.TabIndex = 6;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = true;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnDividir
            // 
            btnDividir.Dock = DockStyle.Fill;
            btnDividir.Location = new Point(483, 6);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(150, 129);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnOperador_Click;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(6, 144);
            btn7.Name = "btn7";
            btn7.Size = new Size(150, 98);
            btn7.TabIndex = 8;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumero_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(165, 144);
            btn8.Name = "btn8";
            btn8.Size = new Size(150, 98);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumero_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(324, 144);
            btn9.Name = "btn9";
            btn9.Size = new Size(150, 98);
            btn9.TabIndex = 10;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumero_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Dock = DockStyle.Fill;
            btnMultiplicar.Location = new Point(483, 144);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(150, 98);
            btnMultiplicar.TabIndex = 11;
            btnMultiplicar.Text = "×";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnOperador_Click;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(6, 251);
            btn4.Name = "btn4";
            btn4.Size = new Size(150, 63);
            btn4.TabIndex = 12;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumero_Click;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(165, 251);
            btn5.Name = "btn5";
            btn5.Size = new Size(150, 63);
            btn5.TabIndex = 13;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumero_Click;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(324, 251);
            btn6.Name = "btn6";
            btn6.Size = new Size(150, 63);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumero_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Dock = DockStyle.Fill;
            btnSubtrair.Location = new Point(483, 251);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(150, 63);
            btnSubtrair.TabIndex = 15;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnOperador_Click;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(6, 323);
            btn1.Name = "btn1";
            btn1.Size = new Size(150, 68);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumero_Click;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(165, 323);
            btn2.Name = "btn2";
            btn2.Size = new Size(150, 68);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumero_Click;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(324, 323);
            btn3.Name = "btn3";
            btn3.Size = new Size(150, 68);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumero_Click;
            // 
            // btnSomar
            // 
            btnSomar.Dock = DockStyle.Fill;
            btnSomar.Location = new Point(483, 323);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(150, 68);
            btnSomar.TabIndex = 19;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnOperador_Click;
            // 
            // btn0
            // 
            painelBotoes.SetColumnSpan(btn0, 2);
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(6, 400);
            btn0.Name = "btn0";
            btn0.Size = new Size(309, 90);
            btn0.TabIndex = 20;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumero_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.Dock = DockStyle.Fill;
            btnVirgula.Location = new Point(324, 400);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(150, 90);
            btnVirgula.TabIndex = 21;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = true;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.Dock = DockStyle.Fill;
            btnPotencia.Location = new Point(483, 400);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(150, 90);
            btnPotencia.TabIndex = 22;
            btnPotencia.Text = "x^y";
            btnPotencia.UseVisualStyleBackColor = true;
            btnPotencia.Click += btnOperador_Click;
            // 
            // btnIgual
            // 
            painelBotoes.SetColumnSpan(btnIgual, 4);
            btnIgual.Dock = DockStyle.Fill;
            btnIgual.Location = new Point(6, 499);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(627, 62);
            btnIgual.TabIndex = 23;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 616);
            Controls.Add(painelBotoes);
            Controls.Add(txtVisor);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Simples";
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            painelBotoes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private TextBox txtVisor;
        private TableLayoutPanel painelBotoes;
        private Button btnLimpar;
        private Button btnMaisMenos;
        private Button btnRaiz;
        private Button btnDividir;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicar;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnSubtrair;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSomar;
        private Button btn0;
        private Button btnVirgula;
        private Button btnPotencia;
        private Button btnIgual;
        private ToolTip toolTip1;
        private ToolStripTextBox txtVisorCalc;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripTextBox btnSobre;
    }
}
