Project Overview
This project is a simple text editor built with Windows Forms in C# (.NET Framework 4.7.2). It provides essential text editing features such as open, save, undo, redo, formatting, and word count, similar to a basic Notepad application.
---
Undo & Redo Functionality
The editor implements custom Undo and Redo features using two stacks (MyStack<string>) to manage the editing history.
•	Undo (Ctrl+Z):
Each time the text changes, the previous state is pushed onto the undoStack. When Undo is triggered, the last state is popped from the undoStack and restored, while the current state is pushed onto the redoStack.
•	Redo (Ctrl+Y):
When Redo is triggered, the last state is popped from the redoStack and restored, and the current state is pushed back onto the undoStack.
•	Stack Management:
After any new text change (not caused by Undo/Redo), the redoStack is cleared to maintain correct history. An internal flag prevents recursive stack updates during programmatic text changes.
This approach ensures users can safely revert or reapply changes step-by-step for a reliable editing experience.
---
Custom Stack Implementation: MyStack<T>
The project uses a custom generic stack class, MyStack<T>, to manage Undo/Redo operations.
Key Features
•	Push(T item): Adds an item to the top of the stack. Automatically resizes the internal array if needed.
•	Pop(): Removes and returns the item at the top of the stack. Throws an exception if the stack is empty.
•	Peek(): Returns the item at the top of the stack without removing it.
•	Clear(): Removes all items from the stack and resets its size.
•	Count / IsEmpty: Properties to check the number of items and whether the stack is empty.

var stack = new MyStack<int>();
stack.Push(1);
stack.Push(2);
int top = stack.Peek(); // top = 2
int removed = stack.Pop(); // removed = 2
bool empty = stack.IsEmpty; // false
stack.Clear();

---
Other Features
•	Open, Save, and Create New Documents:
Users can open existing text files, save their work, or create new editor windows.
•	Undo/Redo Functionality:
Custom undo and redo stacks allow users to revert or reapply changes.
•	Text Editing Tools:
Includes cut, copy, paste, select all, and find functionalities.
•	Formatting Options:
Users can change font, text color, and toggle bullet lists.
•	Zoom Support:
The editor supports zoom in, zoom out, and reset to default zoom, with a display of the current zoom level.
•	Word Count:
Displays the current word count in real time.
•	Insert Date/Time:
Quickly insert the current date and time into the document.
•	Keyboard Shortcuts:
Common actions are accessible via standard keyboard shortcuts (e.g., Ctrl+S to save, Ctrl+Z to undo).
•	About Dialog:
An "About Us" dialog provides information about the application.
---
This application is suitable for basic text editing tasks and demonstrates the use of custom data structures, event handling, and user interface design in Windows Forms.
