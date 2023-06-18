# Assignment: Library Management System

The goal of this assignment is to implement a basic Library Management System as a C# console application. This application will help you practice key principles of Object-Oriented Programming: Encapsulation, Abstraction, Inheritance, and Polymorphism.

## Description

A library has books and users. Users can be either cutomers or librarians. Librarians can add or remove books from the library and also can issue books to customers. Customers can request to borrow or return books. Also, library can have different types of books (Comic, Novel, TextBook, ResearchPaper) as well.

Your job is to model this system using classes, interfaces, and/or abstract classes as you see fit.

## Features

1. `Library` should manage the collection of Book objects, and `Person` objects. This class should have following methods:
   - Add, Remove, Borrow, and Return books
   - Add, Remove, Edit `Person` objects
2. `Person` has properties such as Name and ID. `Customer` and `Librarian` should inherit from this class and have additional properties/features:
   - `Customer` can Borrow and Return books.
   - `Librarian` can Add, Remove, Edit books.
3. `Book` has properties like Title, Author, ISBN, PublicationYear, CanBorrow, and CanPrint. To simplify the logic, we can consider each book an unique record with unique ISBN in the `Library`. In addition, `Book` has `PrintInfo()` method to print information about each book (uses `Console.WriteLine`). `Comic`, `Novel`, `TextBook`, and `ResearchPaper`should inherit properties from `Book` and have additional properties/features:
   - `Comic` has `Artist`, `Novel` has `Genre`
   - `Comic`, `Novel`, `TextBook` can be borrowed, but `ResearchPaper` cannot. If books are borrowable, they should have both `Borrow()` and `Return()` method
   - `TextBook`, and `ResearchPaper` can be printed (to certain amount of pages), but `Comic`, `Novel` cannot. The `PrintPages(int startPage, endPage)`method uses `Console.WriteLine` to inform the start page and end page to be printed, in case the amount of to-be-printed pages do not exceed the maximum allowed pages.
   - `Comic`and `Novel` should have different implementations of `PrintInfo()` with extra information about the extra properties, while `TextBook`, and `ResearchPaper` have default implementation.

## Requirements

1. Encapsulation: Use proper encapsulation for the fields in your classes. Use access modifiers to limit the access to the class members.

2. Abstraction: Use abstract classes/interfaces where necessary. Think about what methods are common to certain objects and could be abstracted into a superclass or interface.

3. Inheritance: Make use of inheritance. There should be a clear hierarchy and use of both base and derived classes.

4. Polymorphism: Your program should utilize polymorphism, allowing objects to decide which methods should be invoked.

## Results
Create books & library
![Create books & library](src/demo%20photos/create%20books%20%26%20library.png)

Create users: Customer & Librarian.
Only librarian can edit a book's information
![create users & edit book](src/demo%20photos/create%20users%2C%20edit%20book%20info.png)


Customers can borrow & return books
![borrow & return books](src/demo%20photos/borrow%20%26%20return%20book.png)

Customers can borrow Comic, Novel, Textbook, but not Research Paper
![can not borrow research paper](src/demo%20photos/can%20not%20borrow%20research%20paper.png)
