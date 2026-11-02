using System.Globalization;

namespace CalculadoraConInterfazPol
{
    public partial class Form1 : Form
    {
        Calculadora calc = new Calculadora();
        CalculadoraIVA calcIVA = new CalculadoraIVA();

        double primerNumero = 0;    // el numero de antes de pulsar + - x ...
        string operacion = "";      // la operacion que se ha pulsado
        bool numeroNuevo = true;    // si es true, el siguiente numero borra la pantalla

        public Form1()
        {
            InitializeComponent();

            // Para que los decimales sean con coma (2,5) en cualquier ordenador
            CultureInfo.CurrentCulture = new CultureInfo("es-ES");
        }

        // ---------- Metodos de ayuda ----------

        void EscribirNumero(string numero)
        {
            if (numeroNuevo || txtPantalla.Text == "0")
            {
                txtPantalla.Text = numero;
                numeroNuevo = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + numero;
            }
        }

        void ElegirOperacion(string op)
        {
            // Si ya habia una operacion pendiente (ej: 2 + 3 +), la hacemos primero
            if (operacion != "" && !numeroNuevo)
            {
                Calcular();
            }

            primerNumero = Convert.ToDouble(txtPantalla.Text);
            operacion = op;
            numeroNuevo = true;
        }

        void Calcular()
        {
            double segundoNumero = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = calc.Sumar(primerNumero, segundoNumero);
                    break;

                case "-":
                    resultado = calc.Restar(primerNumero, segundoNumero);
                    break;

                case "x":
                    resultado = calc.Multiplicar(primerNumero, segundoNumero);
                    break;

                case "/":
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show("Error: No se puede dividir entre cero.");
                        Borrar();
                        return;
                    }
                    resultado = calc.Dividir(primerNumero, segundoNumero);
                    break;

                case "^":
                    resultado = calc.Potencia(primerNumero, segundoNumero);
                    break;

                default:
                    return;
            }

            // Redondeamos para que no salgan cosas como 0,30000000000000004
            txtPantalla.Text = Math.Round(resultado, 10).ToString();
            operacion = "";
            numeroNuevo = true;
        }

        void Borrar()
        {
            txtPantalla.Text = "0";
            primerNumero = 0;
            operacion = "";
            numeroNuevo = true;
        }

        // ---------- Botones de numeros ----------

        private void btn0_Click(object sender, EventArgs e)
        {
            EscribirNumero("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            EscribirNumero("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            EscribirNumero("2");
        }

        // Este es el boton 3 (se llama button6 porque se creo antes de cambiarle el nombre)
        private void button6_Click(object sender, EventArgs e)
        {
            EscribirNumero("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            EscribirNumero("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            EscribirNumero("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            EscribirNumero("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            EscribirNumero("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            EscribirNumero("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            EscribirNumero("9");
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (numeroNuevo)
            {
                txtPantalla.Text = "0,";
                numeroNuevo = false;
            }
            else if (!txtPantalla.Text.Contains(","))
            {
                txtPantalla.Text = txtPantalla.Text + ",";
            }
        }

        // ---------- Botones de operaciones ----------

        private void btnSuma_Click(object sender, EventArgs e)
        {
            ElegirOperacion("+");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            ElegirOperacion("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            ElegirOperacion("x");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            ElegirOperacion("/");
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            ElegirOperacion("^");
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(txtPantalla.Text);

            if (numero < 0)
            {
                MessageBox.Show("Error: No se puede hacer la raiz de un numero negativo.");
            }
            else
            {
                txtPantalla.Text = Math.Round(calc.RaizCuadrada(numero), 10).ToString();
            }
            numeroNuevo = true;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Borrar();
        }

        // ---------- Huecos que se crearon sin querer (se pueden dejar vacios) ----------

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        // ---------- Pestaña IVA ----------

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double precio;
            double cantidad;

            try
            {
                precio = Convert.ToDouble(txtPrice.Text);
                cantidad = Convert.ToDouble(txtQuantity.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Tienes que escribir un numero valido.");
                return;
            }

            if (precio < 0)
            {
                MessageBox.Show("Error: El precio no puede ser negativo.");
                return;
            }

            if (cantidad < 1)
            {
                MessageBox.Show("Error: La cantidad tiene que ser 1 o mas.");
                return;
            }

            // Descuento (si es Partner siempre es un 30%)
            double descuento = 0;
            if (chkPartner.Checked) descuento = 30;
            else if (rbD5.Checked) descuento = 5;
            else if (rbD10.Checked) descuento = 10;
            else if (rbD20.Checked) descuento = 20;

            // IVA
            if (rbIva0.Checked) calcIVA.porcentajeIVA = 0;
            else if (rbIva4.Checked) calcIVA.porcentajeIVA = 4;
            else if (rbIva10.Checked) calcIVA.porcentajeIVA = 10;
            else if (rbIva21.Checked) calcIVA.porcentajeIVA = 21;

            // Primero el descuento y despues el IVA
            double subtotal = precio * cantidad;
            calcIVA.baseImponible = subtotal - subtotal * (descuento / 100);

            // "C2" = moneda con 2 decimales (93,60 €)
            txtNoIva.Text = Math.Round(calcIVA.baseImponible, 2).ToString("C2");
            txtWithIva.Text = Math.Round(calcIVA.CalcularTotal(), 2).ToString("C2");
        }

        private void chkPartner_CheckedChanged(object sender, EventArgs e)
        {
            // Si es Partner, no se puede elegir descuento (ya tiene el 30%)
            if (chkPartner.Checked)
            {
                grpDiscount.Enabled = false;
            }
            else
            {
                grpDiscount.Enabled = true;
            }
        }
    }
}
