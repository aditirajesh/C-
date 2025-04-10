# Object Oriented Programming using C#

## 1. **Basic Data Types, Control Structures, and Methods
    - Write a console application that calculates the factorial of a given number.
    - Read an integer from the user.
    - Validate the input (ensure it’s a positive integer).
    - Use loops (or recursion) to calculate the factorial.
    - Display the result in the console.
    
## 2. **Simple Object-Oriented Programming (OOP)
    - Create a `Person` class with properties and methods.
    - Define properties such as `Name` and `Age`.
    - Implement a method `Introduce()` that prints a personalized greeting.
    - Instantiate a few `Person` objects in your `Main` method and call `Introduce()` on each.
    
## 3. **Basic Collections and String Manipulation
    - Write a program to manage a list of strings (e.g., names or tasks).
    - Use a `List<string>` to store items.
    - Allow the user to add, remove, and display items.
    - Utilize loops and basic string methods (like `Trim()`, `ToUpper()`) to process user input.
    
## 4. **Working with Collections and LINQ
    - Create a student management console application.
    - Define a `Student` class with properties such as `Name`, `Grade`, and `Age`.
    - Populate a collection (e.g., a `List<Student>`) with sample data.
    - Use LINQ to:
        - Filter students who have a grade above a certain threshold.
        - Sort the filtered results by name or grade.
    - Display the filtered and sorted list.
    
## 5. **File I/O and Exception Handling
    - Develop an application that reads from and writes to files.
    - Read text from a file (e.g., a log file or a simple CSV).
    - Process the data (for example, count words or lines).
    - Write the result to a new file.
    - Implement exception handling to manage file-related errors (such as `FileNotFoundException` or `IOException`).
    
## 6. **Delegates, Events, and Basic Event Handling
    - Build a console-based event-driven application (e.g., a counter that triggers an event at a threshold).
    - Define a delegate and an event that fires when a counter reaches a specific value.
    - Create multiple event handler methods that perform actions when the event is raised.
    - In your main loop, increment the counter and raise the event when appropriate.
    - Demonstrate how events can decouple the producer and consumer logic.
    
## 7. **Asynchronous Programming and Multi-threading
    - Develop a console application that performs multiple asynchronous operations concurrently.
    - Use `async` and `await` to fetch data from multiple simulated sources (e.g., using `Task.Delay` to mimic API calls).
    - Aggregate the results once all tasks are complete.
    - Handle exceptions that may occur during asynchronous operations.
    
## 8. **Generics and Interfaces with a Repository Pattern
    - Implement a generic in-memory repository to perform CRUD operations.
    - Define an interface (e.g., `IRepository<T>`) with methods like `Add`, `Get`, `Update`, and `Delete`.
    - Create a generic class that implements this interface.
    - Use type constraints if necessary (e.g., where `T : class` or implementing a specific interface).
    - Write a simple console UI to demonstrate the repository with a sample entity (e.g., `Product` or `Student`).
    
## 9. **Reflection and Custom Attributes
    - Build an application that discovers and executes methods based on custom attributes.
    - Define a custom attribute (e.g., `[Runnable]`).
    - Create several classes with methods decorated with the `[Runnable]` attribute.
    - Use reflection to scan the current assembly for methods marked with `[Runnable]`.
    - Invoke the discovered methods dynamically and display their outputs.
    
## 10. **Building a Mini Microservice with ASP.NET Core
    - Create a small RESTful API that manages a resource (e.g., Products, Orders, or Books) using ASP.NET Core.
    - **Project Setup:**
        - Set up a new ASP.NET Core Web API project.
        - Configure routing and controllers.
    - **Dependency Injection:**
        - Implement a service layer and register services using ASP.NET Core’s dependency injection.
    - **Data Access:**
        - Use Entity Framework Core with an in-memory database (or SQLite) to perform CRUD operations.
    - **Asynchronous Operations:**
        - Use `async`/`await` in your controller actions to handle database operations.
    - **Error Handling and Logging:**
        - Implement middleware or filters for global exception handling.
        - Integrate basic logging to record actions and errors.
    - **Testing and Documentation:**
        - Write unit tests for your controllers and services.
        - Document the API endpoints (using tools like Swagger).
    - **Advanced Considerations (Optional):**
        - Incorporate design patterns such as Repository and Unit of Work.
        - Implement custom middleware for request/response logging or authentication.
