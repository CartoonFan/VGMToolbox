﻿using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;

using VGMToolbox.auditing;
using VGMToolbox.plugin;

namespace VGMToolbox.forms.audit
{
    public partial class DatafileCheckerForm : AVgmtForm
    {        
        public DatafileCheckerForm(TreeNode pTreeNode)
            : base(pTreeNode)
        {
            // set title
            this.lblTitle.Text =
                ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_Title"];
            this.btnDoTask.Text =
                ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_DoTaskButton"];
            this.tbOutput.Text =
                ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_IntroText"];

            this.btnCancel.Hide();

            InitializeComponent();

            // languages
            this.gbSourceDestination.Text = 
                ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_GroupSource"];
            this.lblSourceDataFile.Text = 
                ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_LblSourceDataFile"];
            this.lblReportDestination.Text = 
                ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_LblReportDestination"];
                    
        }

        private void btnDatafileChecker_Check_Click(object sender, EventArgs e)
        {
            if (base.checkFileExists(tbDatafileChecker_SourceFile.Text, this.lblSourceDataFile.Text) &&
                base.checkFolderExists(tbDatafileChecker_OutputPath.Text, this.lblReportDestination.Text))
            {
                DatafileCheckerWorker.DatafileCheckerStruct datafileCheckerStruct = new DatafileCheckerWorker.DatafileCheckerStruct();
                datafileCheckerStruct.datafilePath = tbDatafileChecker_SourceFile.Text;
                datafileCheckerStruct.outputPath = tbDatafileChecker_OutputPath.Text;

                base.backgroundWorker_Execute(datafileCheckerStruct);
            }
        }
        private void tbDatafileChecker_BrowseSource_Click(object sender, EventArgs e)
        {
            tbDatafileChecker_SourceFile.Text = base.browseForFile(sender, e);
        }
        private void tbDatafileChecker_BrowseDestination_Click(object sender, EventArgs e)
        {
            tbDatafileChecker_OutputPath.Text = base.browseForFolder(sender, e);
        }

        protected override IVgmtBackgroundWorker getBackgroundWorker()
        {
            return new DatafileCheckerWorker();
        }
        protected override string getCancelMessage()
        {
            return ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_MessageCancel"];
        }
        protected override string getCompleteMessage()
        {
            return ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_MessageComplete"];
        }
        protected override string getBeginMessage()
        {
            return ConfigurationSettings.AppSettings["Form_AuditDatafileChecker_MessageBegin"];
        }
    }
}
