using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadonnaChecker
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {

            DataLoading.TableFetch tablevarfinal = new DataLoading.TableFetch();
            tablevarfinal.tablechoice = DataLoading.TablePass.chosentable;

            DataLoading.Ss Selectfinal = new DataLoading.Ss
            {
                Sql = "SELECT * FROM " + tablevarfinal.tablechoice
            };

           
                try
                {
                    DataLoading.MSQC congridf = new DataLoading.MSQC();  //connection stuff
                    MySqlConnection conf = new MySqlConnection(congridf.Mysqc);
                    conf.Open();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(Selectfinal.Sql, conf);
                    ///////////begin filling table
                    DataSet dsf = new DataSet();
                    //adapt the data to fill it into the table
                    adapter1.Fill(dsf, "MadonnaSongs");
                    dataGridViewf.DataSource = dsf.Tables["MadonnaSongs"];
                   DataLoading.VarGrab.sqlrows = dataGridViewf.RowCount;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(Selectfinal.Sql + "Error: " + ex.ToString());
                }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

