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
    public partial class DataLoading : Form
    {
        const int MAX_LV_ARRAY = 3;
        //starts at negative one because when user presses it turns to zero.
        //is a part of the form's variable because multiple methods need access to it; and making it a class is overkill.
        //uclv User Loop Controled Variable
        int uclv = -1;
        //tick is for timer controls
        int tick = 0;
     

        public DataLoading()
        {
            InitializeComponent();
            //We want to initalize the dropdown data right away
            //because, that's how I want to do it
            //AND IT'S MY PROGRAM
            MSQC constring = new MSQC();
            MySqlConnection con2 = new MySqlConnection(constring.Mysqc);
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            string showtables = "select * from  table_list";
            adapter = new MySqlDataAdapter(showtables, con2);
            adapter.Fill(table);
            //more prepwork for filling in tables
            databaseTablePicker1.DataSource = table;
            databaseTablePicker1.DisplayMember = "table_name";
            databaseTablePicker1.ValueMember = "table_name";


           //begin animation
            timer1.Start();







        }
   
        public DataGridView dgv { get { return dataGridView1; } }
        public DataGridView dgvcsv { get { return dataGridViewCSV; } }

        public object LevGrabSwap { get; private set; }

        //these um...pretend classes HEY DOCTOR SPEARS; I WAS SHOOTING IN THE DARK TO GET THIS TO WORK, WHAT ARE THESE THINGS ^^^^
        private void DataLoading_Load(object sender, EventArgs e)
        {
            //this code is required to fill in the dropdown list 
            this.table_listTableAdapter.Fill(this.musicDataSet.table_list);

        }
        private void dataGridViewCSV_CellFormatting(object sender,
                                        DataGridViewCellFormattingEventArgs e)
        {
        }
        private void dataGridViewCSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {//exception handling (why yes, I did read chapter 

            try
            {//if something is wrong with the file such as not being a proper CSV we can have an exception
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        dataGridViewCSV.DataSource = ReadCSV(ofd.FileName);

                }
            }

            catch (Exception ex)
            {//catches exception; shows information. 
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         //we will need this for loops later on in the program.
            VarGrab.csvrows = dataGridViewCSV.RowCount;
     
        }

        public DataTable ReadCSV(string fileName1)
        {
            DataTable dt = new DataTable("DataTableInstance");//instantiates a new datatable that we're going to ultimately embed in the form
                                                             /*this next section uses the OLEDB command which is an API designed by Microsoft for accessing dat from various sources in a uniform manner*/
            using (OleDbConnection olecn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" +
              Path.GetDirectoryName(fileName1) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                using (OleDbCommand olecmd = new OleDbCommand(string.Format("select* from [{0}]", new FileInfo(fileName1).Name), olecn))
                {
                    olecn.Open();
                    //opens the connection then the adapter will make the data get in the table
                    using (OleDbDataAdapter oleadapt = new OleDbDataAdapter(olecmd))
                    {
                        oleadapt.Fill(dt);
                    }

                }
                /*note: the "using" keyword basically tells the program to ditch the resources once it is 
                 * done using them becuase they are no longer needed*/
            }
            return dt;

        }

        public static string Sqlcn(string x1, string x2, string x3, string x4, string x5)
        {
            //this is just for concating together all the mysql connection strings 
            //why do something 90 times when you can do it once.
            string mysqlcn = x1 + x2 + x3 + x4 + x5;
            return mysqlcn;
        }
        public class MSQC
        {
            public string Mysqc
            { //I'm willing to type the connection information to MySQL at most twice, then I'm over it, this will help.
                get
                {
                    return Sqlcn(Form1.login.c1, Form1.login.user, Form1.login.c3, Form1.login.pass, Form1.login.c5);
                }
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.table_listTableAdapter.FillBy(this.musicDataSet.table_list);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            string chosenTable = databaseTablePicker1.SelectedValue.ToString();

            TableFetch tablevar = new TableFetch();
            tablevar.tablechoice = chosenTable;

            Ss Select = new Ss
            {
                Sql = "SELECT * FROM " + tablevar.tablechoice
            };

            if (tablevar.tablechoice == "System.Data.DataRowView")
            {
                
            }
            else
            {
                databaseTablePickerLabel1.Visible = false;
                try
                { //pretty much everything but a simple table call with MYSQL probably needs a try block
                    MSQC congrid = new MSQC();
                    MySqlConnection con1 = new MySqlConnection(congrid.Mysqc);
                    con1.Open();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(Select.Sql, con1);
                    ///////////begin filling table
                    DataSet ds = new DataSet();
                    //adapt the data to fill it into the table
                    adapter1.Fill(ds, "MadonnaSongs");
                    dataGridView1.DataSource = ds.Tables["MadonnaSongs"];
                    VarGrab.sqlrows = dataGridView1.RowCount; //this is going to be important for looping
                    //need to send this to the next form
                    TablePass.chosentable = tablevar.tablechoice;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(Select.Sql + "Error: " + ex.ToString());
                }
            }
        }

        public class TableFetch
        {
            public string tablechoice { get; set; }
        }
        public  class Ss //short for select statment
        {
            public string Sql { get; set;}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //this exists to create the view for a datagrid in particular from MYSQL
        }
        
        protected void button3_Click(object sender, EventArgs e)
        { //this whole section is for the data matching display and selection routine.
            //note: this damn thing would not refactor to the name I wanted it to havel even though it's
            //called something else everywhere else, changing this name here messes it all up.
          
            if (checkBox1.Visible==false)
                {
                checkBox1.Visible=true;
                checkBox2.Visible=true;
                checkBox3.Visible=true;
                }
            //end checkbox unlocking
            //begin getting strings to compare so the user can see.
            string[] sqltablevals1 = new string[dgv.Rows.Count];
            string[] sqltablevals2 = new string[dgv.Rows.Count];
            string[] csvtablevals1 = new string[dgvcsv.Rows.Count];
            string[] csvtablevals2 = new string[dgvcsv.Rows.Count];
            ArraySlurp(sqltablevals1, sqltablevals2, dataGridView1);
            ArraySlurp(csvtablevals1, sqltablevals2, dataGridViewCSV);

            int p = 0; //LCV for problemString
         
            uclv++; //every time the user presses the button this goes up. 
            //this is why this variable exists as part of the form the user creates their own loop.
            if (uclv < csvtablevals1.Length)
                { //start fuzzy matching if we have not passed the amount of rows in the tables
                    FuzzyArrayUpdatePrepare(uclv, p, csvtablevals1, sqltablevals1);
                if (uclv == (csvtablevals1.Length - 1))
                {
                    generateMatches.Text = "ENOUGH!";
                    loadFinalForm.Visible = true;
                }
                else if (uclv != -1) generateMatches.Text = "Keep going!";
                }
            checkboxActivate();
            System.Drawing.Color backcolor1 = System.Drawing.ColorTranslator.FromHtml("#AADAFF");
            updateSQLButton.BackColor = backcolor1;
            System.Drawing.Color transcolor1 = System.Drawing.ColorTranslator.FromHtml("#000000");
            generateMatches.BackColor = transcolor1;
        }
        //next 3 events prevent checkboxes from being activted if one already is; only one can be checked at a time.
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled)
                checkBox2.Enabled = false;
            else checkBox2.Enabled = true;

            if (checkBox3.Enabled)
                checkBox3.Enabled = false;
            else checkBox3.Enabled = true;

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled)
                checkBox1.Enabled = false;
            else checkBox1.Enabled = true;

            if (checkBox3.Enabled)
                checkBox3.Enabled = false;
            else checkBox3.Enabled = true;

        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled)
                checkBox1.Enabled = false;
            else checkBox1.Enabled = true;
            if (checkBox2.Enabled)
                checkBox2.Enabled = false;
            else checkBox2.Enabled = true;
        }
        private void checkboxReset()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
        //next event updates the MYSQL tables.
        private void updateSQLButton_Click(object sender, EventArgs e)
        {
            ////-\\\\\ATTENTION: Dr. Spears:
            /*I could have done a whole thing where I had many albums and many songs and used JOINS but this
            a test of what you taught me in C# not my incredible SQL prowess .*/
            Ss Update = new Ss();
            Update.Sql = null; //its safer to null this each loop before we get to business.

            if (!(checkBox1.Checked) && !(checkBox2.Checked) && !(checkBox3.Checked))
            {
                debugLabel1.Visible = true;
                debugLabel1.Text = "You WILL select a box to proceed!";
            }
            else if (checkBox1.Checked)
            {
                debugLabel1.Visible = false;
                Update.Sql = "UPDATE  " + TablePass.chosentable + "   SET SongTitle= '" + LevGrab.controlViewArray[0] + "' WHERE SongTitle = '" + LevGrab.problemViewArray[0] + "' ";
                UpdateMySQL(Update.Sql);
            }
            else if (checkBox2.Checked)
            {
                debugLabel1.Visible = false;
                Update.Sql = "UPDATE  " + TablePass.chosentable + "   SET SongTitle= '" + LevGrab.controlViewArray[1] + "' WHERE SongTitle = '" + LevGrab.problemViewArray[1] + "' ";
                UpdateMySQL(Update.Sql);
            }
            else if (checkBox3.Checked)
            {
                debugLabel1.Visible = false;
                Update.Sql = "UPDATE  " + TablePass.chosentable + "   SET SongTitle= '" + LevGrab.controlViewArray[2] + "' WHERE SongTitle = '" + LevGrab.problemViewArray[2] + "' ";
                UpdateMySQL(Update.Sql);
            }
            //Reset all checkboxes to be Enabled and unchecked.
            checkboxReset();
            System.Drawing.Color backcolor2 = System.Drawing.ColorTranslator.FromHtml("#AADAFF");
            generateMatches.BackColor = backcolor2;
            System.Drawing.Color transcolor2 = System.Drawing.ColorTranslator.FromHtml("#000000");
            updateSQLButton.BackColor = transcolor2;
        }

        public void checkboxActivate()
        //this method places the strings next to the correct checkboxes
        {
            checkBox1.Text = "Distance Factor: " + Convert.ToString(LevGrab.levDist[0]) + " | " + "Control: " + LevGrab.controlViewArray[0] + " | " + "Problem: " + LevGrab.problemViewArray[0];
            checkBox2.Text = "Distance Factor: " + Convert.ToString(LevGrab.levDist[1]) + " | " + "Control: " + LevGrab.controlViewArray[1] + " | " + "Problem: " + LevGrab.problemViewArray[1];
            checkBox3.Text = "Distance Factor: " + Convert.ToString(LevGrab.levDist[2]) + " | " + "Control: " + LevGrab.controlViewArray[2] + " | " + "Problem: " + LevGrab.problemViewArray[2];
        }
        //this method below slurps the values out of a datagrid and vomits them into an array!
       
        public void UpdateMySQL(string update)
        {
            try
            {
                MSQC congrid1 = new MSQC();
                MySqlConnection con2 = new MySqlConnection(congrid1.Mysqc);
                con2.Open();
                MySqlCommand command = new MySqlCommand(update, con2);
                //remember Ss.Sql is the class I made for SQL queries 
                command.ExecuteNonQuery();
                con2.Close();
           
    }
            catch (MySqlException exSql)
            {
                MessageBox.Show(update + "Error: " + exSql.ToString());
            }

        }
        public void ArraySlurp(string[] column0Array, string[] column1Array, DataGridView dgvpass)
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvpass.Rows)
            {
                /*why this logic is the way it is.
                 * 1. we have to pull out both arrays here or C# gets mad; that I don't know why.
                 * 2. We need to make sure the cell value is not null so we can proceed; one problem with MYSQL is it leaves a null row at the end of each table
                 * 3. So if the value isn't null then we can extract that index's cell value into a string; otherwise just ignore it and leave it empty
                 * Decision/Logic?Option1 if True: Option2 if False*/
                column0Array[i] = row.Cells[0].Value != null ? row.Cells[0].Value.ToString() : string.Empty;
                column1Array[i] = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                i++;
            }
        }
        public class LevGrab
        {  /*class for grabbing the data out of the arrays and into the distance formula so it can be shown to user then
            ultimately updated into the SQL tables */

            public static int[] levDist = new int[MAX_LV_ARRAY];
            public static string[] controlViewArray = new string[MAX_LV_ARRAY];
            public static string[] problemViewArray = new string[MAX_LV_ARRAY];
        }
        public class VarGrab
        {
            public static int csvrows = 0;
            public static int sqlrows = 0;
            //DB01-3
            public static string csvrow0 = null;
            public static string[] csvRowVals = new string[csvrows];
            public static string[] sqlRowVals = new string[sqlrows];
        }
        public void FuzzyArrayUpdatePrepare(int i, int p, string[] csvtablevals1, string[] sqltablevals1)
        { //this prepares the arrays that will be used with the fuzzy matching protocol in this case Levenshtein distance

            int[] arrLevDist = new int[sqltablevals1.Length];
            LevGroup[] arrLevGroup = new LevGroup[sqltablevals1.Length];

            while (i < csvtablevals1.Length)
            {
                while (p < sqltablevals1.Length)
                {
                    arrLevDist[p] = ComputeLevD(csvtablevals1[i], sqltablevals1[p]);
                    arrLevGroup[p] = new LevGroup()
                    {
                        LevDist = arrLevDist[p],
                        CSVTitle = csvtablevals1[i],
                        SQLTitle = sqltablevals1[p]
                    };
                    ++p;
                    //don't forget to reset LD just to be safe.
                }
                var anonTypeArr = arrLevGroup.Select(x => new { x.LevDist, x.CSVTitle, x.SQLTitle }).OrderBy(x => x.LevDist).ToArray();
                foreach (var x in anonTypeArr)
                {
                    if (x != null) grid.DataSource = anonTypeArr;
                }
                //lcvs columns are constant nums to push along the data out to the correct class for ultimately shoving back in the database
                for (int q = 0; q <= 2; ++q)
                {//dataGridView[Column index, Row index].Value
                    LevGrab.levDist[q] = Convert.ToInt32(grid[0, q].Value);
                    LevGrab.controlViewArray[q] = grid[1, q].Value.ToString();
                    LevGrab.problemViewArray[q] = grid[2, q].Value.ToString();
                }

                ++i;
            }
        }

        public static int ComputeLevD(string s, string t)
        {
            /*note this code is heavily pulled from 
             * https://www.dotnetperls.com/levenshtein
             * what this module does:
             * 1st it establishes a two dimensional array which will be treated
             * much like a Matrix (think Algebra 2) 
             * the matrix from the upper left most cell will fill in 
             * with a count of how how many changes are needed to get the letter required based on
             * what the minimum cost is to get to the next lower right most cell (assuming 0,0 heading right and down)
             * the final cell is the minimum cost/distance to change the word; this formula replicates that*/
        
            int n = s.Length;
            int m = t.Length;
            int[,] d = new int[n + 1, m + 1];

            // Step 1
            if (n == 0)
            {
                return m;
            }

            if (m == 0)
            {
                return n;
            }

            // Step 2
            for (int i = 0; i <= n; d[i, 0] = i++)
            {
            }

            for (int j = 0; j <= m; d[0, j] = j++)
            {
            }

            // Step 3
            for (int i = 1; i <= n; i++)
            {
                //Step 4
                for (int j = 1; j <= m; j++)
                {
                    // Step 5
                    int cost = (t[j - 1] == s[i - 1]) ? 0 : 1;

                    // Step 6
                    d[i, j] = Math.Min(
                        Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1),
                        d[i - 1, j - 1] + cost);
                }
            }
            // Step 7
            return d[n, m];
        }

        public class LevGroup
        {
            public int LevDist { get; set; }
            public string CSVTitle { get; set; }
            public string SQLTitle { get; set; }

        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
              
        public void loopButton_Click(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void beginMatchGenerator_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            //hide stuff
            loadCSVButton.Visible = false;
            LoadCSVLabel.Visible = false;
            databaseTablePicker1.Visible = false;
            databaseTablePickerLabel1.Visible = false;
            dataGridViewCSV.Visible = false;
            dataGridView1.Visible = false;
            //view stuff
            updateSQLButton.Visible = true;
            madonnaThrone.Visible = true;


            //move stuff
            timerAnimate.Start();

            //final act, hide the button and replace it with proper match genertor.
            generateMatches.Visible = true;
            beginMatchGenerator.Visible = false;
         


        }
        private void timer1_Tick(object sender, EventArgs e)
        {   //before the timer starts show the first chunk of instructions
            //madonna will point to the controls
            instructions1.Visible = true;
            ++tick;
            if (tick == 1)
            {
             gsEroticaLeftPoint.Visible = true;
            }
            if (tick == 4)
            {
                loadCSVButton.Visible = true;
                LoadCSVLabel.Visible = true;
                dataGridViewCSV.Visible = true;             
            }
            if (tick == 5)
            {                
               instructions2.Visible = true;
            }

            if (tick == 6)
            {
                gsEroticaLeftPoint.Visible = false;
                gsEroticaPointRightImage.Visible = true;
                databaseTablePicker1.Visible = true;
                databaseTablePickerLabel1.Visible = true;
                dataGridView1.Visible = true;                            
            }
            if (tick == 8)
            {
                gsEroticaPointRightImage.Visible = false;
                beginMatchGenerator.Visible = true;            
            }
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            if (instructions1.Top > 54)
            {
                instructions1.Top = instructions1.Top - 1;
                instructions2.Top = instructions2.Top - 1;
            }
            else
            {                
                timerAnimate.Stop();
            }
          
        }

        private void loadFinalForm_Click(object sender, EventArgs e)
        {  //hide this form; generate a new object form, shove any needed arguments to it.
            this.Hide();
            var FinalForm = new FinalForm();
            FinalForm.Closed += (s, args) => this.Close();
            FinalForm.Show();
        }
        public static class TablePass
        {
            //making it easier to shove this variable in to the next form.
            public static string chosentable;
        }

        private void instructions2_Click(object sender, EventArgs e)
        {

        }
    }
   


}

