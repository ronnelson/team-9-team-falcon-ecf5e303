using levelup;


namespace LevelUpGame.levelup
{
    public sealed class FakeCharacterClass : Character
    {

        private Position currentPosition;
        public FakeCharacterClass()
            :base(){}

        public FakeCharacterClass(string name) 
            :base(name)
        {
            
        }
        public void setPosition(int XCoordinates, int YCoordinates)
        {
           this.currentPosition = new Position(XCoordinates, YCoordinates);
        }

        public GameMap getGameMap()
        {
            return base.GameMap;
        }
    }
}