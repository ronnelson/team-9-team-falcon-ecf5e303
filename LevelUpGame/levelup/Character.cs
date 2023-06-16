using Sharprompt;
using System.Collections;
using System.Drawing;

namespace LevelUpGame.levelup;
public class Character
{
    public static string DefaultName = "Mark";
    private string Name {get;set;}
    private Point CurrentPosition {get;set;}
    public GameMap GameMap {get;set;}
    public Position Position {get;set;}

    public Character()
    {  
        Name = DefaultName;
    }
    public Character(string name)
    {
        Name = name;
    }

    public string GetName()
    {
        return Name;
    }

    public void EnterMap(GameMap map)
    {
        GameMap = map;
        Position = GameMap.StartingPosition;
    }

}