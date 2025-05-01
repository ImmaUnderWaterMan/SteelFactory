using SteelFactoryForm.SteelFactoryForm;
using System;
using System.Windows.Forms;

namespace SteelFactoryForm
{
    public partial class Order : Form
    {
        private readonly DBManager dbManager = new DBManager();

        public Order()
        {
            InitializeComponent();
            textBoxId.Validating += TextBoxId_Validating;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string nameOrg = textBoxCustomerName.Text;
            string statusOrder = "В процессе";

            if (string.IsNullOrWhiteSpace(nameOrg))
            {
                MessageBox.Show("Пожалуйста, введите имя клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id;
            if (!int.TryParse(textBoxId.Text, out id))
            {
                MessageBox.Show("Пожалуйста, введите корректный Id (положительное целое число).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int orderId = dbManager.SaveOrderToDatabase(nameOrg, statusOrder, id);

            if (orderId > 0)
            {

                if (dbManager.DoesIdExistInWarehouse(id))
                {
                    CreateOrder createOrder = new CreateOrder(orderId, id);
                    createOrder.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка: Id не существует в таблице Warehouse.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ошибка при сохранении заказа.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxId_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (int.TryParse(textBox.Text, out int id) && id > 0)
            {
                if (!dbManager.DoesIdExistInWarehouse(id))
                {
                    MessageBox.Show("Введенное Id не существует в базе данных Warehouse.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный Id (положительное целое число).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
    }
}
