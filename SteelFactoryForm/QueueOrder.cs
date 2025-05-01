using SteelFactoryForm.SteelFactoryForm;
using System;
using System.Data;
using System.Windows.Forms;

namespace SteelFactoryForm
{
    public partial class QueueOrder : Form
    {
        private readonly DBManager dbManager = new DBManager();

        public QueueOrder()
        {
            InitializeComponent();
        }

        private void QueueOrder_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void LoadOrderData()
        {
            try
            {
                DataTable dataTable = dbManager.GetOrderData();

                if (dataTable == null || dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных для отображения.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewOrders.DataSource = dataTable;
                dataGridViewOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                if (dataGridViewOrders.Columns.Contains("Id"))
                {
                    dataGridViewOrders.Columns["Id"].HeaderText = "ID";
                }
                if (dataGridViewOrders.Columns.Contains("StatusOrder"))
                {
                    dataGridViewOrders.Columns["StatusOrder"].HeaderText = "Статус";
                }
                if (dataGridViewOrders.Columns.Contains("NameOrg"))
                {
                    dataGridViewOrders.Columns["NameOrg"].HeaderText = "Имя клиента";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при загрузке данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        }
    }

