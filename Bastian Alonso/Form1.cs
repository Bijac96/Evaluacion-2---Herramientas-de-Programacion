namespace Bastian_Alonso
{
    public partial class Form1 : Form
    {
        private Atencion[] atencion = new Atencion[100];
        private int cantidad = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }
        public void salir()
        {
            Application.Exit();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
        private Cliente buscarCliente(string rut)
        {
            Cliente c;
            for (int i = 0; i < cantidad; i++)
            {
                c = atencion[i].ClienteAtencion;
                if (c.Rut.Equals(rut))
                    return c;
            }
            return null;
        }
        private void enlazarAtencionCliente(Atencion a, Cliente c)
        {
            a.ClienteAtencion = c;
            c[c.Cantidad] = a;
            //c.Cantidad++;
        }
        private void mostrar(Atencion a, Cliente c)
        {
            string Datos = "Tipo de atencion: " + a.TipoAtencion + ", Fecha: " + a.Fecha + ", Hora: " + a.Hora
                + ", Rut cliente: " + c.Rut + "Nombre cliente: " + c.Nombre + ", Celular cliente: " + c.Celular + ", E-Mail cliente: " + c.Email + ".";
            lstViewReservas.Items.Add(Datos);
            MessageBox.Show("Turno ingresado");
            limpiar();
        }
        public void limpiar()
        {
            txtRut.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            chkBoxBarba.Checked = false;
            chkBoxCabello.Checked = false;
            cmbHora.SelectedItem = null;
            txtNombreEx.Clear();
            txtCelularEx.Clear();
            txtEmailEx.Clear();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if ((chkBoxBarba.Checked == true || chkBoxCabello.Checked == true) && cmbHora.SelectedItem != null)
            {
                Atencion a = new Atencion();
                a.Fecha = Calendar.SelectionStart.ToString();
                a.Fecha = a.Fecha.Substring(0, 10); //Quitamos la hora de la cadena
                a.Hora = cmbHora.Text;
                if (chkBoxBarba.Checked == true && chkBoxCabello.Checked == true)
                    a.TipoAtencion = chkBoxCabello.Text + " y " + chkBoxBarba.Text;
                else if (chkBoxBarba.Checked == true && chkBoxCabello.Checked == false)
                    a.TipoAtencion = chkBoxBarba.Text;
                else
                    a.TipoAtencion = chkBoxCabello.Text;

                if (txtRut.Text != "" && txtNombre.Text != "" && txtCelular.Text != "" && txtEmail.Text != "")
                {
                    //Creamos cliente
                    Cliente c = new Cliente();
                    c.Rut = txtRut.Text;
                    c.Nombre = txtNombre.Text;
                    c.Celular = txtCelular.Text;
                    c.Email = txtEmail.Text;
                    //Enlazamos el cliente con la atencion
                    enlazarAtencionCliente(a, c);
                    mostrar(a, c);
                    //Agregamos rut al ComboBox
                    cmbRutEx.Items.Add(c.Rut);
                    //Agregamos el turno de atencion al arreglo
                    atencion[cantidad] = a;
                    cantidad++;
                }
                else if (cmbRutEx.SelectedItem != null)
                {
                    Cliente c = buscarCliente(cmbRutEx.Text);
                    enlazarAtencionCliente(a, c);
                    mostrar(a, c);

                    atencion[cantidad] = a;
                    cantidad++;
                }
            }
            else
            {
                MessageBox.Show("No estan los datos completos");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbRutEx.SelectedItem != null)
            {
                Cliente c;
                c = buscarCliente(cmbRutEx.Text);
                if (c != null)
                {
                    txtNombreEx.Text = c.Nombre;
                    txtCelularEx.Text = c.Celular;
                    txtEmailEx.Text = c.Email;
                }
                else
                {
                    MessageBox.Show("Seleccione un RUT o ingrese un cliente nuevo");
                }
            }
        }
    }
}