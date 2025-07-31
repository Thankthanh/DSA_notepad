# Text Editor Application - Windows Forms Project

## Project Overview
This is a **Windows Forms text editor application** built using C# and .NET Framework 4.7.2. The project demonstrates the implementation of fundamental data structures and algorithms, specifically focusing on **Stack data structure** for implementing undo/redo functionality.

## Key Features

### 1. **Core Text Editor Functionality**
- **Rich Text Editing**: Uses RichTextBox control for advanced text formatting
- **File Operations**: Open, save, and create new text files (.txt format)
- **Text Formatting**: Font selection, color customization, and bullet list support
- **Zoom Controls**: Zoom in/out functionality with percentage display (10%-500% range)

### 2. **Undo/Redo System**
- **Custom Stack Implementation**: Uses a generic `MyStack<T>` class for managing undo/redo operations
- **Real-time Tracking**: Automatically tracks text changes and stores previous states
- **Keyboard Shortcuts**: Ctrl+Z for undo, Ctrl+Y for redo
- **Memory Management**: Efficient stack operations with dynamic array resizing

### 3. **Search and Replace**
- **Find Functionality**: Search for text with case-sensitive matching
- **Highlight Results**: Yellow highlighting of all matching text
- **Replace Feature**: Replace all occurrences of text
- **Dedicated Form**: Separate `FindForm` for search operations

### 4. **User Interface Features**
- **Menu System**: Comprehensive menu with File, Edit, Format, View, and Help options
- **Keyboard Shortcuts**: Standard shortcuts (Ctrl+N, Ctrl+O, Ctrl+S, Ctrl+F, etc.)
- **Word Counter**: Real-time word count display
- **Date/Time Insertion**: F5 shortcut to insert current date/time

### 5. **Data Structure Implementation**
- **Custom Stack Class**: `MyStack<T>` with the following operations:
  - `Push()`: Add item to stack
  - `Pop()`: Remove and return top item
  - `Peek()`: View top item without removal
  - `Clear()`: Empty the stack
  - `IsEmpty`: Check if stack is empty
  - Dynamic array resizing for efficient memory usage

#### **Detailed MyStack Implementation**
The `MyStack<T>` class is a custom implementation of the Stack data structure using a generic array:

**Core Components:**
- `private T[] _items`: Internal array to store stack elements
- `private int _count`: Tracks the number of elements in the stack
- `public int Count`: Property to get current element count
- `public bool IsEmpty`: Property to check if stack is empty

**Key Operations:**
1. **Constructor**: Initializes with array size of 4 elements
2. **Push(T item)**: 
   - Checks if array is full, doubles size if needed
   - Adds item to top of stack (LIFO principle)
   - Increments count
3. **Pop()**: 
   - Returns and removes top element
   - Decrements count
   - Clears the position to prevent memory leaks
4. **Peek()**: 
   - Returns top element without removing it
   - Throws exception if stack is empty
5. **Clear()**: 
   - Resets count to 0
   - Reinitializes array to default size

**Memory Management:**
- Dynamic resizing: Array doubles in size when full (4→8→16→32...)
- Efficient memory usage with automatic garbage collection
- Prevents stack overflow through automatic expansion

## Technical Architecture

### **Project Structure**
- **Main Form** (`Form1.cs`): Primary text editor interface
- **Custom Stack** (`MyStack.cs`): Generic stack implementation
- **Find Form** (`FindForm.cs`): Search and replace functionality
- **About Form** (`AboutForm.cs`): Team information display

### **Key Components**
1. **Form1**: Main application window with RichTextBox, menus, and controls
2. **MyStack<T>**: Generic stack data structure for undo/redo operations
3. **FindForm**: Modal dialog for text search and replace
4. **AboutForm**: Information dialog showing team members

### **Data Flow**
- Text changes trigger `TextChanged` event
- Previous text states are pushed to `undoStack`
- Undo operations move states from `undoStack` to `redoStack`
- Redo operations reverse the process

#### **Stack Usage in Undo/Redo System**
The application uses two `MyStack<string>` instances:

**Undo Stack (`undoStack`):**
- Stores previous text states before each change
- When user types/edits: previous text → `undoStack`
- When user presses Ctrl+Z: top state → current text, current text → `redoStack`

**Redo Stack (`redoStack`):**
- Stores text states that can be "redone"
- When user presses Ctrl+Y: top state → current text, current text → `undoStack`
- Cleared when new text changes occur (prevents invalid redo states)

**Example Flow:**
1. User types "Hello" → `undoStack` contains [""]
2. User types "Hello World" → `undoStack` contains ["", "Hello"]
3. User presses Ctrl+Z → text becomes "Hello", `redoStack` contains ["Hello World"]
4. User presses Ctrl+Y → text becomes "Hello World", `undoStack` contains ["", "Hello", "Hello World"]

## Educational Value
This project serves as an excellent example of:
- **Data Structure Implementation**: Custom stack with generic types
- **Windows Forms Development**: Modern UI design and event handling
- **Algorithm Design**: Efficient undo/redo system
- **Software Engineering**: Modular code organization and separation of concerns

## Requirements
- .NET Framework 4.7.2 or higher
- Visual Studio 2017 or later
- Windows Operating System

## How to Run
1. Open the project in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Run the application (F5)

## Features Summary
- ✅ Text editing with rich formatting
- ✅ File operations (Open/Save/New)
- ✅ Undo/Redo functionality using custom stack
- ✅ Search and replace with highlighting
- ✅ Zoom controls (10%-500%)
- ✅ Word counter
- ✅ Keyboard shortcuts
- ✅ Font and color customization
- ✅ Bullet list support
- ✅ Date/time insertion

This text editor demonstrates practical application of data structures and algorithms in a real-world software development context, making it an excellent learning project for understanding both theoretical concepts and their practical implementation. 
