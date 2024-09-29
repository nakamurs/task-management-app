# TaskManagerApp

## Description
**TaskManagerApp** is a web application developed using **C#** and **ASP.NET MVC**. This application allows users to manage tasks through a user-friendly interface where they can add, edit, and delete the tasks.

### Project Structure
- **Controllers**
  - [`TasksController.cs`](Controllers/TasksController.cs): Handles the operations for tasks. It manages the logic for reading, creating, editing, and deleting tasks, as well as toggling their completion status.

- **Models**
  - [`TaskItem.cs`](Models/TaskItem.cs): Defines the data structure for a task, including properties like `Id`, `Title`, `Description`, `DueDate`, and `IsCompleted`.

- **Views**
  - [`Index.cshtml`](Views/Tasks/Index.cshtml): Displays the list of tasks in a table format, allowing users to interact with each task.
  - [`Create.cshtml`](Views/Tasks/Create.cshtml): Provides a form for users to create a new task.
  - [`Edit.cshtml`](Views/Tasks/Edit.cshtml): Allows users to update the details of an existing task.
  - [`Delete.cshtml`](Views/Tasks/Delete.cshtml): Confirms the deletion of a task.

- **wwwroot**
  - Contains static files such as CSS, JavaScript, and images.

## Installation and Usage Guide
1. Clone the repository:
   ```bash
   git clone https://github.com/nakamurs/task-management-app.git
2. Navigate to the project directory
   ```bash
   cd task-management-app/TaskManagerApp
3. Open the project in Visual Studio or your preferred IDE.
4. Restore the necessary packages by running:
   ```bash
   dotnet resotre
5. Run the application:
   ```bash
   dotnet run
6. Open a web browser and go to <https://localhost:7089> or <http://localhost:5021> to view the application.
   **Warning:** 

This application is for development purposes only and may be running on an unsecured connection. Please do not enter any sensitive information, such as passwords or personal data, while using this application. 

## Contributing
Feel free to fork the repository and submit pull requests. Contributions are welcome!

## License
This project is licensed under the MIT License.

