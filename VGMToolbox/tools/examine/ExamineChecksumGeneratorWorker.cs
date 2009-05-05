﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

using ICSharpCode.SharpZipLib.Checksums;

using VGMToolbox.format;
using VGMToolbox.format.util;
using VGMToolbox.plugin;
using VGMToolbox.util;

namespace VGMToolbox.tools.examine
{
    class ExamineChecksumGeneratorWorker : AVgmtDragAndDropWorker, IVgmtBackgroundWorker
    {

        public struct ExamineChecksumGeneratorStruct : IVgmtWorkerStruct
        {
            private string[] sourcePaths;
            public string[] SourcePaths
            {
                get { return sourcePaths; }
                set { sourcePaths = value; }
            }
        }

        public ExamineChecksumGeneratorWorker() : base() { }

        protected override void DoTaskForFile(string pPath,
            IVgmtWorkerStruct pExamineChecksumGeneratorStruct, DoWorkEventArgs e)
        {
            ExamineChecksumGeneratorStruct examineChecksumGeneratorStruct =
                (ExamineChecksumGeneratorStruct)pExamineChecksumGeneratorStruct;

            string crc32;
            string md5;
            string sha1;

            string vgmtCrc32 = "Not implemented for this format.";
            Type formatType = null;
            IFormat vgmData = null;

            using (FileStream fs = File.OpenRead(pPath))
            {
                crc32 = ChecksumUtil.GetCrc32OfFullFile(fs);
                md5 = ChecksumUtil.GetMd5OfFullFile(fs);
                sha1 = ChecksumUtil.GetSha1OfFullFile(fs);

                formatType = FormatUtil.getObjectType(fs);
                if (formatType != null)
                {
                    vgmData = (IFormat)Activator.CreateInstance(formatType);
                    vgmData.Initialize(fs, pPath);
                }
            }

            if (vgmData != null)
            {
                Crc32 crc32Generator = new Crc32();
                vgmData.GetDatFileCrc32(ref crc32Generator);
                vgmtCrc32 = crc32Generator.Value.ToString("X8");
            }

            this.progressStruct.Clear();
            progressStruct.GenericMessage = String.Format("<{0}>{1}", pPath, Environment.NewLine);
            progressStruct.GenericMessage += String.Format("CRC32: {0}{1}", crc32, Environment.NewLine);
            progressStruct.GenericMessage += String.Format("MD5: {0}{1}", md5, Environment.NewLine);
            progressStruct.GenericMessage += String.Format("SHA1: {0}{1}{2}", sha1, Environment.NewLine, Environment.NewLine);

            progressStruct.GenericMessage += String.Format("CRC32 (VGMT): {0}{1}{2}", vgmtCrc32, Environment.NewLine, Environment.NewLine);
            ReportProgress(this.Progress, progressStruct);
        }
    }
}