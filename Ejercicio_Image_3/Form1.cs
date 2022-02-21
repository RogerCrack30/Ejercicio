using Ejercicio_Imagen_4.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Imagen_4
{
    public partial class Form1 : Form
    {
        List<Materias> listaMaterias = new List<Materias>();
        List<Estudiante> listaEstudiantes = new List<Estudiante>();
        List<Notas> listanotas = new List<Notas>();


        Notas nota;
        Materias mate;
        Estudiante estudi;

        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        
        public void guardarNota()
        {
          
            nota = new Notas(int.Parse(txtIdEstudiant.Text), int.Parse(txtIdMateri.Text), int.Parse(txtNota.Text));

            listanotas.Add(nota);

            dgvNotas.DataSource = null;
            dgvNotas.DataSource = listanotas;
        }

        public void guardarMateria()
        {
            mate = new Materias(int.Parse(txtIDMateria.Text),txtNomMateria.Text);

            listaMaterias.Add(mate);

            dgvMateria.DataSource = null;
            dgvMateria.DataSource = listaMaterias;
        }

        public void guardarEstudiante()
        {


            estudi = new Estudiante(Convert.ToInt32(txtIdEstudiantes.Text), txtNombre.Text, txtApellido.Text,
            txtDireccion.Text, txtTelefono.Text);

            listaEstudiantes.Add(estudi);

            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = listaEstudiantes;
        }

        private void rbAlumnosOrdenados_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Clear();
            getAlumnosOrdenados();
        }

        public void getAlumnosOrdenados()
        {
            IEnumerable<Estudiante> nomalum = from d in listaEstudiantes orderby d.Nombre descending select d;

            foreach (Estudiante st in nomalum)
            {
                txtConsulta.AppendText(st.getDateEstudiantes());
            }
        }


        private void rbAlumnosRegistrados_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Clear();
            getEstudiante();
        }

        public void getEstudiante()
        {
            IEnumerable<Estudiante> nombrEmp = from nEmp in listaEstudiantes select nEmp;

            foreach (Estudiante em in nombrEmp)
            {
                txtConsulta.AppendText(em.getEstudiRegistrados());
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtConsulta.Clear();
            getMateria();
        }

        public void getMateria()
        {
            IEnumerable<Materias> nombeEmp = from nEmp in listaMaterias select nEmp;

            foreach (Materias em in nombeEmp)
            {
                txtConsulta.AppendText(em.getMateRegistradas());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            guardarNota();

            txtIdMateri.Clear();
            txtIdEstudiant.Clear();
            txtNota.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guardarEstudiante();

            txtIdEstudiantes.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guardarMateria();

            txtIDMateria.Clear();
            txtNomMateria.Clear();
           
        }
    }
}
