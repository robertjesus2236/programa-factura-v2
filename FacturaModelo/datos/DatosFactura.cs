using FacturaModelo.dataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaModelo.datos
{
    internal class DatosFactura
    {
        conexionPSQL conectandose = new conexionPSQL();
        
        public void datatest()
        {
            conectandose.conectar();
            
            /*Se envian los datos por parametro
            conectandose.Insertar(
                Convert.ToInt32(txt_id.Text)
                , txt_ci.Text
                , txt_nomb.Text
                , txt_certificado.Text);

            //Actualiza el datagridview
            dtgv_Consulta.DataSource = conectandose.Consultar();
            MessageBox.Show("the refence of this object is working corectly");*/
        }
    }
}
