namespace WordToHtml
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnExecute = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblSourceFolder = new System.Windows.Forms.Label();
			this.lblDestinationFolder = new System.Windows.Forms.Label();
			this.btnSourceFolder = new System.Windows.Forms.Button();
			this.btnDestinationFolder = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.txtDestinationFolder = new System.Windows.Forms.TextBox();
			this.txtSourceFolder = new System.Windows.Forms.TextBox();
			this.lblSourceFile = new System.Windows.Forms.Label();
			this.lblDestinationFile = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnExecute
			// 
			this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExecute.Location = new System.Drawing.Point(464, 93);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 0;
			this.btnExecute.Text = "E&xecute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.BtnExecute_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(545, 93);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// lblSourceFolder
			// 
			this.lblSourceFolder.AutoSize = true;
			this.lblSourceFolder.Location = new System.Drawing.Point(12, 13);
			this.lblSourceFolder.Name = "lblSourceFolder";
			this.lblSourceFolder.Size = new System.Drawing.Size(76, 13);
			this.lblSourceFolder.TabIndex = 2;
			this.lblSourceFolder.Text = "Source Folder:";
			// 
			// lblDestinationFolder
			// 
			this.lblDestinationFolder.AutoSize = true;
			this.lblDestinationFolder.Location = new System.Drawing.Point(12, 39);
			this.lblDestinationFolder.Name = "lblDestinationFolder";
			this.lblDestinationFolder.Size = new System.Drawing.Size(95, 13);
			this.lblDestinationFolder.TabIndex = 3;
			this.lblDestinationFolder.Text = "Destination Folder:";
			// 
			// btnSourceFolder
			// 
			this.btnSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSourceFolder.Location = new System.Drawing.Point(592, 12);
			this.btnSourceFolder.Name = "btnSourceFolder";
			this.btnSourceFolder.Size = new System.Drawing.Size(26, 23);
			this.btnSourceFolder.TabIndex = 6;
			this.btnSourceFolder.Text = "...";
			this.btnSourceFolder.UseVisualStyleBackColor = true;
			this.btnSourceFolder.Click += new System.EventHandler(this.BtnSourceFolder_Click);
			// 
			// btnDestinationFolder
			// 
			this.btnDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDestinationFolder.Location = new System.Drawing.Point(592, 37);
			this.btnDestinationFolder.Name = "btnDestinationFolder";
			this.btnDestinationFolder.Size = new System.Drawing.Size(26, 23);
			this.btnDestinationFolder.TabIndex = 7;
			this.btnDestinationFolder.Text = "...";
			this.btnDestinationFolder.UseVisualStyleBackColor = true;
			this.btnDestinationFolder.Click += new System.EventHandler(this.BtnDestinationFolder_Click);
			// 
			// txtDestinationFolder
			// 
			this.txtDestinationFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDestinationFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WordToHtml.Properties.Settings.Default, "DestinationFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtDestinationFolder.Location = new System.Drawing.Point(114, 39);
			this.txtDestinationFolder.Name = "txtDestinationFolder";
			this.txtDestinationFolder.Size = new System.Drawing.Size(472, 20);
			this.txtDestinationFolder.TabIndex = 5;
			this.txtDestinationFolder.Text = global::WordToHtml.Properties.Settings.Default.DestinationFolder;
			// 
			// txtSourceFolder
			// 
			this.txtSourceFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSourceFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WordToHtml.Properties.Settings.Default, "SourceFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.txtSourceFolder.Location = new System.Drawing.Point(114, 13);
			this.txtSourceFolder.Name = "txtSourceFolder";
			this.txtSourceFolder.Size = new System.Drawing.Size(472, 20);
			this.txtSourceFolder.TabIndex = 4;
			this.txtSourceFolder.Text = global::WordToHtml.Properties.Settings.Default.SourceFolder;
			// 
			// lblSourceFile
			// 
			this.lblSourceFile.AutoSize = true;
			this.lblSourceFile.Location = new System.Drawing.Point(111, 62);
			this.lblSourceFile.Name = "lblSourceFile";
			this.lblSourceFile.Size = new System.Drawing.Size(0, 13);
			this.lblSourceFile.TabIndex = 8;
			// 
			// lblDestinationFile
			// 
			this.lblDestinationFile.AutoSize = true;
			this.lblDestinationFile.Location = new System.Drawing.Point(111, 75);
			this.lblDestinationFile.Name = "lblDestinationFile";
			this.lblDestinationFile.Size = new System.Drawing.Size(0, 13);
			this.lblDestinationFile.TabIndex = 9;
			// 
			// Form1
			// 
			this.AcceptButton = this.btnExecute;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(630, 125);
			this.Controls.Add(this.lblDestinationFile);
			this.Controls.Add(this.lblSourceFile);
			this.Controls.Add(this.btnDestinationFolder);
			this.Controls.Add(this.btnSourceFolder);
			this.Controls.Add(this.txtDestinationFolder);
			this.Controls.Add(this.txtSourceFolder);
			this.Controls.Add(this.lblDestinationFolder);
			this.Controls.Add(this.lblSourceFolder);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnExecute);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1920, 164);
			this.MinimumSize = new System.Drawing.Size(646, 164);
			this.Name = "Form1";
			this.Text = "WordToHtml";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblSourceFolder;
		private System.Windows.Forms.Label lblDestinationFolder;
		private System.Windows.Forms.TextBox txtSourceFolder;
		private System.Windows.Forms.TextBox txtDestinationFolder;
		private System.Windows.Forms.Button btnSourceFolder;
		private System.Windows.Forms.Button btnDestinationFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label lblSourceFile;
		private System.Windows.Forms.Label lblDestinationFile;
	}
}

