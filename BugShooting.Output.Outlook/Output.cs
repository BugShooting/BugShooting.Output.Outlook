using BS.Plugin.V3.Output;
using System;

namespace BugShooting.Output.Outlook
{

  public class Output: IOutput 
  {

    string name;
    string fileName;
    Guid fileFormatID;
    bool editFileName;

    public Output(string name,
                  string fileName,
                  Guid fileFormatID,
                  bool editFileName)
    {
      this.name = name;
      this.fileName = fileName;
      this.fileFormatID = fileFormatID;
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

    public Guid FileFormatID
    {
      get { return fileFormatID; }
    }

    public bool EditFileName
    {
      get { return editFileName; }
    }

  }
}