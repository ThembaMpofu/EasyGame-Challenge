using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challange
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Datahandler obj = new Datahandler();
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Client> clients = obj.allclient();
            clients.Sort((x,y) => x.Name.CompareTo(y.Name));
            foreach (var item in clients)
            {
                comboClient.Items.Add(item.Name + " "+ item.Surname);
            }
            dgvalldata.DataSource =obj.allclient();
        }
        
        public void comboClient_DropDownClosed(object sender,EventArgs e) {
            dgvalldata.DataSource = null;
          if(comboClient.Text == "")
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                List<Tranaction> linkedtranaction = new List<Tranaction>();
                string[] temp = comboClient.SelectedItem.ToString().Split(' ');
                foreach (var item in obj.allclient())
                {

                    if (item.Name == temp[0])
                    {

                        linkedtranaction = obj.ClientTranaction(item.ClientID1);
                    }
                }
                linkedtranaction.Sort((x, y) => x.Amount.CompareTo(y.Amount));
                dgvalldata.DataSource = linkedtranaction;
            }
            
        }

        private void dgvalldata_leave(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dgvalldata_leave(object sender, EventArgs e)
        {
           

        }
       public static string tranactiontype = "";
        public static int id;
        public static string name;
        private void btncredit_Click_1(object sender, EventArgs e)
        {
            if(comboClient.Text != "")
            {

                tranactiontype = "Credit";
                int index = dgvalldata.CurrentCell.RowIndex;
                DataGridViewRow row = dgvalldata.Rows[index];
                id = int.Parse(row.Cells[1].Value.ToString());
                name = comboClient.Text;

                this.Hide();
                var form2 = new Transactions();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Make sure you selected a client");
            }
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            if (comboClient.Text != "")
            {

                tranactiontype = "Debit";
                int index = dgvalldata.CurrentCell.RowIndex;
                DataGridViewRow row = dgvalldata.Rows[index];
                id = int.Parse(row.Cells[1].Value.ToString());
                name = comboClient.Text;

                this.Hide();
                var form2 = new Transactions();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Make sure you selected a client");
            }
        }

        private void dgvalldata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = dgvalldata.CurrentCell.RowIndex;
            DataGridViewRow row = dgvalldata.Rows[index];
            obj.Update(int.Parse(row.Cells[0].Value.ToString()), row.Cells[4].Value.ToString());
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
