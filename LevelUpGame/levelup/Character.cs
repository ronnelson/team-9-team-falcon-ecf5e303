using Sharprompt;
using System.Collections;
namespace levelup;
public class Character
{
    public static string DefaultName = "Mark";
    public string Name {get;set;}

    public Character()
    {    }
    public Character(string name)
    {
        Name = name;
    }

}