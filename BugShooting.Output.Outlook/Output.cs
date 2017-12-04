using BS.Plugin.V3.Output;

namespace BugShooting.Output.Outlook
{

  public class Output: IOutput 
  {

    string name;
    string fileName;
    string fileFormat;
    bool editFileName;

    public Output(string name,
                  string fileName,
                  string fileFormat,
                  bool editFileName)
    {
      this.name = name;
      this.fileName = fileName;
      this.fileFormat = fileFormat;
      this.editFileName = editFileName;
    }

    public string Name
    {
      get { return name; }
    }

    public string Information
    {
      get { return string.Empty; }
    }

    public string FileName
    {
      get { return fileName; }
    }

    public string FileFormat
    {
      get { return fileFormat; }
    }

    public bool EditFileName
    {
      get { return editFileName; }
    }

  }
}
