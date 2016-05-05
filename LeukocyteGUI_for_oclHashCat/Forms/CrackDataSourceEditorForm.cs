using LeukocyteCore_for_oclHashcat;
using LeukocyteCore_for_oclHashcat.Classes;
using LeukocyteCore_for_oclHashcat.Interfaces;
using System;
using System.Windows.Forms;

namespace LeukocyteGUI_for_oclHashcat.Forms
{
    public partial class CrackDataSourceEditorForm : Form
    {
        bool editMode = false;
        DataTypes sourceType = DataTypes.Masks;
        ICrackDataSource source;

        public DataTypes SourceType
        {
            get
            {
                return sourceType;
            }
        }
        public ICrackDataSource Source
        {
            get
            {
                return source;
            }
        }

        public CrackDataSourceEditorForm()
        {
            InitializeComponent();
        }
        public CrackDataSourceEditorForm(ICrackDataSource source) : this()
        {
            editMode = true;

            gbCrackDataSourceType.Enabled = false;

            tbName.Text = source.Name;
            tbDescription.Text = source.Description;
            cmbLeftSource.Text = source.Source;

            if (source is ICombinedCrackData)
            {
                cmbRightSource.Text = (source as ICombinedCrackData).AdditionalSource;

                if (source is Combination)
                {
                    rbCombination.Checked = true;
                    sourceType = DataTypes.Combinations;
                }
                else if (source is HybridDictMask)
                {
                    FillMaskData((source as HybridDictMask).AdditionalSourceBase);
                    rbDictMask.Checked = true;
                    sourceType = DataTypes.HybridDictMask;
                }
                else if (source is HybridMaskDict)
                {
                    FillMaskData((source as HybridMaskDict).SourceBase);
                    rbMaskDict.Checked = true;
                    sourceType = DataTypes.HybridMaskDict;
                }
            }
            else if (source is Mask)
            {
                FillMaskData(source as Mask);
                sourceType = DataTypes.Masks;
            }
            else
            {
                sourceType = DataTypes.Dictionaries;
            }

            this.source = source;
        }

        private void FillMaskData(Mask mask)
        {
            cbIncrementMode.Checked = mask.IncrementSettings.Increment;
            nudIncrementMin.Value = mask.IncrementSettings.IncrementMin;
            nudIncrementMax.Value = mask.IncrementSettings.IncrementMax;
            cbCharset1.Checked = mask.CharsetsSettings.UseCharset1;
            cbCharset2.Checked = mask.CharsetsSettings.UseCharset2;
            cbCharset3.Checked = mask.CharsetsSettings.UseCharset3;
            cbCharset4.Checked = mask.CharsetsSettings.UseCharset4;
            cmbCharset1.Text = mask.CharsetsSettings.Charset1;
            cmbCharset2.Text = mask.CharsetsSettings.Charset2;
            cmbCharset3.Text = mask.CharsetsSettings.Charset3;
            cmbCharset4.Text = mask.CharsetsSettings.Charset4;
        }
        private Mask GetMaskFromForm()
        {
            Mask mask = new Mask()
            {
                CharsetsSettings = new CustomCharsetsSettings()
                {
                    Charset1 = cmbCharset1.Text,
                    Charset2 = cmbCharset2.Text,
                    Charset3 = cmbCharset3.Text,
                    Charset4 = cmbCharset4.Text,
                    UseCharset1 = cbCharset1.Checked,
                    UseCharset2 = cbCharset2.Checked,
                    UseCharset3 = cbCharset3.Checked,
                    UseCharset4 = cbCharset4.Checked
                },
                IncrementSettings = new IncrementSettings()
                {
                    Increment = cbIncrementMode.Checked,
                    IncrementMin = (int)nudIncrementMin.Value,
                    IncrementMax = (int)nudIncrementMax.Value
                }
            };

            return mask;
        }
        private void UpdateSource()
        {
            switch (sourceType)
            {
                case DataTypes.Masks:
                    {
                        Mask maskData = GetMaskFromForm();

                        if (editMode)
                        {
                            Mask mask = (Mask)source;
                            mask.IncrementSettings = maskData.IncrementSettings;
                            mask.CharsetsSettings = maskData.CharsetsSettings;

                        }
                        else
                        {
                            source = maskData;
                        }

                        source.Source = cmbLeftSource.Text;

                        break;
                    }

                case DataTypes.Dictionaries:
                    {
                        if (editMode)
                        {
                            Dictionary dictionary = (Dictionary)source;
                            dictionary.Source = cmbLeftSource.Text;
                        }
                        else
                        {
                            source = new Dictionary(cmbLeftSource.Text, "");
                        }

                        break;
                    }

                case DataTypes.Combinations:
                    {
                        Dictionary leftDictionary = new Dictionary(cmbLeftSource.Text, "");
                        Dictionary rightDictionary = new Dictionary(cmbRightSource.Text, "");

                        if (editMode)
                        {
                            Combination combination = (Combination)source;
                            combination.SourceBase = leftDictionary;
                            combination.AdditionalSourceBase = rightDictionary;
                        }
                        else
                        {
                            source = new Combination(leftDictionary, rightDictionary);
                        }

                        break;
                    }

                case DataTypes.HybridDictMask:
                    {
                        Dictionary hybridDictLeft = new Dictionary(cmbLeftSource.Text, "");
                        Mask hybridMaskRight = new Mask(cmbRightSource.Text);

                        if (editMode)
                        {
                            HybridDictMask hybridDictMask = (HybridDictMask)source;
                            hybridDictMask.SourceBase = hybridDictLeft;
                            hybridDictMask.AdditionalSourceBase = hybridMaskRight;
                        }
                        else
                        {
                            source = new HybridDictMask(hybridDictLeft, hybridMaskRight);
                        }

                        break;
                    }

                case DataTypes.HybridMaskDict:
                    {
                        Mask hybridMaskLeft = new Mask(cmbLeftSource.Text);
                        Dictionary hybridDictRight = new Dictionary(cmbRightSource.Text, "");

                        if (editMode)
                        {
                            HybridMaskDict hybridMaskDict = (HybridMaskDict)source;
                            hybridMaskDict.SourceBase = hybridMaskLeft;
                            hybridMaskDict.AdditionalSourceBase = hybridDictRight;
                        }
                        else
                        {
                            source = new HybridMaskDict(hybridMaskLeft, hybridDictRight);
                        }

                        break;
                    }
            }

            source.Name = tbName.Text;
            source.Description = tbDescription.Text;
        }

        private void rbCrackSource_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "rbDictionary":
                        gbIncrementMode.Enabled = false;
                        gbCharsets.Enabled = false;
                        lblRightSource.Enabled = false;
                        cmbRightSource.Enabled = false;
                        lblLeftSource.Text = "Dictionary:";
                        sourceType = DataTypes.Dictionaries;

                        break;

                    case "rbCombination":
                        gbIncrementMode.Enabled = false;
                        gbCharsets.Enabled = false;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Dictionary:";
                        lblRightSource.Text = "Right Dictionary:";
                        sourceType = DataTypes.Combinations;

                        break;

                    case "rbMask":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = false;
                        cmbRightSource.Enabled = false;
                        lblLeftSource.Text = "Mask:";
                        sourceType = DataTypes.Masks;

                        break;

                    case "rbDictMask":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Dictionary:";
                        lblRightSource.Text = "Right Mask:";
                        sourceType = DataTypes.HybridDictMask;

                        break;

                    case "rbMaskDict":
                        gbIncrementMode.Enabled = true;
                        gbCharsets.Enabled = true;
                        lblRightSource.Enabled = true;
                        cmbRightSource.Enabled = true;
                        lblLeftSource.Text = "Left Mask:";
                        lblRightSource.Text = "Right Dictionary:";
                        sourceType = DataTypes.HybridMaskDict;

                        break;
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            UpdateSource();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
