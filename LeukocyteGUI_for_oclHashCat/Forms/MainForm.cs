using LeukocyteGUI_for_oclHashCat.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashCat
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DataManager.DataLoaded += DataManager_DataLoaded;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            new TaskEditorForm().ShowDialog();
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataManager.SaveAllData();
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            DataManager.LoadAllAvailableData();
        }

        private void DataManager_DataLoaded(DataLoadedSavedEventArgs e)
        {

        }
    }
}
