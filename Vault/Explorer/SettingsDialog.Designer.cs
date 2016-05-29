﻿namespace Microsoft.PS.Common.Vault.Explorer
{
    partial class SettingsDialog
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
            System.Windows.Forms.TabControl uxTabControl;
            this.uxButtonCancel = new System.Windows.Forms.Button();
            this.uxButtonOK = new System.Windows.Forms.Button();
            this.uxPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.uxTabPageOptions = new System.Windows.Forms.TabPage();
            this.uxTabPageAbout = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uxLinkLabelTitle = new System.Windows.Forms.LinkLabel();
            this.uxTextBoxVersions = new System.Windows.Forms.TextBox();
            this.uxLinkLabelInstallLocation = new System.Windows.Forms.LinkLabel();
            this.uxLinkLabelKudos = new System.Windows.Forms.LinkLabel();
            this.uxLinkLabelSendFeedback = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            uxTabControl = new System.Windows.Forms.TabControl();
            uxTabControl.SuspendLayout();
            this.uxTabPageOptions.SuspendLayout();
            this.uxTabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uxButtonCancel
            // 
            this.uxButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uxButtonCancel.Location = new System.Drawing.Point(432, 474);
            this.uxButtonCancel.Margin = new System.Windows.Forms.Padding(4);
            this.uxButtonCancel.Name = "uxButtonCancel";
            this.uxButtonCancel.Size = new System.Drawing.Size(100, 28);
            this.uxButtonCancel.TabIndex = 3;
            this.uxButtonCancel.Text = "Cancel";
            this.uxButtonCancel.UseVisualStyleBackColor = true;
            // 
            // uxButtonOK
            // 
            this.uxButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.uxButtonOK.Enabled = false;
            this.uxButtonOK.Location = new System.Drawing.Point(324, 474);
            this.uxButtonOK.Margin = new System.Windows.Forms.Padding(4);
            this.uxButtonOK.Name = "uxButtonOK";
            this.uxButtonOK.Size = new System.Drawing.Size(100, 28);
            this.uxButtonOK.TabIndex = 2;
            this.uxButtonOK.Text = "OK";
            this.uxButtonOK.UseVisualStyleBackColor = true;
            this.uxButtonOK.Click += new System.EventHandler(this.uxButtonOK_Click);
            // 
            // uxPropertyGrid
            // 
            this.uxPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxPropertyGrid.Location = new System.Drawing.Point(3, 3);
            this.uxPropertyGrid.Name = "uxPropertyGrid";
            this.uxPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.uxPropertyGrid.Size = new System.Drawing.Size(507, 420);
            this.uxPropertyGrid.TabIndex = 0;
            this.uxPropertyGrid.ToolbarVisible = false;
            // 
            // uxTabControl
            // 
            uxTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            uxTabControl.Controls.Add(this.uxTabPageOptions);
            uxTabControl.Controls.Add(this.uxTabPageAbout);
            uxTabControl.Location = new System.Drawing.Point(12, 12);
            uxTabControl.Name = "uxTabControl";
            uxTabControl.SelectedIndex = 0;
            uxTabControl.Size = new System.Drawing.Size(521, 455);
            uxTabControl.TabIndex = 4;
            // 
            // uxTabPageOptions
            // 
            this.uxTabPageOptions.Controls.Add(this.uxPropertyGrid);
            this.uxTabPageOptions.Location = new System.Drawing.Point(4, 25);
            this.uxTabPageOptions.Name = "uxTabPageOptions";
            this.uxTabPageOptions.Padding = new System.Windows.Forms.Padding(3);
            this.uxTabPageOptions.Size = new System.Drawing.Size(513, 426);
            this.uxTabPageOptions.TabIndex = 0;
            this.uxTabPageOptions.Text = "Options";
            this.uxTabPageOptions.UseVisualStyleBackColor = true;
            // 
            // uxTabPageAbout
            // 
            this.uxTabPageAbout.BackColor = System.Drawing.SystemColors.Window;
            this.uxTabPageAbout.Controls.Add(this.uxTextBoxVersions);
            this.uxTabPageAbout.Controls.Add(this.uxLinkLabelInstallLocation);
            this.uxTabPageAbout.Controls.Add(this.uxLinkLabelKudos);
            this.uxTabPageAbout.Controls.Add(this.uxLinkLabelSendFeedback);
            this.uxTabPageAbout.Controls.Add(this.label2);
            this.uxTabPageAbout.Controls.Add(this.uxLinkLabelTitle);
            this.uxTabPageAbout.Controls.Add(this.pictureBox1);
            this.uxTabPageAbout.Location = new System.Drawing.Point(4, 25);
            this.uxTabPageAbout.Name = "uxTabPageAbout";
            this.uxTabPageAbout.Padding = new System.Windows.Forms.Padding(3);
            this.uxTabPageAbout.Size = new System.Drawing.Size(462, 426);
            this.uxTabPageAbout.TabIndex = 1;
            this.uxTabPageAbout.Text = "About";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Microsoft.PS.Common.Vault.Explorer.Properties.Resources.BigKey;
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // uxLinkLabelTitle
            // 
            this.uxLinkLabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxLinkLabelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLinkLabelTitle.Location = new System.Drawing.Point(76, 6);
            this.uxLinkLabelTitle.Name = "uxLinkLabelTitle";
            this.uxLinkLabelTitle.Size = new System.Drawing.Size(380, 64);
            this.uxLinkLabelTitle.TabIndex = 1;
            this.uxLinkLabelTitle.TabStop = true;
            this.uxLinkLabelTitle.Text = "Azure Key Vault Explorer";
            this.uxLinkLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxLinkLabelTitle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxLinkLabelTitle_LinkClicked);
            // 
            // uxTextBoxVersions
            // 
            this.uxTextBoxVersions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxTextBoxVersions.BackColor = System.Drawing.SystemColors.Window;
            this.uxTextBoxVersions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uxTextBoxVersions.Location = new System.Drawing.Point(9, 304);
            this.uxTextBoxVersions.Multiline = true;
            this.uxTextBoxVersions.Name = "uxTextBoxVersions";
            this.uxTextBoxVersions.ReadOnly = true;
            this.uxTextBoxVersions.Size = new System.Drawing.Size(447, 116);
            this.uxTextBoxVersions.TabIndex = 15;
            this.uxTextBoxVersions.Text = "Version: x.x.x.x";
            // 
            // uxLinkLabelInstallLocation
            // 
            this.uxLinkLabelInstallLocation.AutoSize = true;
            this.uxLinkLabelInstallLocation.Location = new System.Drawing.Point(6, 264);
            this.uxLinkLabelInstallLocation.Name = "uxLinkLabelInstallLocation";
            this.uxLinkLabelInstallLocation.Size = new System.Drawing.Size(109, 17);
            this.uxLinkLabelInstallLocation.TabIndex = 14;
            this.uxLinkLabelInstallLocation.TabStop = true;
            this.uxLinkLabelInstallLocation.Text = "Install location...";
            this.uxLinkLabelInstallLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxLinkLabelInstallLocation_LinkClicked);
            // 
            // uxLinkLabelKudos
            // 
            this.uxLinkLabelKudos.AutoSize = true;
            this.uxLinkLabelKudos.Location = new System.Drawing.Point(6, 182);
            this.uxLinkLabelKudos.Name = "uxLinkLabelKudos";
            this.uxLinkLabelKudos.Size = new System.Drawing.Size(169, 17);
            this.uxLinkLabelKudos.TabIndex = 12;
            this.uxLinkLabelKudos.TabStop = true;
            this.uxLinkLabelKudos.Text = "Like it? Send me Kudos...";
            this.uxLinkLabelKudos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxLinkLabelKudos_LinkClicked);
            // 
            // uxLinkLabelSendFeedback
            // 
            this.uxLinkLabelSendFeedback.AutoSize = true;
            this.uxLinkLabelSendFeedback.Location = new System.Drawing.Point(6, 213);
            this.uxLinkLabelSendFeedback.Name = "uxLinkLabelSendFeedback";
            this.uxLinkLabelSendFeedback.Size = new System.Drawing.Size(299, 17);
            this.uxLinkLabelSendFeedback.TabIndex = 13;
            this.uxLinkLabelSendFeedback.TabStop = true;
            this.uxLinkLabelSendFeedback.Text = "Questions or comments? Send me feedback...";
            this.uxLinkLabelSendFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.uxLinkLabelSendFeedback_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 85);
            this.label2.TabIndex = 11;
            this.label2.Text = "Copyright (c) 2016 Microsoft Corporation\r\n\r\nFOR INTERNAL USE ONLY\r\n\r\nWritten by E" +
    "li Zeitlin (elize)";
            // 
            // SettingsDialog
            // 
            this.AcceptButton = this.uxButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uxButtonCancel;
            this.ClientSize = new System.Drawing.Size(545, 515);
            this.Controls.Add(uxTabControl);
            this.Controls.Add(this.uxButtonCancel);
            this.Controls.Add(this.uxButtonOK);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 550);
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            uxTabControl.ResumeLayout(false);
            this.uxTabPageOptions.ResumeLayout(false);
            this.uxTabPageAbout.ResumeLayout(false);
            this.uxTabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxButtonCancel;
        private System.Windows.Forms.Button uxButtonOK;
        private System.Windows.Forms.PropertyGrid uxPropertyGrid;
        private System.Windows.Forms.TabPage uxTabPageOptions;
        private System.Windows.Forms.TabPage uxTabPageAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel uxLinkLabelTitle;
        private System.Windows.Forms.TextBox uxTextBoxVersions;
        private System.Windows.Forms.LinkLabel uxLinkLabelInstallLocation;
        private System.Windows.Forms.LinkLabel uxLinkLabelKudos;
        private System.Windows.Forms.LinkLabel uxLinkLabelSendFeedback;
        private System.Windows.Forms.Label label2;
    }
}