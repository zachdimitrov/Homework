## Data Structures
#### Linear Structures
- Lists
  - static list
```c#
List<int> // default structure in C#
```
  - single linked list
  - double linked list
```c#
// same as this
LinkedList<int> list = new LinkedList<int>;
// our implementation
class Node<T> 
{
    public Node(T value)
    {
        this.Value = value;
    }
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Prev { get; set; }
}
class DoubleLinkedList<T>
{
    private Node<T> start;
    private Node<T> end;
    public void AddStart(T value)
    {
        // implement Add to start
    }
    public void AddEnd(T value)
    {
        // implement Add to end
    }
}
```
- Stacks - only top element is usable
```c#
Stack<int> // default structure in C#
// Push - inserts at top
// Pop - removes from top
```
- Queues - only bottom element is usable
```c# 
Queue<int> // default structure in C#
// Enqueue - adds to head
// Dequeue - removest at head
```
- List Interfaces
  - IEnumerable, IEnumerable<T> - using forEach
  - ICollection, ICollection<T> - using count
  - IList, IList<T> - inherits top 2 interfaces

#### Tree-Like Structures
- Binary
- Ordered search trees
- Balansed
- B-trees
#### Dictionaries
- Contain pairs (key, value)
- Hash tables
#### Sets and Bags
- Set - collection of unique elements
- Bag - non-uniqie elements
#### Ordered sets, Bags
#### Priority queues / heaps
#### Special thee, interval tree, index tree, trie
#### Graphs
- Directed / undirected
- Weighted / un-weighted
- Connected / non-connected

## Algotithms

- Using Pseudo Code
- Using Flowcharts

### Types of algorithms

#### Sorting and Searching
#### Dynamic programming
#### Graph algorithms
- DFS and BFS traversals
#### Combinatorial algorithms
- Recursive algorithms
#### Other algorithms
- Greedy algorithms
- Computational geometry
- Randomised algorithms
- Generic algorithms

### Algotithm Analisis

#### Predict required resources
#### Running time of algorithms
- total number of operations
- algorithm complexity

### complexity
- Worst Case
- Average Case
- Best Case

#### Types of complexity

complexity | notation | description
-- | -- | --
quadratic | O(1) | Constant number of operations regardless the input Data
logaritmic | O(log n) | Proportional but very small number of operations
linear | O(n) | Number of operations is almost same as elements
linear*log | O(n*log n) | Very often appearing complexity
quadratic | O(n^2) | Proportional to square of elements
qubic | O(n^3) | Proportional to cube of elements
exponential | O(2^n), O(k^n), O(n!) | Too complex - 20 elements -> 1 mln operations

#### Multiple variable complexity
#### Polinomial algorithms
