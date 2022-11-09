﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPAI
{
    public class InterfazWhatsApp   //DEFINO LA CLASE 
    {
        public void enviarNotificacionReserva(string numeroWhatsapp, RecursoTecnologico rtSeleccionado, Turno turnoSeleccionado, string marca, string modelo)  //MUESTRA UN MENSAJE QUE CONFIRMA EL ENVIO DE LA NOTIFICACION
        {
            string mensaje = "Se ha enviado la notificación de confirmación de reserva del turno del día " + turnoSeleccionado.FechaHoraInicio.ToString() + " para el Recurso Tecnológico: " + rtSeleccionado.TipoRecursoTecnologico.Nombre.ToString() + " Nro. inventario: " +
                rtSeleccionado.NumeroRT.ToString() + " Modelo: " + modelo + " Marca: " + marca + " al número de WhatsApp: " + numeroWhatsapp;

            MessageBox.Show(mensaje);
        }
    }
}

