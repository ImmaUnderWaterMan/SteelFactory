using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteelFactoryForm
{
    public partial class SteelFactory : Form
    {
        public SteelFactory()
        {
            InitializeComponent();
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Show();
        }

        private void buttonWarehouse_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.Show();
        }

        private void buttonOrderQueue_Click(object sender, EventArgs e)
        {
            QueueOrder queueOrder = new QueueOrder();
            queueOrder.Show();
        }
    }
}