namespace estructurasMultiples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnumero.Clear();
            txtdia.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaracion
            byte numero;
            string dia;
            //Entrada de datos
            numero = Convert.ToByte(txtnumero.Text);
            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miercoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sabado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Ingrese un nuevo numero";
                    break;

            }
            //Salida
            txtdia.Text = dia;
        }
    }
}