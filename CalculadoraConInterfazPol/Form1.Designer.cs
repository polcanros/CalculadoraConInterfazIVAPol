namespace CalculadoraConInterfazPol
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnIgual = new Button();
            btnResta = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn3 = new Button();
            btnSuma = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btnComa = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btnPotencia = new Button();
            btnDividir = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplicar = new Button();
            btnRaiz = new Button();
            btnBorrar = new Button();
            txtPantalla = new TextBox();
            tabPage2 = new TabPage();
            txtWithIva = new TextBox();
            label4 = new Label();
            txtNoIva = new TextBox();
            label3 = new Label();
            btnCalculate = new Button();
            chkPartner = new CheckBox();
            grpDiscount = new GroupBox();
            rbD20 = new RadioButton();
            rbD10 = new RadioButton();
            rbD5 = new RadioButton();
            rbD0 = new RadioButton();
            grpIva = new GroupBox();
            rbIva21 = new RadioButton();
            rbIva10 = new RadioButton();
            rbIva4 = new RadioButton();
            rbIva0 = new RadioButton();
            txtQuantity = new TextBox();
            label2 = new Label();
            txtPrice = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            grpDiscount.SuspendLayout();
            grpIva.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.Buttons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Cursor = Cursors.Hand;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(384, 511);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkOrchid;
            tabPage1.Controls.Add(btnIgual);
            tabPage1.Controls.Add(btnResta);
            tabPage1.Controls.Add(btn6);
            tabPage1.Controls.Add(btn1);
            tabPage1.Controls.Add(btn3);
            tabPage1.Controls.Add(btnSuma);
            tabPage1.Controls.Add(btn2);
            tabPage1.Controls.Add(btn0);
            tabPage1.Controls.Add(btnComa);
            tabPage1.Controls.Add(btn4);
            tabPage1.Controls.Add(btn5);
            tabPage1.Controls.Add(btnPotencia);
            tabPage1.Controls.Add(btnDividir);
            tabPage1.Controls.Add(btn7);
            tabPage1.Controls.Add(btn8);
            tabPage1.Controls.Add(btn9);
            tabPage1.Controls.Add(btnMultiplicar);
            tabPage1.Controls.Add(btnRaiz);
            tabPage1.Controls.Add(btnBorrar);
            tabPage1.Controls.Add(txtPantalla);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(376, 480);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Calculadora";
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.HotPink;
            btnIgual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIgual.Location = new Point(279, 358);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(80, 60);
            btnIgual.TabIndex = 26;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnResta
            // 
            btnResta.BackColor = Color.Plum;
            btnResta.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnResta.Location = new Point(279, 224);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(80, 60);
            btnResta.TabIndex = 25;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Plum;
            btn6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(191, 224);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 60);
            btn6.TabIndex = 24;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Plum;
            btn1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(15, 291);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 60);
            btn1.TabIndex = 23;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Plum;
            btn3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(191, 291);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 60);
            btn3.TabIndex = 22;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += button6_Click;
            // 
            // btnSuma
            // 
            btnSuma.BackColor = Color.Plum;
            btnSuma.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSuma.Location = new Point(279, 291);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(80, 60);
            btnSuma.TabIndex = 21;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Plum;
            btn2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(103, 291);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 60);
            btn2.TabIndex = 20;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Plum;
            btn0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn0.Location = new Point(15, 358);
            btn0.Name = "btn0";
            btn0.Size = new Size(168, 60);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnComa
            // 
            btnComa.BackColor = Color.Plum;
            btnComa.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComa.Location = new Point(191, 358);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(80, 60);
            btnComa.TabIndex = 18;
            btnComa.Text = ",";
            btnComa.UseVisualStyleBackColor = false;
            btnComa.Click += btnComa_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Plum;
            btn4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(15, 224);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 60);
            btn4.TabIndex = 17;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Plum;
            btn5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(103, 224);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 60);
            btn5.TabIndex = 16;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.BackColor = Color.Plum;
            btnPotencia.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPotencia.Location = new Point(191, 90);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(80, 60);
            btnPotencia.TabIndex = 15;
            btnPotencia.Text = "xʸ";
            btnPotencia.UseVisualStyleBackColor = false;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.Plum;
            btnDividir.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDividir.Location = new Point(279, 90);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(80, 60);
            btnDividir.TabIndex = 14;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Plum;
            btn7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(15, 157);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 60);
            btn7.TabIndex = 13;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Plum;
            btn8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(103, 157);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 60);
            btn8.TabIndex = 12;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Plum;
            btn9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(191, 157);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 60);
            btn9.TabIndex = 11;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.Plum;
            btnMultiplicar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(279, 157);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(80, 60);
            btnMultiplicar.TabIndex = 10;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnRaiz
            // 
            btnRaiz.BackColor = Color.Plum;
            btnRaiz.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRaiz.Location = new Point(103, 90);
            btnRaiz.Name = "btnRaiz";
            btnRaiz.Size = new Size(80, 60);
            btnRaiz.TabIndex = 2;
            btnRaiz.Text = "√";
            btnRaiz.UseVisualStyleBackColor = false;
            btnRaiz.Click += btnRaiz_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Plum;
            btnBorrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(15, 90);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(80, 60);
            btnBorrar.TabIndex = 1;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // txtPantalla
            // 
            txtPantalla.BackColor = Color.Plum;
            txtPantalla.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPantalla.Location = new Point(15, 15);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(345, 50);
            txtPantalla.TabIndex = 0;
            txtPantalla.Text = "0";
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            txtPantalla.TextChanged += txtPantalla_TextChanged;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.DarkOrchid;
            tabPage2.Controls.Add(txtWithIva);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtNoIva);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(btnCalculate);
            tabPage2.Controls.Add(chkPartner);
            tabPage2.Controls.Add(grpDiscount);
            tabPage2.Controls.Add(grpIva);
            tabPage2.Controls.Add(txtQuantity);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtPrice);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(376, 480);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "IVA";
            // 
            // txtWithIva
            // 
            txtWithIva.BackColor = Color.Pink;
            txtWithIva.Location = new Point(110, 397);
            txtWithIva.Name = "txtWithIva";
            txtWithIva.ReadOnly = true;
            txtWithIva.Size = new Size(250, 23);
            txtWithIva.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(15, 400);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 10;
            label4.Text = "CON IVA";
            // 
            // txtNoIva
            // 
            txtNoIva.BackColor = Color.Pink;
            txtNoIva.Location = new Point(110, 357);
            txtNoIva.Name = "txtNoIva";
            txtNoIva.ReadOnly = true;
            txtNoIva.Size = new Size(250, 23);
            txtNoIva.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(15, 360);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 8;
            label3.Text = "NO IVA";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Plum;
            btnCalculate.Location = new Point(15, 290);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(345, 45);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // chkPartner
            // 
            chkPartner.AutoSize = true;
            chkPartner.ForeColor = SystemColors.ControlLightLight;
            chkPartner.Location = new Point(195, 255);
            chkPartner.Name = "chkPartner";
            chkPartner.Size = new Size(64, 19);
            chkPartner.TabIndex = 6;
            chkPartner.Text = "Partner";
            chkPartner.UseVisualStyleBackColor = true;
            chkPartner.CheckedChanged += chkPartner_CheckedChanged;
            // 
            // grpDiscount
            // 
            grpDiscount.BackColor = Color.Plum;
            grpDiscount.Controls.Add(rbD20);
            grpDiscount.Controls.Add(rbD10);
            grpDiscount.Controls.Add(rbD5);
            grpDiscount.Controls.Add(rbD0);
            grpDiscount.Location = new Point(195, 95);
            grpDiscount.Name = "grpDiscount";
            grpDiscount.Size = new Size(165, 150);
            grpDiscount.TabIndex = 5;
            grpDiscount.TabStop = false;
            grpDiscount.Text = "Descuento";
            // 
            // rbD20
            // 
            rbD20.AutoSize = true;
            rbD20.Location = new Point(15, 115);
            rbD20.Name = "rbD20";
            rbD20.Size = new Size(50, 19);
            rbD20.TabIndex = 3;
            rbD20.Text = "20 %";
            rbD20.UseVisualStyleBackColor = true;
            // 
            // rbD10
            // 
            rbD10.AutoSize = true;
            rbD10.Location = new Point(15, 85);
            rbD10.Name = "rbD10";
            rbD10.Size = new Size(50, 19);
            rbD10.TabIndex = 2;
            rbD10.Text = "10 %";
            rbD10.UseVisualStyleBackColor = true;
            // 
            // rbD5
            // 
            rbD5.AutoSize = true;
            rbD5.Location = new Point(15, 55);
            rbD5.Name = "rbD5";
            rbD5.Size = new Size(44, 19);
            rbD5.TabIndex = 1;
            rbD5.Text = "5 %";
            rbD5.UseVisualStyleBackColor = true;
            // 
            // rbD0
            // 
            rbD0.AutoSize = true;
            rbD0.Checked = true;
            rbD0.Location = new Point(18, 22);
            rbD0.Name = "rbD0";
            rbD0.Size = new Size(44, 19);
            rbD0.TabIndex = 0;
            rbD0.TabStop = true;
            rbD0.Text = "0 %";
            rbD0.UseVisualStyleBackColor = true;
            // 
            // grpIva
            // 
            grpIva.BackColor = Color.Plum;
            grpIva.Controls.Add(rbIva21);
            grpIva.Controls.Add(rbIva10);
            grpIva.Controls.Add(rbIva4);
            grpIva.Controls.Add(rbIva0);
            grpIva.Location = new Point(15, 95);
            grpIva.Name = "grpIva";
            grpIva.Size = new Size(165, 150);
            grpIva.TabIndex = 4;
            grpIva.TabStop = false;
            grpIva.Text = "IVA";
            // 
            // rbIva21
            // 
            rbIva21.AutoSize = true;
            rbIva21.Location = new Point(15, 115);
            rbIva21.Name = "rbIva21";
            rbIva21.Size = new Size(50, 19);
            rbIva21.TabIndex = 3;
            rbIva21.Text = "21 %";
            rbIva21.UseVisualStyleBackColor = true;
            // 
            // rbIva10
            // 
            rbIva10.AutoSize = true;
            rbIva10.Location = new Point(15, 85);
            rbIva10.Name = "rbIva10";
            rbIva10.Size = new Size(50, 19);
            rbIva10.TabIndex = 2;
            rbIva10.Text = "10 %";
            rbIva10.UseVisualStyleBackColor = true;
            // 
            // rbIva4
            // 
            rbIva4.AutoSize = true;
            rbIva4.Location = new Point(15, 55);
            rbIva4.Name = "rbIva4";
            rbIva4.Size = new Size(44, 19);
            rbIva4.TabIndex = 1;
            rbIva4.Text = "4 %";
            rbIva4.UseVisualStyleBackColor = true;
            // 
            // rbIva0
            // 
            rbIva0.AutoSize = true;
            rbIva0.Checked = true;
            rbIva0.Location = new Point(18, 22);
            rbIva0.Name = "rbIva0";
            rbIva0.Size = new Size(44, 19);
            rbIva0.TabIndex = 0;
            rbIva0.TabStop = true;
            rbIva0.Text = "0 %";
            rbIva0.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(110, 52);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(250, 23);
            txtQuantity.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(15, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(110, 17);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(250, 23);
            txtPrice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Precio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 511);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Calculadora Pol";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            grpDiscount.ResumeLayout(false);
            grpDiscount.PerformLayout();
            grpIva.ResumeLayout(false);
            grpIva.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPantalla;
        private Button btnResta;
        private Button btn6;
        private Button btn1;
        private Button btn3;
        private Button btnSuma;
        private Button btn2;
        private Button btn0;
        private Button btnComa;
        private Button btn4;
        private Button btn5;
        private Button btnPotencia;
        private Button btnDividir;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicar;
        private Button btnRaiz;
        private Button btnBorrar;
        private Button btnIgual;
        private GroupBox grpIva;
        private RadioButton rbIva21;
        private RadioButton rbIva10;
        private RadioButton rbIva4;
        private RadioButton rbIva0;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtPrice;
        private Label label1;
        private GroupBox grpDiscount;
        private RadioButton rbD20;
        private RadioButton rbD10;
        private RadioButton rbD5;
        private RadioButton rbD0;
        private CheckBox chkPartner;
        private TextBox txtWithIva;
        private Label label4;
        private TextBox txtNoIva;
        private Label label3;
        private Button btnCalculate;
    }
}
