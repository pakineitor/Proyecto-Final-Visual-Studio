using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final_definitivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ocultarInicio()
        {
            this.userBienvenida1.Visible = false;
            this.userBienvenida1.SendToBack();
        }

        /// <summary>
        /// Volver a la página principal.
        /// </summary>
        public void VolverAtras()
        {
            this.userBienvenida1.Visible = true;
            this.userBienvenida1.BringToFront();

        }
        /// <summary>
        /// Función que va a encargarse de guardar este form en el atributo de tipo form de todos los user control para poder gestionarlos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userBienvenida1_Load(object sender, EventArgs e)
        {
            
            this.userBienvenida1.form = this;
            this.userAlumno1.form = this;
            this.userInformacion1.form = this;
            this.userEquipoDocente1.form = this;
            this.userPlanoCentro1.form = this;
            this.userPlanoPlanta11.form = this;
           

            
        }

        /// <summary>
        /// Método encargada de gestionar que el user control del alumno se oculte y mande al fondo.
        /// </summary>
        public void OcultarUserAlumno1()
        {
            this.userAlumno1.Visible = false;
            this.userAlumno1.SendToBack();
        }

        /// <summary>
        /// Método que se va a encargar de hacer visible y traer a la pantalla el user control del Alumno.
        /// </summary>
        public void MostrarUserAlumno1()
        {
            this.userAlumno1.Visible = true;
            this.userAlumno1.BringToFront();
        }

        /// <summary>
        /// Método encargado de traer a la pantalla el user control de información.
        /// </summary>
        public void MostrarInformacion()
        {
            OcultarUserAlumno1();
            this.userInformacion1.BringToFront();
            this.userInformacion1.Visible = true;
            
        }


        /// <summary>
        /// Método encargado de ocultar el user control de información para mostrar el user control de Alumno.
        /// </summary>
        public void SalirInformacion()
        {
            this.userInformacion1.SendToBack();
            this.userInformacion1.Visible = false;
            MostrarUserAlumno1();


        }

        /// <summary>
        /// Método encargado de mostrar el user control del equipo docente.
        /// </summary>
        public void MostrarEquipoDiretivo()
        {
            OcultarUserAlumno1();
            this.userEquipoDocente1.Visible = true;
            this.userEquipoDocente1.BringToFront();

        }

        /// <summary>
        /// Método encargado de salir del user control de Alumno.
        /// </summary>
        public void SalirUserAlumno()
        {
            this.userEquipoDocente1.Visible = false;
            this.userEquipoDocente1.SendToBack();
            MostrarUserAlumno1();


        }

        /// <summary>
        /// Método encargado de mostrar el user control que te da a elegir qué planta quieres ver del centro en el plano.
        /// </summary>
        public void MostrarPlanosDelCentro()
        {
            OcultarUserAlumno1();
            this.userPlanoCentro1.Visible = true;
            this.userPlanoCentro1.BringToFront();
        }

        /// <summary>
        /// Método encargado de ocultar el user control que te da a elegir si ver el plano de la planta una o dos.
        /// </summary>
        public void OcultarUserPlanosDelCentro()
        {
            this.userPlanoCentro1.Visible = false;
            this.userPlanoCentro1.SendToBack();
            MostrarUserAlumno1();
        }

       

        /// <summary>
        /// Método que muestra el user control que muestra el plano de la planta uno.
        /// </summary>
        public void MostrarUserPlanoPlanta1()
        {
            this.MostrarPlanosDelCentro();
            this.userPlanoPlanta11.Visible = true;
            this.userPlanoPlanta11.BringToFront();
        }

        /// <summary>
        /// Método encargado de ocultar el user control que muestra el plano de la pantalla uno.
        /// </summary>
        public void OcultarUserPlanoPlanta1()
        {
            this.userPlanoPlanta11.Visible = false;
            this.userPlanoPlanta11.SendToBack();
        }
    }
}
