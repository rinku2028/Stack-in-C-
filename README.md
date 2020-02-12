# Stack-in-C-
Stack in C#

Stack is a collection which represents Last in First Out(LIFO) conept. For better understaning, an example of stack of books kept on top of each other. 

The concept of las’t in first out in the case of books means that only the top most book can be removed from the stack of books. It is not possible to remove a book from between, because then that would disturb the setting of the stack.

When using last in firt out, add item in list which is called pushing an item and when you remove it, it is known as popping the item in stack. 

So we will implement this LIFO concept in programming with examples.

Following are the characteristics of Class Stack:

Stack capacity is the total number of elements that can hold. When elements are added in stack, automatically the capacity of stack is increased as per the requirement through reallocation.
Stack accepts duplicate elements and null as a valid value.
If count is less than the capacity of the stack, PUSH is an 0(1) operation. If capacity needs to increase the new element, Push becomes 0(n) operation, where n i count of an element. Pop is an 0(1) operation.



