using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectTransfer;
using Busisness;

namespace View
{
    public partial class FrmClientRegister : Form
    {
        ScrennAction scrennActionSelected;

        public FrmClientRegister(ScrennAction scrennAction, Client client)
        {
            InitializeComponent();

            scrennActionSelected = scrennAction;

            if (scrennAction == ScrennAction.Insert)
            {
                this.Text = "Inserir Cliente";
            }
            else if (scrennAction == ScrennAction.Edit)
            {
                this.Text = "Alterar Cliente";
                txtCodigo.Text = client.IdClient.ToString();
                txtName.Text = client.ClientName;
                dtpDateBirth.Value = client.DateBirth;
                if (client.Sex == true)
                    rdbMasculino.Checked = true;
                else
                    rdbFeminino.Checked = true;
                txtLimit.Text = client.LimitPurchases.ToString();

            }
            else
            {
                this.Text = "Consultar Cliente";

                this.Text = "Alterar Cliente";
                txtCodigo.Text = client.IdClient.ToString();
                txtName.Text = client.ClientName;
                dtpDateBirth.Value = client.DateBirth;
                if (client.Sex == true)
                {
                    rdbMasculino.Checked = true;
                } else
                {
                    rdbFeminino.Checked = true;
                }
                txtLimit.Text = client.LimitPurchases.ToString();

                txtName.ReadOnly = true;
                txtName.TabStop = false;
                dtpDateBirth.Enabled = false;
                rdbMasculino.Enabled = false;
                rdbFeminino.Enabled = false;
                txtLimit.ReadOnly = true;
                txtLimit.TabStop = false;

                btnSave.Visible = false;
                btnCancel.Text = "Fechar";
                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(scrennActionSelected == ScrennAction.Insert)
            {
                Client client = new Client();
                client.ClientName = txtName.Text;
                client.DateBirth = dtpDateBirth.Value;
                if (rdbMasculino.Checked == true)
                    client.Sex = true;
                else
                    client.Sex = false;
                client.LimitPurchases = Convert.ToDecimal(txtLimit.Text);

                ClientBusiness clientBusiness = new ClientBusiness();
                string returnn = clientBusiness.Insert(client);

                try
                {
                    int IdClient = Convert.ToInt32(returnn);

                    MessageBox.Show("Cliente cadastrado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.Yes;
                   
                }
                catch 
                {
                    MessageBox.Show("Não foi possível cadastrar um novo cliente. Detalhe: " + returnn, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;

                }

               
            } else if(scrennActionSelected == ScrennAction.Edit)
            {
                Client client = new Client();

                client.IdClient = Convert.ToInt32(txtCodigo.Text);
                client.ClientName = txtName.Text;
                client.DateBirth = dtpDateBirth.Value;
                if (rdbMasculino.Checked == true)
                    client.Sex = true;
                else
                    client.Sex = false;
                client.LimitPurchases = Convert.ToDecimal(txtLimit.Text);

                ClientBusiness clientBusiness = new ClientBusiness();
                string returnn = clientBusiness.Edit(client);

                try
                {
                    int IdClient = Convert.ToInt32(returnn);

                    MessageBox.Show("Cliente alterado com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.Yes;

                }
                catch
                {
                    MessageBox.Show("Não foi possível alterar este cliente. Detalhe: " + returnn, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;

                }
            }
        }
    }
}
