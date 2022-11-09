﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAI.Forms;
using PPAI.AccesoDatos;

namespace PPAI
{
    public partial class Login : Form
    {
        private Sesion sesion;
        public static Sesion Sesion { get; set; }

        private GestorRegistrarReserva gestor;                                                     //DENTRO DE LA CLASE PANTALLA SE AGREGA UN PUNTERO AL GESTOR

        public GestorRegistrarReserva Gestor { get => gestor; set => gestor = value; }

        public Login()
        {
            InitializeComponent();
        }

        public string id_usuario { get; set; }
        public String Pp_usuario
        {
            get { return txt_usuario.Text; }
            set { txt_usuario.Text = value; }
        }


        public String Pp_password
        {
            get { return txt_password.Text; }
            set { txt_password.Text = value; }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            btn_ver_contrasena.Hide();
        }

        private (bool, Usuario)  validar_Usuario(string usuario, string password)  // VALIDA QUE EXISTA EL USUARIO INGRESADO
        {
            bool resultado = false;
            Usuario usuarioLogueado = null; 
            foreach (Usuario user in ObjetosCreados.Usuarios) {
                if(user.UsuarioNombre == usuario && user.Contraseña == password)
                {
                    resultado = true;
                    usuarioLogueado = user;
                }
                
            }
            return (resultado, usuarioLogueado) ;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "")
            {
                MessageBox.Show("La casilla de USUARIO se encuentra vacia");
                txt_usuario.Focus();
                return;
            }
            if (txt_password.Text == "")
            {
                MessageBox.Show("La casilla de PASSWORD se encuentra vacia");
                txt_password.Focus();
                return;
            }

           (bool, Usuario) resultado = validar_Usuario(txt_usuario.Text, txt_password.Text);

            if (resultado.Item1)
            {
                CU_Cientifico RV = new CU_Cientifico();

                this.sesion = ObjetosCreados.sesionActual; //SESION CREADA

                RV.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("El usuario y la password no coinciden con ninguno de nuestra Base Datos.");
                txt_usuario.Focus();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void btn_ver_contrasena_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
            btn_ver_contrasena.Hide();
            btn_ocultar_contrasena.Show();
        }

        private void btn_ocultar_contrasena_Click(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '\0';
            btn_ocultar_contrasena.Hide();
            btn_ver_contrasena.Show();
        }

        private void btn_cerrar_programa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
