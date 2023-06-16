
using LevelUpGame.levelup;

namespace GameTests{
    public sealed class FakeCharacterClass : Character
    {

        public FakeCharacterClass(string name) 
            :base(name)
        {
            
        }
        public void setPosition(int XCoordinates, int YCoordinates)
        {
            this.CurrentPosition = new Position(XCoordinates, YCoordinates);
        }

        public GameMap getGameMap()
        {
            return this.GameMap;
        }
    }
}