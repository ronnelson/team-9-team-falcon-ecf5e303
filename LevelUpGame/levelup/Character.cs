using Sharprompt;
using System.Collections;
using System.Drawing;
using static levelup.GameController;

namespace LevelUpGame.levelup
{
    public class Character
    {
        public static string DefaultName = "Mark";
        private string Name {get;set;}
        public Position CurrentPosition {get;set;}
        public GameMap GameMap {get;set;}

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
            CurrentPosition = GameMap.StartingPosition;
        }

        public Position GetPosition()
        {
            return CurrentPosition;
        }

        public void Move(DIRECTION direction)
        {
            var movedPosition =  GameMap.CalculatePosition(CurrentPosition, direction);
            CurrentPosition = movedPosition;
        }
    }
}