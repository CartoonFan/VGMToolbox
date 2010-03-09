﻿namespace VGMToolbox.forms.extraction
{
    partial class VfsExtractorForm
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
            this.grpFileCount = new System.Windows.Forms.GroupBox();
            this.tbFileCountEndOffset = new System.Windows.Forms.TextBox();
            this.rbFileCountEndOffset = new System.Windows.Forms.RadioButton();
            this.comboFileCountByteOrder = new System.Windows.Forms.ComboBox();
            this.lblFileCountByteOrder = new System.Windows.Forms.Label();
            this.comboFileCountOffsetSize = new System.Windows.Forms.ComboBox();
            this.lblFileCountSize = new System.Windows.Forms.Label();
            this.tbFileCountValue = new System.Windows.Forms.TextBox();
            this.tbFileCountOffset = new System.Windows.Forms.TextBox();
            this.rbOffsetBasedFileCount = new System.Windows.Forms.RadioButton();
            this.rbUserEnteredFileCount = new System.Windows.Forms.RadioButton();
            this.grpPresets = new System.Windows.Forms.GroupBox();
            this.grpFileRecordInfo = new System.Windows.Forms.GroupBox();
            this.grpFileRecordName = new System.Windows.Forms.GroupBox();
            this.lblFileRecordNameHasSize = new System.Windows.Forms.Label();
            this.tbFileRecordNameSize = new System.Windows.Forms.TextBox();
            this.tbFileRecordNameOffset = new System.Windows.Forms.TextBox();
            this.cbFileNameIsPresent = new System.Windows.Forms.CheckBox();
            this.grpIndividualFileLength = new System.Windows.Forms.GroupBox();
            this.rbUseOffsetsToDetermineLength = new System.Windows.Forms.RadioButton();
            this.lblFileRecordLengthByteOrder = new System.Windows.Forms.Label();
            this.lblFileRecordLengthHasSize = new System.Windows.Forms.Label();
            this.comboFileRecordLengthByteOrder = new System.Windows.Forms.ComboBox();
            this.comboFileRecordLengthSize = new System.Windows.Forms.ComboBox();
            this.tbFileRecordLengthOffset = new System.Windows.Forms.TextBox();
            this.rbUseVfsFileLength = new System.Windows.Forms.RadioButton();
            this.grpIndividualFileOffset = new System.Windows.Forms.GroupBox();
            this.tbFileRecordOffsetMultiplier = new System.Windows.Forms.TextBox();
            this.cbUseOffsetMultiplier = new System.Windows.Forms.CheckBox();
            this.lblUseFileLengthToDetermineOffset = new System.Windows.Forms.Label();
            this.tbUseFileLengthBeginOffset = new System.Windows.Forms.TextBox();
            this.rbUseFileSizeToDetermineOffset = new System.Windows.Forms.RadioButton();
            this.lblFileRecordOffsetByteOrder = new System.Windows.Forms.Label();
            this.lblFileRecordOffsetHasSize = new System.Windows.Forms.Label();
            this.comboFileRecordOffsetByteOrder = new System.Windows.Forms.ComboBox();
            this.comboFileRecordOffsetSize = new System.Windows.Forms.ComboBox();
            this.tbFileRecordOffsetOffset = new System.Windows.Forms.TextBox();
            this.rbUseVfsFileOffset = new System.Windows.Forms.RadioButton();
            this.pnlFileRecordsHeader = new System.Windows.Forms.Panel();
            this.lblFileRecordsStartOffset = new System.Windows.Forms.Label();
            this.comboFileRecordSize = new System.Windows.Forms.ComboBox();
            this.tbFileRecordsBeginOffset = new System.Windows.Forms.TextBox();
            this.lblFileRecordSize = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLabels.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.grpFileCount.SuspendLayout();
            this.grpFileRecordInfo.SuspendLayout();
            this.grpFileRecordName.SuspendLayout();
            this.grpIndividualFileLength.SuspendLayout();
            this.grpIndividualFileOffset.SuspendLayout();
            this.pnlFileRecordsHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLabels
            // 
            this.pnlLabels.Location = new System.Drawing.Point(0, 501);
            this.pnlLabels.Size = new System.Drawing.Size(898, 19);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Size = new System.Drawing.Size(898, 20);
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(0, 424);
            this.tbOutput.Size = new System.Drawing.Size(898, 77);
            this.toolTip1.SetToolTip(this.tbOutput, "Double-Click to view in your default text editor.");
            // 
            // pnlButtons
            // 
            this.pnlButtons.Location = new System.Drawing.Point(0, 404);
            this.pnlButtons.Size = new System.Drawing.Size(898, 20);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(838, 0);
            // 
            // btnDoTask
            // 
            this.btnDoTask.Location = new System.Drawing.Point(778, 0);
            // 
            // grpFileCount
            // 
            this.grpFileCount.Controls.Add(this.tbFileCountEndOffset);
            this.grpFileCount.Controls.Add(this.rbFileCountEndOffset);
            this.grpFileCount.Controls.Add(this.comboFileCountByteOrder);
            this.grpFileCount.Controls.Add(this.lblFileCountByteOrder);
            this.grpFileCount.Controls.Add(this.comboFileCountOffsetSize);
            this.grpFileCount.Controls.Add(this.lblFileCountSize);
            this.grpFileCount.Controls.Add(this.tbFileCountValue);
            this.grpFileCount.Controls.Add(this.tbFileCountOffset);
            this.grpFileCount.Controls.Add(this.rbOffsetBasedFileCount);
            this.grpFileCount.Controls.Add(this.rbUserEnteredFileCount);
            this.grpFileCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFileCount.Location = new System.Drawing.Point(0, 0);
            this.grpFileCount.Name = "grpFileCount";
            this.grpFileCount.Size = new System.Drawing.Size(898, 91);
            this.grpFileCount.TabIndex = 7;
            this.grpFileCount.TabStop = false;
            this.grpFileCount.Text = "File Count";
            // 
            // tbFileCountEndOffset
            // 
            this.tbFileCountEndOffset.Location = new System.Drawing.Point(137, 18);
            this.tbFileCountEndOffset.Name = "tbFileCountEndOffset";
            this.tbFileCountEndOffset.Size = new System.Drawing.Size(70, 20);
            this.tbFileCountEndOffset.TabIndex = 9;
            // 
            // rbFileCountEndOffset
            // 
            this.rbFileCountEndOffset.AutoSize = true;
            this.rbFileCountEndOffset.Location = new System.Drawing.Point(6, 19);
            this.rbFileCountEndOffset.Name = "rbFileCountEndOffset";
            this.rbFileCountEndOffset.Size = new System.Drawing.Size(107, 17);
            this.rbFileCountEndOffset.TabIndex = 8;
            this.rbFileCountEndOffset.TabStop = true;
            this.rbFileCountEndOffset.Text = "Parse Until Offset";
            this.rbFileCountEndOffset.UseVisualStyleBackColor = true;
            this.rbFileCountEndOffset.CheckedChanged += new System.EventHandler(this.rbFileCountEndOffset_CheckedChanged);
            // 
            // comboFileCountByteOrder
            // 
            this.comboFileCountByteOrder.FormattingEnabled = true;
            this.comboFileCountByteOrder.Location = new System.Drawing.Point(419, 64);
            this.comboFileCountByteOrder.Name = "comboFileCountByteOrder";
            this.comboFileCountByteOrder.Size = new System.Drawing.Size(88, 21);
            this.comboFileCountByteOrder.TabIndex = 7;
            // 
            // lblFileCountByteOrder
            // 
            this.lblFileCountByteOrder.AutoSize = true;
            this.lblFileCountByteOrder.Location = new System.Drawing.Point(338, 67);
            this.lblFileCountByteOrder.Name = "lblFileCountByteOrder";
            this.lblFileCountByteOrder.Size = new System.Drawing.Size(75, 13);
            this.lblFileCountByteOrder.TabIndex = 6;
            this.lblFileCountByteOrder.Text = "and byte order";
            // 
            // comboFileCountOffsetSize
            // 
            this.comboFileCountOffsetSize.FormattingEnabled = true;
            this.comboFileCountOffsetSize.Location = new System.Drawing.Point(285, 64);
            this.comboFileCountOffsetSize.Name = "comboFileCountOffsetSize";
            this.comboFileCountOffsetSize.Size = new System.Drawing.Size(47, 21);
            this.comboFileCountOffsetSize.TabIndex = 5;
            // 
            // lblFileCountSize
            // 
            this.lblFileCountSize.AutoSize = true;
            this.lblFileCountSize.Location = new System.Drawing.Point(213, 67);
            this.lblFileCountSize.Name = "lblFileCountSize";
            this.lblFileCountSize.Size = new System.Drawing.Size(66, 13);
            this.lblFileCountSize.TabIndex = 4;
            this.lblFileCountSize.Text = "and has size";
            // 
            // tbFileCountValue
            // 
            this.tbFileCountValue.Location = new System.Drawing.Point(137, 41);
            this.tbFileCountValue.MaxLength = 10;
            this.tbFileCountValue.Name = "tbFileCountValue";
            this.tbFileCountValue.Size = new System.Drawing.Size(70, 20);
            this.tbFileCountValue.TabIndex = 3;
            // 
            // tbFileCountOffset
            // 
            this.tbFileCountOffset.Location = new System.Drawing.Point(137, 64);
            this.tbFileCountOffset.MaxLength = 10;
            this.tbFileCountOffset.Name = "tbFileCountOffset";
            this.tbFileCountOffset.Size = new System.Drawing.Size(70, 20);
            this.tbFileCountOffset.TabIndex = 2;
            // 
            // rbOffsetBasedFileCount
            // 
            this.rbOffsetBasedFileCount.AutoSize = true;
            this.rbOffsetBasedFileCount.Location = new System.Drawing.Point(6, 65);
            this.rbOffsetBasedFileCount.Name = "rbOffsetBasedFileCount";
            this.rbOffsetBasedFileCount.Size = new System.Drawing.Size(125, 17);
            this.rbOffsetBasedFileCount.TabIndex = 1;
            this.rbOffsetBasedFileCount.TabStop = true;
            this.rbOffsetBasedFileCount.Text = "File Count is at Offset";
            this.rbOffsetBasedFileCount.UseVisualStyleBackColor = true;
            this.rbOffsetBasedFileCount.CheckedChanged += new System.EventHandler(this.rbOffsetBasedFileCount_CheckedChanged);
            // 
            // rbUserEnteredFileCount
            // 
            this.rbUserEnteredFileCount.AutoSize = true;
            this.rbUserEnteredFileCount.Location = new System.Drawing.Point(6, 42);
            this.rbUserEnteredFileCount.Name = "rbUserEnteredFileCount";
            this.rbUserEnteredFileCount.Size = new System.Drawing.Size(107, 17);
            this.rbUserEnteredFileCount.TabIndex = 0;
            this.rbUserEnteredFileCount.TabStop = true;
            this.rbUserEnteredFileCount.Text = "File Count Equals";
            this.rbUserEnteredFileCount.UseVisualStyleBackColor = true;
            this.rbUserEnteredFileCount.CheckedChanged += new System.EventHandler(this.rbUserEnteredFileCount_CheckedChanged);
            // 
            // grpPresets
            // 
            this.grpPresets.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpPresets.Location = new System.Drawing.Point(0, 23);
            this.grpPresets.Name = "grpPresets";
            this.grpPresets.Size = new System.Drawing.Size(898, 38);
            this.grpPresets.TabIndex = 8;
            this.grpPresets.TabStop = false;
            this.grpPresets.Text = "Presets (not yet implemented)";
            // 
            // grpFileRecordInfo
            // 
            this.grpFileRecordInfo.Controls.Add(this.grpFileRecordName);
            this.grpFileRecordInfo.Controls.Add(this.grpIndividualFileLength);
            this.grpFileRecordInfo.Controls.Add(this.grpIndividualFileOffset);
            this.grpFileRecordInfo.Controls.Add(this.pnlFileRecordsHeader);
            this.grpFileRecordInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFileRecordInfo.Location = new System.Drawing.Point(0, 91);
            this.grpFileRecordInfo.Name = "grpFileRecordInfo";
            this.grpFileRecordInfo.Size = new System.Drawing.Size(898, 241);
            this.grpFileRecordInfo.TabIndex = 9;
            this.grpFileRecordInfo.TabStop = false;
            this.grpFileRecordInfo.Text = "File Record Information";
            // 
            // grpFileRecordName
            // 
            this.grpFileRecordName.Controls.Add(this.lblFileRecordNameHasSize);
            this.grpFileRecordName.Controls.Add(this.tbFileRecordNameSize);
            this.grpFileRecordName.Controls.Add(this.tbFileRecordNameOffset);
            this.grpFileRecordName.Controls.Add(this.cbFileNameIsPresent);
            this.grpFileRecordName.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFileRecordName.Location = new System.Drawing.Point(3, 194);
            this.grpFileRecordName.Name = "grpFileRecordName";
            this.grpFileRecordName.Size = new System.Drawing.Size(892, 42);
            this.grpFileRecordName.TabIndex = 7;
            this.grpFileRecordName.TabStop = false;
            this.grpFileRecordName.Text = "Individual File Name";
            // 
            // lblFileRecordNameHasSize
            // 
            this.lblFileRecordNameHasSize.AutoSize = true;
            this.lblFileRecordNameHasSize.Location = new System.Drawing.Point(219, 20);
            this.lblFileRecordNameHasSize.Name = "lblFileRecordNameHasSize";
            this.lblFileRecordNameHasSize.Size = new System.Drawing.Size(66, 13);
            this.lblFileRecordNameHasSize.TabIndex = 7;
            this.lblFileRecordNameHasSize.Text = "and has size";
            // 
            // tbFileRecordNameSize
            // 
            this.tbFileRecordNameSize.Location = new System.Drawing.Point(291, 17);
            this.tbFileRecordNameSize.Name = "tbFileRecordNameSize";
            this.tbFileRecordNameSize.Size = new System.Drawing.Size(47, 20);
            this.tbFileRecordNameSize.TabIndex = 2;
            // 
            // tbFileRecordNameOffset
            // 
            this.tbFileRecordNameOffset.Location = new System.Drawing.Point(140, 17);
            this.tbFileRecordNameOffset.Name = "tbFileRecordNameOffset";
            this.tbFileRecordNameOffset.Size = new System.Drawing.Size(73, 20);
            this.tbFileRecordNameOffset.TabIndex = 1;
            // 
            // cbFileNameIsPresent
            // 
            this.cbFileNameIsPresent.AutoSize = true;
            this.cbFileNameIsPresent.Location = new System.Drawing.Point(6, 19);
            this.cbFileNameIsPresent.Name = "cbFileNameIsPresent";
            this.cbFileNameIsPresent.Size = new System.Drawing.Size(126, 17);
            this.cbFileNameIsPresent.TabIndex = 0;
            this.cbFileNameIsPresent.Text = "File Name is at Offset";
            this.cbFileNameIsPresent.UseVisualStyleBackColor = true;
            this.cbFileNameIsPresent.CheckedChanged += new System.EventHandler(this.cbFileNameIsPresent_CheckedChanged);
            // 
            // grpIndividualFileLength
            // 
            this.grpIndividualFileLength.Controls.Add(this.rbUseOffsetsToDetermineLength);
            this.grpIndividualFileLength.Controls.Add(this.lblFileRecordLengthByteOrder);
            this.grpIndividualFileLength.Controls.Add(this.lblFileRecordLengthHasSize);
            this.grpIndividualFileLength.Controls.Add(this.comboFileRecordLengthByteOrder);
            this.grpIndividualFileLength.Controls.Add(this.comboFileRecordLengthSize);
            this.grpIndividualFileLength.Controls.Add(this.tbFileRecordLengthOffset);
            this.grpIndividualFileLength.Controls.Add(this.rbUseVfsFileLength);
            this.grpIndividualFileLength.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpIndividualFileLength.Location = new System.Drawing.Point(3, 130);
            this.grpIndividualFileLength.Name = "grpIndividualFileLength";
            this.grpIndividualFileLength.Size = new System.Drawing.Size(892, 64);
            this.grpIndividualFileLength.TabIndex = 6;
            this.grpIndividualFileLength.TabStop = false;
            this.grpIndividualFileLength.Text = "Individual File Length";
            // 
            // rbUseOffsetsToDetermineLength
            // 
            this.rbUseOffsetsToDetermineLength.AutoSize = true;
            this.rbUseOffsetsToDetermineLength.Location = new System.Drawing.Point(6, 44);
            this.rbUseOffsetsToDetermineLength.Name = "rbUseOffsetsToDetermineLength";
            this.rbUseOffsetsToDetermineLength.Size = new System.Drawing.Size(220, 17);
            this.rbUseOffsetsToDetermineLength.TabIndex = 9;
            this.rbUseOffsetsToDetermineLength.TabStop = true;
            this.rbUseOffsetsToDetermineLength.Text = "Use File Offsets to determine File Lengths";
            this.rbUseOffsetsToDetermineLength.UseVisualStyleBackColor = true;
            this.rbUseOffsetsToDetermineLength.CheckedChanged += new System.EventHandler(this.rbUseOffsetsToDetermineLength_CheckedChanged);
            // 
            // lblFileRecordLengthByteOrder
            // 
            this.lblFileRecordLengthByteOrder.AutoSize = true;
            this.lblFileRecordLengthByteOrder.Location = new System.Drawing.Point(344, 21);
            this.lblFileRecordLengthByteOrder.Name = "lblFileRecordLengthByteOrder";
            this.lblFileRecordLengthByteOrder.Size = new System.Drawing.Size(75, 13);
            this.lblFileRecordLengthByteOrder.TabIndex = 8;
            this.lblFileRecordLengthByteOrder.Text = "and byte order";
            // 
            // lblFileRecordLengthHasSize
            // 
            this.lblFileRecordLengthHasSize.AutoSize = true;
            this.lblFileRecordLengthHasSize.Location = new System.Drawing.Point(219, 21);
            this.lblFileRecordLengthHasSize.Name = "lblFileRecordLengthHasSize";
            this.lblFileRecordLengthHasSize.Size = new System.Drawing.Size(66, 13);
            this.lblFileRecordLengthHasSize.TabIndex = 6;
            this.lblFileRecordLengthHasSize.Text = "and has size";
            // 
            // comboFileRecordLengthByteOrder
            // 
            this.comboFileRecordLengthByteOrder.FormattingEnabled = true;
            this.comboFileRecordLengthByteOrder.Location = new System.Drawing.Point(425, 18);
            this.comboFileRecordLengthByteOrder.Name = "comboFileRecordLengthByteOrder";
            this.comboFileRecordLengthByteOrder.Size = new System.Drawing.Size(88, 21);
            this.comboFileRecordLengthByteOrder.TabIndex = 3;
            // 
            // comboFileRecordLengthSize
            // 
            this.comboFileRecordLengthSize.FormattingEnabled = true;
            this.comboFileRecordLengthSize.Location = new System.Drawing.Point(291, 18);
            this.comboFileRecordLengthSize.Name = "comboFileRecordLengthSize";
            this.comboFileRecordLengthSize.Size = new System.Drawing.Size(47, 21);
            this.comboFileRecordLengthSize.TabIndex = 2;
            // 
            // tbFileRecordLengthOffset
            // 
            this.tbFileRecordLengthOffset.Location = new System.Drawing.Point(140, 18);
            this.tbFileRecordLengthOffset.Name = "tbFileRecordLengthOffset";
            this.tbFileRecordLengthOffset.Size = new System.Drawing.Size(73, 20);
            this.tbFileRecordLengthOffset.TabIndex = 1;
            // 
            // rbUseVfsFileLength
            // 
            this.rbUseVfsFileLength.AutoSize = true;
            this.rbUseVfsFileLength.Location = new System.Drawing.Point(6, 19);
            this.rbUseVfsFileLength.Name = "rbUseVfsFileLength";
            this.rbUseVfsFileLength.Size = new System.Drawing.Size(130, 17);
            this.rbUseVfsFileLength.TabIndex = 0;
            this.rbUseVfsFileLength.TabStop = true;
            this.rbUseVfsFileLength.Text = "File Length is at Offset";
            this.rbUseVfsFileLength.UseVisualStyleBackColor = true;
            this.rbUseVfsFileLength.CheckedChanged += new System.EventHandler(this.rbUseVfsFileLength_CheckedChanged);
            // 
            // grpIndividualFileOffset
            // 
            this.grpIndividualFileOffset.Controls.Add(this.tbFileRecordOffsetMultiplier);
            this.grpIndividualFileOffset.Controls.Add(this.cbUseOffsetMultiplier);
            this.grpIndividualFileOffset.Controls.Add(this.lblUseFileLengthToDetermineOffset);
            this.grpIndividualFileOffset.Controls.Add(this.tbUseFileLengthBeginOffset);
            this.grpIndividualFileOffset.Controls.Add(this.rbUseFileSizeToDetermineOffset);
            this.grpIndividualFileOffset.Controls.Add(this.lblFileRecordOffsetByteOrder);
            this.grpIndividualFileOffset.Controls.Add(this.lblFileRecordOffsetHasSize);
            this.grpIndividualFileOffset.Controls.Add(this.comboFileRecordOffsetByteOrder);
            this.grpIndividualFileOffset.Controls.Add(this.comboFileRecordOffsetSize);
            this.grpIndividualFileOffset.Controls.Add(this.tbFileRecordOffsetOffset);
            this.grpIndividualFileOffset.Controls.Add(this.rbUseVfsFileOffset);
            this.grpIndividualFileOffset.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpIndividualFileOffset.Location = new System.Drawing.Point(3, 42);
            this.grpIndividualFileOffset.Name = "grpIndividualFileOffset";
            this.grpIndividualFileOffset.Size = new System.Drawing.Size(892, 88);
            this.grpIndividualFileOffset.TabIndex = 5;
            this.grpIndividualFileOffset.TabStop = false;
            this.grpIndividualFileOffset.Text = "Individual File Offset";
            // 
            // tbFileRecordOffsetMultiplier
            // 
            this.tbFileRecordOffsetMultiplier.Location = new System.Drawing.Point(140, 40);
            this.tbFileRecordOffsetMultiplier.Name = "tbFileRecordOffsetMultiplier";
            this.tbFileRecordOffsetMultiplier.Size = new System.Drawing.Size(73, 20);
            this.tbFileRecordOffsetMultiplier.TabIndex = 12;
            // 
            // cbUseOffsetMultiplier
            // 
            this.cbUseOffsetMultiplier.AutoSize = true;
            this.cbUseOffsetMultiplier.Location = new System.Drawing.Point(21, 42);
            this.cbUseOffsetMultiplier.Name = "cbUseOffsetMultiplier";
            this.cbUseOffsetMultiplier.Size = new System.Drawing.Size(107, 17);
            this.cbUseOffsetMultiplier.TabIndex = 11;
            this.cbUseOffsetMultiplier.Text = "Multiply Offset By";
            this.cbUseOffsetMultiplier.UseVisualStyleBackColor = true;
            this.cbUseOffsetMultiplier.CheckedChanged += new System.EventHandler(this.cbUseOffsetMultiplier_CheckedChanged);
            // 
            // lblUseFileLengthToDetermineOffset
            // 
            this.lblUseFileLengthToDetermineOffset.AutoSize = true;
            this.lblUseFileLengthToDetermineOffset.Location = new System.Drawing.Point(219, 67);
            this.lblUseFileLengthToDetermineOffset.Name = "lblUseFileLengthToDetermineOffset";
            this.lblUseFileLengthToDetermineOffset.Size = new System.Drawing.Size(247, 13);
            this.lblUseFileLengthToDetermineOffset.TabIndex = 10;
            this.lblUseFileLengthToDetermineOffset.Text = "and use File Lengths to determine following offsets.";
            // 
            // tbUseFileLengthBeginOffset
            // 
            this.tbUseFileLengthBeginOffset.Location = new System.Drawing.Point(140, 64);
            this.tbUseFileLengthBeginOffset.Name = "tbUseFileLengthBeginOffset";
            this.tbUseFileLengthBeginOffset.Size = new System.Drawing.Size(73, 20);
            this.tbUseFileLengthBeginOffset.TabIndex = 9;
            // 
            // rbUseFileSizeToDetermineOffset
            // 
            this.rbUseFileSizeToDetermineOffset.AutoSize = true;
            this.rbUseFileSizeToDetermineOffset.Location = new System.Drawing.Point(6, 65);
            this.rbUseFileSizeToDetermineOffset.Name = "rbUseFileSizeToDetermineOffset";
            this.rbUseFileSizeToDetermineOffset.Size = new System.Drawing.Size(128, 17);
            this.rbUseFileSizeToDetermineOffset.TabIndex = 8;
            this.rbUseFileSizeToDetermineOffset.TabStop = true;
            this.rbUseFileSizeToDetermineOffset.Text = "Begin cutting at offset";
            this.rbUseFileSizeToDetermineOffset.UseVisualStyleBackColor = true;
            this.rbUseFileSizeToDetermineOffset.CheckedChanged += new System.EventHandler(this.rbUseFileSizeToDetermineOffset_CheckedChanged);
            // 
            // lblFileRecordOffsetByteOrder
            // 
            this.lblFileRecordOffsetByteOrder.AutoSize = true;
            this.lblFileRecordOffsetByteOrder.Location = new System.Drawing.Point(344, 19);
            this.lblFileRecordOffsetByteOrder.Name = "lblFileRecordOffsetByteOrder";
            this.lblFileRecordOffsetByteOrder.Size = new System.Drawing.Size(75, 13);
            this.lblFileRecordOffsetByteOrder.TabIndex = 7;
            this.lblFileRecordOffsetByteOrder.Text = "and byte order";
            // 
            // lblFileRecordOffsetHasSize
            // 
            this.lblFileRecordOffsetHasSize.AutoSize = true;
            this.lblFileRecordOffsetHasSize.Location = new System.Drawing.Point(219, 19);
            this.lblFileRecordOffsetHasSize.Name = "lblFileRecordOffsetHasSize";
            this.lblFileRecordOffsetHasSize.Size = new System.Drawing.Size(66, 13);
            this.lblFileRecordOffsetHasSize.TabIndex = 5;
            this.lblFileRecordOffsetHasSize.Text = "and has size";
            // 
            // comboFileRecordOffsetByteOrder
            // 
            this.comboFileRecordOffsetByteOrder.FormattingEnabled = true;
            this.comboFileRecordOffsetByteOrder.Location = new System.Drawing.Point(425, 15);
            this.comboFileRecordOffsetByteOrder.Name = "comboFileRecordOffsetByteOrder";
            this.comboFileRecordOffsetByteOrder.Size = new System.Drawing.Size(88, 21);
            this.comboFileRecordOffsetByteOrder.TabIndex = 3;
            // 
            // comboFileRecordOffsetSize
            // 
            this.comboFileRecordOffsetSize.FormattingEnabled = true;
            this.comboFileRecordOffsetSize.Location = new System.Drawing.Point(291, 15);
            this.comboFileRecordOffsetSize.Name = "comboFileRecordOffsetSize";
            this.comboFileRecordOffsetSize.Size = new System.Drawing.Size(47, 21);
            this.comboFileRecordOffsetSize.TabIndex = 2;
            // 
            // tbFileRecordOffsetOffset
            // 
            this.tbFileRecordOffsetOffset.Location = new System.Drawing.Point(140, 16);
            this.tbFileRecordOffsetOffset.Name = "tbFileRecordOffsetOffset";
            this.tbFileRecordOffsetOffset.Size = new System.Drawing.Size(73, 20);
            this.tbFileRecordOffsetOffset.TabIndex = 1;
            // 
            // rbUseVfsFileOffset
            // 
            this.rbUseVfsFileOffset.AutoSize = true;
            this.rbUseVfsFileOffset.Location = new System.Drawing.Point(6, 19);
            this.rbUseVfsFileOffset.Name = "rbUseVfsFileOffset";
            this.rbUseVfsFileOffset.Size = new System.Drawing.Size(125, 17);
            this.rbUseVfsFileOffset.TabIndex = 0;
            this.rbUseVfsFileOffset.TabStop = true;
            this.rbUseVfsFileOffset.Text = "File Offset is at Offset";
            this.rbUseVfsFileOffset.UseVisualStyleBackColor = true;
            this.rbUseVfsFileOffset.CheckedChanged += new System.EventHandler(this.rbUseVfsFileOffset_CheckedChanged);
            // 
            // pnlFileRecordsHeader
            // 
            this.pnlFileRecordsHeader.Controls.Add(this.lblFileRecordsStartOffset);
            this.pnlFileRecordsHeader.Controls.Add(this.comboFileRecordSize);
            this.pnlFileRecordsHeader.Controls.Add(this.tbFileRecordsBeginOffset);
            this.pnlFileRecordsHeader.Controls.Add(this.lblFileRecordSize);
            this.pnlFileRecordsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFileRecordsHeader.Location = new System.Drawing.Point(3, 16);
            this.pnlFileRecordsHeader.Name = "pnlFileRecordsHeader";
            this.pnlFileRecordsHeader.Size = new System.Drawing.Size(892, 26);
            this.pnlFileRecordsHeader.TabIndex = 4;
            // 
            // lblFileRecordsStartOffset
            // 
            this.lblFileRecordsStartOffset.AutoSize = true;
            this.lblFileRecordsStartOffset.Location = new System.Drawing.Point(3, 5);
            this.lblFileRecordsStartOffset.Name = "lblFileRecordsStartOffset";
            this.lblFileRecordsStartOffset.Size = new System.Drawing.Size(131, 13);
            this.lblFileRecordsStartOffset.TabIndex = 2;
            this.lblFileRecordsStartOffset.Text = "File records begin at offset";
            // 
            // comboFileRecordSize
            // 
            this.comboFileRecordSize.FormattingEnabled = true;
            this.comboFileRecordSize.Location = new System.Drawing.Point(351, 2);
            this.comboFileRecordSize.Name = "comboFileRecordSize";
            this.comboFileRecordSize.Size = new System.Drawing.Size(70, 21);
            this.comboFileRecordSize.TabIndex = 1;
            // 
            // tbFileRecordsBeginOffset
            // 
            this.tbFileRecordsBeginOffset.Location = new System.Drawing.Point(140, 2);
            this.tbFileRecordsBeginOffset.Name = "tbFileRecordsBeginOffset";
            this.tbFileRecordsBeginOffset.Size = new System.Drawing.Size(73, 20);
            this.tbFileRecordsBeginOffset.TabIndex = 3;
            // 
            // lblFileRecordSize
            // 
            this.lblFileRecordSize.AutoSize = true;
            this.lblFileRecordSize.Location = new System.Drawing.Point(219, 5);
            this.lblFileRecordSize.Name = "lblFileRecordSize";
            this.lblFileRecordSize.Size = new System.Drawing.Size(126, 13);
            this.lblFileRecordSize.TabIndex = 0;
            this.lblFileRecordSize.Text = "and each record has size";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.grpFileRecordInfo);
            this.panel1.Controls.Add(this.grpFileCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(898, 343);
            this.panel1.TabIndex = 10;
            // 
            // VfsExtractorForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpPresets);
            this.Name = "VfsExtractorForm";
            this.Text = "VfsExtractorForm";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VfsExtractorForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VfsExtractorForm_DragEnter);
            this.Controls.SetChildIndex(this.pnlLabels, 0);
            this.Controls.SetChildIndex(this.tbOutput, 0);
            this.Controls.SetChildIndex(this.pnlTitle, 0);
            this.Controls.SetChildIndex(this.pnlButtons, 0);
            this.Controls.SetChildIndex(this.grpPresets, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.pnlLabels.ResumeLayout(false);
            this.pnlLabels.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.grpFileCount.ResumeLayout(false);
            this.grpFileCount.PerformLayout();
            this.grpFileRecordInfo.ResumeLayout(false);
            this.grpFileRecordName.ResumeLayout(false);
            this.grpFileRecordName.PerformLayout();
            this.grpIndividualFileLength.ResumeLayout(false);
            this.grpIndividualFileLength.PerformLayout();
            this.grpIndividualFileOffset.ResumeLayout(false);
            this.grpIndividualFileOffset.PerformLayout();
            this.pnlFileRecordsHeader.ResumeLayout(false);
            this.pnlFileRecordsHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFileCount;
        private System.Windows.Forms.RadioButton rbOffsetBasedFileCount;
        private System.Windows.Forms.RadioButton rbUserEnteredFileCount;
        private System.Windows.Forms.GroupBox grpPresets;
        private System.Windows.Forms.TextBox tbFileCountOffset;
        private System.Windows.Forms.TextBox tbFileCountValue;
        private System.Windows.Forms.Label lblFileCountSize;
        private System.Windows.Forms.ComboBox comboFileCountOffsetSize;
        private System.Windows.Forms.Label lblFileCountByteOrder;
        private System.Windows.Forms.ComboBox comboFileCountByteOrder;
        private System.Windows.Forms.RadioButton rbFileCountEndOffset;
        private System.Windows.Forms.TextBox tbFileCountEndOffset;
        private System.Windows.Forms.GroupBox grpFileRecordInfo;
        private System.Windows.Forms.Label lblFileRecordSize;
        private System.Windows.Forms.ComboBox comboFileRecordSize;
        private System.Windows.Forms.Label lblFileRecordsStartOffset;
        private System.Windows.Forms.TextBox tbFileRecordsBeginOffset;
        private System.Windows.Forms.Panel pnlFileRecordsHeader;
        private System.Windows.Forms.GroupBox grpIndividualFileOffset;
        private System.Windows.Forms.RadioButton rbUseVfsFileOffset;
        private System.Windows.Forms.TextBox tbFileRecordOffsetOffset;
        private System.Windows.Forms.ComboBox comboFileRecordOffsetSize;
        private System.Windows.Forms.ComboBox comboFileRecordOffsetByteOrder;
        private System.Windows.Forms.Label lblFileRecordOffsetHasSize;
        private System.Windows.Forms.Label lblFileRecordOffsetByteOrder;
        private System.Windows.Forms.RadioButton rbUseFileSizeToDetermineOffset;
        private System.Windows.Forms.TextBox tbUseFileLengthBeginOffset;
        private System.Windows.Forms.Label lblUseFileLengthToDetermineOffset;
        private System.Windows.Forms.TextBox tbFileRecordOffsetMultiplier;
        private System.Windows.Forms.CheckBox cbUseOffsetMultiplier;
        private System.Windows.Forms.GroupBox grpIndividualFileLength;
        private System.Windows.Forms.TextBox tbFileRecordLengthOffset;
        private System.Windows.Forms.RadioButton rbUseVfsFileLength;
        private System.Windows.Forms.ComboBox comboFileRecordLengthByteOrder;
        private System.Windows.Forms.ComboBox comboFileRecordLengthSize;
        private System.Windows.Forms.Label lblFileRecordLengthHasSize;
        private System.Windows.Forms.Label lblFileRecordLengthByteOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbUseOffsetsToDetermineLength;
        private System.Windows.Forms.GroupBox grpFileRecordName;
        private System.Windows.Forms.CheckBox cbFileNameIsPresent;
        private System.Windows.Forms.TextBox tbFileRecordNameOffset;
        private System.Windows.Forms.TextBox tbFileRecordNameSize;
        private System.Windows.Forms.Label lblFileRecordNameHasSize;
    }
}