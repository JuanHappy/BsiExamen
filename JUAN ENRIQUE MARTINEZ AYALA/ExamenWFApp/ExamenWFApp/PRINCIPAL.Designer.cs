namespace ExamenWFApp
{
    partial class PRINCIPAL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn_Descripcion = new System.Windows.Forms.RadioButton();
            this.btn_Refrescar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.rbtn_Nombre = new System.Windows.Forms.RadioButton();
            this.rbtn_Id = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_Buscar = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagrid_Consulta = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Agregar = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_Descripcion_Agregar = new System.Windows.Forms.TextBox();
            this.lb_Descripcion = new System.Windows.Forms.Label();
            this.txt_Nombre_Agregar = new System.Windows.Forms.TextBox();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.txt_Id_Agregar = new System.Windows.Forms.TextBox();
            this.lb_ID = new System.Windows.Forms.Label();
            this.tabPage_Editar = new System.Windows.Forms.TabPage();
            this.btn_Buscar_Editar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_GuardarCambios = new System.Windows.Forms.Button();
            this.txt_Descripcion_Actualizar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nombre_Actualizar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Id_Actualizar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage_Eliminar = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_Buscar_Eliminar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.txt_Descripcion_Eliminar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Nombre_Eliminar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Id_Eliminar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Consulta)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage_Agregar.SuspendLayout();
            this.tabPage_Editar.SuspendLayout();
            this.tabPage_Eliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btn_Cerrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 37);
            this.panel2.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cerrar.Location = new System.Drawing.Point(825, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(94, 37);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(919, 51);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXAMEN BASICO DE SELECCION";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtn_Descripcion);
            this.panel4.Controls.Add(this.btn_Refrescar);
            this.panel4.Controls.Add(this.btn_Buscar);
            this.panel4.Controls.Add(this.rbtn_Nombre);
            this.panel4.Controls.Add(this.rbtn_Id);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbo_Buscar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(919, 60);
            this.panel4.TabIndex = 1;
            // 
            // rbtn_Descripcion
            // 
            this.rbtn_Descripcion.AutoSize = true;
            this.rbtn_Descripcion.Location = new System.Drawing.Point(260, 19);
            this.rbtn_Descripcion.Name = "rbtn_Descripcion";
            this.rbtn_Descripcion.Size = new System.Drawing.Size(108, 24);
            this.rbtn_Descripcion.TabIndex = 7;
            this.rbtn_Descripcion.Text = "Descripcion";
            this.rbtn_Descripcion.UseVisualStyleBackColor = true;
            this.rbtn_Descripcion.CheckedChanged += new System.EventHandler(this.rbtn_Descripcion_CheckedChanged);
            // 
            // btn_Refrescar
            // 
            this.btn_Refrescar.Location = new System.Drawing.Point(818, 20);
            this.btn_Refrescar.Name = "btn_Refrescar";
            this.btn_Refrescar.Size = new System.Drawing.Size(89, 29);
            this.btn_Refrescar.TabIndex = 6;
            this.btn_Refrescar.Text = "Refrescar";
            this.btn_Refrescar.UseVisualStyleBackColor = true;
            this.btn_Refrescar.Click += new System.EventHandler(this.btn_Refrescar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(657, 20);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(74, 29);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // rbtn_Nombre
            // 
            this.rbtn_Nombre.AutoSize = true;
            this.rbtn_Nombre.Checked = true;
            this.rbtn_Nombre.Location = new System.Drawing.Point(169, 19);
            this.rbtn_Nombre.Name = "rbtn_Nombre";
            this.rbtn_Nombre.Size = new System.Drawing.Size(85, 24);
            this.rbtn_Nombre.TabIndex = 3;
            this.rbtn_Nombre.TabStop = true;
            this.rbtn_Nombre.Text = "Nombre";
            this.rbtn_Nombre.UseVisualStyleBackColor = true;
            this.rbtn_Nombre.CheckedChanged += new System.EventHandler(this.rbtn_Nombre_CheckedChanged);
            // 
            // rbtn_Id
            // 
            this.rbtn_Id.AutoSize = true;
            this.rbtn_Id.Location = new System.Drawing.Point(120, 19);
            this.rbtn_Id.Name = "rbtn_Id";
            this.rbtn_Id.Size = new System.Drawing.Size(43, 24);
            this.rbtn_Id.TabIndex = 2;
            this.rbtn_Id.Text = "Id";
            this.rbtn_Id.UseVisualStyleBackColor = true;
            this.rbtn_Id.CheckedChanged += new System.EventHandler(this.rbtn_Id_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por:";
            // 
            // cbo_Buscar
            // 
            this.cbo_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbo_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Buscar.FormattingEnabled = true;
            this.cbo_Buscar.Location = new System.Drawing.Point(374, 21);
            this.cbo_Buscar.Name = "cbo_Buscar";
            this.cbo_Buscar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbo_Buscar.Size = new System.Drawing.Size(276, 28);
            this.cbo_Buscar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datagrid_Consulta);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 467);
            this.panel1.TabIndex = 4;
            // 
            // datagrid_Consulta
            // 
            this.datagrid_Consulta.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.datagrid_Consulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Consulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_Consulta.Location = new System.Drawing.Point(333, 60);
            this.datagrid_Consulta.Name = "datagrid_Consulta";
            this.datagrid_Consulta.ReadOnly = true;
            this.datagrid_Consulta.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.datagrid_Consulta.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Consulta.RowTemplate.Height = 29;
            this.datagrid_Consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_Consulta.Size = new System.Drawing.Size(586, 407);
            this.datagrid_Consulta.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Agregar);
            this.tabControl1.Controls.Add(this.tabPage_Editar);
            this.tabControl1.Controls.Add(this.tabPage_Eliminar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(333, 407);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage_Agregar
            // 
            this.tabPage_Agregar.Controls.Add(this.panel5);
            this.tabPage_Agregar.Controls.Add(this.btn_Agregar);
            this.tabPage_Agregar.Controls.Add(this.txt_Descripcion_Agregar);
            this.tabPage_Agregar.Controls.Add(this.lb_Descripcion);
            this.tabPage_Agregar.Controls.Add(this.txt_Nombre_Agregar);
            this.tabPage_Agregar.Controls.Add(this.lb_Nombre);
            this.tabPage_Agregar.Controls.Add(this.txt_Id_Agregar);
            this.tabPage_Agregar.Controls.Add(this.lb_ID);
            this.tabPage_Agregar.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Agregar.Name = "tabPage_Agregar";
            this.tabPage_Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Agregar.Size = new System.Drawing.Size(325, 374);
            this.tabPage_Agregar.TabIndex = 0;
            this.tabPage_Agregar.Text = "Agregar";
            this.tabPage_Agregar.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(319, 16);
            this.panel5.TabIndex = 9;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(219, 307);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(89, 29);
            this.btn_Agregar.TabIndex = 7;
            this.btn_Agregar.Text = "Guardar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_Descripcion_Agregar
            // 
            this.txt_Descripcion_Agregar.Location = new System.Drawing.Point(28, 180);
            this.txt_Descripcion_Agregar.MaxLength = 255;
            this.txt_Descripcion_Agregar.Multiline = true;
            this.txt_Descripcion_Agregar.Name = "txt_Descripcion_Agregar";
            this.txt_Descripcion_Agregar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Descripcion_Agregar.Size = new System.Drawing.Size(280, 121);
            this.txt_Descripcion_Agregar.TabIndex = 5;
            // 
            // lb_Descripcion
            // 
            this.lb_Descripcion.AutoSize = true;
            this.lb_Descripcion.Location = new System.Drawing.Point(28, 157);
            this.lb_Descripcion.Name = "lb_Descripcion";
            this.lb_Descripcion.Size = new System.Drawing.Size(90, 20);
            this.lb_Descripcion.TabIndex = 4;
            this.lb_Descripcion.Text = "Descripcion:";
            // 
            // txt_Nombre_Agregar
            // 
            this.txt_Nombre_Agregar.Location = new System.Drawing.Point(28, 110);
            this.txt_Nombre_Agregar.MaxLength = 255;
            this.txt_Nombre_Agregar.Name = "txt_Nombre_Agregar";
            this.txt_Nombre_Agregar.Size = new System.Drawing.Size(280, 27);
            this.txt_Nombre_Agregar.TabIndex = 3;
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(28, 87);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(67, 20);
            this.lb_Nombre.TabIndex = 2;
            this.lb_Nombre.Text = "Nombre:";
            // 
            // txt_Id_Agregar
            // 
            this.txt_Id_Agregar.Location = new System.Drawing.Point(28, 53);
            this.txt_Id_Agregar.MaxLength = 10;
            this.txt_Id_Agregar.Name = "txt_Id_Agregar";
            this.txt_Id_Agregar.Size = new System.Drawing.Size(107, 27);
            this.txt_Id_Agregar.TabIndex = 1;
            this.txt_Id_Agregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Id_Agregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_Agregar_KeyPress);
            // 
            // lb_ID
            // 
            this.lb_ID.AutoSize = true;
            this.lb_ID.Location = new System.Drawing.Point(28, 30);
            this.lb_ID.Name = "lb_ID";
            this.lb_ID.Size = new System.Drawing.Size(27, 20);
            this.lb_ID.TabIndex = 0;
            this.lb_ID.Text = "ID:";
            // 
            // tabPage_Editar
            // 
            this.tabPage_Editar.Controls.Add(this.btn_Buscar_Editar);
            this.tabPage_Editar.Controls.Add(this.panel6);
            this.tabPage_Editar.Controls.Add(this.btn_GuardarCambios);
            this.tabPage_Editar.Controls.Add(this.txt_Descripcion_Actualizar);
            this.tabPage_Editar.Controls.Add(this.label3);
            this.tabPage_Editar.Controls.Add(this.txt_Nombre_Actualizar);
            this.tabPage_Editar.Controls.Add(this.label4);
            this.tabPage_Editar.Controls.Add(this.txt_Id_Actualizar);
            this.tabPage_Editar.Controls.Add(this.label5);
            this.tabPage_Editar.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Editar.Name = "tabPage_Editar";
            this.tabPage_Editar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Editar.Size = new System.Drawing.Size(325, 374);
            this.tabPage_Editar.TabIndex = 1;
            this.tabPage_Editar.Text = "Editar";
            this.tabPage_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Buscar_Editar
            // 
            this.btn_Buscar_Editar.Location = new System.Drawing.Point(141, 48);
            this.btn_Buscar_Editar.Name = "btn_Buscar_Editar";
            this.btn_Buscar_Editar.Size = new System.Drawing.Size(74, 29);
            this.btn_Buscar_Editar.TabIndex = 23;
            this.btn_Buscar_Editar.Text = "Buscar";
            this.btn_Buscar_Editar.UseVisualStyleBackColor = true;
            this.btn_Buscar_Editar.Click += new System.EventHandler(this.btn_Buscar_Editar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SteelBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(319, 16);
            this.panel6.TabIndex = 15;
            // 
            // btn_GuardarCambios
            // 
            this.btn_GuardarCambios.Location = new System.Drawing.Point(171, 304);
            this.btn_GuardarCambios.Name = "btn_GuardarCambios";
            this.btn_GuardarCambios.Size = new System.Drawing.Size(137, 29);
            this.btn_GuardarCambios.TabIndex = 14;
            this.btn_GuardarCambios.Text = "Guardar Cambios";
            this.btn_GuardarCambios.UseVisualStyleBackColor = true;
            this.btn_GuardarCambios.Click += new System.EventHandler(this.btn_GuardarCambios_Click);
            // 
            // txt_Descripcion_Actualizar
            // 
            this.txt_Descripcion_Actualizar.Location = new System.Drawing.Point(28, 177);
            this.txt_Descripcion_Actualizar.MaxLength = 255;
            this.txt_Descripcion_Actualizar.Multiline = true;
            this.txt_Descripcion_Actualizar.Name = "txt_Descripcion_Actualizar";
            this.txt_Descripcion_Actualizar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Descripcion_Actualizar.Size = new System.Drawing.Size(280, 121);
            this.txt_Descripcion_Actualizar.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Descripcion:";
            // 
            // txt_Nombre_Actualizar
            // 
            this.txt_Nombre_Actualizar.Location = new System.Drawing.Point(28, 107);
            this.txt_Nombre_Actualizar.MaxLength = 255;
            this.txt_Nombre_Actualizar.Name = "txt_Nombre_Actualizar";
            this.txt_Nombre_Actualizar.Size = new System.Drawing.Size(280, 27);
            this.txt_Nombre_Actualizar.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre:";
            // 
            // txt_Id_Actualizar
            // 
            this.txt_Id_Actualizar.Location = new System.Drawing.Point(28, 50);
            this.txt_Id_Actualizar.MaxLength = 10;
            this.txt_Id_Actualizar.Name = "txt_Id_Actualizar";
            this.txt_Id_Actualizar.Size = new System.Drawing.Size(107, 27);
            this.txt_Id_Actualizar.TabIndex = 9;
            this.txt_Id_Actualizar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Id_Actualizar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_Actualizar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID:";
            // 
            // tabPage_Eliminar
            // 
            this.tabPage_Eliminar.Controls.Add(this.panel7);
            this.tabPage_Eliminar.Controls.Add(this.btn_Buscar_Eliminar);
            this.tabPage_Eliminar.Controls.Add(this.btn_Eliminar);
            this.tabPage_Eliminar.Controls.Add(this.txt_Descripcion_Eliminar);
            this.tabPage_Eliminar.Controls.Add(this.label6);
            this.tabPage_Eliminar.Controls.Add(this.txt_Nombre_Eliminar);
            this.tabPage_Eliminar.Controls.Add(this.label7);
            this.tabPage_Eliminar.Controls.Add(this.txt_Id_Eliminar);
            this.tabPage_Eliminar.Controls.Add(this.label8);
            this.tabPage_Eliminar.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Eliminar.Name = "tabPage_Eliminar";
            this.tabPage_Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Eliminar.Size = new System.Drawing.Size(325, 374);
            this.tabPage_Eliminar.TabIndex = 2;
            this.tabPage_Eliminar.Text = "Eliminar";
            this.tabPage_Eliminar.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 16);
            this.panel7.TabIndex = 23;
            // 
            // btn_Buscar_Eliminar
            // 
            this.btn_Buscar_Eliminar.Location = new System.Drawing.Point(141, 48);
            this.btn_Buscar_Eliminar.Name = "btn_Buscar_Eliminar";
            this.btn_Buscar_Eliminar.Size = new System.Drawing.Size(74, 29);
            this.btn_Buscar_Eliminar.TabIndex = 22;
            this.btn_Buscar_Eliminar.Text = "Buscar";
            this.btn_Buscar_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Buscar_Eliminar.Click += new System.EventHandler(this.btn_Buscar_Eliminar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(165, 319);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(137, 29);
            this.btn_Eliminar.TabIndex = 21;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // txt_Descripcion_Eliminar
            // 
            this.txt_Descripcion_Eliminar.Enabled = false;
            this.txt_Descripcion_Eliminar.Location = new System.Drawing.Point(28, 176);
            this.txt_Descripcion_Eliminar.MaxLength = 255;
            this.txt_Descripcion_Eliminar.Multiline = true;
            this.txt_Descripcion_Eliminar.Name = "txt_Descripcion_Eliminar";
            this.txt_Descripcion_Eliminar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Descripcion_Eliminar.Size = new System.Drawing.Size(280, 121);
            this.txt_Descripcion_Eliminar.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Descripcion:";
            // 
            // txt_Nombre_Eliminar
            // 
            this.txt_Nombre_Eliminar.Enabled = false;
            this.txt_Nombre_Eliminar.Location = new System.Drawing.Point(28, 106);
            this.txt_Nombre_Eliminar.MaxLength = 255;
            this.txt_Nombre_Eliminar.Name = "txt_Nombre_Eliminar";
            this.txt_Nombre_Eliminar.Size = new System.Drawing.Size(280, 27);
            this.txt_Nombre_Eliminar.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre:";
            // 
            // txt_Id_Eliminar
            // 
            this.txt_Id_Eliminar.Location = new System.Drawing.Point(28, 49);
            this.txt_Id_Eliminar.MaxLength = 10;
            this.txt_Id_Eliminar.Name = "txt_Id_Eliminar";
            this.txt_Id_Eliminar.Size = new System.Drawing.Size(107, 27);
            this.txt_Id_Eliminar.TabIndex = 16;
            this.txt_Id_Eliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Id_Eliminar.TextChanged += new System.EventHandler(this.txt_Id_Eliminar_TextChanged);
            this.txt_Id_Eliminar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_Eliminar_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "ID:";
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PRINCIPAL";
            this.Text = "Examen";
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Consulta)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Agregar.ResumeLayout(false);
            this.tabPage_Agregar.PerformLayout();
            this.tabPage_Editar.ResumeLayout(false);
            this.tabPage_Editar.PerformLayout();
            this.tabPage_Eliminar.ResumeLayout(false);
            this.tabPage_Eliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button btn_Cerrar;
        private Panel panel4;
        private ComboBox cbo_Buscar;
        private Panel panel1;
        private Button btn_Refrescar;
        private Button btn_Buscar;
        private RadioButton rbtn_Nombre;
        private RadioButton rbtn_Id;
        private Label label2;
        private DataGridView datagrid_Consulta;
        private TabControl tabControl1;
        private TabPage tabPage_Agregar;
        private TextBox txt_Descripcion_Agregar;
        private Label lb_Descripcion;
        private TextBox txt_Nombre_Agregar;
        private Label lb_Nombre;
        private TextBox txt_Id_Agregar;
        private Label lb_ID;
        private TabPage tabPage_Editar;
        private TabPage tabPage_Eliminar;
        private Button btn_Agregar;
        private Button btn_GuardarCambios;
        private TextBox txt_Descripcion_Actualizar;
        private Label label3;
        private TextBox txt_Nombre_Actualizar;
        private Label label4;
        private TextBox txt_Id_Actualizar;
        private Label label5;
        private Button btn_Buscar_Eliminar;
        private Button btn_Eliminar;
        private TextBox txt_Descripcion_Eliminar;
        private Label label6;
        private TextBox txt_Nombre_Eliminar;
        private Label label7;
        private TextBox txt_Id_Eliminar;
        private Label label8;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private RadioButton rbtn_Descripcion;
        private Button btn_Buscar_Editar;
    }
}