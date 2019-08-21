 public void FuzzyArrayUpdatePrepare(string[] controlString, string[] problemString)
        {
            int i = 0; //LCV for controlString
            int p = 0; //LCV for problemString
            int ld; //levenshtein distance
            DataGridView tempLevSorter = new DataGridView();
            //add and namecolumns will need names later
            tempLevSorter.ColumnCount = 3;
            tempLevSorter.Columns[0].Name = "Variation";
            tempLevSorter.Columns[1].Name = "CSV Song Name";
            tempLevSorter.Columns[2].Name = "Database Song Name";
            tempLevSorter.Visible = false;
            while (i < controlString.Length)
            {
                /*it shouldn't hurt to clear and refresh the grid up here, and we will
                 * absolutely have to each iteration of this outerloop! */
                tempLevSorter.Rows.Clear();
                tempLevSorter.Refresh();
                while (p < problemString.Length)
                {
                    ld = 0;
                    ld = ComputeLevD(controlString[i], problemString[p]);
                    //make it easier to type out the rest of the inputs
                    tempLevSorter.Rows.Add(ld, controlString[i], problemString[p]);

                    /*DataGridView.Rows row = (DataGridView)tempLevSorter.Rows[i].Clone();
                    row.Cells[0].Value = ld;
                    row.Cells[1].Value = controlString[i];
                    row.Cells[2].Value = problemString[p];
                    tempLevSorter.Rows.Add(row);*/
                    ++p;
                    //don't forget to reset LD just to be safe.
                }
                //this is where the datagrid view sorting and updating will happen!
             
                tempLevSorter.Sort(tempLevSorter.Columns[0], ListSortDirection.Ascending);
                label7.Text = tempLevSorter.Rows[0].Cells[0].ToString();



               /* for (int x = 0; x < (tempLevSorter.RowCount-1); ++x)
                {
                    if (x > 3) tempLevSorter.Rows[x].Visible = false;
                }*/


                //DO NOT FORGET TO SET THE RADIOBUTTONS TO UNCHECKED BEFORE PROCEEDING
                p = 0;
                ++i;
            }
        }