namespace Turnero
{
    public partial class Form1 : Form
    {
        // Se crean los nodos PRIMERO & ULTIMO
        Nodo PRIMERO = null;
        Nodo ULTIMO = null;

        // Se crea el contador inicializado en 0
        int CONTADOR = 0;

        //Lamo a que se cree el segundo formulario
        Form2 F2 = new Form2();

        public Form1()
        {
            InitializeComponent();

            // Indico que se muestre el FORMULARIO 2
            F2.Show();
        }

        private void cmdRegistras_Click(object sender, EventArgs e)
        {
            // Se crea el nodo "NUEVO" para cada paciente que llegue
            Nodo NuevoPACIENTE = new Nodo();
            // Los atributos del nodo NUEVO, son completados con lo que ingrese el usuario
            NuevoPACIENTE.nombre = txtNombre.Text;
            NuevoPACIENTE.apellido = txtApellido.Text;
            NuevoPACIENTE.dni = txtDNI.Text;
            NuevoPACIENTE.edad = txtEdad.Text;

            if (PRIMERO == null)                    //Si la cola esta VACIA. (PRIMERO no existe.)
            {
                PRIMERO = NuevoPACIENTE;           //El NUEVO paciente es el unico por ende, es PRIMERO & ULTIMO.
                ULTIMO = NuevoPACIENTE;
            }
            else                                   // Si la cola YA TIENE pacientes.
            {
                ULTIMO.SIGUIENTE = NuevoPACIENTE;  // Se asigna valor a SIGUIENTE, del paciente que estaba ULTIMO 
                ULTIMO = NuevoPACIENTE;            // Ahora ULTIMO, se le asigna al RECIEN LLEGADO
            }
            CONTADOR++;                                  // Cada vez que pasa este EVENTE, se INCREMENTA el contador.
            lblEspera.Text = CONTADOR.ToString("000");   // Se muestra en pantalla el NUEVO VALOR del CONTADOR.
        }

        private void cmdAtender_Click(object sender, EventArgs e)
        {
            if (PRIMERO != null)                    // Si EXITE pacientes esperando. 
            {
                // Se llama al metodo del FORMULARIO 2. LLAMAR PACIENTE. Se pasa los ATRIBUTOS de AUXILIAR que copio de PRIMERO.
                F2.LlamarPaciente(PRIMERO.apellido + ", " + PRIMERO.nombre);

                PRIMERO = PRIMERO.SIGUIENTE;       // PRIMERO toma los datos que tiene AUXILIAR.SIGUIENTE

                CONTADOR--;                         // Se DISMINUYE el CONTADOR
                lblEspera.Text = CONTADOR.ToString("000");  // Se muestra el contador ACTUALIZADO
            }
            else
            {
                F2.LlamarPaciente("Bienvenido");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}