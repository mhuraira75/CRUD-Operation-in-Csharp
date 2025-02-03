using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tasking.data;

namespace tasking.management
{
    public class TaskManagement
    {
        private readonly List<TaskData> _tasks = new();

        public void Addtask(TaskData taskData)
        {
            taskData.TaskId = _tasks.Count + 1;
            _tasks.Add(taskData);
            Console.WriteLine($"\n {taskData.TaskId} , {taskData.TaskName} , {taskData.TaskDescription} successfully added.\n");
        }
        public IEnumerable<TaskData> GetTasks()
        {
            return _tasks;
        }

        public IEnumerable<TaskData> GetAlltasks(string query)
        {
            return _tasks.Where(a => 
            a.TaskName.Contains(query, StringComparison.OrdinalIgnoreCase ) ||
            a.TaskDescription.Contains(query, StringComparison.OrdinalIgnoreCase ));
        }
        public bool DeleteTask(int taskId)
        {
            var taskToRemove = _tasks.FirstOrDefault(t => t.TaskId == taskId);
            if (taskToRemove != null)
            {
                _tasks.Remove(taskToRemove);
                Console.WriteLine($"Task with ID {taskId} has been deleted.");
                return true; 
            }
            else
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return false; 
            }
        }
        public bool UpdateTask(int taskId, string newTaskName, string newTaskDescription)
        {
            var taskToUpdate = _tasks.FirstOrDefault(t => t.TaskId == taskId);
            if (taskToUpdate != null)
            {
                taskToUpdate.TaskName = newTaskName;
                taskToUpdate.TaskDescription = newTaskDescription;
                Console.WriteLine($"Task with ID {taskId} has been updated.");
                return true; // Task found and updated
            }
            else
            {
                Console.WriteLine($"Task with ID {taskId} not found.");
                return false; // Task not found
            }
        }
    }
}
