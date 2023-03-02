namespace FacturaModelo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCargarLista = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 81);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ventas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "ldArticulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad:";
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.Location = new System.Drawing.Point(114, 118);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(123, 23);
            this.txtIdArticulo.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(114, 190);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(123, 23);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 23);
            this.txtNombre.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(114, 229);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(123, 23);
            this.txtCantidad.TabIndex = 8;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToOrderColumns = true;
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.SubTotal});
            this.dgvLista.Location = new System.Drawing.Point(74, 312);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowTemplate.Height = 25;
            this.dgvLista.Size = new System.Drawing.Size(400, 126);
            this.dgvLista.TabIndex = 9;
            this.dgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellContentClick);
            // 
            // idArticulo
            // 
            this.idArticulo.HeaderText = "Id";
            this.idArticulo.Name = "idArticulo";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(255, 119);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 23);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCargarLista
            // 
            this.btnCargarLista.Location = new System.Drawing.Point(153, 271);
            this.btnCargarLista.Name = "btnCargarLista";
            this.btnCargarLista.Size = new System.Drawing.Size(242, 35);
            this.btnCargarLista.TabIndex = 11;
            this.btnCargarLista.Text = "Cargar Lista";
            this.btnCargarLista.UseVisualStyleBackColor = true;
            this.btnCargarLista.Click += new System.EventHandler(this.btnCargarLista_Click);
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.Lime;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Location = new System.Drawing.Point(560, 388);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(178, 38);
            this.btnVender.TabIndex = 12;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(591, 349);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(123, 23);
            this.txtEfectivo.TabIndex = 13;
            this.txtEfectivo.TextChanged += new System.EventHandler(this.txtEfectivo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(628, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Efectivo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "$";
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.BackColor = System.Drawing.Color.Black;
            this.lblTotalAPagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAPagar.ForeColor = System.Drawing.Color.Lime;
            this.lblTotalAPagar.Location = new System.Drawing.Point(28, 6);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(41, 21);
            this.lblTotalAPagar.TabIndex = 17;
            this.lblTotalAPagar.Text = "0.00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblTotalAPagar);
            this.panel2.Location = new System.Drawing.Point(548, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(591, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Total a Pagar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(591, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Devolución";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblDevolucion);
            this.panel3.Location = new System.Drawing.Point(548, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 32);
            this.panel3.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "$";
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.BackColor = System.Drawing.Color.Black;
            this.lblDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDevolucion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDevolucion.ForeColor = System.Drawing.Color.Red;
            this.lblDevolucion.Location = new System.Drawing.Point(28, 6);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(41, 21);
            this.lblDevolucion.TabIndex = 17;
            this.lblDevolucion.Text = "0.00";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(372, 119);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 23);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEfectivo);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.btnCargarLista);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtIdArticulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdArticulo;
        private TextBox txtPrecio;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private DataGridView dgvLista;
        private Button btnBuscar;
        private Button btnCargarLista;
        private Button btnVender;
        private TextBox txtEfectivo;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblTotalAPagar;
        private Panel panel2;
        private Label label10;
        private Label label11;
        private Panel panel3;
        private Label label12;
        private Label lblDevolucion;
        private DataGridViewTextBoxColumn idArticulo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn SubTotal;
        private Button btnEliminar;
    }
}