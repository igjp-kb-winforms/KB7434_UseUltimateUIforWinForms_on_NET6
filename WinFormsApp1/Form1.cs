using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            DataTable table = new DataTable();

            table.Columns.Add("col1", typeof(Int32));
            table.Columns.Add("col2", typeof(string));
            table.Columns.Add("col3", typeof(string));

            for (int i = 0; i < 5; i++)
            {
                table.Rows.Add(new object[] { i, "test" + i, "ITEM" + i });
            }

            ultraGrid1.DataSource = table;
        }
    }
}