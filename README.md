# HeadFirstDesignPattern
Head First Design Pattern: my notes taken from the book and exercises that I practiced.

---

## 1 Strategy Pattern
### 1 Strategy
Strategy defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
### 2 Shared language
Patterns provide a shared language that can maximize the value of your communication with other developers.

## 2 Observer Pattern
### Design Principles
* Identify the aspects of your application that vary and separate them from what stays the same.
  * The thing that varies in the Observer Pattern is the state of the Subject and the number and types of Observers. With this pattern, you can vary the objects that are dependent on the state of the Subject, without having to change that Subject. That's called planning ahead.

* Program to an interface, not an implementation.
 * Both the Subject and Observer use interfaces. The Subject keeps track of objects implementing the Observer interface, while the observers register with and get notified by, the Subject interface. This keeps things nice and loosely coupled.

* Favor composition over inheritance.
 * The Observer Pattern uses composition to compose any number of Observers with their Subjects. These relationships aren't set up by some kind of inheritance hierarchy. No, they are set up at runtime by composition.

