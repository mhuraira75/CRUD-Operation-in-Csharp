**Task Management Application**
A simple task management application built in C#. This program allows users to add, view, search, delete, and update tasks in a task list.

**Features**
Add Task: Add a new task with a name and description.

View Tasks: View all tasks in the list.

Search Task: Search for tasks by name or description.

Delete Task: Delete a task by its ID.

Update Task: Update the name or description of a task by its ID.

Exit: Exit the application.

How to Run the Program
**Prerequisites**
.NET SDK installed on your machine.

**Steps to Run**
Clone or download the project to your local machine.

Open a terminal or command prompt and navigate to the project directory.

Run the following command to build and execute the program: dotnet run

Follow the on-screen instructions to interact with the task management system.

**Code Structure**
The project consists of three main files:

Program.cs: The main entry point of the application. Handles the user interface and menu options.

TaskManagement.cs: Manages the list of tasks and provides methods for adding, viewing, searching, deleting, and updating tasks.

TaskData.cs: Defines the TaskData class, which represents a task with properties like TaskId, TaskName, TaskDescription, and IsTask.

**Usage**
Main Menu
When you run the program, you will see the following menu:
*****Task List*****
[1] Add Task
[2] View Task
[3] Search Task
[4] Delete Task
[5] Update Task
[6] Exit List
Select an option to proceed...

Adding a Task
Select option [1] from the menu.

Enter the task name and description when prompted.

The task will be added to the list, and a confirmation message will be displayed.

Viewing Tasks
Select option [2] from the menu.

All tasks in the list will be displayed with their ID, name, description, and completion status.

Searching for a Task
Select option [3] from the menu.

Enter a search query (task name or description).

All matching tasks will be displayed.

Deleting a Task
Select option [4] from the menu.

Enter the ID of the task you want to delete.

If the task is found, it will be deleted, and a confirmation message will be displayed.

Updating a Task
Select option [5] from the menu.

Enter the ID of the task you want to update.

Enter the new task name and description.

If the task is found, it will be updated, and a confirmation message will be displayed.

Exiting the Program
Select option [6] from the menu.

The program will exit.

**License**
This project is open-source and available under the MIT License.


Author
[Muhammad Huraira]
[muhammadhuraira74@gmail.com]
[(https://github.com/mhuraira75/)]
