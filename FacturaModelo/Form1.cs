using Factura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FacturaModelo
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

        private void btnCargarLista_Click(object sender, EventArgs e)
        {

            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(dgvLista);

            file.Cells[0].Value = txtIdArticulo.Text;
            file.Cells[1].Value = txtNombre.Text;
            file.Cells[2].Value = txtPrecio.Text;
            file.Cells[3].Value = txtCantidad.Text;
            file.Cells[4].Value = (float.Parse(txtPrecio.Text) * float.Parse(txtCantidad.Text)).ToString();

            dgvLista.Rows.Add(file);

            txtIdArticulo.Text = txtNombre.Text = txtPrecio.Text = txtCantidad.Text = "";

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
            }
            catch
            {
                lblDevolucion.Text = "0.00";

            }
        }

        private void btnVender_Click(object sender, EventArgs e)
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

            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}