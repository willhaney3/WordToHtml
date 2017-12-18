using System;
using System.Windows.Forms;
using  System.IO;

namespace WordToHtml
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Constants
		private const string SELECT_SOURCE_FOLDER = "Select source folder";
		private const string SELECT_DESTINATION_FOLDER = "Select destination folder";
		private const string ERROR = "Error: ";
		private const string FILES_PROCESSED = " files processed";
		private const string INVALID_DESTINATION_FOLDER = "Invalid destination folder";
		private const string INVALID_SOURCE_FOLDER = "Invalid source folder";
		#endregion

		#region Private Module Variables
		// word to html business object
		private WordToHtmlBo _oWordToHtmlBo = null;
		// file counter
		private int _iFileCounter = 0;

		#endregion
		
		#region Events

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			// cancel application
			CancelApplication();
		}

		private void BtnExecute_Click(object sender, EventArgs e)
		{
			// execute process
			ExecuteProcess();
		}

		private void BtnSourceFolder_Click(object sender, EventArgs e)
		{
			// browse source folder
			BrowseSourceFolder();
		}

		private void BtnDestinationFolder_Click(object sender, EventArgs e)
		{
			// browse destination folder
			BrowseDestinationFolder();
		}

		private void DocConverted(string wordDoc, string htmlDoc)
		{
			// update display
			this.lblSourceFile.Text = wordDoc;
			this.lblDestinationFile.Text = htmlDoc;
			// increment counter
			_iFileCounter++;
		}

		#endregion

		#region Processes
		
		private void ExecuteProcess()
		{
			// check for valid folders
			if (CheckFolders())
			{
				try
				{
					// process files
					ProcessFiles();

				}
				catch (Exception exception)
				{
					MessageBox.Show(ERROR + exception.GetBaseException().ToString());
				}
			}
		}

		private void CancelApplication()
		{
			if (System.Windows.Forms.Application.MessageLoop)
			{
				// WinForms app
				System.Windows.Forms.Application.Exit();
			}
			else
			{
				// Console app
				System.Environment.Exit(1);
			}
		}
		
		private bool CheckFolders()
		{
			// results
			var bResults = true;
			// check source folder
			if (!Directory.Exists(this.txtSourceFolder.Text))
			{
				MessageBox.Show(INVALID_SOURCE_FOLDER);
				bResults = false;
			}
			// check destination folder
			if (!Directory.Exists(this.txtDestinationFolder.Text))
			{
				MessageBox.Show(INVALID_DESTINATION_FOLDER);
				bResults = false;
			}
			return bResults;
		}

		private void ProcessFiles()
		{
			// clear file counter
			_iFileCounter = 0;
			// instantiate word to html business object
			_oWordToHtmlBo = new WordToHtmlBo();
			// hook up event
			_oWordToHtmlBo.FileConverted += new WordToHtmlBo.DelFileConverted(DocConverted);
			// convert documents
			_oWordToHtmlBo.ConvertWordDocsToFilteredHtml(this.txtSourceFolder.Text, this.txtDestinationFolder.Text);
			// display message
			MessageBox.Show(_iFileCounter.ToString() + FILES_PROCESSED);
			// clear display
			this.lblSourceFile.Text = string.Empty;
			this.lblDestinationFile.Text = string.Empty;
		}
		
		private void BrowseSourceFolder()
		{
			// check if current folder selected is valid
			if (Directory.Exists(this.txtSourceFolder.Text))
			{
				folderBrowserDialog1.SelectedPath = txtSourceFolder.Text;
			}
			// display header
			this.folderBrowserDialog1.Description = SELECT_SOURCE_FOLDER;
			// show browser, check for ok button
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				// update display with folder selected
				this.txtSourceFolder.Text = this.folderBrowserDialog1.SelectedPath;
				// save settings
				SaveSettings();
			}
		}
		
		private void BrowseDestinationFolder()
		{
			// check if current folder selected is valid
			if (Directory.Exists(this.txtDestinationFolder.Text))
			{
				folderBrowserDialog1.SelectedPath = txtDestinationFolder.Text;
			}
			// display heder
			this.folderBrowserDialog1.Description = SELECT_DESTINATION_FOLDER;
			// show browser, check for ok button
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				// update display with folder selected
				this.txtDestinationFolder.Text = this.folderBrowserDialog1.SelectedPath;
				// save settings
				SaveSettings();
			}
		}

		private void SaveSettings()
		{
			// save settings
			Properties.Settings.Default.Save();
		}

		#endregion

	}
}
