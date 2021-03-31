using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlProteinasClient.ProteinTrackingServiceSoap;

namespace ControlProteinasClient
{
    public partial class ControlProteinasForm : Form
    {
        private ProteinTrackingServiceSoapClient service = new ProteinTrackingServiceSoapClient();

        private User[] users;
        public ControlProteinasForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            users = service.ListUsers();
            cmbSelect.DataSource = users;
            cmbSelect.DisplayMember = "Name";
            cmbSelect.ValueMember = "UserId";
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string name = txtNombre.Text;
            int meta = int.Parse(txtMeta.Text);
            service.AddUser(name, meta);
            users = service.ListUsers();
            cmbSelect.DataSource = users;
            cleanUserData();
        }

        private void cleanUserData()
        {
            txtNombre.Text = "";
            txtMeta.Text = "";
        }

        private void OnUserChanged(object sender, EventArgs e)
        {
            var index = cmbSelect.SelectedIndex;
            lblTotalCount.Text = users[index].Total.ToString();
            lblMetaCount.Text = users[index].Goal.ToString();
        }

        private void OnAddProtein(object sender, EventArgs e)
        {
            var userId = users[cmbSelect.SelectedIndex].UserId;
            var total = int.Parse(txtBoxAgregar.Text);
            var newTotal = service.AddProtein(total, userId);
            lblTotalCount.Text = newTotal.ToString();
            txtBoxAgregar.Text = "";
            users = service.ListUsers();
        }
    }
}
