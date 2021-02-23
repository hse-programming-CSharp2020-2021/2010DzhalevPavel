using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ManageTasks
{
    public class Project
    {
        //Maximum number of tasks in every project
        const int MaxTasks = 10;
        

        private List<TaskBase> _tasks = new List<TaskBase>();
        public string Name { get; set; }

        public List<TaskBase> Tasks
        {
            get => _tasks;
            set
            {
                if(_tasks.Count == MaxTasks)
                    Console.WriteLine("You have reached the maximum number of tasks.");
                else
                {
                    _tasks = value;
                }
            }
        }

        public Project(string name)
        {
            Name = name;
        }
        
        public Project(string name, List<TaskBase> tasks)
        {
            Name = name;
            Tasks = tasks;
        }

        public Project()
        {
        }

        public override string ToString()
        {
            return $"{Name} - {Tasks.Count} tasks";
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public override bool Equals(object? obj)
        {
            Project p = (Project) obj;
            return p != null && p.Name == Name;
        }
    }
}