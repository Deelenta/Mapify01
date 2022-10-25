Dictionary<string, string> mydictionary = new Dictionary<string, string>();

mydictionary.Add("Key 1", "Value 1");
mydictionary.Add("Key 2", "Value 2");
mydictionary.Add("Key 3", "Value 3");

string value;
bool hasValue = mydictionary.TryGetValue("Key 3", out value);
if (hasValue)
{
    Console.WriteLine(value);
}
else
{
    Console.WriteLine("Key not present");
}
        
