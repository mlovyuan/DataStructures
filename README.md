# Data Structures
### Array
* There are two types of array structure, includes fixed array and dynamic array.
* Dynamic array based on fixed array, it has a default capacity when we create an instance, if user want to add or remove some elements in array, the capacity of it will be
expanded or shrunk.
---
### Boxing & UnBoxing
* Value Type: Most of them are inherited from struct, includes enum though it belongs to class.
* Reference Type: Most of them are inherited from class, includes interface.
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
