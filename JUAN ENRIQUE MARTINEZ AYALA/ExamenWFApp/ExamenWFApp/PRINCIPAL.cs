using System.Data;
using System.Data.OleDb;
namespace ExamenWFApp
{
    public partial class PRINCIPAL : Form
    {
        public PRINCIPAL()
        {
            InitializeComponent();
        }
        // Desarrollador Juan Enrique Martinez Ayala
        // Fecha de desarrollo 29-06-2023

        //NOTAS: El Id se dejo libre, se metieron validaciones para saber si existe o no, No es consecutivo.
        //Se tomo en cuenta dado que no se sabe si es una tabla basada en parametros existentes o consecutivo nuevos.
        CONECTORES.Conexion obDatos = new CONECTORES.Conexion();
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {
            //Centramos Ventana
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            
            CargarDatos();
            //bandera = 1;
        }
        public void CargarDatos()
        {
            Llenar_datagrid();
            Llenar_combobox();
        }
        public void Llenar_datagrid() 
        {
           // datagrid_Consulta.Rows.Clear();
            datagrid_Consulta.DataSource = null;
            datagrid_Consulta.Refresh();

            DataTable ds = new DataTable();
            ds = obDatos.Consultar("SELECT idExamen,Nombre,Descripcion FROM tblExamen", "tblExamen");
            string Nombre = "", Descripcion = "";
            if (ds.Rows.Count > 0)
            {
                datagrid_Consulta.DataSource = ds;
                datagrid_Consulta.AutoResizeColumns();
                datagrid_Consulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            else
            {
                    System.Windows.Forms.MessageBox.Show("De momento no cuenta con registros.");
                    return;
            }

        }

        //PARA BUSQUEDAS POR COINCIDENCIAS DENTRO DE UN COMBOBOX SE MODIFICAN LAS SIGUIENTES PROPIEDADES
        //Propiedad DropDownStyle en DropDown
        //Propiedad AutocompleteSource en ListItems
        //Propiedad Autocompletemode en Suggest
        //ES MAS PRACTICO A LA HORA DE BUSCAR UN ITEM QUE COINCIDA QUE USAR UN TEXTBOX
        public void Llenar_combobox()
        {
            try
            {
                cbo_Buscar.DataSource = null;
                cbo_Buscar.Items.Clear();
                this.cbo_Buscar.DataSource = obDatos.Consultar("SELECT idExamen, Nombre, Descripcion FROM tblExamen order by idExamen asc", "tblExamen");
                if(rbtn_Id.Checked == true) { this.cbo_Buscar.DisplayMember = "idExamen"; cbo_Buscar.RightToLeft = RightToLeft.Yes; }
                else if(rbtn_Nombre.Checked == true) { cbo_Buscar.DisplayMember = "Nombre"; cbo_Buscar.RightToLeft = RightToLeft.No; }
                else if (rbtn_Descripcion.Checked == true) { cbo_Buscar.DisplayMember = "Descripcion"; cbo_Buscar.RightToLeft = RightToLeft.No; }
                this.cbo_Buscar.ValueMember = "idExamen";
                cbo_Buscar.SelectedIndex = -1;
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }

        }

        private void txt_Id_Agregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_Id_Actualizar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_Id_Eliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try { 
                    Agregar();
                    CargarDatos();
                }
            catch (OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void btn_GuardarCambios_Click(object sender, EventArgs e)
        {
            try {
                    Editar();
                    CargarDatos();
                }
            catch (OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void btn_Buscar_Eliminar_Click(object sender, EventArgs e)
        {
            try {
                    Buscar_Id("Eliminar");
                }
            catch (OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_Id("Consultar");
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }
        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            //SE PUEDE HACER UN REFRESH PASANDO LOS CONTROLADORES A DEFAULT UNO POR UNO O BIEN EN EL CASO DE NO CARGAR TANTOS DATOS COMO ACTUALMENTE
            //ELIMINAR Y CREAR LA VENTANA NUEVAMENTE
            PRINCIPAL NewForm = new PRINCIPAL();
            NewForm.Show();
            this.Dispose(false);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Eliminar();
                CargarDatos();
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }
        public void Agregar() 
        {
            if (txt_Id_Agregar.Text == "" || txt_Nombre_Agregar.Text == "" || txt_Descripcion_Agregar.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Todos los campos son obligatorios.", "Error: campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataTable ds = new DataTable();
                ds = obDatos.spAgregar(txt_Id_Agregar.Text, txt_Nombre_Agregar.Text, txt_Descripcion_Agregar.Text);
                string Codigo = "", Descripcion = "";

                foreach (DataRow row in ds.Rows)
                {
                    Codigo = Convert.ToString(row[0]);
                    Descripcion = Convert.ToString(row[1]);
                    MessageBox.Show("Codigo: (" + Codigo + ")" + " " + Descripcion);
                }
                if (Codigo.Equals("1"))
                {
                    txt_Id_Agregar.Text = "";
                    txt_Nombre_Agregar.Text = "";
                    txt_Descripcion_Agregar.Text = "";
                }
            }
        }
        public void Editar() 
        {
            if (txt_Id_Actualizar.Text == "" || txt_Nombre_Actualizar.Text == "" || txt_Descripcion_Actualizar.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Todos los campos son obligatorios.", "Error: campos vacios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataTable ds = new DataTable();
                ds = obDatos.spActualizar(txt_Id_Actualizar.Text, txt_Nombre_Actualizar.Text, txt_Descripcion_Actualizar.Text);
                string Codigo = "", Descripcion = "";

                foreach (DataRow row in ds.Rows)
                {
                    Codigo = Convert.ToString(row[0]);
                    Descripcion = Convert.ToString(row[1]);
                    MessageBox.Show("Codigo: (" + Codigo + ")" + " " + Descripcion);
                }
                if (Codigo.Equals("1"))
                {
                    txt_Id_Actualizar.Text = "";
                    txt_Nombre_Actualizar.Text = "";
                    txt_Descripcion_Actualizar.Text = "";
                }
            }
        }
        public void Eliminar() 
        {
            if (txt_Id_Eliminar.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Campo ID obligatorio.", "Error: campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DataTable ds = new DataTable();
                ds = obDatos.spEliminar(txt_Id_Eliminar.Text);
                string Codigo = "", Descripcion = "";

                foreach (DataRow row in ds.Rows)
                {
                    Codigo = Convert.ToString(row[0]);
                    Descripcion = Convert.ToString(row[1]);
                    MessageBox.Show("Codigo: (" + Codigo + ")" + " " + Descripcion);
                }
                if (Codigo.Equals("1"))
                {
                    txt_Id_Eliminar.Text = "";
                    txt_Nombre_Eliminar.Text = "";
                    txt_Descripcion_Eliminar.Text = "";
                }
            }
        }

        //Se puede realizar por medio de un SP, para ejemplos diversos de formas de consulta y dado que es una ventana fija,
        //se opto por dejar la consulta dentro del codigo
        public void Buscar_Id(string Tipo) 
        {
            if (Tipo.Equals("Eliminar"))
            {
                txt_Nombre_Eliminar.Text = "";
                txt_Descripcion_Eliminar.Text = "";
                if (txt_Id_Eliminar.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Campo ID obligatorio.", "Error: campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DataTable ds = new DataTable();
                    ds = obDatos.Consultar("SELECT idExamen,Nombre,Descripcion FROM tblExamen WHERE idExamen = " + txt_Id_Eliminar.Text + " ", "tblExamen");
                    string Nombre = "", Descripcion = "";
                    if (ds.Rows.Count > 0)
                    {
                        foreach (DataRow row in ds.Rows)
                        {
                            Nombre = Convert.ToString(row[1]);
                            Descripcion = Convert.ToString(row[2]);
                            txt_Nombre_Eliminar.Text = Nombre;
                            txt_Descripcion_Eliminar.Text = Descripcion;
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Registro no encontrado.");
                        return;
                    }

                }
            }
            else if (Tipo.Equals("Consultar")) 
            {
                bool existe = false;
                //Buscamos Elemento en combobox
                cbo_Buscar.SelectedIndex = cbo_Buscar.FindStringExact(cbo_Buscar.Text);

                //Revisamos si existe o no 
                int i = cbo_Buscar.FindStringExact(cbo_Buscar.Text);
                if (i >= 0)
                {
                    existe = true;
                }
                //Se opto para hacer mas eficiente la busqueda del spConsulta usar el IdValue del Combobox de Busqueda
                if (existe == false)
                {
                    System.Windows.Forms.MessageBox.Show("Selecione un elemento del combo o ingrese uno existente.", "Error: No existe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
                else if (cbo_Buscar.Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Elegir o Ingresar un Dato a Buscar.", "Error: Campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    DataTable ds = new DataTable();
                    ds = obDatos.spConsultar(cbo_Buscar.SelectedValue.ToString());
                    string Nombre = "", Descripcion = "";
                    if (ds.Rows.Count > 0)
                    {
                        datagrid_Consulta.DataSource = ds;
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Registro no encontrado.");
                        return;
                    }

                }
            }
            else if (Tipo.Equals("Editar"))
                {
                    txt_Nombre_Actualizar.Text = "";
                    txt_Descripcion_Actualizar.Text = "";
                    if (txt_Id_Actualizar.Text == "")
                    {
                        System.Windows.Forms.MessageBox.Show("Campo ID obligatorio.", "Error: campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        DataTable ds = new DataTable();
                        ds = obDatos.Consultar("SELECT idExamen,Nombre,Descripcion FROM tblExamen WHERE idExamen = " + txt_Id_Actualizar.Text + " ", "tblExamen");
                        string Nombre = "", Descripcion = "";
                        if (ds.Rows.Count > 0)
                        {
                            foreach (DataRow row in ds.Rows)
                            {
                                Nombre = Convert.ToString(row[1]);
                                Descripcion = Convert.ToString(row[2]);
                                txt_Nombre_Actualizar.Text = Nombre;
                                txt_Descripcion_Actualizar.Text = Descripcion;
                            }
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Registro no encontrado.");
                            return;
                        }

                    }
                }
        }

        private void rbtn_Id_CheckedChanged(object sender, EventArgs e)
        {
            Llenar_combobox();
        }

        private void rbtn_Nombre_CheckedChanged(object sender, EventArgs e)
        {
            Llenar_combobox();
        }

        private void rbtn_Descripcion_CheckedChanged(object sender, EventArgs e)
        {
            Llenar_combobox();
        }

        private void btn_Buscar_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Buscar_Id("Editar");
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Error: " + exp.Message);
            }
        }

        private void txt_Id_Eliminar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Nombre_Eliminar.Text != "")
            {
                txt_Nombre_Eliminar.Text = "";
            }
            if (txt_Descripcion_Eliminar.Text != "") 
            {
                txt_Descripcion_Eliminar.Text = "";
            }
        }
    }
}