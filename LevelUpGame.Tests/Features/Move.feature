Feature: Move
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position but does increment move count.

@acceptance
Scenario Outline: Move in a direction
    Simple example of how to test move

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player chooses to move in <direction>
    And the current move count is <startingMoveCount>
    When the character moves
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates  <endingPositionY>
    And the new move count is <endingMoveCount>
    Examples:

        | startingPositionX | startingPositionY | direction | startingMoveCount | endingPositionX | endingPositionY | endingMoveCount |
        | 0 | 5 | SOUTH | 5 | 1 | 5 | 6 |
        | 0 | 5 | NORTH | 7 | 0 | 5 | 8 | 
        | 0 | 9 | WEST | 19 | 0 | 9 | 20 | 
        | 0 | 9 | SOUTH | 30 | 0 | 9 | 31 | 
        | 0 | 9 | EAST | 11 | 1 | 9 | 12 | 
        | 2 | 4 | WEST | 15 | 1 | 4 | 16 | 
