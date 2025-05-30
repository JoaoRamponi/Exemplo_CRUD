using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        empregado em = new empregado();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            em.setNome(txt_nome.Text);
            em.setSobrenome(txt_sobrenome.Text);
            em.setCpf(txt_cpf.Text);
            em.inserir();

        }
    }
}
