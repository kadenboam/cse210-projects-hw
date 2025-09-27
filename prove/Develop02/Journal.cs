public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry a)
    {
        _entries.Add(a);
    }
    public void DisplayAllEntries()
    {
        foreach (Entry k in _entries)
        {
            Console.WriteLine("");
            k.DisplayEntry();
        }
    }
    public void DisplayMiracles() {
        foreach (Entry k in _entries)
        {
            Console.WriteLine("");
            k.DisplayEachMiracle();
        }
    }
}