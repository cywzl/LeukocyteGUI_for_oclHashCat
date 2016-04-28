using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashCat.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void VisualizeCrackSource(ICrackDataSource crackSource, int listViewId)
        {
            lvPredefined.Items.Add(
                new ListViewItem(
                    new string[]
                    {
                        listViewId.ToString(),
                        crackSource.GetType().ToString(),
                        crackSource.Name,
                        crackSource.Description
                    }
                )
            );
        }
        private void VisualizeCrackSource(ICrackDataSource crackSource)
        {
            VisualizeCrackSource(crackSource, lvPredefined.Items.Count - 1);
        }

        private void SettingsForm_Shown(object sender, EventArgs e)
        {
            foreach (var dictionary in DataManager.Dictionaries)
            {
                VisualizeCrackSource(dictionary);
            }
            foreach (var mask in DataManager.Masks)
            {
                VisualizeCrackSource(mask);
            }
        }
    }
}
