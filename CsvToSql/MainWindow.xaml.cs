using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CsvToSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string filepath = this.txtCsv.Text;
                DataTable datatable = new DataTable();

                using (StreamReader sr = new StreamReader(filepath))
                {
                    string line = sr.ReadLine();
                    string[] value = line.Split(',');

                    foreach (string dc in value)
                        datatable.Columns.Add(new DataColumn(dc));

                    while (!sr.EndOfStream)
                    {
                        value = sr.ReadLine().Split(',');
                        if (value.Length == datatable.Columns.Count)
                        {
                            DataRow row = datatable.NewRow();
                            row.ItemArray = value;
                            datatable.Rows.Add(row);
                        }
                    }
                }
                using (SqlConnection connection = new SqlConnection(this.txtConnectionString.Text))
                {
                    using (SqlBulkCopy bc = new SqlBulkCopy(connection.ConnectionString, SqlBulkCopyOptions.TableLock))
                    {
                        bc.DestinationTableName = this.txtTabela.Text;
                        bc.BatchSize = datatable.Rows.Count;

                        connection.Open();
                        bc.WriteToServer(datatable);
                    }
                }

                MessageBox.Show("Importação concluída com sucesso!!!", "Atenção", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
