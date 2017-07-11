using System.Windows;
using System.Windows.Input;

namespace BS.Output.Outlook
{
  partial class Send : Window
  {

    public Send(string fileName)
    {
      InitializeComponent();

      FileNameTextBox.Text = fileName;
      FileNameTextBox.SelectAll();
      FileNameTextBox.Focus();

    }

    public string FileName
    {
      get
      {
        return FileNameTextBox.Text;
      }
    }

    private void OK_Click(object sender, RoutedEventArgs e)
    {
      this.DialogResult = true;
    }

    private void Cancel_Click(object sender, RoutedEventArgs e)
    {
      this.DialogResult = false;
    }

    protected override void OnPreviewKeyDown(KeyEventArgs e)
    {
      base.OnPreviewKeyDown(e);

      switch (e.Key)
      {
        case Key.Enter:
          OK_Click(this, e);
          break;
        case Key.Escape:
          Cancel_Click(this, e);
          break;
      }

    }
    
  }

}
