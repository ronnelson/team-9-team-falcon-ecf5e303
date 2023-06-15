using Sharprompt;
using System.Collections;
namespace levelup;
public class Character
{
    public static string DefaultName = "Mark";
    public string Name {get;set;}

    public Character()
    {  
        Name = DefaultName;
    }
    public Character(string name)
    {
        Name = name;
    }

}