using SteelFactoryForm.SteelFactoryForm;
using System;
using System.Windows.Forms;

namespace SteelFactoryForm
{
    public partial class Warehouse : Form
    {
        private readonly DatabaseConnection dbConnection = DatabaseConnection.Instance;
        private readonly DBManager dbManager = new DBManager();

        public Warehouse()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTimeFurnace.Text) || string.IsNullOrEmpty(textBoxTimeConverter.Text) || string.IsNullOrEmpty(textBoxTimeRollingMachine.Text))
            {
                MessageBox.Show("Пожалуйста, введите время работы: печи, конвертора, прокатного стана.");
                return;
            }
            if (!int.TryParse(textBoxId.Text, out int id) || id < 0)
            {
                MessageBox.Show("Пожалуйста, введите корректный ID (положительное целое число).");
                return;
            }
            if (!float.TryParse(textBoxOre.Text, out float ore) || ore < 0)
            {
                MessageBox.Show("Пожалуйста, введите кол-во руды (положительное число).");
                return;
            }
            if (!float.TryParse(textBoxNickel.Text, out float nickel) || nickel < 0)
            {
                MessageBox.Show("Пожалуйста, введите кол-во никеля (положительное число).");
                return;
            }
            if (!float.TryParse(textBoxChrome.Text, out float chrome) || chrome < 0)
            {
                MessageBox.Show("Пожалуйста, введите кол-во хрома (положительное число).");
                return;
            }
            if (!float.TryParse(textBoxManganese.Text, out float manganese) || manganese < 0)
            {
                MessageBox.Show("Пожалуйста, введите кол-во марганца (положительное число).");
                return;
            }

            dbManager.SaveSelectedValueWarehouseToDatabase(
                id,
                ore,
                nickel,
                chrome,
                manganese,
                textBoxTimeFurnace.Text,
                textBoxTimeConverter.Text,
                textBoxTimeRollingMachine.Text);

            MessageBox.Show("Данные успешно записаны");
            this.Close();
        }
    }
}
