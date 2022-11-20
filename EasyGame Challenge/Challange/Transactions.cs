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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
        }
        Datahandler obj = new Datahandler();
        private void Transaction_Load(object sender, EventArgs e)
        {
            txtclient.Text = Main.name;
            txttype.Text = Main.tranactiontype;
            txtID.Text = obj.Tranactionid().ToString();
        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            string type = "0";
            decimal amount = decimal.Parse(txtamount.Text);
            if (txttype.Text == "Debit")
            {
                type = "1";
            }
            else
            {
                type = "2";
                amount = amount * -1;
            }
            obj.insertTranaction(int.Parse(txtID.Text), Main.id,amount,type,txtcomment.Text);
            this.Hide();
            var form2 = new Main();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
