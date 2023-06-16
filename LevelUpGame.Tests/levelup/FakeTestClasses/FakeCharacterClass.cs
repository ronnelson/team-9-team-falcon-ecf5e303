using levelup;


namespace LevelUpGame.levelup
{
    public sealed class FakeCharacterClass : Character
    {

        public FakeCharacterClass()
            :base()
        {

        }

        public FakeCharacterClass(string name) 
            :base(name)
        {
            
        }
        public void setPosition(int XCoordinates, int YCoordinates)
        {
           base.CurrentPosition = new Position(XCoordinates, YCoordinates);
        }

        public GameMap getGameMap()
        {
            return base.GameMap;
        }
    }
}