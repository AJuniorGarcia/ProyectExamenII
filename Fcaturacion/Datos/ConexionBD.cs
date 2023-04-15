using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ConexionBD
    {
        string cadena = "server=localhost; user=root; database=Registro; password=123456;";
        public void InsertarTicket(Ticket ticket)
        {
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "INSERT INTO Tickets (Fecha, Usuario, Cliente, TipoSoporte, DescripcionSolicitud, DescripcionRespuesta, Precio, Impuesto, Descuento, Total) " +
                                  "VALUES (@Fecha, @Usuario, @Cliente, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @Impuesto, @Descuento, @Total)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Fecha", ticket.Fecha);
                comando.Parameters.AddWithValue("@Usuario", ticket.Usuario);
                comando.Parameters.AddWithValue("@Cliente", ticket.Cliente);
                comando.Parameters.AddWithValue("@TipoSoporte", ticket.TipoSoporte);
                comando.Parameters.AddWithValue("@DescripcionSolicitud", ticket.DescripcionSolicitud);
                comando.Parameters.AddWithValue("@DescripcionRespuesta", ticket.DescripcionRespuesta);
                comando.Parameters.AddWithValue("@Precio", ticket.Precio);
                comando.Parameters.AddWithValue("@Impuesto", ticket.Impuesto);
                comando.Parameters.AddWithValue("@Descuento", ticket.Descuento);
                comando.Parameters.AddWithValue("@Total", ticket.Total);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
            }
        }
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            bool resultado = false;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@Usuario AND Contrasena=@Contrasena";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Usuario", usuario);
                comando.Parameters.AddWithValue("@Contrasena", contrasena);
                conexion.Open();
                int count = (int)comando.ExecuteScalar();
                conexion.Close();
                resultado = count > 0;
            }
            return resultado;
        }
    }

}
