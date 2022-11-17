using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.AccesoDatos;
using PPAI.Forms;



namespace PPAI.Forms
{
    public partial class PantallaRegistrarReserva : Form
    {
        private GestorRegistrarReserva gestor;                                                     //DENTRO DE LA CLASE PANTALLA SE AGREGA UN PUNTERO AL GESTOR
        public GestorRegistrarReserva Gestor { get => gestor; set => gestor = value; }


        //OTROS METODOS DE LA PANTALLA

        public PantallaRegistrarReserva()                                                        //METODO CONSTRUCTOR DE PANTALLA. EN EL MISMO SE INSTANCIA AL GESTOR MANDANDOLE COMO PARAMETRO LA PROPIA PANTALLA
        {
            InitializeComponent();
            gestor = new GestorRegistrarReserva(this);
        }



        public void tomarOpcionReservarTurnoRT()                                                     //SE LLAMA AL METODO HABILITAR VENTANA
        {
            habilitarVentana();
        }
        public void habilitarVentana()                                                          //HABILITA LA PANTALLA
        {
            this.ShowDialog();
            dgTiposRT.Enabled = false;
            dg_rt.Enabled = false;
            dg_fecha.Enabled = false;
            dg_turno.Enabled = false;

        }

        ///

        private void PantallaRegistrarReserva_Load(object sender, EventArgs e)                  //EVENTO QUE SUCEDE AL INICIARSE LA PANTALLA
        {

            this.gestor.tomarOpcionReservarTurnoRT();                                                //SE LLAMA AL METODO DEL GESTOR PARA QUE TOME LA OPCION DE RESERVAR TURNO DE RT
        }

        public void mostrarTiposRT(List<String> listaNombresTiposRT)                           //RECIBE UNA LISTA DE TIPOS DE RT PARA CARGAR EL GRID
        {
            foreach (String nombre in listaNombresTiposRT)
            {
                dgTiposRT.Rows.Add(nombre, true);
            }
        }


        public void solicitarSeleccionTipoRT()                                                 //SOLICITA LA SELECCION DE UN TIPO RT HABILITANDO EL GRID Y EL BOTÓN
        {
            dgTiposRT.Enabled = true;
            btn_mostrar_rt.Enabled = true;
        }

        ///

        public void tomarSeleccionTipoRT()                                                       //INVOCA EL METODO DEL GESTOR ENVIANDOLE POR PARAMETRO EL TIPORTSELECCIONADO
        {
            int contadorSelecciones = 0;
            string nombreTipoRTSeleccionado = "";
            for (int i = 0; i < dgTiposRT.Rows.Count; i++)
            {
                if (dgTiposRT.Rows[i].Cells[1].Value.ToString() == "True")
                {
                    contadorSelecciones += 1; 
                    nombreTipoRTSeleccionado = dgTiposRT.Rows[i].Cells[0].Value.ToString();
                }
            }
            if (contadorSelecciones == 1)
            {
                gestor.tomarSeleccionTipoRT(nombreTipoRTSeleccionado);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Tipo de recurso tecnológico","Sleccione un recurso tecnologico",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
          
        }



        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //


        private void btn_mostrar_rt_Click(object sender, EventArgs e)
        {
            dg_rt.Rows.Clear();
            tomarSeleccionTipoRT();
            
        }

        public void mostrarRT(List<List<string>> listaDatosRT)                           //RECIBE UNA LISTA DE LOS DATOS DE LOS RT Y LOS CARGA EN EL GRID
        {
            for (int fila = 0; fila < listaDatosRT.Count; fila++)
            {
                dg_rt.Rows.Add();
                dg_rt.Rows[fila].Cells[0].Value = listaDatosRT[fila][0].ToString();
                dg_rt.Rows[fila].Cells[1].Value = listaDatosRT[fila][1].ToString();
                dg_rt.Rows[fila].Cells[2].Value = listaDatosRT[fila][2].ToString();
                dg_rt.Rows[fila].Cells[3].Value = listaDatosRT[fila][3].ToString();
                dg_rt.Rows[fila].Cells[4].Value = listaDatosRT[fila][4].ToString();
                dg_rt.Rows[fila].Cells[5].Value = false;

                if (listaDatosRT[fila][4].ToString() == "Disponible")
                {
                    dg_rt.Rows[fila].Cells[4].Style.BackColor = Color.FromArgb(21, 171, 206);
                }
                if (listaDatosRT[fila][4].ToString() == "En mantenimiento")
                {
                    dg_rt.Rows[fila].Cells[4].Style.BackColor = Color.FromArgb(182, 206, 56);
                }
                if (listaDatosRT[fila][4].ToString() == "Con inicio de Mantenimiento correctivo")
                {
                    dg_rt.Rows[fila].Cells[4].Style.BackColor = Color.FromArgb(171, 190, 188);
                }
            }

        }

        public void solicitarSeleccionRT()                          // HABILITA EL GRID Y EL BOTON PARA LA SELECCION
        {
            dg_rt.Enabled = true;
            btn_seleccionar_rt.Enabled = true;
    
        }

        private void btn_seleccionar_rt_Click(object sender, EventArgs e)           // EL CLICK EN EL BOTON DISPARA EL METODO DE TOMARSELECCIONRT
        {
            dg_fecha.Rows.Clear();
            tomarSeleccionRT();
        }


        public void tomarSeleccionRT()                                                       //INVOCA EL METODO DEL GESTOR, ENVIANDOLE POR PARAMETRO EL RT SELECCIONADO
        {
            int contadorSelecciones = 0;
            (string, int) rtSeleccionado = ("", -1);
            for (int i = 0; i < dg_rt.Rows.Count; i++)
            {
                if (dg_rt.Rows[i].Cells[5].Value.ToString() == "True")
                {
                    contadorSelecciones += 1;
                    rtSeleccionado = (dg_rt.Rows[i].Cells[0].Value.ToString(), int.Parse(dg_rt.Rows[i].Cells[1].Value.ToString()));
                }
            }

            if (contadorSelecciones == 1)
            {
                gestor.tomarSeleccionRT(rtSeleccionado.Item1, rtSeleccionado.Item2);
               
            }
            else
            {
                MessageBox.Show("Debe seleccionar un recurso tecnológico","Seleccione un recurso tecnologico",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }

        public void mostrarFechas(List<DateTime> listaDias, List<int> listaContadores)  //RECIBE UNA LISTA DE DIAS Y UNA CON LA CANTIDAD DE TURNOS DE ESTOS PARA CARGAR EL GRID
        { for (int fila = 0; fila < listaDias.Count; fila++)
            {
                dg_fecha.Rows.Add();
                dg_fecha.Rows[fila].Cells[0].Value = listaDias[fila].ToString().Split(' ')[0];
                dg_fecha.Rows[fila].Cells[1].Value = false;

            }

            for (int fila = 0; fila < listaContadores.Count; fila++)
            {
                if (listaContadores[fila] > 0)
                {
                    dg_fecha.Rows[fila].Cells[0].Style.BackColor = Color.FromArgb(21, 171, 206);        //SI ALGUNO DE LOS TURNOS DE ESE DIA ES DISPONIBLE PINTA DE AZUL ESA FECHA, DE LO CONTRARIO LA PINTA DE ROJO
                    dg_fecha.Rows[fila].Cells[1].Style.BackColor = Color.FromArgb(21, 171, 206);

                }
                else
                {
                    dg_fecha.Rows[fila].Cells[0].Style.BackColor = Color.FromArgb(244, 6, 92);
                    dg_fecha.Rows[fila].Cells[1].Style.BackColor = Color.FromArgb(244, 6, 92);
                }
                

            }
            if (listaContadores.Count == 0)
            {
                for (int fila = 0; fila < dg_fecha.Rows.Count; fila++)
                {
                    dg_fecha.Rows[fila].Cells[0].Style.BackColor = Color.FromArgb(244, 6, 92);
                    dg_fecha.Rows[fila].Cells[1].Style.BackColor = Color.FromArgb(244, 6, 92);
                }
            }

        }

        public void solicitarSeleccionFecha()                // HABILITA EL GRID Y EL BOTON PARA LA SELECCION
        {
            dg_fecha.Enabled = true;
            btn_seleccionar_rt.Enabled = true;

        }


        private void btn_seleccionar_fecha_Click(object sender, EventArgs e)            // EL CLICK EN EL BOTON DISPARA EL METODO DE TOMARSELECCIONFECHA
        {
            dg_turno.Rows.Clear();
            tomarSeleccionFecha();
        }

        private void tomarSeleccionFecha()          //INVOCA EL METODO DEL GESTOR, ENVIANDOLE POR PARAMETRO LA FECHA SELECCIONADA
        {
            int contadorSelecciones = 0;
            string fechaSeleleccionada = "";
            for (int i = 0; i < dg_fecha.Rows.Count; i++)
            {
                if (dg_fecha.Rows[i].Cells[1].Value.ToString() == "True" && dg_fecha.Rows[i].Cells[0].Style.BackColor == Color.FromArgb(244, 6, 92))
                {
                    contadorSelecciones = -50;
                    break;
                }
                else
                {
                    if (dg_fecha.Rows[i].Cells[1].Value.ToString() == "True" && (dg_fecha.Rows[i].Cells[0].Style.BackColor == Color.FromArgb(21, 171, 206)))
                    {
                        contadorSelecciones += 1;
                        fechaSeleleccionada = dg_fecha.Rows[i].Cells[0].Value.ToString();
                    }
                }
            }

            if (contadorSelecciones == 1)
            {
                gestor.tomarSeleccionFecha(fechaSeleleccionada);

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fecha disponible","Seleccione una fecha disponible",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        public void mostrarTurnos(List<List<string>> listaDatosTurnos)                       //RECIBE UNA LISTA DE TURNOS Y LOS CARGA EN EL GRID, PINTANDOLOS SEGUN SU ESTADO
        {
            for (int fila = 0; fila < listaDatosTurnos.Count; fila++)
            {
                dg_turno.Rows.Add();
                dg_turno.Rows[fila].Cells[0].Value = listaDatosTurnos[fila][0].ToString(); ;
                dg_turno.Rows[fila].Cells[1].Value = listaDatosTurnos[fila][1].ToString(); ;
                dg_turno.Rows[fila].Cells[2].Value = listaDatosTurnos[fila][2].ToString();
                dg_turno.Rows[fila].Cells[3].Value = false;

                if (listaDatosTurnos[fila][2].ToString() == "Disponible")
                {
                    dg_turno.Rows[fila].Cells[2].Style.BackColor = Color.FromArgb(21, 171, 206);
                }
                if (listaDatosTurnos[fila][2].ToString() == "Con reserva pendiente de confirmacion")   //??????????????????????????????????????????????????????
                {
                    dg_turno.Rows[fila].Cells[2].Style.BackColor = Color.FromArgb(171, 190, 188);
                }
                if (listaDatosTurnos[fila][2].ToString() == "Reservado")
                {
                    dg_turno.Rows[fila].Cells[2].Style.BackColor = Color.FromArgb(244, 6, 92);
                }

            }

            solicitarSeleccionTurno();
        }

        public void solicitarSeleccionTurno()            // HABILITA EL GRID Y EL BOTON PARA LA SELECCION
        {
            dg_turno.Enabled = true;
            btn_seleccionar_turno.Enabled = true;

        }

        private void btn_seleccionar_turno_Click(object sender, EventArgs e)        // EL CLICK EN EL BOTON DISPARA EL METODO DE TOMARSELECCIONTURNO
        {
            btn_seleccionar_turno.Enabled = false;
            tomarSeleccionTurno();
        }

        private void tomarSeleccionTurno()          //INVOCA EL METODO DEL GESTOR, ENVIANDOLE POR PARAMETRO EL TURNO SELECCIONADO
        {
            int contadorSelecciones = 0;
            (string, string) turnoSeleccionado = ("", "");
            for (int i = 0; i < dg_turno.Rows.Count; i++)
            {
                if ((dg_turno.Rows[i].Cells[3].Value.ToString() == "True" && dg_turno.Rows[i].Cells[2].Value.ToString() == "Con reserva pendiente de confirmacion")
                    || (dg_turno.Rows[i].Cells[3].Value.ToString() == "True" && dg_turno.Rows[i].Cells[2].Value.ToString() == "Reservado"))
                {
                    contadorSelecciones = -50;
                    break;
                }
                else
                {
                    if (dg_turno.Rows[i].Cells[3].Value.ToString() == "True" &&  dg_turno.Rows[i].Cells[2].Value.ToString() == "Disponible")
                    {
                        contadorSelecciones += 1;
                        turnoSeleccionado = (dg_turno.Rows[i].Cells[0].Value.ToString(), dg_turno.Rows[i].Cells[1].Value.ToString());
                        MessageBox.Show("Turno seleccionado con éxito. A continuación confirme su reserva","Confirme reserva",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }

            if (contadorSelecciones == 1)
            {
                gestor.tomarSeleccionTurno(turnoSeleccionado.Item1, turnoSeleccionado.Item2);

            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno disponible","Seleccione un turno disponible",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        public void solicitarConfirmacionReserva()      // HABILITA EL BOTON PARA LA CONFIRMACION
        {
            btn_confirmar.Enabled = true;
        }

        private void btn_confirmar_Click(object sender, EventArgs e)        // EL CLICK EN EL BOTON DISPARA EL METODO DE TOMARCONFIRMACIONRESERVA
        {
            dg_turno.Enabled = false;

            if (!(chk_notificacionEmail.Checked || chk_notificacionWhatsapp.Checked))
            {
                MessageBox.Show("Debe seleccionar un método de notificación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            tomarConfirmacionReserva();

        }

        private void tomarConfirmacionReserva()         //INVOCA EL METODO DEL GESTOR, ENVIANDOLE POR PARAMETRO LOS METODOS DE NOTIFICACION
        {

            gestor.tomarConfirmacionReserva(chk_notificacionWhatsapp.Checked, chk_notificacionEmail.Checked);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
