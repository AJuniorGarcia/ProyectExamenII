using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tickets Ticket = new Tickets();
            Ticket.Fecha = DateTime.Now;
            Ticket.Usuario = txtUsuario.Text;
            Ticket.Cliente = txtCliente.Text;
            Ticket.TipoSoporte = cmbTipoSoporte.Text;
            Ticket.DescripcionSolicitud = txtSolicitud.Text;
            Ticket.DescripcionRespuesta = txtRespuesta.Text;
            Ticket.Precio = decimal.Parse(txtPrecio.Text);
            Ticket.Impuesto = decimal.Parse(txtImpuesto.Text);
            Ticket.Descuento = decimal.Parse(txtDescuento.Text);
            Ticket.Total = decimal.Parse(txtTotal.Text);

            ConexionBD conexionBD = new ConexionBD();
            conexionBD.InsertarTicket(ticket);

            MessageBox.Show("El ticket se ha guardado correctamente.");
        }

        private void Tickets_Load_1(object sender, EventArgs e)
        {

        }

        private void Gurdar_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Fecha = DateTime.Now;
            ticket.Usuario = txtUsuario.Text;
            ticket.Cliente = txtCliente.Text;
            ticket.TipoSoporte = cmbTipoSoporte.Text;
            ticket.DescripcionSolicitud = txtSolicitud.Text;
            ticket.DescripcionRespuesta = txtRespuesta.Text;
            ticket.Precio = decimal.Parse(txtPrecio1.Text);
            ticket.Impuesto = decimal.Parse(txtImpuesto1.Text);
            ticket.Descuento = decimal.Parse(txtDescuento.Text);
            ticket.Total = decimal.Parse(txtTotal.Text);

            ConexionBD conexionBD = new ConexionBD();
            conexionBD.InsertarTicket(ticket);

            MessageBox.Show("El ticket se ha guardado correctamente.");
        }
    }


    
}
