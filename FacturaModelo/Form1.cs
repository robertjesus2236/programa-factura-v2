using Factura;
using FacturaModelo.dataBase;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;




namespace FacturaModelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        conexionPSQL conectandose = new conexionPSQL();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarLista_Click(object sender, EventArgs e)
        {
            // Crear la fila del DataGridView
            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvLista);
            file.Cells[0].Value = txtIdArticulo.Text;
            file.Cells[1].Value = txtNombre.Text;
            file.Cells[2].Value = txtPrecio.Text;
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = (float.Parse(txtPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

            // Agregar la fila al DataGridView
            dgvLista.Rows.Add(file);

            // Limpiar los campos de texto
            txtIdArticulo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = "";

            // Calcular el costo a pagar
            CostoApagar();

           

        }


        public void CostoApagar()
        {
            float CostoTotal = 0;
            int Conteo = 0;

            Conteo = dgvLista.RowCount;

            for (int i = 0; i<Conteo; i++)
            {
                CostoTotal += float.Parse(dgvLista.Rows[i].Cells[4].Value.ToString());
            }
            lblTotalAPagar.Text = CostoTotal.ToString();
    

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult rppta = MessageBox.Show("¿Desea eliminar producto?",
                    "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rppta == DialogResult.Yes)
                {
                    dgvLista.Rows.Remove(dgvLista.CurrentRow);
                }
            }
            catch { }
            CostoApagar();
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       

        private void txtEfectivo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDevolucion.Text = (float.Parse(txtEfectivo.Text) - float.Parse(lblTotalAPagar.Text)).ToString();
                Console.WriteLine(lblDevolucion.Text);
            }
            catch
            {
                lblDevolucion.Text = "0.00";

            }
        }

        public void btnVender_Click(object sender, EventArgs e)
        {
            

            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("Empresa xxxxx "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: 0120102");
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString());
            Ticket1.TextoIzquierda("Le Atendio: xxxx");
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();

            clsFactura.CreaTicket.EncabezadoVenta();
            clsFactura.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in dgvLista.Rows)
            {
                // PROD                     //PRECIO                                    CANT                         TOTAL
                Ticket1.AgregaArticulo(Articulo: r.Cells[1].Value.ToString(), double.Parse(r.Cells[2].Value.ToString()), int.Parse(r.Cells[3].Value.ToString()), double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(lblTotalAPagar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(txtEfectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(lblDevolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("*     Gracias por preferirnos    *");

            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("Gracias por preferirnos");

            CrearFactura();

            this.Close();

           

            


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            CrearFactura();
        }
        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

    public void CrearFactura()
    {
        // Crear el documento PDF
        Document document = new Document();
        PdfWriter.GetInstance(document, new FileStream("factura.pdf", FileMode.Create));

    
        document.Open();

        // Agregar el encabezado
        Paragraph encabezado = new Paragraph("Factura de venta");
        encabezado.Alignment = Element.ALIGN_CENTER;
        document.Add(encabezado);

        // Agregar la información de la factura
        PdfPTable tabla = new PdfPTable(4);
        tabla.WidthPercentage = 100;

        tabla.AddCell(new PdfPCell(new Phrase("Producto")));
        tabla.AddCell(new PdfPCell(new Phrase("Precio")));
        tabla.AddCell(new PdfPCell(new Phrase("Cantidad")));
        tabla.AddCell(new PdfPCell(new Phrase("Total")));

        foreach (DataGridViewRow r in dgvLista.Rows)
        {
            tabla.AddCell(new PdfPCell(new Phrase(r.Cells[1].Value.ToString())));
            tabla.AddCell(new PdfPCell(new Phrase(r.Cells[2].Value.ToString())));
            tabla.AddCell(new PdfPCell(new Phrase(r.Cells[3].Value.ToString())));
            tabla.AddCell(new PdfPCell(new Phrase(r.Cells[4].Value.ToString())));
        }

        document.Add(tabla);

        // Agregar los totales
        Paragraph total = new Paragraph("Total a pagar: " + lblTotalAPagar.Text);
        total.Alignment = Element.ALIGN_RIGHT;
        document.Add(total);

        Paragraph efectivo = new Paragraph("Efectivo entregado: " + txtEfectivo.Text);
        efectivo.Alignment = Element.ALIGN_RIGHT;
        document.Add(efectivo);

        Paragraph devolucion = new Paragraph("Efectivo devuelto: " + lblDevolucion.Text);
        devolucion.Alignment = Element.ALIGN_RIGHT;
        document.Add(devolucion);

        document.Close();

        MessageBox.Show("Factura generada correctamente.");


    }

        private void facturaClientes()
        {
            using System.Data.SqlClient;

            public void EnviarFacturaPorEmailDesdeBD()
            {
                // Crear el documento PDF
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream("factura.pdf", FileMode.Create));

                // Abrir el documento
                document.Open();

                // Agregar el contenido del documento

                // Cerrar el documento
                document.Close();

                // Obtener los correos electrónicos de la base de datos
                string cadenaConexion = "Data Source=NombreDelServidor;Initial Catalog=NombreDeLaBaseDeDatos;Integrated Security=True";
                string consulta = "SELECT CorreoElectronico FROM TablaDeCorreos";
                List<string> correos = new List<string>();

                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        correos.Add(reader.GetString(0));
                    }

                    reader.Close();
                    conexion.Close();
                }

                // Enviar la factura a cada correo electrónico de la lista
                foreach (string correo in correos)
                {
                    // Crear el mensaje de correo electrónico
                    MailMessage mensaje = new MailMessage();
                    mensaje.From = new MailAddress("tucorreo@gmail.com");
                    mensaje.To.Add(correo);
                    mensaje.Subject = "Factura de venta";
                    mensaje.Body = "Adjunto encontrarás la factura de venta.";

                    // Adjuntar el archivo PDF
                    Attachment archivo = new Attachment("factura.pdf");
                    mensaje.Attachments.Add(archivo);

                    // Enviar el correo electrónico
                    SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
                    clienteSmtp.EnableSsl = true;
                    clienteSmtp.UseDefaultCredentials = false;
                    clienteSmtp.Credentials = new NetworkCredential("tucorreo@gmail.com", "tupassword");
                    clienteSmtp.Send(mensaje);
                }

                MessageBox.Show("Factura enviada correctamente por correo electrónico.");
            }

        }

    }
}