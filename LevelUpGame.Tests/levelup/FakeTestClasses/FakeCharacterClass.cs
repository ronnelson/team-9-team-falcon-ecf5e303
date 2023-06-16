using levelup;


namespace LevelUpGame.levelup
{
    public sealed class FakeCharacterClass : Character
    {

        private Position currentPosition;
        private GameMap gameMap;
        public FakeCharacterClass()
            :base(){}

        public FakeCharacterClass(string name) 
            :base(name)
        {
            
        }

        public FakeCharacterClass(GameMap map) 
            :base()
        {
            this.gameMap = map;
        }

        public void setPosition(int XCoordinates, int YCoordinates)
        {
           this.currentPosition = new Position(XCoordinates, YCoordinates);
        }

        public void setGameMap(GameMap map)
        {
            this.gameMap = map;
        }

        public GameMap getGameMap()
        {
            return this.gameMap;
        }
    }
}