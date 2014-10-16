namespace ZoneHelper
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpHostPorts = new System.Windows.Forms.GroupBox();
            this.btnHostsSave = new System.Windows.Forms.Button();
            this.btnHostsLoad = new System.Windows.Forms.Button();
            this.lstHostPorts = new System.Windows.Forms.ListBox();
            this.btnHostPortRemove = new System.Windows.Forms.Button();
            this.btnHostPortAdd = new System.Windows.Forms.Button();
            this.txtHostPort = new System.Windows.Forms.TextBox();
            this.lblHostPort = new System.Windows.Forms.Label();
            this.grpArrayPorts = new System.Windows.Forms.GroupBox();
            this.btnArraySave = new System.Windows.Forms.Button();
            this.btnArrayLoad = new System.Windows.Forms.Button();
            this.lstArrayPorts = new System.Windows.Forms.ListBox();
            this.btnArrayPortRemove = new System.Windows.Forms.Button();
            this.lblArrayPort = new System.Windows.Forms.Label();
            this.btnArrayPortAdd = new System.Windows.Forms.Button();
            this.txtArrayPort = new System.Windows.Forms.TextBox();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.lblZonesetName = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.txtZonesetName = new System.Windows.Forms.TextBox();
            this.txtVSANNumber = new System.Windows.Forms.TextBox();
            this.lblVSANNumber = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnSaveOutput = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearOutput = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.grpDelimiter = new System.Windows.Forms.GroupBox();
            this.rbUnderscore = new System.Windows.Forms.RadioButton();
            this.rbHypen = new System.Windows.Forms.RadioButton();
            this.grpMemberType = new System.Windows.Forms.GroupBox();
            this.rbDeviceAlias = new System.Windows.Forms.RadioButton();
            this.rbFCAlias = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.grpHostPorts.SuspendLayout();
            this.grpArrayPorts.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpDelimiter.SuspendLayout();
            this.grpMemberType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpHostPorts
            // 
            this.grpHostPorts.Controls.Add(this.btnHostsSave);
            this.grpHostPorts.Controls.Add(this.btnHostsLoad);
            this.grpHostPorts.Controls.Add(this.lstHostPorts);
            this.grpHostPorts.Controls.Add(this.btnHostPortRemove);
            this.grpHostPorts.Controls.Add(this.btnHostPortAdd);
            this.grpHostPorts.Controls.Add(this.txtHostPort);
            this.grpHostPorts.Controls.Add(this.lblHostPort);
            this.grpHostPorts.Location = new System.Drawing.Point(8, 8);
            this.grpHostPorts.Name = "grpHostPorts";
            this.grpHostPorts.Size = new System.Drawing.Size(385, 163);
            this.grpHostPorts.TabIndex = 0;
            this.grpHostPorts.TabStop = false;
            // 
            // btnHostsSave
            // 
            this.btnHostsSave.Location = new System.Drawing.Point(316, 15);
            this.btnHostsSave.Name = "btnHostsSave";
            this.btnHostsSave.Size = new System.Drawing.Size(26, 23);
            this.btnHostsSave.TabIndex = 6;
            this.btnHostsSave.Text = "S";
            this.btnHostsSave.UseVisualStyleBackColor = true;
            this.btnHostsSave.Click += new System.EventHandler(this.btnHostsSave_Click);
            // 
            // btnHostsLoad
            // 
            this.btnHostsLoad.Location = new System.Drawing.Point(348, 15);
            this.btnHostsLoad.Name = "btnHostsLoad";
            this.btnHostsLoad.Size = new System.Drawing.Size(26, 23);
            this.btnHostsLoad.TabIndex = 4;
            this.btnHostsLoad.Text = "L";
            this.btnHostsLoad.UseVisualStyleBackColor = true;
            this.btnHostsLoad.Click += new System.EventHandler(this.btnHostsLoad_Click);
            // 
            // lstHostPorts
            // 
            this.lstHostPorts.FormattingEnabled = true;
            this.lstHostPorts.Location = new System.Drawing.Point(10, 43);
            this.lstHostPorts.Name = "lstHostPorts";
            this.lstHostPorts.Size = new System.Drawing.Size(364, 108);
            this.lstHostPorts.TabIndex = 5;
            // 
            // btnHostPortRemove
            // 
            this.btnHostPortRemove.Location = new System.Drawing.Point(284, 15);
            this.btnHostPortRemove.Name = "btnHostPortRemove";
            this.btnHostPortRemove.Size = new System.Drawing.Size(26, 23);
            this.btnHostPortRemove.TabIndex = 3;
            this.btnHostPortRemove.Text = "-";
            this.btnHostPortRemove.UseVisualStyleBackColor = true;
            this.btnHostPortRemove.Click += new System.EventHandler(this.btnHostPortRemove_Click);
            // 
            // btnHostPortAdd
            // 
            this.btnHostPortAdd.Location = new System.Drawing.Point(252, 15);
            this.btnHostPortAdd.Name = "btnHostPortAdd";
            this.btnHostPortAdd.Size = new System.Drawing.Size(26, 23);
            this.btnHostPortAdd.TabIndex = 2;
            this.btnHostPortAdd.Text = "+";
            this.btnHostPortAdd.UseVisualStyleBackColor = true;
            this.btnHostPortAdd.Click += new System.EventHandler(this.btnHostPortAdd_Click);
            // 
            // txtHostPort
            // 
            this.txtHostPort.Location = new System.Drawing.Point(67, 17);
            this.txtHostPort.MaxLength = 64;
            this.txtHostPort.Name = "txtHostPort";
            this.txtHostPort.Size = new System.Drawing.Size(179, 20);
            this.txtHostPort.TabIndex = 1;
            // 
            // lblHostPort
            // 
            this.lblHostPort.AutoSize = true;
            this.lblHostPort.Location = new System.Drawing.Point(7, 20);
            this.lblHostPort.Name = "lblHostPort";
            this.lblHostPort.Size = new System.Drawing.Size(54, 13);
            this.lblHostPort.TabIndex = 0;
            this.lblHostPort.Text = "Host Port:";
            // 
            // grpArrayPorts
            // 
            this.grpArrayPorts.Controls.Add(this.btnArraySave);
            this.grpArrayPorts.Controls.Add(this.btnArrayLoad);
            this.grpArrayPorts.Controls.Add(this.lstArrayPorts);
            this.grpArrayPorts.Controls.Add(this.btnArrayPortRemove);
            this.grpArrayPorts.Controls.Add(this.lblArrayPort);
            this.grpArrayPorts.Controls.Add(this.btnArrayPortAdd);
            this.grpArrayPorts.Controls.Add(this.txtArrayPort);
            this.grpArrayPorts.Location = new System.Drawing.Point(399, 7);
            this.grpArrayPorts.Name = "grpArrayPorts";
            this.grpArrayPorts.Size = new System.Drawing.Size(376, 164);
            this.grpArrayPorts.TabIndex = 0;
            this.grpArrayPorts.TabStop = false;
            // 
            // btnArraySave
            // 
            this.btnArraySave.Location = new System.Drawing.Point(307, 16);
            this.btnArraySave.Name = "btnArraySave";
            this.btnArraySave.Size = new System.Drawing.Size(26, 23);
            this.btnArraySave.TabIndex = 11;
            this.btnArraySave.Text = "S";
            this.btnArraySave.UseVisualStyleBackColor = true;
            this.btnArraySave.Click += new System.EventHandler(this.btnArraySave_Click);
            // 
            // btnArrayLoad
            // 
            this.btnArrayLoad.Location = new System.Drawing.Point(339, 16);
            this.btnArrayLoad.Name = "btnArrayLoad";
            this.btnArrayLoad.Size = new System.Drawing.Size(26, 23);
            this.btnArrayLoad.TabIndex = 9;
            this.btnArrayLoad.Text = "L";
            this.btnArrayLoad.UseVisualStyleBackColor = true;
            this.btnArrayLoad.Click += new System.EventHandler(this.btnArrayLoad_Click);
            // 
            // lstArrayPorts
            // 
            this.lstArrayPorts.FormattingEnabled = true;
            this.lstArrayPorts.Location = new System.Drawing.Point(9, 44);
            this.lstArrayPorts.Name = "lstArrayPorts";
            this.lstArrayPorts.Size = new System.Drawing.Size(356, 108);
            this.lstArrayPorts.TabIndex = 10;
            // 
            // btnArrayPortRemove
            // 
            this.btnArrayPortRemove.Location = new System.Drawing.Point(275, 16);
            this.btnArrayPortRemove.Name = "btnArrayPortRemove";
            this.btnArrayPortRemove.Size = new System.Drawing.Size(26, 23);
            this.btnArrayPortRemove.TabIndex = 8;
            this.btnArrayPortRemove.Text = "-";
            this.btnArrayPortRemove.UseVisualStyleBackColor = true;
            this.btnArrayPortRemove.Click += new System.EventHandler(this.btnArrayPortRemove_Click);
            // 
            // lblArrayPort
            // 
            this.lblArrayPort.AutoSize = true;
            this.lblArrayPort.Location = new System.Drawing.Point(6, 21);
            this.lblArrayPort.Name = "lblArrayPort";
            this.lblArrayPort.Size = new System.Drawing.Size(56, 13);
            this.lblArrayPort.TabIndex = 0;
            this.lblArrayPort.Text = "Array Port:";
            // 
            // btnArrayPortAdd
            // 
            this.btnArrayPortAdd.Location = new System.Drawing.Point(243, 16);
            this.btnArrayPortAdd.Name = "btnArrayPortAdd";
            this.btnArrayPortAdd.Size = new System.Drawing.Size(26, 23);
            this.btnArrayPortAdd.TabIndex = 7;
            this.btnArrayPortAdd.Text = "+";
            this.btnArrayPortAdd.UseVisualStyleBackColor = true;
            this.btnArrayPortAdd.Click += new System.EventHandler(this.btnArrayPortAdd_Click);
            // 
            // txtArrayPort
            // 
            this.txtArrayPort.Location = new System.Drawing.Point(68, 18);
            this.txtArrayPort.MaxLength = 64;
            this.txtArrayPort.Name = "txtArrayPort";
            this.txtArrayPort.Size = new System.Drawing.Size(169, 20);
            this.txtArrayPort.TabIndex = 6;
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.lblZonesetName);
            this.grpOptions.Controls.Add(this.btnAbout);
            this.grpOptions.Controls.Add(this.txtZonesetName);
            this.grpOptions.Controls.Add(this.txtVSANNumber);
            this.grpOptions.Controls.Add(this.lblVSANNumber);
            this.grpOptions.Location = new System.Drawing.Point(8, 178);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(218, 81);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // lblZonesetName
            // 
            this.lblZonesetName.AutoSize = true;
            this.lblZonesetName.Location = new System.Drawing.Point(15, 51);
            this.lblZonesetName.Name = "lblZonesetName";
            this.lblZonesetName.Size = new System.Drawing.Size(49, 13);
            this.lblZonesetName.TabIndex = 0;
            this.lblZonesetName.Text = "Zoneset:";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(128, 22);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(76, 20);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtZonesetName
            // 
            this.txtZonesetName.Location = new System.Drawing.Point(67, 48);
            this.txtZonesetName.MaxLength = 64;
            this.txtZonesetName.Name = "txtZonesetName";
            this.txtZonesetName.Size = new System.Drawing.Size(137, 20);
            this.txtZonesetName.TabIndex = 12;
            // 
            // txtVSANNumber
            // 
            this.txtVSANNumber.Location = new System.Drawing.Point(67, 22);
            this.txtVSANNumber.MaxLength = 5;
            this.txtVSANNumber.Name = "txtVSANNumber";
            this.txtVSANNumber.Size = new System.Drawing.Size(55, 20);
            this.txtVSANNumber.TabIndex = 11;
            // 
            // lblVSANNumber
            // 
            this.lblVSANNumber.AutoSize = true;
            this.lblVSANNumber.Location = new System.Drawing.Point(18, 27);
            this.lblVSANNumber.Name = "lblVSANNumber";
            this.lblVSANNumber.Size = new System.Drawing.Size(46, 13);
            this.lblVSANNumber.TabIndex = 0;
            this.lblVSANNumber.Text = "VSAN #";
            // 
            // grpActions
            // 
            this.grpActions.Controls.Add(this.btnSaveOutput);
            this.grpActions.Controls.Add(this.btnClearAll);
            this.grpActions.Controls.Add(this.btnClearOutput);
            this.grpActions.Controls.Add(this.btnCopy);
            this.grpActions.Controls.Add(this.btnGenerate);
            this.grpActions.Location = new System.Drawing.Point(477, 178);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(299, 81);
            this.grpActions.TabIndex = 3;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Actions";
            // 
            // btnSaveOutput
            // 
            this.btnSaveOutput.Location = new System.Drawing.Point(105, 19);
            this.btnSaveOutput.Name = "btnSaveOutput";
            this.btnSaveOutput.Size = new System.Drawing.Size(86, 25);
            this.btnSaveOutput.TabIndex = 7;
            this.btnSaveOutput.Text = "Save Output";
            this.btnSaveOutput.UseVisualStyleBackColor = true;
            this.btnSaveOutput.Click += new System.EventHandler(this.btnSaveOutput_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(13, 19);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(86, 25);
            this.btnClearAll.TabIndex = 3;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnClearOutput
            // 
            this.btnClearOutput.Location = new System.Drawing.Point(13, 49);
            this.btnClearOutput.Name = "btnClearOutput";
            this.btnClearOutput.Size = new System.Drawing.Size(86, 25);
            this.btnClearOutput.TabIndex = 2;
            this.btnClearOutput.Text = "Clear Output";
            this.btnClearOutput.UseVisualStyleBackColor = true;
            this.btnClearOutput.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(105, 49);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(86, 25);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(197, 19);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(90, 55);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtOutput.Location = new System.Drawing.Point(8, 265);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(767, 289);
            this.txtOutput.TabIndex = 4;
            this.txtOutput.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt files|*.txt|All files|*.*";
            // 
            // grpDelimiter
            // 
            this.grpDelimiter.Controls.Add(this.rbUnderscore);
            this.grpDelimiter.Controls.Add(this.rbHypen);
            this.grpDelimiter.Location = new System.Drawing.Point(356, 178);
            this.grpDelimiter.Name = "grpDelimiter";
            this.grpDelimiter.Size = new System.Drawing.Size(115, 81);
            this.grpDelimiter.TabIndex = 5;
            this.grpDelimiter.TabStop = false;
            this.grpDelimiter.Text = "Delimiter";
            // 
            // rbUnderscore
            // 
            this.rbUnderscore.AutoSize = true;
            this.rbUnderscore.Checked = true;
            this.rbUnderscore.Location = new System.Drawing.Point(18, 49);
            this.rbUnderscore.Name = "rbUnderscore";
            this.rbUnderscore.Size = new System.Drawing.Size(89, 17);
            this.rbUnderscore.TabIndex = 9;
            this.rbUnderscore.TabStop = true;
            this.rbUnderscore.Text = "Underscore _";
            this.rbUnderscore.UseVisualStyleBackColor = true;
            // 
            // rbHypen
            // 
            this.rbHypen.AutoSize = true;
            this.rbHypen.Location = new System.Drawing.Point(18, 25);
            this.rbHypen.Name = "rbHypen";
            this.rbHypen.Size = new System.Drawing.Size(62, 17);
            this.rbHypen.TabIndex = 8;
            this.rbHypen.Text = "Hypen -";
            this.rbHypen.UseVisualStyleBackColor = true;
            // 
            // grpMemberType
            // 
            this.grpMemberType.Controls.Add(this.rbDeviceAlias);
            this.grpMemberType.Controls.Add(this.rbFCAlias);
            this.grpMemberType.Location = new System.Drawing.Point(234, 178);
            this.grpMemberType.Name = "grpMemberType";
            this.grpMemberType.Size = new System.Drawing.Size(116, 81);
            this.grpMemberType.TabIndex = 6;
            this.grpMemberType.TabStop = false;
            this.grpMemberType.Text = "Member Type";
            // 
            // rbDeviceAlias
            // 
            this.rbDeviceAlias.AutoSize = true;
            this.rbDeviceAlias.Checked = true;
            this.rbDeviceAlias.Location = new System.Drawing.Point(19, 49);
            this.rbDeviceAlias.Name = "rbDeviceAlias";
            this.rbDeviceAlias.Size = new System.Drawing.Size(84, 17);
            this.rbDeviceAlias.TabIndex = 1;
            this.rbDeviceAlias.TabStop = true;
            this.rbDeviceAlias.Text = "Device Alias";
            this.rbDeviceAlias.UseVisualStyleBackColor = true;
            // 
            // rbFCAlias
            // 
            this.rbFCAlias.AutoSize = true;
            this.rbFCAlias.Location = new System.Drawing.Point(19, 27);
            this.rbFCAlias.Name = "rbFCAlias";
            this.rbFCAlias.Size = new System.Drawing.Size(63, 17);
            this.rbFCAlias.TabIndex = 0;
            this.rbFCAlias.Text = "FC Alias";
            this.rbFCAlias.UseVisualStyleBackColor = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "Text Files|*.txt|All Files (*.*)|*.*";
            this.saveFileDialog.Title = "Save Output";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.grpMemberType);
            this.Controls.Add(this.grpDelimiter);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.grpArrayPorts);
            this.Controls.Add(this.grpHostPorts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 1366);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zone Helper";
            this.grpHostPorts.ResumeLayout(false);
            this.grpHostPorts.PerformLayout();
            this.grpArrayPorts.ResumeLayout(false);
            this.grpArrayPorts.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpDelimiter.ResumeLayout(false);
            this.grpDelimiter.PerformLayout();
            this.grpMemberType.ResumeLayout(false);
            this.grpMemberType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpHostPorts;
        private System.Windows.Forms.ListBox lstHostPorts;
        private System.Windows.Forms.Button btnHostPortRemove;
        private System.Windows.Forms.Button btnHostPortAdd;
        private System.Windows.Forms.TextBox txtHostPort;
        private System.Windows.Forms.Label lblHostPort;
        private System.Windows.Forms.GroupBox grpArrayPorts;
        private System.Windows.Forms.ListBox lstArrayPorts;
        private System.Windows.Forms.Button btnArrayPortRemove;
        private System.Windows.Forms.Label lblArrayPort;
        private System.Windows.Forms.Button btnArrayPortAdd;
        private System.Windows.Forms.TextBox txtArrayPort;
        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.Label lblZonesetName;
        private System.Windows.Forms.TextBox txtZonesetName;
        private System.Windows.Forms.TextBox txtVSANNumber;
        private System.Windows.Forms.Label lblVSANNumber;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnClearOutput;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button btnHostsLoad;
        private System.Windows.Forms.Button btnArrayLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.GroupBox grpDelimiter;
        private System.Windows.Forms.RadioButton rbUnderscore;
        private System.Windows.Forms.RadioButton rbHypen;
        private System.Windows.Forms.GroupBox grpMemberType;
        private System.Windows.Forms.RadioButton rbDeviceAlias;
        private System.Windows.Forms.RadioButton rbFCAlias;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHostsSave;
        private System.Windows.Forms.Button btnArraySave;
        private System.Windows.Forms.Button btnSaveOutput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

    }
}

