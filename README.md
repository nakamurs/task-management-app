# TaskManagerApp

## Description
**TaskManagerApp** is a web application developed using **C#** and **ASP.NET MVC**. This application allows users to manage tasks through a user-friendly interface where they can add, edit, and delete the tasks.

### Project Structure
- **Controllers**
  - [`TasksController.cs`](TaskManagerApp/Controllers/TasksController.cs): Handles the operations for tasks. It manages the logic for reading, creating, editing, and deleting tasks, as well as toggling their completion status.

- **Models**
  - [`TaskItem.cs`](TaskManagerApp/Models/TaskItem.cs): Defines the data structure for a task, including properties like `Id`, `Title`, `Description`, `DueDate`, and `IsCompleted`.

- **Views**
  - [`Index.cshtml`](TaskManagerApp/Views/Tasks/Index.cshtml): Displays the list of tasks in a table format, allowing users to interact with each task.
  - [`Create.cshtml`](TaskManagerApp/Views/Tasks/Create.cshtml): Provides a form for users to create a new task.
  - [`Edit.cshtml`](TaskManagerApp/Views/Tasks/Edit.cshtml): Allows users to update the details of an existing task.
  - [`Delete.cshtml`](TaskManagerApp/Views/Tasks/Delete.cshtml): Confirms the deletion of a task.

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
   dotnet restore
5. Run the application:
   ```bash
   dotnet run
6. Open a web browser and go to <https://localhost:7089> or <http://localhost:5021> to view the application.

**Note on Running the Application:**

When you run the application, it will utilize the URLs specified in the above [`launchSettings.json`](TaskManagerApp/Properties/launchSettings.json) file.<br> 
Here are some important considerations:

  * **Localhost Access**: The application is configured to run on your local machine (localhost). Make sure the specified ports are not already in use by other applications. If they are, you may need to change the ports in [`launchSettings.json`](TaskManagerApp/Properties/launchSettings.json).
  * **HTTPS Configuration**: If you are accessing the application over HTTPS and encounter issues, ensure that your environment is set up to handle SSL certificates for the specified ports. You may need to trust a self-signed certificate if one is used.
  * **Environment Variables**: Ensure that any necessary environment variables, as defined in `launchSettings.json`, are configured properly in your development environment.

By keeping these points in mind, you should be able to run the application without issues. If you encounter any problems, feel free to reach out for assistance!

## Contributing
This project is primarily for personal use and to showcase my skills. However, if you have any suggestions or feedback, feel free to reach out to me directly.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.


