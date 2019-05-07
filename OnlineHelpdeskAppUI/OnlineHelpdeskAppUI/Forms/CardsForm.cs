using OnlineHelpdeskAppUI.App_Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineHelpdeskAppUI.Forms
{
    public partial class CardsForm : Form
    {
        public CardsForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void CardsForm_Load(object sender, EventArgs e)
        {
            dgv_cards.DataSource =  DbContext.Cards.GetAll();
        }
    }
}
