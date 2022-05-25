using DiplomApp.AdminsPart;
using DiplomApp.Clasess;
using DiplomApp.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Maroquio;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace DiplomApp.zExports
{
    public partial class TeacherExport : Form
    {
        AllModel<Dogovor> dogovors = new AllModel<Dogovor>("Dogovors");
        AllModel<Student> students = new AllModel<Student>("Students");

        //private Form _requestForm;
        public TeacherExport()
        {
            InitializeComponent();
            selectFiltr.Items.Clear();
            Clear(DataFilter);
            AddOps();
            //_requestForm = requestForm;
        }
        public void Clear(DataGridView DataFilter)
        {
            while (DataFilter.Rows.Count > 1)
                for (int i = 0; i < DataFilter.Rows.Count - 1; i++)
                    DataFilter.Rows.Remove(DataFilter.Rows[i]);
        }
        public string[] SelEx =
        {
            "Excel",
            "PDF",
            "CSV",
            "WORD",
        };
        public string[] VidSort =
        {
            "",
            "Студенты",
            "Договора",
        };

        public string[] VidSortStud =
        {
            "",
            "По группам",
            "По руководителю от техникума"
        };

        public string[] VidSortDog =
        {
            "",
            "По практикам",
            "По руководителям орг."
        };


        public void AddOps()
        {
           

            selectTable.Items.Add(VidSort[0]);
            selectTable.Items.Add(VidSort[1]);
            selectTable.Items.Add(VidSort[2]);


            exportBox.Items.Add(SelEx[0]);
            exportBox.Items.Add(SelEx[1]);
            exportBox.Items.Add(SelEx[2]);
            exportBox.Items.Add(SelEx[3]);
            exportBox.SelectedIndex = 0;
        }

        public void AddOpsStud()
        {
            

            selectFiltr.Items.Add(VidSortStud[0]);
            selectFiltr.Items.Add(VidSortStud[1]);
            selectFiltr.Items.Add(VidSortStud[2]);
        }

        public void AddOpsDog()
        {
            
            selectFiltr.Items.Add(VidSortDog[0]);
            selectFiltr.Items.Add(VidSortDog[1]);
            selectFiltr.Items.Add(VidSortDog[2]);
        }

       


        //--------------
        public void ExcepExport(DataGridView dataGrid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                ws.Name = "Exported from gridview";

                ws.Rows.HorizontalAlignment = HorizontalAlignment.Center;
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value;
                    }
                }

                ws.Cells.EntireColumn.AutoFit();

                app.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CsvExport(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGrid.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGrid.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGrid.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGrid.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGrid.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        public void WordExport(DataGridView dataGrid, string filename)
        {
            if (dataGrid.Rows.Count != 0)
            {
                int RowCount = dataGrid.Rows.Count;
                int ColumnCount = dataGrid.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = dataGrid.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGrid.Columns[c].HeaderText;
                }

                //table style 
                //oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }

        public void PdfExport(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "PFDFile.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Записать данные на диск не удалось." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Данные Успешно Экспортированы!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка :" + ex.Message);
                        }
                    }
                }
            }
        }

       

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Global.userId == 0)
            {
                AdminTabControl adminTab = new AdminTabControl();
                adminTab.Show();
            }
            else
            {
                TeacherForm teacher = new TeacherForm(Global.userId);
                teacher.Show();
            }
            this.Hide();
        }


      

        private void TeacherFilterText_TextChanged(object sender, EventArgs e)
        {
            if (selectTable.SelectedIndex == 1 && selectFiltr.SelectedIndex == 1)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(TeacherFilterText.Text))
                        DataFilter.DataSource = students.Objs;
                    else
                    {

                        if (DataFilter.DataSource is DataTable)
                            (DataFilter.DataSource as DataTable)!.DefaultView.RowFilter = $"GroupName LIKE '%{TeacherFilterText.Text}%'";
                        else
                        {

                            var DT = (DataFilter.DataSource as List<Student>)!.ToDataTable();
                            DT.DefaultView.RowFilter = $"GroupName LIKE '%{TeacherFilterText.Text}%'";
                            DataFilter.DataSource = DT;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (selectTable.SelectedIndex == 1 && selectFiltr.SelectedIndex == 2)
            {
                try
                {
                    if (string.IsNullOrWhiteSpace(TeacherFilterText.Text))
                        DataFilter.DataSource = students.Objs;
                    else
                    {

                        if (DataFilter.DataSource is DataTable)
                            (DataFilter.DataSource as DataTable)!.DefaultView.RowFilter = $"TeachFio LIKE '%{TeacherFilterText.Text}%'";
                        else
                        {

                            var DT = (DataFilter.DataSource as List<Student>)!.ToDataTable();
                            DT.DefaultView.RowFilter = $"TeachFio LIKE '%{TeacherFilterText.Text}%'";
                            DataFilter.DataSource = DT;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (selectTable.SelectedIndex == 2)
            {
                switch (selectFiltr.SelectedIndex)
                {
                    case 1:
                        {
                            try
                            {
                                if (string.IsNullOrWhiteSpace(TeacherFilterText.Text))
                                    DataFilter.DataSource = dogovors.Objs;
                                else
                                {

                                    if (DataFilter.DataSource is DataTable)
                                        (DataFilter.DataSource as DataTable)!.DefaultView.RowFilter = $"PraktikName LIKE '%{TeacherFilterText.Text}%'";
                                    else
                                    {

                                        var DT = (DataFilter.DataSource as List<Dogovor>)!.ToDataTable();
                                        DT.DefaultView.RowFilter = $"PraktikName LIKE '%{TeacherFilterText.Text}%'";
                                        DataFilter.DataSource = DT;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;

                    case 2:
                        {
                            try
                            {
                                if (string.IsNullOrWhiteSpace(TeacherFilterText.Text))
                                    DataFilter.DataSource = dogovors.Objs;
                                else
                                {

                                    if (DataFilter.DataSource is DataTable)
                                        (DataFilter.DataSource as DataTable)!.DefaultView.RowFilter = $"RykovodName LIKE '%{TeacherFilterText.Text}%'";
                                    else
                                    {

                                        var DT = (DataFilter.DataSource as List<Dogovor>)!.ToDataTable();
                                        DT.DefaultView.RowFilter = $"RykovodName LIKE '%{TeacherFilterText.Text}%'";
                                        DataFilter.DataSource = DT;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        break;
                }
            }
        }

        private void selectTable_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectTable.SelectedIndex == 1)
            {
                selectFiltr.Items.Clear();
                AddOpsStud();
                DataFilter.DataSource = new SortableBindingList<Student>(students.Objs);
                DataFilter.Refresh();
                DataFilter.Columns[5].Visible = false;
                DataFilter.Columns[6].Visible = false;
                DataFilter.Columns[7].Visible = false;
                DataFilter.Columns[11].Visible = false;

                TeacherFilterText.Text = "Введите";
            }
            else if (selectTable.SelectedIndex == 2)
            {
                selectFiltr.Items.Clear();
                AddOpsDog();
                DataFilter.DataSource = new SortableBindingList<Dogovor>(dogovors.Objs);
                DataFilter.Refresh();

                DataFilter.Columns[3].Visible = false;
                DataFilter.Columns[4].Visible = false;
                DataFilter.Columns[5].Visible = false;

                TeacherFilterText.Text = "Введите";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            switch (exportBox.SelectedIndex)
            {
                case 0:
                    {
                        ExcepExport(DataFilter);
                    }
                    break;

                case 1:
                    {
                        PdfExport(DataFilter);
                    }
                    break;

                case 2:
                    {
                        CsvExport(DataFilter);
                    }
                    break;

                case 3:
                    {
                        SaveFileDialog sfd = new SaveFileDialog();

                        sfd.Filter = "Word Documents (.docx)|.docx";

                        sfd.FileName = "export.docx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            WordExport(DataFilter, sfd.FileName);
                        }
                    }
                    break;
            }
        }

        private void TeacherFilterText_Click(object sender, EventArgs e)
        {
            TeacherFilterText.Text = "";
        }
    }

    public static class ListtoDataTableConverter
    {
        public static DataTable ToDataTable<T>(this List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    values[i] = Props[i].GetValue(item, null)!;
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }
    }
}

