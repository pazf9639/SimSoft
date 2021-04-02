using Dapper;
using SimSift.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimSoft.BML
{
   public class Proveedor
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idProveedor { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public bool activo { get; set; }


        public Proveedor()
        {

        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombre", nombre);
            parametros.Add("@telefono", telefono);


            return dataAccess.Execute("stp_proveedores_Add", parametros);

        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            return dataAccess.Execute("stp_proveedores_delete", parametros);
        }
        public List<Proveedor> GetAll()
        {
            return dataAccess.Query<Proveedor>("stp_proveedores_getall");
        }
        public Proveedor GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            return dataAccess.QuerySingle<Proveedor>("stp_proveedores_getbyid", parametros);

        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idProveedor", idProveedor);
            parametros.Add("@nombre", nombre);
            parametros.Add("@telefono", telefono);
            return dataAccess.Execute("stp_proveedores_update", parametros);

        }





    }


}
