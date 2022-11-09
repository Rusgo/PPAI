using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAI.Forms
{
    public partial class CU_Cientifico : Form
    {
        public CU_Cientifico()
        {
            InitializeComponent();
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CU23_Click(object sender, EventArgs e) //INICIALIZA EL CU, CREA LA PANTALLA E INVOCA EL PRIMER METODO
        {
            PantallaRegistrarReserva pantallaRegistrarReserva = new PantallaRegistrarReserva();
            pantallaRegistrarReserva.tomarOpcionReservarTurnoRT();
            this.Close();
        }
    }
}
