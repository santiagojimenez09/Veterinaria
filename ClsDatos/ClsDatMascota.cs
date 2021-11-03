using ClsEnt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsDatos
{
    public class ClsDatMascota
    {

        ClsConexion objconexion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();

        public bool guardar_mascota(ClsEntMascota oentmascota)
        {
            try
            {
                cmd.Connection = objconexion.conectar("Veterinaria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_guardar_mascota";
                cmd.Parameters.Add("@pcod_mascota", oentmascota.Cod_mascota);
                cmd.Parameters.Add("@pnom_mascota", oentmascota.Nom_mascota);
                cmd.Parameters.Add("@pnom_propietario", oentmascota.Nom_propietario);
                cmd.Parameters.Add("@pfecha_naci_mascota", oentmascota.Fecha_naci_mascota);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public bool anular_mascota(ClsEntMascota oentmascota)
        {
            try
            {
                cmd.Connection = objconexion.conectar("Veterinaria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_anular_mascota";
                cmd.Parameters.Add("@pcod_mascota", oentmascota.Cod_mascota);
                cmd.Parameters.Add("@ptipo", oentmascota.Tipo);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }

        public DataSet consultar_mascota(ClsEntMascota oentmascota)
        {
            try
            {
                cmd.Connection = objconexion.conectar("Veterinaria");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_consultar_mascota";
                cmd.Parameters.Add("@pcod_mascota", oentmascota.Cod_mascota);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
        }



    }
}
