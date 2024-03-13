/// <summary>
/// Defines a maze using a dictionary. The dictionary is provided by the
/// user when the Maze object is created. The dictionary will contain the
/// following mapping:
///
/// (x,y) : [left, right, up, down]
///
/// 'x' and 'y' are integers and represents locations in the maze.
/// 'left', 'right', 'up', and 'down' are boolean are represent valid directions
///
/// If a direction is false, then we can assume there is a wall in that direction.
/// If a direction is true, then we can proceed.  
///
/// If there is a wall, then display "Can't go that way!".  If there is no wall,
/// then the 'currX' and 'currY' values should be changed.
/// </summary>
public class Maze {
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap) {
        _mazeMap = mazeMap;
    }

    // Todo Maze Problem - ADD YOUR CODE HERE
    /// <summary>
    /// Check to see if you can move left.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveLeft() {
        // Check the current position
        int currentRow = _currX;
        int currentCol = _currY;

        // Define the key
        var key = (currentRow,currentCol);

        // Get the value of the Dictionary to see if it can move (true or false)
        if (_mazeMap.TryGetValue(key, out var value)) {
            bool canMoveLeft = value[0];

            // If can move, substract one
            if (canMoveLeft) {
                _currX = _currX - 1;
                Console.WriteLine("Move Right: Success");
            } else {
                Console.WriteLine("Can't go that way!");
            }
        }
    }
    

    /// <summary>
    /// Check to see if you can move right.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveRight() {
        // Check the current position
        int currentRow = _currX;
        int currentCol = _currY;

        // Define the key
        var key = (currentRow,currentCol);

        // Get the value of the Dictionary to see if it can move (true or false)
        if (_mazeMap.TryGetValue(key, out var value)) {

            bool canMoveRight = value[1];

            // If can move, add one
            if (canMoveRight) {
                _currX = _currX + 1;
                Console.WriteLine("Move Right: Sucess");
            } else {
                Console.WriteLine("Can't go that way!");
            }
        }
    }

    /// <summary>
    /// Check to see if you can move up.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveUp() {
        // Check the current position
        int currentRow = _currX;
        int currentCol = _currY;

        // Define the key
        var key = (currentRow,currentCol);

        // Get the value of the Dictionary to see if it can move (true or false)
        if (_mazeMap.TryGetValue(key, out var value)) {
            bool canMoveUp = value[2];

            // If can move, substract one
            if (canMoveUp) {
                _currY = _currY - 1;
                Console.WriteLine("Move Up: Success");
            } else {
                Console.WriteLine("Can't go that way!");
            }
        }
    }

    /// <summary>
    /// Check to see if you can move down.  If you can, then move.  If you
    /// can't move, then display "Can't go that way!"
    /// </summary>
    public void MoveDown() {
        // Check the current position
        int currentRow = _currX;
        int currentCol = _currY;

        // Define the key
        var key = (currentRow,currentCol);

        // Get the value of the Dictionary to see if it can move (true or false)
        if (_mazeMap.TryGetValue(key, out var value)) {
            bool canMoveDown = value[3];

            // If can move, add one
            if (canMoveDown) {
                _currY = _currY + 1;
                Console.WriteLine("Move Down: Success");
            } else {
                Console.WriteLine("Can't go that way!");
            }
        }
    }

    public void ShowStatus() {
        Console.WriteLine($"Current location (x={_currX}, y={_currY})");
    }
}