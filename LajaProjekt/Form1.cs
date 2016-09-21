using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using ClosedXML.Excel;

namespace LajaProjekt
{
    public partial class Form1 : Form
    {
        private int Tab2_Id;
        private int day;
        private int month;
        private int year;

        private String ExportPath;

        private String[] Category = { "SUMA", "HERBATY", "POSIŁKI", "SKLEP", "FAJKI", "INNE" };

        private int EditCount;

        public Form1()
        {
            InitializeComponent();
            this.CategoryComboBox.MouseWheel += new MouseEventHandler(CategoryComboBox_MouseWheel);
            this.ExportPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\1.xlsx";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadSettings();
            this.table2TableAdapter.Fill(this.databaseDataSet.Table2);
            this.query1TableAdapter.Fill(this.databaseDataSet.query1);
            this.tableTableAdapter.Fill(this.databaseDataSet.Table);
            this.MenuCount.Text = String.Format("Ilość pozycji: {0}", this.databaseDataSet.Table.Count);
            this.EditCount = Convert.ToInt32(this.databaseDataSet.Tables["Table"].Rows[Convert.ToInt32(this.databaseDataSet.Tables["Table"].Rows.Count) - 1]["Id"]) + 1;
            try {
                this.Tab2_Id = Convert.ToInt32(this.databaseDataSet.Tables["Table2"].Rows[Convert.ToInt32(this.databaseDataSet.Tables["Table2"].Rows.Count) - 1]["id"]);
            }
            catch {
                this.Tab2_Id = 0;
            }
            this.CategoryComboBox.Text = Convert.ToString(this.databaseDataSet.Tables["Table"].Rows[0]["Kategoria"]);
            this.SalesFilter_method();        
            this.UpdateSummary_metchod();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.UpdateSettings();
        }

        private void LoadSettings()
        {
            this.settingsTableAdapter1.Fill(this.databaseDataSet.Settings);
            this.ExpO1.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[0][1]);
            this.ExpO2.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[1][1]);
            this.ExpO3.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[2][1]);
            this.ExpS1.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[3][1]);
            this.ExpS2.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[4][1]);
            this.f0.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[5][1]);
            this.f1.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[6][1]);
            this.f2.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[7][1]);
            this.f3.Checked = Convert.ToBoolean(this.databaseDataSet.Tables["Settings"].Rows[8][1]);
        }

        private void UpdateSettings()
        {
            this.databaseDataSet.Tables["Settings"].Rows[0][1] = this.ExpO1.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[1][1] = this.ExpO2.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[2][1] = this.ExpO3.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[3][1] = this.ExpS1.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[4][1] = this.ExpS2.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[5][1] = this.f0.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[6][1] = this.f1.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[7][1] = this.f2.Checked;
            this.databaseDataSet.Tables["Settings"].Rows[8][1] = this.f3.Checked;
            this.settingsTableAdapter1.Update(this.databaseDataSet.Settings);
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.RemoveFilter();
            this.tableBindingSource.AddNew();
            this.idTextBox.Text = Convert.ToString(EditCount);
            ++this.EditCount;
            this.kategoriaTextBox.Text = this.CategoryComboBox.Text;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.tableBindingSource.Count > 0)
            {
                this.tableBindingSource.RemoveCurrent();
            }   
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try{
                this.Validate();
                this.tableBindingSource.EndEdit();
                this.tableTableAdapter.Update(this.databaseDataSet.Table);
            }
            catch
            {
                MessageBox.Show("Nie można usunąć! \nTa pozycja jest używana obecnie w tabeli utargu", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.tableTableAdapter.Fill(this.databaseDataSet.Table);
            }
            this.MenuCount.Text = String.Format("Ilość pozycji: {0}", this.databaseDataSet.Table.Count);
            this.query1TableAdapter.Fill(this.databaseDataSet.query1);
            this.SalesFilter_method();
            this.UpdateSummary_metchod();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.CategoryComboBox.Text = this.kategoriaTextBox.Text;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.kategoriaTextBox.Text = this.CategoryComboBox.Text;
        }
        
        private void CategoryComboBox_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            try {
                this.tableBindingSource.Filter = string.Format("Nazwa LIKE '{0}%' or Nazwa LIKE '% {0}%'", SearchBox.Text);
            }
            catch { };
        }
 
        private void SearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.tableBindingSource.Count > 0)
            {
                int row = this.dataGridView1.CurrentCell.RowIndex;
                if (e.KeyCode == Keys.Up)
                {
                    if (row > 0)
                    {
                        this.dataGridView1.Rows[row].Selected = false;
                        this.dataGridView1.Rows[row - 1].Selected = true;
                        this.dataGridView1.CurrentCell = this.dataGridView1[1, row - 1];
                        this.CategoryComboBox.Text = this.kategoriaTextBox.Text;
                    }
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (row < this.tableBindingSource.Count - 1)
                    {
                        this.dataGridView1.Rows[row].Selected = false;
                        this.dataGridView1.Rows[row + 1].Selected = true;
                        this.dataGridView1.CurrentCell = this.dataGridView1[1, row + 1];
                        this.CategoryComboBox.Text = this.kategoriaTextBox.Text;
                    }
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    this.AddToSales_method();
                    this.UpdateSummary_metchod();
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void DateUpdate_method()
        {
            this.day = SalesDate.Value.Day;
            this.month = SalesDate.Value.Month;
            this.year = SalesDate.Value.Year;
        }
   
        private void AddToSales_Click(object sender, EventArgs e)
        {
            this.AddToSales_method();
            this.UpdateSummary_metchod();
        }

        private void AddToSales_method()
        {
            ++this.Tab2_Id;
            int Id_prod = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            int ilosc;
            try {
                ilosc = Convert.ToInt32(this.AddQuantity.Text);
            }
            catch
            {
                ilosc = 1;
            }

            decimal cena = Convert.ToDecimal(this.dataGridView1.CurrentRow.Cells[3].Value);

            DateUpdate_method();
            
            double discount = 0;
            if (this.d1.Checked) {
                discount = 0;
            }
            else if (this.d2.Checked) {
                discount = 0.2;
            }
            else if (this.d3.Checked) {
                discount = 0.3;
            }

            this.table2TableAdapter.Insert(this.Tab2_Id, Id_prod, ilosc, cena, this.day, this.month, this.year, discount);
            this.databaseDataSet.AcceptChanges();
            this.query1TableAdapter.Fill(this.databaseDataSet.query1);

            this.dataGridView2.ClearSelection();
            int row = this.dataGridView2.Rows.Count - 1;
            this.dataGridView2.Rows[row].Selected = true;
            this.dataGridView2.CurrentCell = this.dataGridView2.Rows[row].Cells[1];
            this.dataGridView2.FirstDisplayedScrollingRowIndex = row;

            this.UpdateSalesCounter_method();
        }

        private void SalesDate_ValueChanged(object sender, EventArgs e)
        {
            this.SalesFilter_method();
            this.UpdateSummary_metchod();
        }

        private void f0_CheckedChanged(object sender, EventArgs e)
        {
            this.SalesFilter_method();
            this.UpdateSummary_metchod();
        }

        private void f1_CheckedChanged(object sender, EventArgs e)
        {
            this.SalesFilter_method();
            this.UpdateSummary_metchod();
        }

        private void f2_CheckedChanged(object sender, EventArgs e)
        {
            this.SalesFilter_method();
            this.UpdateSummary_metchod();
        }

        private void f3_CheckedChanged(object sender, EventArgs e)
        {
            this.SalesFilter_method();
            this.UpdateSummary_metchod();
        }

        private void SalesFilter_method()
        {
            this.DateUpdate_method();

            if (this.f0.Checked) {
                this.query1BindingSource.RemoveFilter();
            }
            else if (this.f1.Checked) {
                this.query1BindingSource.Filter = string.Format("year = {0}", this.year);
            }
            else if (this.f2.Checked) {
                this.query1BindingSource.Filter = string.Format("month = {0} and year = {1}", this.month, this.year);
            }
            else if (this.f3.Checked) {
                this.query1BindingSource.Filter = string.Format("day = {0} and month = {1} and year = {2}", this.day, this.month, this.year);
            }

            this.UpdateSalesCounter_method();
        }

        private void UpdateSalesCounter_method()
        {
            this.SalesCount.Text = String.Format("Ilość pozycji: {0}", this.dataGridView2.RowCount);
        }

        private double[] ExectuteSummaryQueries_method()
        {
            double[] Display = new double[6];
            
            if (this.f0.Checked)
            {
                Display[0] = Convert.ToDouble(this.queriesTableAdapter1.AllGetSum());
                for (int i = 1; i < 6; ++i)
                {
                    Display[i] = Convert.ToDouble(this.queriesTableAdapter1.AllGetCategory(this.Category[i]));
                }
            }
            else if (this.f1.Checked)
            {
                Display[0] = Convert.ToDouble(this.queriesTableAdapter1.YearGetSum(this.year));
                for (int i = 1; i < 6; ++i)
                {
                    Display[i] = Convert.ToDouble(this.queriesTableAdapter1.YearGetCategory(this.Category[i], this.year));
                }
            }
            else if (this.f2.Checked)
            {
                Display[0] = Convert.ToDouble(this.queriesTableAdapter1.MonthGetSum(this.year, this.month));
                for (int i = 1; i < 6; ++i)
                {
                    Display[i] = Convert.ToDouble(this.queriesTableAdapter1.MonthGetCategory(this.Category[i], this.year, this.month));
                }
            }
            else if (this.f3.Checked)
            {
                Display[0] = Convert.ToDouble(this.queriesTableAdapter1.DayGetSum(this.year, this.month, this.day));
                for (int i = 1; i < 6; ++i)
                {
                    Display[i] = Convert.ToDouble(this.queriesTableAdapter1.DayGetCategory(this.Category[i], this.year, this.month, this.day));
                }
            }

            return Display;
        }

        private void UpdateSummary_metchod()
        {
            this.DateUpdate_method();
            double[] Display = this.ExectuteSummaryQueries_method();
            
            this.uSum.Text = String.Format("{0:C}", Display[0]);
            this.uCat1.Text = String.Format("{0:C}", Display[1]);
            this.uCat2.Text = String.Format("{0:C}", Display[2]);
            this.uCat3.Text = String.Format("{0:C}", Display[3]);
            this.uCat4.Text = String.Format("{0:C}", Display[4]);
            this.uCat5.Text = String.Format("{0:C}", Display[5]);

            this.chart1.Series[0].Points.Clear();
            if (Display[0] != 0){
                this.chart1.Series[0].Points.AddXY(this.Category[0], Display[0]);
                this.chart1.Series[0].Points[0].Color = Color.LightSeaGreen;
            }
            for (int i = 1; i < 6; ++i)
            {
                if (Display[i] != 0) { 
                    this.chart1.Series[0].Points.AddXY(this.Category[i], Display[i]);
                }
            }

        }

        private void SalesDeleteEntry_Click(object sender, EventArgs e)
        {
            int row = Convert.ToInt32(this.dataGridView2.Rows[this.dataGridView2.CurrentRow.Index].Cells["Id"].Value);
            this.table2TableAdapter.DeleteQuery(row);
            this.databaseDataSet.AcceptChanges();
            this.query1TableAdapter.Fill(this.databaseDataSet.query1);

            this.UpdateSummary_metchod();
            this.UpdateSalesCounter_method();
        }

        private void getPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog();
            sd.DefaultExt = ".xlsx";
            sd.AddExtension = true;
            sd.Filter = "Skoroszyt programu Excel|*.xlsx";
            sd.InitialDirectory = Path.GetDirectoryName(this.ExportPath);
            sd.FileName = "Zestawienie";
           
            DialogResult resault = sd.ShowDialog();
            if(resault == DialogResult.OK) {
                this.ExportPath = sd.FileName;
                this.ExportExcel();
            }
            sd.Dispose();
        }

        private void ExportExcel()
        {
            this.DateUpdate_method();
            double[] Display = this.ExectuteSummaryQueries_method();
            var workbook = new XLWorkbook();
            
            if (ExpS2.Checked)
            {
                if (!ExpO1.Checked)
                {
                    if (this.f0.Checked) {
                        this.exp1TableAdapter.Fill(this.databaseDataSet.Exp1);
                    }
                    else if (this.f1.Checked) {
                        this.exp1TableAdapter.FillYear(this.databaseDataSet.Exp1, this.year);
                    }
                    else if (this.f2.Checked) {
                        this.exp1TableAdapter.FillMonth(this.databaseDataSet.Exp1, this.year, this.month);
                    }
                    else if (this.f3.Checked) {
                        this.exp1TableAdapter.FillDay(this.databaseDataSet.Exp1, this.year, this.month, this.day);
                    }
                        
                    var worksheet = workbook.Worksheets.Add("Zestawienie");
                    worksheet.Cell(1, 1).InsertTable(databaseDataSet.Tables["Exp1"]);
                    worksheet.Column(5).CellsUsed().Style.NumberFormat.Format = "0.00 zł";
                    worksheet.Column(6).CellsUsed().Style.NumberFormat.Format = "0.00 zł";
                    worksheet.Columns().AdjustToContents();
                }
                else
                {
                    for (int i = 1; i < 6; ++i)
                    {
                        if (!ExpO3.Checked || Display[i] != 0)
                        {
                            if (this.f0.Checked)
                            {
                                this.exp1TableAdapter.FillC(this.databaseDataSet.Exp1, this.Category[i]);
                            }
                            else if (this.f1.Checked)
                            {
                                this.exp1TableAdapter.FillYearC(this.databaseDataSet.Exp1, this.Category[i], this.year);
                            }
                            else if (this.f2.Checked)
                            {
                                this.exp1TableAdapter.FillMonthC(this.databaseDataSet.Exp1, this.Category[i], this.year, this.month);
                            }
                            else if (this.f3.Checked)
                            {
                                this.exp1TableAdapter.FillDayC(this.databaseDataSet.Exp1, this.Category[i], this.year, this.month, this.day);
                            }

                            var worksheet = workbook.Worksheets.Add(this.Category[i]);
                            worksheet.Cell(1, 1).InsertTable(databaseDataSet.Tables["Exp1"]);
                            worksheet.Column(5).CellsUsed().Style.NumberFormat.Format = "0.00 zł";
                            worksheet.Column(6).CellsUsed().Style.NumberFormat.Format = "0.00 zł";
                            worksheet.Columns().AdjustToContents();
                        }
                    }
                }

                if (ExpO2.Checked)
                {
                    var SumWorksheet = workbook.Worksheets.Add("Podsumownie");

                    DataTable table = new DataTable();
                    table.Columns.Add("Kategoria", typeof(string));
                    table.Columns.Add("Dochód", typeof(double));
                    
                    for (int i = 1; i < 6; ++i)
                    {
                        table.Rows.Add(this.Category[i], Display[i]);
                    }
                    table.Rows.Add("", null);
                    table.Rows.Add(this.Category[0], Display[0]);

                    SumWorksheet.Cell(1, 1).InsertTable(table);
                    SumWorksheet.Column(2).CellsUsed().Style.NumberFormat.Format = "0.00 zł";
                    SumWorksheet.Columns().AdjustToContents();
                }
            }
            else
            {
                this.tableTableAdapter.Fill(this.databaseDataSet.Table);
                var worksheet = workbook.Worksheets.Add("Menu");
                worksheet.Cell(1, 1).InsertTable(databaseDataSet.Tables["Table"]);
                worksheet.Columns().AdjustToContents();
            }           
            
            try {
                workbook.SaveAs(this.ExportPath);
                if(MessageBox.Show("Wygenerowano zestawienie \nCzy chcesz otworzyć?", "Excel Export", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    System.Diagnostics.Process.Start(this.ExportPath);
                }
            }
            catch {
                MessageBox.Show("Nie można wygenerować pliku! \nSprawdź czy nie jest otwarty w innej aplikacji", "Błąd eksportu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            workbook.Dispose();
        }
    }
}