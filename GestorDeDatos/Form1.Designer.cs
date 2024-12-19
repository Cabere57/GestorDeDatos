namespace GestorDeDatos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar recursos.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDireccion = new TextBox();
            btnGuardar = new Button();
            dgvClientes = new DataGridView();
            labelIDEliminar = new Label();
            txtIDEliminar = new TextBox();
            btnEliminar = new Button();
            labelBuscar = new Label();
            txtBuscarNombre = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 50);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Teléfono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 90);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 130);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 10);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(100, 50);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(100, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 6;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(100, 130);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(10, 170);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.Location = new Point(10, 210);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(360, 200);
            dgvClientes.TabIndex = 9;
            // 
            // labelIDEliminar
            // 
            labelIDEliminar.AutoSize = true;
            labelIDEliminar.Location = new Point(10, 420);
            labelIDEliminar.Name = "labelIDEliminar";
            labelIDEliminar.Size = new Size(76, 15);
            labelIDEliminar.TabIndex = 10;
            labelIDEliminar.Text = "ID a eliminar:";
            // 
            // txtIDEliminar
            // 
            txtIDEliminar.Location = new Point(100, 420);
            txtIDEliminar.Name = "txtIDEliminar";
            txtIDEliminar.Size = new Size(100, 23);
            txtIDEliminar.TabIndex = 11;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(210, 420);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += btnEliminar_Click;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(10, 450);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(54, 15);
            labelBuscar.TabIndex = 13;
            labelBuscar.Text = "Nombre:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Location = new Point(100, 450);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(100, 23);
            txtBuscarNombre.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(210, 450);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(210, 480);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(75, 23);
            btnMostrarTodos.TabIndex = 16;
            btnMostrarTodos.Text = "Mostrar Todos";
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 520);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(btnGuardar);
            Controls.Add(dgvClientes);
            Controls.Add(labelIDEliminar);
            Controls.Add(txtIDEliminar);
            Controls.Add(btnEliminar);
            Controls.Add(labelBuscar);
            Controls.Add(txtBuscarNombre);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrarTodos);
            Name = "Form1";
            Text = "Gestor de Datos";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvClientes;

        private System.Windows.Forms.Label labelIDEliminar;
        private System.Windows.Forms.TextBox txtIDEliminar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
    }
}
