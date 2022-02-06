using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busisness;
using ObjectTransfer;

namespace View
{
    public partial class FrmSelectedClient : Form
    {
        public FrmSelectedClient()
        {
            InitializeComponent();
            dgvPricipal.AutoGenerateColumns = false;


        }

        private void tbnSearch_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            ClientBusiness clientBusiness = new ClientBusiness();

            ClientCollection clients = new ClientCollection();

            clients = clientBusiness.ConsultByName(txtSearch.Text);

            dgvPricipal.DataSource = null;
            dgvPricipal.DataSource = clients;

            dgvPricipal.Update();
            dgvPricipal.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgvPricipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado");
                return;
            }

            DialogResult result = MessageBox.Show("Deseja realmente excluir? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.No)
            {
                return;
            }

            Client clientSelected = (dgvPricipal.SelectedRows[0].DataBoundItem as Client);

            ClientBusiness clientBusiness = new ClientBusiness();

            string returnn = clientBusiness.Delete(clientSelected);

            try
            {
                int idClient = Convert.ToInt32(returnn);
                MessageBox.Show("Cliente excluido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGrid();
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível excluir. Detalhe: " + returnn, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            FrmClientRegister frmClientRegister = new FrmClientRegister(ScrennAction.Insert, null);
            DialogResult dialogResult = frmClientRegister.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                UpdateGrid();

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPricipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado");
                return;
            }


            Client clientSelected = (dgvPricipal.SelectedRows[0].DataBoundItem as Client);

            FrmClientRegister frmClientRegister = new FrmClientRegister(ScrennAction.Edit, clientSelected);
           DialogResult dialogResult = frmClientRegister.ShowDialog();
            if (dialogResult == DialogResult.Yes)
                UpdateGrid();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            if (dgvPricipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado");
                return;
            }


            Client clientSelected = (dgvPricipal.SelectedRows[0].DataBoundItem as Client);

            FrmClientRegister frmClientRegister = new FrmClientRegister(ScrennAction.Consult, clientSelected);
            frmClientRegister.ShowDialog();
        }
    }
}
