//Most of this code came from http://www.codeproject.com/Articles/18611/A-small-Content-Detection-Library
//I modified the code to suit my needs.

/*
The Code Project Open License (CPOL) 1.02
Preamble
This License governs Your use of the Work. This License is intended to allow developers to use the Source Code and Executable Files provided as part of the Work in any application in any form.

The main points subject to the terms of the License are:

Source Code and Executable Files can be used in commercial applications;
Source Code and Executable Files can be redistributed; and
Source Code can be modified to create derivative works.
No claim of suitability, guarantee, or any warranty whatsoever is provided. The software is provided "as-is".
The Article(s) accompanying the Work may not be distributed or republished without the Author's consent
This License is entered between You, the individual or other entity reading or otherwise making use of the Work licensed pursuant to this License and the individual or other entity which offers the Work under the terms of this License ("Author").

License
THE WORK (AS DEFINED BELOW) IS PROVIDED UNDER THE TERMS OF THIS CODE PROJECT OPEN LICENSE ("LICENSE"). THE WORK IS PROTECTED BY COPYRIGHT AND/OR OTHER APPLICABLE LAW. ANY USE OF THE WORK OTHER THAN AS AUTHORIZED UNDER THIS LICENSE OR COPYRIGHT LAW IS PROHIBITED.

BY EXERCISING ANY RIGHTS TO THE WORK PROVIDED HEREIN, YOU ACCEPT AND AGREE TO BE BOUND BY THE TERMS OF THIS LICENSE. THE AUTHOR GRANTS YOU THE RIGHTS CONTAINED HEREIN IN CONSIDERATION OF YOUR ACCEPTANCE OF SUCH TERMS AND CONDITIONS. IF YOU DO NOT AGREE TO ACCEPT AND BE BOUND BY THE TERMS OF THIS LICENSE, YOU CANNOT MAKE ANY USE OF THE WORK.

Definitions.
"Articles" means, collectively, all articles written by Author which describes how the Source Code and Executable Files for the Work may be used by a user.
"Author" means the individual or entity that offers the Work under the terms of this License.
"Derivative Work" means a work based upon the Work or upon the Work and other pre-existing works.
"Executable Files" refer to the executables, binary files, configuration and any required data files included in the Work.
"Publisher" means the provider of the website, magazine, CD-ROM, DVD or other medium from or by which the Work is obtained by You.
"Source Code" refers to the collection of source code and configuration files used to create the Executable Files.
"Standard Version" refers to such a Work if it has not been modified, or has been modified in accordance with the consent of the Author, such consent being in the full discretion of the Author.
"Work" refers to the collection of files distributed by the Publisher, including the Source Code, Executable Files, binaries, data files, documentation, whitepapers and the Articles.
"You" is you, an individual or entity wishing to use the Work and exercise your rights under this License.
Fair Use/Fair Use Rights. Nothing in this License is intended to reduce, limit, or restrict any rights arising from fair use, fair dealing, first sale or other limitations on the exclusive rights of the copyright owner under copyright law or other applicable laws.
License Grant. Subject to the terms and conditions of this License, the Author hereby grants You a worldwide, royalty-free, non-exclusive, perpetual (for the duration of the applicable copyright) license to exercise the rights in the Work as stated below:
You may use the standard version of the Source Code or Executable Files in Your own applications.
You may apply bug fixes, portability fixes and other modifications obtained from the Public Domain or from the Author. A Work modified in such a way shall still be considered the standard version and will be subject to this License.
You may otherwise modify Your copy of this Work (excluding the Articles) in any way to create a Derivative Work, provided that You insert a prominent notice in each changed file stating how, when and where You changed that file.
You may distribute the standard version of the Executable Files and Source Code or Derivative Work in aggregate with other (possibly commercial) programs as part of a larger (possibly commercial) software distribution.
The Articles discussing the Work published in any form by the author may not be distributed or republished without the Author's consent. The author retains copyright to any such Articles. You may use the Executable Files and Source Code pursuant to this License but you may not repost or republish or otherwise distribute or make available the Articles, without the prior written consent of the Author.
Any subroutines or modules supplied by You and linked into the Source Code or Executable Files of this Work shall not be considered part of this Work and will not be subject to the terms of this License.
Patent License. Subject to the terms and conditions of this License, each Author hereby grants to You a perpetual, worldwide, non-exclusive, no-charge, royalty-free, irrevocable (except as stated in this section) patent license to make, have made, use, import, and otherwise transfer the Work.
Restrictions. The license granted in Section 3 above is expressly made subject to and limited by the following restrictions:
You agree not to remove any of the original copyright, patent, trademark, and attribution notices and associated disclaimers that may appear in the Source Code or Executable Files.
You agree not to advertise or in any way imply that this Work is a product of Your own.
The name of the Author may not be used to endorse or promote products derived from the Work without the prior written consent of the Author.
You agree not to sell, lease, or rent any part of the Work. This does not restrict you from including the Work or any part of the Work inside a larger software distribution that itself is being sold. The Work by itself, though, cannot be sold, leased or rented.
You may distribute the Executable Files and Source Code only under the terms of this License, and You must include a copy of, or the Uniform Resource Identifier for, this License with every copy of the Executable Files or Source Code You distribute and ensure that anyone receiving such Executable Files and Source Code agrees that the terms of this License apply to such Executable Files and/or Source Code. You may not offer or impose any terms on the Work that alter or restrict the terms of this License or the recipients' exercise of the rights granted hereunder. You may not sublicense the Work. You must keep intact all notices that refer to this License and to the disclaimer of warranties. You may not distribute the Executable Files or Source Code with any technological measures that control access or use of the Work in a manner inconsistent with the terms of this License.
You agree not to use the Work for illegal, immoral or improper purposes, or on pages containing illegal, immoral or improper material. The Work is subject to applicable export laws. You agree to comply with all such laws and regulations that may apply to the Work after Your receipt of the Work.
Representations, Warranties and Disclaimer. THIS WORK IS PROVIDED "AS IS", "WHERE IS" AND "AS AVAILABLE", WITHOUT ANY EXPRESS OR IMPLIED WARRANTIES OR CONDITIONS OR GUARANTEES. YOU, THE USER, ASSUME ALL RISK IN ITS USE, INCLUDING COPYRIGHT INFRINGEMENT, PATENT INFRINGEMENT, SUITABILITY, ETC. AUTHOR EXPRESSLY DISCLAIMS ALL EXPRESS, IMPLIED OR STATUTORY WARRANTIES OR CONDITIONS, INCLUDING WITHOUT LIMITATION, WARRANTIES OR CONDITIONS OF MERCHANTABILITY, MERCHANTABLE QUALITY OR FITNESS FOR A PARTICULAR PURPOSE, OR ANY WARRANTY OF TITLE OR NON-INFRINGEMENT, OR THAT THE WORK (OR ANY PORTION THEREOF) IS CORRECT, USEFUL, BUG-FREE OR FREE OF VIRUSES. YOU MUST PASS THIS DISCLAIMER ON WHENEVER YOU DISTRIBUTE THE WORK OR DERIVATIVE WORKS.
Indemnity. You agree to defend, indemnify and hold harmless the Author and the Publisher from and against any claims, suits, losses, damages, liabilities, costs, and expenses (including reasonable legal or attorneys’ fees) resulting from or relating to any use of the Work by You.
Limitation on Liability. EXCEPT TO THE EXTENT REQUIRED BY APPLICABLE LAW, IN NO EVENT WILL THE AUTHOR OR THE PUBLISHER BE LIABLE TO YOU ON ANY LEGAL THEORY FOR ANY SPECIAL, INCIDENTAL, CONSEQUENTIAL, PUNITIVE OR EXEMPLARY DAMAGES ARISING OUT OF THIS LICENSE OR THE USE OF THE WORK OR OTHERWISE, EVEN IF THE AUTHOR OR THE PUBLISHER HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES.
Termination.
This License and the rights granted hereunder will terminate automatically upon any breach by You of any term of this License. Individuals or entities who have received Derivative Works from You under this License, however, will not have their licenses terminated provided such individuals or entities remain in full compliance with those licenses. Sections 1, 2, 6, 7, 8, 9, 10 and 11 will survive any termination of this License.
If You bring a copyright, trademark, patent or any other infringement claim against any contributor over infringements You claim are made by the Work, your License from such contributor to the Work ends automatically.
Subject to the above terms and conditions, this License is perpetual (for the duration of the applicable copyright in the Work). Notwithstanding the above, the Author reserves the right to release the Work under different license terms or to stop distributing the Work at any time; provided, however that any such election will not serve to withdraw this License (or any other license that has been, or is required to be, granted under the terms of this License), and this License will continue in full force and effect unless terminated as stated above.
Publisher. The parties hereby confirm that the Publisher shall not, under any circumstances, be responsible for and shall not have any liability in respect of the subject matter of this License. The Publisher makes no warranty whatsoever in connection with the Work and shall not be liable to You or any party on any legal theory for any damages whatsoever, including without limitation any general, special, incidental or consequential damages arising in connection to this license. The Publisher reserves the right to cease making the Work available to You at any time without notice
Miscellaneous
This License shall be governed by the laws of the location of the head office of the Author or if the Author is an individual, the laws of location of the principal place of residence of the Author.
If any provision of this License is invalid or unenforceable under applicable law, it shall not affect the validity or enforceability of the remainder of the terms of this License, and without further action by the parties to this License, such provision shall be reformed to the minimum extent necessary to make such provision valid and enforceable.
No term or provision of this License shall be deemed waived and no breach consented to unless such waiver or consent shall be in writing and signed by the party to be charged with such waiver or consent.
This License constitutes the entire agreement between the parties with respect to the Work licensed herein. There are no understandings, agreements or representations with respect to the Work not specified herein. The Author shall not be bound by any additional provisions that may appear in any communication from You. This License may not be modified without the mutual written agreement of the Author and You.
 */



//removed Archive classes and extraction code from the original code.  3-12-2016
//Added ByteOffset and FirstBytesToRead to contructors and Signature related classes,SimplePatternSignatureChecker for user specification.  3-13-2016
//Added more stock signatures 3-17-2016
//Added SignatureConfig table code to allow user specification of signatures 3-20-2016
//Added ByteOffset and FirstBytesToRead to HeaderSignature Stock Signature contructors 3-27-2016
//Added more stock signatures 3-31-2016
//Added Error Log write procedure and objects needed event log use 3-31-2016


//Added more 
namespace RansomwareDetection.ContentDetectorLib
{
	#region Using directives.
	// ----------------------------------------------------------------------

	using System;
	using System.Collections.Generic;
	using System.Diagnostics;
	using System.IO;
	//using Archive;
	using Content;
    using System.Data;
    using System.Text;

	// ----------------------------------------------------------------------
	#endregion

	/////////////////////////////////////////////////////////////////////////

    

	/// <summary>
	/// Detection of prohibited content, depending on the file extension and
	/// the content.
	/// </summary>
	public sealed class ContentDetectorEngine
	{
		#region Public methods.
		// ------------------------------------------------------------------

        public bool DetailedLogging 
        {
            get
            {
                return _detailedLogging;
            }
            set
            {
                _detailedLogging = value;
            }
        }

        /// <summary>
        /// Initializes the config table for file filters
        /// </summary>
        /// <returns></returns>
        public static DataTable init_dtSignature()
        {
            DataTable dtSignatures;
            dtSignatures = new DataTable("SignaturesConfig");


            //Create Primary Key Column
            DataColumn dcID = new DataColumn("ID", typeof(Int32));
            dcID.AllowDBNull = false;
            dcID.Unique = true;
            dcID.AutoIncrement = true;
            dcID.AutoIncrementSeed = 1;
            dcID.AutoIncrementStep = 1;

            //Assign Primary Key
            DataColumn[] columns = new DataColumn[1];
            dtSignatures.Columns.Add(dcID);
            columns[0] = dtSignatures.Columns["ID"];
            dtSignatures.PrimaryKey = columns;


            //Create Columns
            dtSignatures.Columns.Add(new DataColumn("Enabled", typeof(String)));
            dtSignatures.Columns.Add(new DataColumn("ByteOffset", typeof(String)));
            dtSignatures.Columns.Add(new DataColumn("FirstNumberOfBytesToRead", typeof(String)));
            dtSignatures.Columns.Add(new DataColumn("HexPattern", typeof(String)));
            dtSignatures.Columns.Add(new DataColumn("SignatureName", typeof(String)));
            dtSignatures.Columns.Add(new DataColumn("FileExtensions", typeof(String)));
            dtSignatures.Columns.Add(new DataColumn("Prohibited", typeof(String)));
            dtSignatures.Columns.Add(new DataColumn("Comment", typeof(String)));

            dtSignatures.Columns["Enabled"].DefaultValue = "true";
            dtSignatures.Columns["ByteOffset"].DefaultValue = "0";
            dtSignatures.Columns["FirstNumberOfBytesToRead"].DefaultValue = "0";
            dtSignatures.Columns["HexPattern"].DefaultValue = "";
            dtSignatures.Columns["SignatureName"].DefaultValue = "";
            dtSignatures.Columns["FileExtensions"].DefaultValue = "";
            dtSignatures.Columns["Prohibited"].DefaultValue = "False";
            dtSignatures.Columns["Comment"].DefaultValue = "";

            return dtSignatures;

        }

		

		

        /// <summary>
        /// Cores the content of the process file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private bool ContainsProhibitedFileContent(
            Delimon.Win32.IO.FileInfo filePath, HeaderSignature[] sigs)
        {
            WriteError(string.Format(
                @"Audit Folder ContentDetectorEngine: Processing content of file '{0}' ({1:0,0} bytes).",
                filePath.FullName,
                filePath.Length), System.Diagnostics.EventLogEntryType.Information,6000,60,true);

            SingleFileContentProcessor processor =
                new SingleFileContentProcessor(filePath);

            bool result = processor.ContainsProhibitedContent(true,sigs);

            if (result)
            {
                WriteError(
                    string.Format(
                        @"Audit Folder ContentDetectorEngine: Detected PROHIBITED content in file '{0}' ({1:0,0} bytes).",
                        filePath.FullName,
                        filePath.Length), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);
            }
            else
            {
                WriteError(
                    string.Format(
                        @"Audit Folder ContentDetectorEngine: Detected NO prohibited content in file '{0}' ({1:0,0} bytes).",
                        filePath.FullName,
                        filePath.Length), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);
            }

            return result;
        }
        
        /// <summary>
        /// Determines whether the specified folder contains files with
        /// file extensions that do not match the content.
        /// </summary>
        /// <param name="folderPath">The folder path.</param>
        /// <param name="recursive">if set to <c>true</c> [recursive].</param>
        /// <returns>
        /// 	<c>true</c> if [contains folder prohibited content] 
        /// [the specified folder path]; otherwise, <c>false</c>.
        /// </returns>
        public void ContainsFolderVerifyContent(
            Delimon.Win32.IO.DirectoryInfo folderPath,
            bool recursive,
            ref List<FileResult> verifiedFiles,
            ref List<FileResult> unVerifiedFiles,
            ref List<FileResult> unknownFiles,
            ref List<FileResult> ProhibitedFiles,
            ref bool blShuttingDown,
            string excludeFolders,
            System.Data.DataTable dtSignatures
            )
        {
            WriteError(
                string.Format(
                @"Audit Folder ContentDetectorEngine: Checking folder '{0}'.",
                folderPath.FullName), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);

            HeaderSignature[] sigs = null;
            try
            {
                if (sigs == null)
                {
                    if (dtSignatures == null || dtSignatures.Rows.Count == 0)
                    {
                        sigs = HeaderSignature.StockSignatures;
                    }
                    else
                    {
                        sigs = HeaderSignature.CustomSignatures(dtSignatures);
                    }
                }
            }
            catch (Exception)
            {
                sigs = null;
            }

            if (sigs != null)
            {
                Delimon.Win32.IO.FileInfo[] filePaths = folderPath.GetFiles();
                
                int index = 0;
                //Load either default signatures or custom for determining ExtensionSupported?
                

                
                foreach (Delimon.Win32.IO.FileInfo filePath in filePaths)
                {
                    if (blShuttingDown)
                    {
                        WriteError(
                            string.Format(
                            @"Audit Folder ContentDetectorEngine: Shutting Down: was about to check file '{0}'.",
                            filePath.FullName), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);
                        break;
                    }
                    try
                    {
                        WriteError(
                        string.Format(
                        @"Audit Folder ContentDetectorEngine: [{0}/{1}] Checking file '{2}' ({3:0,0} bytes).",
                        index + 1, filePaths.Length,
                        filePath.FullName,
                        filePath.Length), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);



                        //Verify File Headers
                        if (!HeaderSignature.ExtensionSupported(filePath.Extension, sigs))
                        {
                            unknownFiles.Add(new FileResult(filePath));
                        }
                        else if (!IsVerifiedContent(filePath, sigs))
                        {
                            unVerifiedFiles.Add(new FileResult(filePath));
                        }
                        else
                        {
                            verifiedFiles.Add(new FileResult(filePath));
                        }

                        //check for prohibited files
                        if (ContainsProhibitedFileContent(filePath, sigs))
                        {
                            ProhibitedFiles.Add(new FileResult(filePath));
                        }

                    }
                    catch (Exception)
                    {
                        WriteError(
                        string.Format(
                        @"Audit Folder ContentDetectorEngine: [{0}/{1}] Error Checking file '{2}' ({3:0,0} bytes).",
                        index + 1, filePaths.Length,
                        filePath.FullName,
                        filePath.Length), System.Diagnostics.EventLogEntryType.Error, 6000, 60, false);
                        unknownFiles.Add(new FileResult(filePath,"Error checking the file"));
                    }


                    index++;
                }
            }
            

            // --

            if (recursive && sigs !=null)
            {
                Delimon.Win32.IO.DirectoryInfo[] folderPaths = folderPath.GetDirectories();

                foreach (Delimon.Win32.IO.DirectoryInfo childFolderPath in folderPaths)
                {
                    bool blIgnoreDirectory = false;
                    if (blShuttingDown)
                    {
                        WriteError(
                            string.Format(
                            @"Audit Folder ContentDetectorEngine: Shutting Down: was about to check folder '{0}'.",
                            childFolderPath.FullName), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);
                        break;
                    }
                    
                    try
                    {
                        
                        char[] delimiters = new char[] { ';' };
                        string[] strArr_excludedfolders = excludeFolders.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                        if (!(strArr_excludedfolders == null || strArr_excludedfolders.Length == 0))
                        {
                            //loop through excluded folders
                            foreach (string strExclude in strArr_excludedfolders)
                            {
                                if (childFolderPath.Name.ToLower() == strExclude.ToLower())
                                {
                                    blIgnoreDirectory = true;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        
                    }
                    
                    if (!blIgnoreDirectory)
                    {
                        ContainsFolderVerifyContent(childFolderPath, recursive, ref verifiedFiles, ref unVerifiedFiles, ref unknownFiles,ref ProhibitedFiles, ref blShuttingDown, excludeFolders,dtSignatures);
                    }
                }
            }

            
        }


        

		// ------------------------------------------------------------------
		#endregion

		#region Private methods.
		// ------------------------------------------------------------------

		

        /// <summary>
        /// Does the content of the check contains file prohibited.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="indentLevel">The nesting depth.</param>
        /// <returns></returns>
        private bool DoVerifyFileHeader(
            Delimon.Win32.IO.FileInfo filePath, HeaderSignature[] sigs)
        {
            if (filePath == null || !filePath.Exists || filePath.Length <= 0)
            {
                return false;
            }
            else
            {
                WriteError(
                    string.Format(
                    @"Audit Folder ContentDetectorEngine: Verifying file '{0}' ({1:0,0} bytes).",
                    filePath.FullName,
                    filePath.Length), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);

                return IsVerifiedContent(filePath, sigs);
            }
        }

		


        /// <summary>
        /// Determines whether File Extension Matches Header of the file
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="indentLevel">The nesting depth.</param>
        /// <returns>
        /// 	<c>true</c> if [is prohibited content] [the specified file path]; otherwise, <c>false</c>.
        /// </returns>
        private bool IsVerifiedContent(Delimon.Win32.IO.FileInfo filePath, HeaderSignature[] sigs)
        {

                return CoreVerifyFileContent(filePath, sigs);
        }

		

		

        /// <summary>
        /// Cores the content of the process file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private bool CoreVerifyFileContent(
            Delimon.Win32.IO.FileInfo filePath, HeaderSignature[] sigs)
        {
            WriteError(
                string.Format(
                @"Audit Folder ContentDetectorEngine: Processing content of file '{0}' ({1:0,0} bytes).",
                filePath.FullName,
                filePath.Length), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);
            bool result;
            SingleFileContentProcessor processor =
                new SingleFileContentProcessor(filePath);

           
            result = processor.VerifyHeaderContent(sigs);
            
            

            if (!result)
            {
                WriteError(
                    string.Format(
                        @"Audit Folder ContentDetectorEngine: Detected Unverified content in file '{0}' ({1:0,0} bytes).",
                        filePath.FullName,
                        filePath.Length), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);
            }
            else
            {
                WriteError(
                    string.Format(
                        @"Audit Folder ContentDetectorEngine: Detected Verified content in file '{0}' ({1:0,0} bytes).",
                        filePath.FullName,
                        filePath.Length), System.Diagnostics.EventLogEntryType.Information, 6000, 60, true);
            }

            return result;
        }

        /// <summary>
        /// Write Event Log Error
        /// </summary>
        /// <param name="strErrorMessage"></param>
        /// <param name="entrytype"></param>
        /// <param name="eventid"></param>
        /// <param name="category"></param>
        /// <param name="blIsDetailedLoggingError"></param>
        private void WriteError(string strErrorMessage, System.Diagnostics.EventLogEntryType entrytype, int eventid, short category, bool blIsDetailedLoggingError)
        {
            //multi threaded so _evt sometimes is not allocated. 
            if (_evt == null)
            {
                _evt = Common.GetEventLog;
            }
            if (blIsDetailedLoggingError == false)
            {
                _evt.WriteEntry(strErrorMessage, entrytype, eventid, category);
            }
            else
            {
                if (DetailedLogging || entrytype == EventLogEntryType.Error)
                {
                    _evt.WriteEntry(strErrorMessage, entrytype, eventid, category);
                }
            }

        }

		// ------------------------------------------------------------------
		#endregion

		#region Private variables.
		// ------------------------------------------------------------------

		/// <summary>
		/// The maximum nesting depth.
		/// </summary>
		private const int maximumNestingDepth = 10;

        private static EventLog _evt;
        
        private bool _detailedLogging = false;
		// ------------------------------------------------------------------
		#endregion
	}

	/////////////////////////////////////////////////////////////////////////
}