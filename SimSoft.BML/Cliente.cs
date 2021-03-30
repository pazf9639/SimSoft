using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimSift.DAL;

namespace SimSoft.BML
{
    class Cliente
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idCliente { get; set; }
        public string nombre { get; set; }
        public string razonSocial { get; set; }
        public string telefono { get; set; }
        public decimal descuento { get; set; }
        public bool activo { get; set; }


        public Cliente()
        {

        }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombre", nombre);
            parametros.Add("@razonSocial", razonSocial);
            parametros.Add("@telefono", telefono);
            parametros.Add("@descuento", descuento);
           

            return dataAccess.Execute("stp_clientes_Add", parametros);

        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAccess.Execute("stp_clientes_delete", parametros);
        }
        public List<Cliente> GetAll()
        {
            return dataAccess.Query<Cliente>("stp_clientes_getall");
        }
        public Cliente GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            return dataAccess.QuerySingle<Cliente>("stp_cliente_getbyid", parametros);

        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idCliente", idCliente);
            parametros.Add("@nombre", nombre);
            parametros.Add("@razonSocial", razonSocial);
            parametros.Add("@telefono", telefono);
            parametros.Add("@descuento", descuento);
            parametros.Add("@activo", activo);
            return dataAccess.Execute("stp_cliente_update", parametros);

        }





    }
  

}
