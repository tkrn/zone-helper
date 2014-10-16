using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ZoneHelper
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = "Zone Helper - v" + Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0, 5);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtHostPort.Text = "";
            txtArrayPort.Text = "";
            txtVSANNumber.Text = "";
            txtZonesetName.Text = "";
            txtOutput.Text = "";
            lstHostPorts.Items.Clear();
            lstArrayPorts.Items.Clear();
        }

        private void btnHostPortAdd_Click(object sender, EventArgs e)
        {
            if (txtHostPort.Text != "")
            {
                lstHostPorts.Items.Add(txtHostPort.Text);
                txtHostPort.Text = "";
                txtHostPort.Select();
            }
        }

        private void btnArrayPortAdd_Click(object sender, EventArgs e)
        {
            if (txtArrayPort.Text != "")
            {
                lstArrayPorts.Items.Add(txtArrayPort.Text);
                txtArrayPort.Text = "";
                txtArrayPort.Select();
            }
        }

        private void btnHostPortRemove_Click(object sender, EventArgs e)
        {
            lstHostPorts.Items.Remove(lstHostPorts.SelectedItem);
            txtHostPort.Select();
        }

        private void btnArrayPortRemove_Click(object sender, EventArgs e)
        {
            lstArrayPorts.Items.Remove(lstArrayPorts.SelectedItem);
            txtArrayPort.Select();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(txtOutput.Text);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            string _delimiter = "_";
            string _carriagereturn = "\r\n";
            string _membertype = "device-alias";

            if (rbHypen.Checked)
            {
                _delimiter = "-";
            }

            if (rbFCAlias.Checked)
            {
                _membertype = "fcalias";
            }
            
            if (!txtVSANNumber.Text.Equals(String.Empty) & !txtZonesetName.Text.Equals(String.Empty)) 
            {
                txtOutput.Text += "zoneset name " + txtZonesetName.Text + " vsan " + txtVSANNumber.Text;
                txtOutput.AppendText(_carriagereturn);
            }

            for (int x = 0; x < lstHostPorts.Items.Count; x++)
            {
                for (int xx = 0; xx < lstArrayPorts.Items.Count; xx++)
                {
                    txtOutput.Text += "zone name " + lstHostPorts.Items[x] + _delimiter + lstArrayPorts.Items[xx];
                        txtOutput.AppendText(_carriagereturn);
                    txtOutput.Text += "member " + _membertype + " " + lstHostPorts.Items[x];
                        txtOutput.AppendText(_carriagereturn);
                    txtOutput.Text += "member " + _membertype + " " + lstArrayPorts.Items[xx];
                        txtOutput.AppendText(_carriagereturn);
                    txtOutput.Text += "exit";
                        txtOutput.AppendText(_carriagereturn);
                }
            }

            if (!txtVSANNumber.Text.Equals(String.Empty) & !txtZonesetName.Text.Equals(String.Empty))
            {
                txtOutput.Text += "zoneset activate name " + txtZonesetName.Text + " vsan " + txtVSANNumber.Text;
            }
        }

        private void btnHostsLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Load Host List";

            using (openFileDialog)
            {
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
                    {
                        using (StreamReader _stRead = new StreamReader(openFileDialog.FileName))
                        {
                            lstArrayPorts.Items.Clear();

                            while (!_stRead.EndOfStream)
                            {
                                lstHostPorts.Items.Add(_stRead.ReadLine());
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("File failed to load!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnArrayLoad_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Load Array List";

            using (openFileDialog)
            {
                try
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
                    {
                        using (StreamReader _stRead = new StreamReader(openFileDialog.FileName))
                        {
                            lstArrayPorts.Items.Clear();

                            while (!_stRead.EndOfStream)
                            {
                                lstArrayPorts.Items.Add(_stRead.ReadLine());
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("File failed to load!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout _frmAbout = new frmAbout();
            _frmAbout.Show();
        }

        private void btnSaveOutput_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save Output";

            if (!txtOutput.Text.Equals(String.Empty))
            {
                using (saveFileDialog)
                {
                    try
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                        {
                            txtOutput.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("File failed to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnHostsSave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save Host List";

            if (lstHostPorts.Items.Count > 0)
            {
                using (saveFileDialog)
                {
                    try
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                        {
                            using (StreamWriter _stWrite = new StreamWriter(saveFileDialog.FileName))
                            {
                                for (int x = 0; x < lstHostPorts.Items.Count; x++)
                                {
                                    if ((lstHostPorts.Items.Count - 1) != x)
                                    {
                                        _stWrite.WriteLine(lstHostPorts.Items[x]);
                                    }
                                    else
                                    {
                                        _stWrite.Write(lstHostPorts.Items[x]);
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("File failed to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnArraySave_Click(object sender, EventArgs e)
        {
            saveFileDialog.Title = "Save Array List";

            if (lstArrayPorts.Items.Count > 0)
            {
                using (saveFileDialog)
                {
                    try
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName.Length > 0)
                        {
                            using (StreamWriter _stWrite = new StreamWriter(saveFileDialog.FileName))
                            {
                                for (int x = 0; x < lstArrayPorts.Items.Count; x++)
                                {
                                    if ((lstArrayPorts.Items.Count - 1) != x)
                                    {
                                        _stWrite.WriteLine(lstArrayPorts.Items[x]);
                                    }
                                    else
                                    {
                                        _stWrite.Write(lstArrayPorts.Items[x]);
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show("File failed to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}