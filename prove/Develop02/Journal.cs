class Journal
{
    public List<Entry> _entries;
    
    public void Display()
    {
        // Iterate through each entry in the list and display it.
        Console.WriteLine("Displaying the journal.");
    }

    public void Save(string file)
    {
        // Save all of the entries out to the file.
        Console.Write("Saving the new entry.");
    }

    public void Load(string file)
    {
        // Load all of the entries from the file.
        
    }

    public void AddEntry(Entry entry)
    {
        // Adds this entry to the list.
    }
}