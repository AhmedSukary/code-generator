using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Generator
{
    public partial class CodeGenerator : Form
    {

        private List<DataTable> _DataTableList = new List<DataTable>();

        private DataTable _DataTable = new DataTable();

        public CodeGenerator()
        {
            InitializeComponent();
            _DataTable.Columns.Add("Column Name");
            _DataTable.Columns.Add("Data Type");
            _DataTable.Columns.Add("Allow Nulls");
        }

        private void ResetInputs()
        {
            textBoxColumnName.Text = "";
            comboBoxDataType.Text = "";
            checkBoxAllowNulls.Checked = true;
        }

        private void AddRowToGridTable()
        {
            DataRow dr = _DataTable.NewRow();
            dr["Column Name"] = textBoxColumnName.Text;
            dr["Data Type"] = comboBoxDataType.Text;
            dr["Allow Nulls"] = checkBoxAllowNulls.Checked;
            _DataTable.Rows.Add(dr);
            dataGridView1.DataSource = _DataTable;
        }

        private void AddDataTableToListAndPanle()
        {
            _DataTableList.Add(_DataTable);
            UserControlDataGridViewTable userControlDataGridViewTable = new UserControlDataGridViewTable(_DataTable);
            flowLayoutPanelTables.Controls.Add(userControlDataGridViewTable);
            userControlDataGridViewTable.OnGenerateCode += HandleGenerateCode;
            _DataTable = new DataTable();
            _DataTable.Columns.Add("Column Name");
            _DataTable.Columns.Add("Data Type");
            _DataTable.Columns.Add("Allow Nulls");
            dataGridView1.DataSource = _DataTable;
            textBoxTableName.Text = "";
        }

        private DataRow GetSelectedRow()
        {
            DataRow dr = _DataTable.NewRow();
            dr["Column Name"] = (string)dataGridView1.CurrentRow.Cells[0].Value;
            dr["Data Type"] = (string)dataGridView1.CurrentRow.Cells[1].Value;
            dr["Allow Nulls"] = bool.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            return dr;
        }

        private void DeleteRow(DataRow row)
        {
            for (int i = _DataTable.Rows.Count - 1; i >= 0; i--)
            {
                DataRow dr = _DataTable.Rows[i];
                if (dr["Column Name"] == row["Column Name"])
                {
                    dr.Delete();
                }
            }
            _DataTable.AcceptChanges();
        }

        private void CreateFile(string fileName, string folderPath, string code)
        {
            string path = @"" + folderPath + "\\" + fileName;
            try
            {
                using (FileStream fs = File.Create(path))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes(code);
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
                MessageBox.Show("The File Name:" + fileName + "\nThe Path:" + path + "\n\nCreated Successfully.");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void HandleGenerateCode(object sender,DataTable dt)
        {
            _DataTable = dt;
            if (textBoxExistDataBaseName.Text != "")
            {
                labelTableQurey.Text = ClassGenerateQureys.UseExistDataBase(textBoxExistDataBaseName.Text);
                labelStoredProceduresQurey.Text = ClassGenerateQureys.UseExistDataBase(textBoxExistDataBaseName.Text);
                labelTableQurey.Text += ClassGenerateQureys.TableQurey(dt);
                labelStoredProceduresQurey.Text += ClassGenerateQureys.StoredProceduresQurey(dt);
                labelDataAccessScript.Text = ClassGenerateDataAccessScript.DataAccessScript(dt);
                labelBusinessLogocScript.Text = ClassGenerateBusinessLogicScript.BusinessLogicScript(dt);
                return;
            }

            if (textBoxDataBaseName.Text != "")
            {
                labelTableQurey.Text = ClassGenerateQureys.CreateNewDataBase(textBoxDataBaseName.Text);
                labelStoredProceduresQurey.Text = ClassGenerateQureys.UseExistDataBase(textBoxDataBaseName.Text);
                labelTableQurey.Text += ClassGenerateQureys.TableQurey(dt);
                labelStoredProceduresQurey.Text += ClassGenerateQureys.StoredProceduresQurey(dt);
                labelDataAccessScript.Text = ClassGenerateDataAccessScript.DataAccessScript(dt);
                labelBusinessLogocScript.Text = ClassGenerateBusinessLogicScript.BusinessLogicScript(dt);
                return;
            }
            else
            {
                labelTableQurey.Text = ClassGenerateQureys.TableQurey(dt);
                labelStoredProceduresQurey.Text = ClassGenerateQureys.StoredProceduresQurey(dt);
                labelDataAccessScript.Text = ClassGenerateDataAccessScript.DataAccessScript(dt);
                labelBusinessLogocScript.Text = ClassGenerateBusinessLogicScript.BusinessLogicScript(dt);
            }
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            textBoxColumnName_Validated(sender, e);
            comboBoxDataType_Validated(sender, e);

            if (textBoxColumnName.Text == "" || comboBoxDataType.Text == "")
                return;

            AddRowToGridTable();
            ResetInputs();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow SelectedRow = GetSelectedRow();
            textBoxColumnName.Text = SelectedRow["Column Name"].ToString();
            comboBoxDataType.Text = SelectedRow["Data Type"].ToString();
            checkBoxAllowNulls.Checked = bool.Parse(SelectedRow["Allow Nulls"].ToString());
            DeleteRow(SelectedRow);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRow SelectedRow = GetSelectedRow();
            if (MessageBox.Show("Are you sure you want to delete this row?[" + SelectedRow["Column Name"] + ", " + SelectedRow["Data Type"] + ", " + SelectedRow["Allow Nulls"] + "]", "Confirm Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                DeleteRow(SelectedRow);
        }

        private void buttonChooseTheFolderDirectory_Click(object sender, EventArgs e)
        {
            textBoxFloderDirectory.Text = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                textBoxFloderDirectory.Text = folderBrowserDialog1.SelectedPath;

            textBoxFloderDirectory_Validated(sender, e);
        }

        private void buttonCopyQurey_Click(object sender, EventArgs e) { Clipboard.SetText(labelTableQurey.Text); }

        private void buttonCopyStoredProceduresQurey_Click(object sender, EventArgs e) { Clipboard.SetText(labelStoredProceduresQurey.Text); }

        private void buttonCopyDataAccessScript_Click(object sender, EventArgs e) { Clipboard.SetText(labelDataAccessScript.Text); }

        private void buttonCopyBusinessLogocScript_Click(object sender, EventArgs e) { Clipboard.SetText(labelBusinessLogocScript.Text); }

        private void textBoxColumnName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxColumnName.Text))
            {
                e.Cancel = true;
                textBoxColumnName.Focus();
                errorProvider1.SetError(textBoxColumnName, "Coulmn name is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBoxColumnName, "");
            }
        }

        private void comboBoxDataType_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxDataType.Text))
            {
                e.Cancel = true;
                comboBoxDataType.Focus();
                errorProvider1.SetError(comboBoxDataType, "Coulmn type is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBoxDataType, "");
            }
        }

        private void textBoxTableName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTableName.Text))
            {
                textBoxTableName.Focus();
                errorProvider1.SetError(textBoxTableName, "Table name is Required");
            }
            else
                errorProvider1.SetError(textBoxTableName, "");
        }

        private void textBoxFloderDirectory_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFloderDirectory.Text))
            {
                buttonChooseTheFolderDirectory.Focus();
                errorProvider1.SetError(textBoxFloderDirectory, "Floder Directory is Required");
            }
            else
            {
                errorProvider1.SetError(textBoxFloderDirectory, "");

            }

        }

        private void textBoxColumnName_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxColumnName.Text))
            {
                textBoxColumnName.Focus();
                errorProvider1.SetError(textBoxColumnName, "Coulmn name is Required");
            }
            else
                errorProvider1.SetError(textBoxColumnName, "");
        }

        private void comboBoxDataType_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(comboBoxDataType.Text))
            {
                comboBoxDataType.Focus();
                errorProvider1.SetError(comboBoxDataType, "Coulmn type is Required");
            }
            else
                errorProvider1.SetError(comboBoxDataType, "");
        }

        private void buttonAddTable_Click(object sender, EventArgs e)
        {
            textBoxTableName_Validated(sender, e);
            _DataTable.TableName = textBoxTableName.Text;
            AddDataTableToListAndPanle();
        }

        private void buttonSaveQureysAndScriptsToProjectFolder_Click(object sender, EventArgs e)
        {
            CreateFile(_DataTable.TableName + "DataTableQurye.sql", textBoxFloderDirectory.Text, labelTableQurey.Text);
            CreateFile(_DataTable.TableName + "StoredProceduresQurye.sql", textBoxFloderDirectory.Text, labelStoredProceduresQurey.Text);
            CreateFile("Class" + _DataTable.TableName + "Data.cs", textBoxFloderDirectory.Text, labelDataAccessScript.Text);
            CreateFile("Class" + _DataTable.TableName + ".cs", textBoxFloderDirectory.Text, labelBusinessLogocScript.Text);
        }

        private void buttonNextTabToTablesTab_Click(object sender, EventArgs e)
        {
            tabControlParent.SelectedIndex = 1;
            textBoxFloderDirectory_Validated(sender, e);

            if (string.IsNullOrWhiteSpace(textBoxDataBaseName.Text))
            {

                if (!string.IsNullOrWhiteSpace(textBoxExistDataBaseName.Text))
                {
                    return;
                }
                errorProvider1.SetError(textBoxDataBaseName, "Data Base Name Required");
            }
            buttonSaveQureysAndScriptsToProjectFolder.Enabled = true;
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            tabControlParent.SelectedIndex = 1;
            buttonSaveQureysAndScriptsToProjectFolder.Enabled = true;
        }

        private void buttonNewProject_Click(object sender, EventArgs e)
        {
            textBoxFloderDirectory.Enabled = true;
            textBoxDataBaseName.Enabled = true;
            textBoxExistDataBaseName.Enabled = true;
            buttonChooseTheFolderDirectory.Enabled = true;
            buttonNextTabToTablesTab.Enabled = true;
            textBoxFloderDirectory.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/AhmedSukary");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/ahmed-sukary-51267b322/");
        }
    }
}
