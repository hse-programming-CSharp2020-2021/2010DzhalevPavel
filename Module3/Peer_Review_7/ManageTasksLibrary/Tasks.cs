using System;
using System.Collections.Generic;

namespace ManageTasks
{
    //This indicates the status of a task
    public enum Status
    {
        Open,
        Working,
        Done
    }

    #region TasksClasses

    /// <summary>
    /// This is the task base class. All types of tasks are based on this class.
    /// </summary>
    public class TaskBase
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public Status Status { get; set; }

        public TaskBase(string name, DateTime created, Status status)
        {
            Name = name;
            CreationDate = created;
            Status = status;
        }

        public override string ToString()
        {
            return $"{Name} - Task of type \"{this.GetType()}\", created on {CreationDate}, with a status \"{Status}\"";
        }
    }

    public class Epic : TaskBase, IAssignable
    {
        public List<TaskBase> Tasks { get; set; }
        public List<User> Users { get; set; }

        public Epic(string name, DateTime created, Status status) : base(name, created, status)
        {
        }
    }


    public class Story : TaskBase, IAssignable
    {
        public List<User> Users { get; set; }

        public Story(string name, DateTime created, Status status) : base(name, created, status)
        {
        }
    }

    public class Task : TaskBase
    {
        public User User { get; set; }

        public Task(string name, DateTime created, Status status, User user) : base(name, created, status)
        {
            User = user;
        }

        public Task(string name, DateTime created, Status status) : base(name, created, status)
        {
        }
    }

    /// <summary>
    /// A task, descibing a problem in the current project. It is NOT
    /// related to Epic.
    /// </summary>
    public class Bug : TaskBase
    {
        public User User { get; set; }

        public Bug(string name, DateTime created, Status status, User user) : base(name, created, status)
        {
            User = user;
        }

        public Bug(string name, DateTime created, Status status) : base(name, created, status)
        {
        }
    }

    #endregion
}