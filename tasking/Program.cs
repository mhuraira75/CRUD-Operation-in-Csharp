using System;
using tasking.data;
using tasking.management;

namespace tasking
{
    public class Program
    {
        public static void Main(string[] args) {
            Console.WriteLine("*****Task List*****");
            Console.WriteLine("*******************");
            var taskManagement = new TaskManagement();

            bool runprogram = true;
            while (runprogram) 
            {
                Console.WriteLine("[1] Add Task");
                Console.WriteLine("[2] View Task");
                Console.WriteLine("[3] Search Task");
                Console.WriteLine("[4] Delete Task");
                Console.WriteLine("[5] Exit List");
                Console.WriteLine("Select an option to proceed...");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        AddTask(taskManagement);
                        break; 
                    case 2:
                        ViewTask(taskManagement);
                        break;
                    case 3:
                        SearchTask(taskManagement);
                        break;
                    case 4:
                        DeleteTask(taskManagement);
                        break;
                    case 5:
                        UpdateTask(taskManagement);
                        break;
                    case 6:
                        Console.WriteLine("List exited.");
                        runprogram = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option selection. Please choose correct option....");
                        break;
                }
            }
        }
        public static void AddTask(TaskManagement taskManagement)
        {
            Console.WriteLine("Add task name....\n");
            string taskname = Console.ReadLine();
            Console.WriteLine("Add task description....\n");
            string taskdescription = Console.ReadLine();

            taskManagement.Addtask(new TaskData() { TaskName = taskname , TaskDescription = taskdescription});
        }
        public static void ViewTask(TaskManagement taskManagement)
        {
            var tasks = taskManagement.GetTasks();
            if (!tasks.Any())
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                foreach (var task in tasks)
                {
                    Console.WriteLine($"{task.TaskId} , {task.TaskName} , {task.TaskDescription} , {task.IsTask = true}");
                }
            }
        }
        public static void SearchTask(TaskManagement taskManagement)
        {
            Console.WriteLine("Enter task name or description to search:....");
            string query = Console.ReadLine();
            var result = taskManagement.GetAlltasks(query);
            if (!result.Any())
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                foreach (var task in result)
                {
                    Console.WriteLine($"{task.TaskId} , {task.TaskName} , {task.TaskDescription} , {task.IsTask = true}");
                }
            }
        }
        public static void DeleteTask(TaskManagement taskManagement)
        {
            Console.WriteLine("Enter the ID of the task to delete:");
            int taskId;
            while (!int.TryParse(Console.ReadLine(), out taskId))
            {
                Console.WriteLine("Invalid input. Please enter a valid task ID.");
            }

            bool isDeleted = taskManagement.DeleteTask(taskId);
            if (isDeleted)
            {
                Console.WriteLine("Task deleted successfully.");
            }
            else
            {
                Console.WriteLine("Task deletion failed. Task ID not found.");
            }
        }
        public static void UpdateTask(TaskManagement taskManagement)
        {
            Console.WriteLine("Enter the ID of the task to update:");
            int taskId;
            while (!int.TryParse(Console.ReadLine(), out taskId))
            {
                Console.WriteLine("Invalid input. Please enter a valid task ID.");
            }

            Console.WriteLine("Enter the new task name:");
            string newTaskName = Console.ReadLine();

            Console.WriteLine("Enter the new task description:");
            string newTaskDescription = Console.ReadLine();

            bool isUpdated = taskManagement.UpdateTask(taskId, newTaskName, newTaskDescription);
            if (isUpdated)
            {
                Console.WriteLine("Task updated successfully.");
            }
            else
            {
                Console.WriteLine("Task update failed. Task ID not found.");
            }
        }
    }
}