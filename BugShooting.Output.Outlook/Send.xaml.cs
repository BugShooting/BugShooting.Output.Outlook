using System;
using System.Windows;

namespace BugShooting.Output.Outlook
{
  partial class Send : Window
  {

    public Send(string fileName)
    {
      InitializeComponent();

      FileNameTextBox.Text = fileName;

      FileNameTextBox.SelectionChanged += ValidateData;
      ValidateData(null, null);

      FileNameTextBox.SelectAll();
      FileNameTextBox.Focus();
                
    }

    public string FileName
    {
      get { return FileNameTextBox.Text; }
    }

    private void ValidateData(object sender, EventArgs e)
    {
      OK.IsEnabled = Validation.IsValid(FileNameTextBox);
    }

    private void OK_Click(object sender, RoutedEventArgs e)
    {
      this.DialogResult = true;
    }

  }

}
