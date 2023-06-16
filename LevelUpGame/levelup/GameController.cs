using LevelUpGame.levelup;
using System.Drawing;

namespace levelup
{
    public class GameController
    {
        public readonly string DEFAULT_CHARACTER_NAME = "Character";

        private Character Character;
        private GameMap GameMap;

        public record struct GameStatus(
            // TODO: Add other status data
            String characterName,
            Point currentPosition,
            int moveCount
            );

        // TODO: Ensure this AND CLI commands match domain model
        public enum DIRECTION
        {
            NORTH, SOUTH, EAST, WEST
        }

        GameStatus status = new GameStatus();

        public GameController()
        {
            status.characterName = DEFAULT_CHARACTER_NAME;
            //Set current position to a nonsense place until you figure out who should initialize
            status.currentPosition = new Point(-1,-1);
            //TODO: Write a failing unit test that will force you to set this to the right number
            status.moveCount = -100;
        }

        // Pre-implemented to demonstrate ATDD
        // TODO: Update this if it does not match your design
        public void CreateCharacter(String name = null)
        {
            Character = new Character(name);
            status.characterName = name;
        }

        public void StartGame()
        {
            GameMap = new GameMap();
            GameMap.Init();

            if (Character == null)
            {
                this.CreateCharacter();
            }

            Character.EnterMap(GameMap);
        }

        public GameStatus GetStatus()
        {
            return this.status;
        }

        public void Move(DIRECTION directionToMove)
        {
            //TODO: Implement move - should call something on another class
            //TODO: Should probably also update the game status
        }

        public void SetCharacterPosition(Point coordinates)
        {
            //TODO: IMPLEMENT THIS TO SET CHARACTERS CURRENT POSITION -- exists to be testable
        }

        public void SetCurrentMoveCount(int moveCount)
        {
            //TODO: IMPLEMENT THIS TO SET CURRENT MOVE COUNT -- exists to be testable
        }

        public int GetTotalPositions()
        {
            //TODO: IMPLEMENT THIS TO GET THE TOTAL POSITIONS FROM THE MAP -- exists to be testable
            return -10;
        }

        public Character GetCharacter()
        {
            return Character;
        }
    }
}