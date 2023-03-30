namespace SingleResponsability;

public class Persistance
{
    public void SaveToFile(Journal journal, string fileName, bool overwrite = false)
    {
        if(overwrite || !File.Exists(fileName))
            File.WriteAllText(fileName, journal.ToString());
    }

    public string Load(string fileName)
    {
        string loadedFile = File.ReadAllText(fileName).ToString();

        return loadedFile;
    }
}