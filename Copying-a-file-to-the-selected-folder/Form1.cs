namespace Copying_a_file_to_the_selected_folder
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    string fileName;
    private void ClearFields()
    {
      txt_FilePath.Text = string.Empty;
      txt_FolderPath.Text = string.Empty;  
    }
    private void EnabledFields()
    {
      txt_FilePath.Enabled = false;
      txt_FolderPath.Enabled = false; 
    }
    private void btn_SelectFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog ofd = new OpenFileDialog();
      ofd.Title = "Please select file to copy.";
      if (ofd.ShowDialog() == DialogResult.OK)
      {
        txt_FilePath.Text = ofd.FileName;
        fileName = ofd.SafeFileName;
      }
      else
      {
        MessageBox.Show("Please select a file to copy!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btn_SelectFolder_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog fbd = new FolderBrowserDialog();
      if (fbd.ShowDialog() == DialogResult.OK)
      {
        txt_FolderPath.Text = fbd.SelectedPath;
      }
      else
      {
        MessageBox.Show("Please select a folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void btn_Copy_Click(object sender, EventArgs e)
    {
      if (!string.IsNullOrEmpty(txt_FilePath.Text) && !string.IsNullOrEmpty(txt_FolderPath.Text))
      {
        if (File.Exists(txt_FolderPath.Text + "\\" + fileName))
        {
          MessageBox.Show("This file already exists in the specified folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else
        {
          File.Copy(txt_FilePath.Text, txt_FolderPath.Text + "/" + fileName);
          MessageBox.Show("Copy to "+txt_FolderPath.Text+" of file named "+fileName+" successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
          ClearFields();

        }
      }
      else
      {
        MessageBox.Show("Please select a file and folder.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      EnabledFields();
      ClearFields();
    }
  }
}