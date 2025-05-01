using SteelFactoryForm.SteelFactoryForm;
using System;
using System.Windows.Forms;

namespace SteelFactoryForm
{
    public partial class CreateOrder : Form
    {
        private readonly DBManager dbManager = new DBManager();
        private int orderId;
        private int warehouseId;

        public CreateOrder(int orderId, int warehouseId)
        {
            InitializeComponent();
            this.orderId = orderId;
            this.warehouseId = warehouseId;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxOreA.Text) ||
                string.IsNullOrWhiteSpace(textBoxNickelA.Text) ||
                string.IsNullOrWhiteSpace(textBoxChromeA.Text) ||
                string.IsNullOrWhiteSpace(textBoxManganeseA.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeFurnaceA.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeConverterA.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeRollingMachineA.Text) ||
                string.IsNullOrWhiteSpace(textBoxOreB.Text) ||
                string.IsNullOrWhiteSpace(textBoxNickelB.Text) ||
                string.IsNullOrWhiteSpace(textBoxChromeB.Text) ||
                string.IsNullOrWhiteSpace(textBoxManganeseB.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeFurnaceB.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeConverterB.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeRollingMachineB.Text) ||
                string.IsNullOrWhiteSpace(textBoxOreC.Text) ||
                string.IsNullOrWhiteSpace(textBoxNickelC.Text) ||
                string.IsNullOrWhiteSpace(textBoxChromeC.Text) ||
                string.IsNullOrWhiteSpace(textBoxManganeseC.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeFurnaceC.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeConverterC.Text) ||
                string.IsNullOrWhiteSpace(textBoxTimeRollingMachineC.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                float oreA = float.Parse(textBoxOreA.Text);
                float nickelA = float.Parse(textBoxNickelA.Text);
                float chromeA = float.Parse(textBoxChromeA.Text);
                float manganeseA = float.Parse(textBoxManganeseA.Text);
                string timeFurnaceA = textBoxTimeFurnaceA.Text;
                string timeConverterA = textBoxTimeConverterA.Text;
                string timeRollingMachineA = textBoxTimeRollingMachineA.Text;
                float productionVolumeA = float.Parse(textBoxProductionVolumeA.Text);
                float priceA = float.Parse(textBoxPriceA.Text);

                float oreB = float.Parse(textBoxOreB.Text);
                float nickelB = float.Parse(textBoxNickelB.Text);
                float chromeB = float.Parse(textBoxChromeB.Text);
                float manganeseB = float.Parse(textBoxManganeseB.Text);
                string timeFurnaceB = textBoxTimeFurnaceB.Text;
                string timeConverterB = textBoxTimeConverterB.Text;
                string timeRollingMachineB = textBoxTimeRollingMachineB.Text;
                float productionVolumeB = float.Parse(textBoxProductionVolumeB.Text);
                float priceB = float.Parse(textBoxPriceB.Text);

                float oreC = float.Parse(textBoxOreC.Text);
                float nickelC = float.Parse(textBoxNickelC.Text);
                float chromeC = float.Parse(textBoxChromeC.Text);
                float manganeseC = float.Parse(textBoxManganeseC.Text);
                string timeFurnaceC = textBoxTimeFurnaceC.Text;
                string timeConverterC = textBoxTimeConverterC.Text;
                string timeRollingMachineC = textBoxTimeRollingMachineC.Text;
                float productionVolumeC = float.Parse(textBoxProductionVolumeC.Text);
                float priceC = float.Parse(textBoxPriceC.Text);


                dbManager.SaveSteelRequirements("A", oreA, nickelA, chromeA, manganeseA, timeFurnaceA, timeConverterA, timeRollingMachineA, productionVolumeA, priceA, warehouseId);
                dbManager.SaveSteelRequirements("B", oreB, nickelB, chromeB, manganeseB, timeFurnaceB, timeConverterB, timeRollingMachineB, productionVolumeB, priceB, warehouseId);
                dbManager.SaveSteelRequirements("C", oreC, nickelC, chromeC, manganeseC, timeFurnaceC, timeConverterC, timeRollingMachineC, productionVolumeC, priceC, warehouseId);

                MessageBox.Show("Данные успешно записаны");
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Ошибка формата данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
