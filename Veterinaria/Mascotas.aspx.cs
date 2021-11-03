using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ClsEnt;
using ClsReglas;

namespace Veterinaria
{
    public partial class Mascotas : System.Web.UI.Page
    {

        ClsEntMascota oentmascota = new ClsEntMascota();
        ClsRegMascota oregmascota = new ClsRegMascota();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsultarMascota_Click(object sender, EventArgs e)
        {

            if (TxtCodMascota.Text.Trim() == "")
            {
                LblMensaje.Text = "Ingresar la identificacion de la mascota";
                TxtCodMascota.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oentmascota.Cod_mascota = TxtCodMascota.Text;
                ds = oregmascota.consultar_mascota(oentmascota);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "Mascota no existe";
                    TxtCodMascota.Focus();
                }
                else
                {
                    TxtNombreMascota.Text = ds.Tables[0].Rows[0]["nom_mascota"].ToString();
                    TxtNombrePropietario.Text = ds.Tables[0].Rows[0]["nom_propietario"].ToString();
                    TxtFecha.Text = ds.Tables[0].Rows[0]["fecha_naci_mascota"].ToString();
                }
            }

        }

        protected void BtnGuardarMascota_Click(object sender, EventArgs e)
        {

            if (TxtNombreMascota.Text.Trim() == "" && TxtNombrePropietario.Text.Trim() == "" && TxtFecha.Text.Trim() == "")
            {
                LblMensaje.Text = "Debe ingresar todos los datos";
                TxtNombreMascota.Focus();
            }
            else
            {
                oentmascota.Cod_mascota = TxtCodMascota.Text;
                oentmascota.Nom_mascota = TxtNombreMascota.Text;
                oentmascota.Nom_propietario = TxtNombrePropietario.Text;
                oentmascota.Fecha_naci_mascota =Convert.ToDateTime(TxtFecha.Text);
                if (oregmascota.guardar_mascota(oentmascota))
                {
                    LblMensaje.Text = "Paciente guardado";
                    limpiar_campos();
                }
                else
                {
                    LblMensaje.Text = "Error guardando paciente";
                    TxtCodMascota.Focus();
                }
            }

        }

        protected void BtnAnularMascota_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Desea anular esta mascota?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                oentmascota.Cod_mascota = TxtCodMascota.Text;
                oentmascota.Tipo = 0;
                if (oregmascota.anular_mascota(oentmascota))
                {
                    LblMensaje.Text = "Mascota anulada";
                    limpiar_campos();
                }
                else
                {
                    LblMensaje.Text = "Error anulando la mascota";
                    TxtCodMascota.Focus();
                }
            }

        }

        protected void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        public void limpiar_campos()
        {
            TxtCodMascota.Text = "";
            TxtNombreMascota.Text = "";
            TxtNombrePropietario.Text = "";
            TxtFecha.Text = "";
            LblMensaje.Text = "";
            
        }
    }
}