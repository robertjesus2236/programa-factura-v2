using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacturaModelo.dataBase
{
    internal class conexionPSQL
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; User Id = postgres; Password =1234; Database=factura;");

        //Just use this line for test
        public void conectar()
        {
            conn.Open();
            MessageBox.Show("ready");
        }

      /* public void Insertar(int id, string nombre, int precio )
        {
            string query = "Insert into \"test\" values (" + id + ",'" + nombre + "','" + precio + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Registrado");
            conn.Close();
        }*/

        public void Insertar(int id, string nombre, int precio, int cantidad, int subtotal)
        {
           /* string query = "Insert into \"productos5\" values (" + id + ",'" + nombre + "','" + precio + "', '" + cantidad + "', '" + subtotal + "')";
            NpgsqlCommand ejecutor = new NpgsqlCommand(query, conn);
            conn.Open();
            ejecutor.ExecuteNonQuery();
            MessageBox.Show("Registrado");
            conn.Close();*/
        }
       
    }
}
