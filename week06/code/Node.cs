public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data){
        // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }   
        // If values is equal to Data do nothing       
    }

    public bool Contains(int value) {
        // If the element is found return true
        if (value == Data)
            return true;
        
        if (value < Data) {
            // If it is null there is no element and return false
            if (Left is null)
                return false;
            else
                // Recursive call to the left
                return Left.Contains(value);
        }
        else {
            // If it is null there is no element and return false
            if (Right is null)
                return false;
            else
                // Recursive call to the right
                return Right.Contains(value);
        }
    }

    // Tree height
    public int GetHeight() {
        // If no elements return 0
        if (this is null)
            return 0;

        // Recursively calculate the height of the left subtree
        int leftHeight;
        if (Left != null) {
            leftHeight = Left.GetHeight();
        }
        else {
            leftHeight = 0;
        }

        // Recursively calculate the height of the right subtree
        int rightHeight;
        if (Right != null) {
            rightHeight = Right.GetHeight();
        }
        else {
            rightHeight = 0;
        }
        
        // Return the maximum height of the left and right subtrees, plus 1 for the current node
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}