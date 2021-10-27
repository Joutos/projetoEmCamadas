using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto3Camadas.CODE.BLL;
using Projeto3Camadas.CODE.DTO;

namespace Projeto3Camadas
{
    public partial class frm_Formatura : Form
    { 
        PacotesBLL pacbll = new PacotesBLL();
        PacotesDTO pacDTO = new PacotesDTO();
        public frm_Formatura()
        {
            InitializeComponent();
        }

       

        private void frm_Formatura_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            pacDTO.Id = int.Parse(txtID.Text);
            pacDTO.Nome = txtNome.Text;
            pacDTO.Descrição = txtDesc.Text;
            pacDTO.Valor = txtValor.Text;

            pacbll.Inserir(pacDTO);
        }
    }
}
