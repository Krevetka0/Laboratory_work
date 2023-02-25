using System;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDlg.InitialDirectory = Application.StartupPath;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDlg.FileName);
            }
        }
        private void ShowData(string datapath)
        {
            try
            {
                DataStorage data = DataStorage.DataCreator(datapath);
                dgvRaw.DataSource = data.GetRawData();
                dgvRaw.ReadOnly = true;
                resultTable.DataSource = data.GetZadolgniki();
                resultTable.ReadOnly = true;
            }
            catch (Exception)
            {
                MessageBox.Show("При загрузке данных что-то сломалось");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dgvRaw.RowCount; i++)
            {
                if (Convert.ToInt32(dgvRaw[3, i].Value) == 0)
                    sum++;
            }
            resultTextBox.Text = sum.ToString();
        }
    }
}
