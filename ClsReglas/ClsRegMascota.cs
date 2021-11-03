using ClsDatos;
using ClsEnt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsReglas
{
    public class ClsRegMascota
    {

        ClsDatMascota odatmascota = new ClsDatMascota();

        public bool guardar_mascota(ClsEntMascota oentmascota)
        {
            return odatmascota.guardar_mascota(oentmascota);
        }

        public bool anular_mascota(ClsEntMascota oentmascota)
        {
            return odatmascota.anular_mascota(oentmascota);
        }

        public DataSet consultar_mascota(ClsEntMascota oentmascota)
        {
            return odatmascota.consultar_mascota(oentmascota);
        }

    }
}
