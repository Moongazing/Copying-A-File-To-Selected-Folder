namespace Copying_a_file_to_the_selected_folder
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.gBox_SourceFileSelection = new System.Windows.Forms.GroupBox();
      this.btn_SelectFile = new System.Windows.Forms.Button();
      this.txt_FilePath = new System.Windows.Forms.TextBox();
      this.lbl_FilePath = new System.Windows.Forms.Label();
      this.gBox_DestinationPathSelection = new System.Windows.Forms.GroupBox();
      this.btn_SelectFolder = new System.Windows.Forms.Button();
      this.txt_FolderPath = new System.Windows.Forms.TextBox();
      this.lbl_FolderPath = new System.Windows.Forms.Label();
      this.btn_Copy = new System.Windows.Forms.Button();
      this.gBox_SourceFileSelection.SuspendLayout();
      this.gBox_DestinationPathSelection.SuspendLayout();
      this.SuspendLayout();
      // 
      // gBox_SourceFileSelection
      // 
      this.gBox_SourceFileSelection.Controls.Add(this.btn_SelectFile);
      this.gBox_SourceFileSelection.Controls.Add(this.txt_FilePath);
      this.gBox_SourceFileSelection.Controls.Add(this.lbl_FilePath);
      this.gBox_SourceFileSelection.Location = new System.Drawing.Point(12, 12);
      this.gBox_SourceFileSelection.Name = "gBox_SourceFileSelection";
      this.gBox_SourceFileSelection.Size = new System.Drawing.Size(591, 156);
      this.gBox_SourceFileSelection.TabIndex = 0;
      this.gBox_SourceFileSelection.TabStop = false;
      this.gBox_SourceFileSelection.Text = "Source File Selection";
      // 
      // btn_SelectFile
      // 
      this.btn_SelectFile.Location = new System.Drawing.Point(25, 111);
      this.btn_SelectFile.Name = "btn_SelectFile";
      this.btn_SelectFile.Size = new System.Drawing.Size(138, 29);
      this.btn_SelectFile.TabIndex = 2;
      this.btn_SelectFile.Text = "Select File";
      this.btn_SelectFile.UseVisualStyleBackColor = true;
      this.btn_SelectFile.Click += new System.EventHandler(this.btn_SelectFile_Click);
      // 
      // txt_FilePath
      // 
      this.txt_FilePath.Location = new System.Drawing.Point(25, 66);
      this.txt_FilePath.Name = "txt_FilePath";
      this.txt_FilePath.Size = new System.Drawing.Size(547, 27);
      this.txt_FilePath.TabIndex = 1;
      // 
      // lbl_FilePath
      // 
      this.lbl_FilePath.AutoSize = true;
      this.lbl_FilePath.Location = new System.Drawing.Point(25, 33);
      this.lbl_FilePath.Name = "lbl_FilePath";
      this.lbl_FilePath.Size = new System.Drawing.Size(64, 20);
      this.lbl_FilePath.TabIndex = 0;
      this.lbl_FilePath.Text = "File Path";
      // 
      // gBox_DestinationPathSelection
      // 
      this.gBox_DestinationPathSelection.Controls.Add(this.btn_SelectFolder);
      this.gBox_DestinationPathSelection.Controls.Add(this.txt_FolderPath);
      this.gBox_DestinationPathSelection.Controls.Add(this.lbl_FolderPath);
      this.gBox_DestinationPathSelection.Location = new System.Drawing.Point(12, 174);
      this.gBox_DestinationPathSelection.Name = "gBox_DestinationPathSelection";
      this.gBox_DestinationPathSelection.Size = new System.Drawing.Size(591, 156);
      this.gBox_DestinationPathSelection.TabIndex = 3;
      this.gBox_DestinationPathSelection.TabStop = false;
      this.gBox_DestinationPathSelection.Text = "Destination Path Selection";
      // 
      // btn_SelectFolder
      // 
      this.btn_SelectFolder.Location = new System.Drawing.Point(25, 111);
      this.btn_SelectFolder.Name = "btn_SelectFolder";
      this.btn_SelectFolder.Size = new System.Drawing.Size(138, 29);
      this.btn_SelectFolder.TabIndex = 2;
      this.btn_SelectFolder.Text = "Select Folder";
      this.btn_SelectFolder.UseVisualStyleBackColor = true;
      this.btn_SelectFolder.Click += new System.EventHandler(this.btn_SelectFolder_Click);
      // 
      // txt_FolderPath
      // 
      this.txt_FolderPath.Location = new System.Drawing.Point(25, 66);
      this.txt_FolderPath.Name = "txt_FolderPath";
      this.txt_FolderPath.Size = new System.Drawing.Size(547, 27);
      this.txt_FolderPath.TabIndex = 1;
      // 
      // lbl_FolderPath
      // 
      this.lbl_FolderPath.AutoSize = true;
      this.lbl_FolderPath.Location = new System.Drawing.Point(25, 33);
      this.lbl_FolderPath.Name = "lbl_FolderPath";
      this.lbl_FolderPath.Size = new System.Drawing.Size(83, 20);
      this.lbl_FolderPath.TabIndex = 0;
      this.lbl_FolderPath.Text = "Folder Path";
      // 
      // btn_Copy
      // 
      this.btn_Copy.Location = new System.Drawing.Point(37, 336);
      this.btn_Copy.Name = "btn_Copy";
      this.btn_Copy.Size = new System.Drawing.Size(138, 31);
      this.btn_Copy.TabIndex = 4;
      this.btn_Copy.Text = "Copy";
      this.btn_Copy.UseVisualStyleBackColor = true;
      this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(812, 450);
      this.Controls.Add(this.btn_Copy);
      this.Controls.Add(this.gBox_DestinationPathSelection);
      this.Controls.Add(this.gBox_SourceFileSelection);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.gBox_SourceFileSelection.ResumeLayout(false);
      this.gBox_SourceFileSelection.PerformLayout();
      this.gBox_DestinationPathSelection.ResumeLayout(false);
      this.gBox_DestinationPathSelection.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private GroupBox gBox_SourceFileSelection;
    private Button btn_SelectFile;
    private TextBox txt_FilePath;
    private Label lbl_FilePath;
    private GroupBox gBox_DestinationPathSelection;
    private Button btn_SelectFolder;
    private TextBox txt_FolderPath;
    private Label lbl_FolderPath;
    private Button btn_Copy;
  }
}