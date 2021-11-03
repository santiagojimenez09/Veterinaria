using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsEnt
{
   public class ClsEntMascota
    {

        private string cod_mascota;
        private string nom_mascota;
        private string nom_propietario;
        private DateTime fecha_naci_mascota;
        private byte activo;
        private byte tipo;

        public string Cod_mascota { get => cod_mascota; set => cod_mascota = value; }
        public string Nom_mascota { get => nom_mascota; set => nom_mascota = value; }
        public string Nom_propietario { get => nom_propietario; set => nom_propietario = value; }
        public DateTime Fecha_naci_mascota { get => fecha_naci_mascota; set => fecha_naci_mascota = value; }
        public byte Activo { get => activo; set => activo = value; }
        public byte Tipo { get => tipo; set => tipo = value; }
    }
}
