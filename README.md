# Data Structures
### Array
* There are two types of array structure, includes fixed array and dynamic array.
* Dynamic array based on fixed array, it has a default capacity when we create an instance, if user want to add or remove some elements in array, the capacity of it will be
expanded or shrunk.
---
### Boxing & UnBoxing
* Value Type: Most of them are inherited from struct, includes enum though it belongs to class.
* Reference Type: Most of them are inherited from class, includes interface.

![Test image](https://i.ibb.co/jwwR72F/test.png "Test image")
---
### ArrayGeneric
* **==** & **.equals()**
  * Comparing two value Type with `==` operator will get `true` result, comparing two Reference Type(without string) with `==` operator will get `false` result.
  * The reason is `==` operator used on an expression of type object, it'll resolve to `System.Object.ReferenceEquals`, and `.equals()` compares object content.
* Value Type: Most of them are inherited from struct, includes enum though it belongs to class.
* Reference Type: Most of them are inherited from class, includes interface.
---
### LinkedList
* Making the most of memory, and capacity is equal length.
* Here what I practice was singly linked list, but there also have doubly linked list in the real world.
* In C#，`LinkedList` represents singly linked list,  `LinkedListNode` represents doubly linked list.
* There is no index concept, because it doesn't continuesly create memory space.
---
### Time complexity
* It describes the time that computer takes to run an algorithm.
* Big O
  * Expressed the relationship between the time an algorithm takes and data scale.
  * Constant time as O(1), simply statements and there's no loop.
  * Linear time as O(n), simply statements within loop.
---
### Stack & Queue
* Feature of stack: Last in first out.
  * ArrayStack: Push an element at last, pop an element at last.
  * LinkedListStack: Push an element at first, pop an element at first.

![Test image of Stack](https://i.ibb.co/7bKhz1r/test.png")

* Feature of queue: First in first out. 
  * Enqueue an element at last, dequeue an element at first.
  * Circular Queue:
