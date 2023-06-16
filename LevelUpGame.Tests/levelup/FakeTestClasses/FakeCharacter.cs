using levelup;


namespace LevelUpGame.levelup
{
    public sealed class FakeCharacter : Character
    {

        private Position currentPosition;
        private GameMap gameMap;
        public FakeCharacter()
            :base(){}

        public FakeCharacter(string name) 
            :base(name)
        {
            
        }

        public FakeCharacter(GameMap map) 
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