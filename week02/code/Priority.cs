public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        //Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the following people and priority: Bob (2), Tim (5), Sue (3)
        // Expected Result: Tim, Sue, Bob
        Console.WriteLine("Test 1");

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        while (priorityQueue.Count() > 0)
            Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 1) The loop to find the maximum priority was not including the last element
        // 2) After finding the highest index the element was not being removed.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with the following people and priority: Peter(3), Bob (2), Tim (5), Sue (3), George(3)
        // Expected Result: Tim, Peter, Sue, George, Bob
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("Peter", 3);
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("George", 3);

        while (priorityQueue.Count() > 0)
            Console.WriteLine(priorityQueue.Dequeue());
        
        // Defect(s) Found: When there were several elements with the same priority, the last
        // element was being deleted instead of the first

        Console.WriteLine("---------");

         // Test 3
        // Scenario: Try to get the next person from an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        // Defect(s) Found: No problems found
    }
}