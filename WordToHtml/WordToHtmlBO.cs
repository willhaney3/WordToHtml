using System.IO;

namespace WordToHtml
{
	class WordToHtmlBo
	{

		#region Constants
		private const string WORD_DOCUMENT_FILE_EXTENSION_WILDCARD = "*.docx";
		private const string HTML_DOCUMENT_FILE_EXTENSION = ".html";
		#endregion

		#region Delegates and Events
		public delegate void DelFileConverted(string sourceFile, string destinationFile);
		public event DelFileConverted FileConverted;
		#endregion

		public void ConvertWordDocsToFilteredHtml(string sourceFolder, string destinationFolder)
		{
			// office application
			var oApplication = new Microsoft.Office.Interop.Word.Application();
			// word coument
			Microsoft.Office.Interop.Word.Document oDocument = null;
			// missing paramater
			object oMissing = System.Reflection.Missing.Value;
			// destination full file name
			var sDestinationFullFileName = string.Empty;

			// get all word document file names from source folder
			var files = Directory.GetFileSystemEntries(sourceFolder, WORD_DOCUMENT_FILE_EXTENSION_WILDCARD);
			// loop through each file
			foreach (var file in files)
			{
				// build destination full file path to html file
				sDestinationFullFileName = Path.Combine(destinationFolder, Path.GetFileNameWithoutExtension(file) + HTML_DOCUMENT_FILE_EXTENSION);
				// check if file exists
				if (File.Exists(sDestinationFullFileName))
				{
					// delete file
					File.Delete(sDestinationFullFileName);
				}
				// open word document read only
				oDocument = oApplication.Documents.Open(file, null, true);

				// attempt conversion
				try
				{
					// save word document as filtered html
					oDocument.SaveAs(sDestinationFullFileName, Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatFilteredHTML, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing);
				}
				catch
				{
					// do nothing, just need to close the doc
				}
				finally
				{
					// close word document
					oDocument.Close();
				}

				// throw event
				FileConverted(Path.GetFileName(file), Path.GetFileName(sDestinationFullFileName));
			}

		}
	}
}
