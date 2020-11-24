using System;
using System.Collections.Generic;

public class Support
{
    private readonly List<Task> tasks = new List<Task>();

    public IEnumerable<Task> Tasks => tasks;

    public int OpenTask(string text)
    {
        tasks.Add(new Task(tasks.Count+1, text));
        return tasks.Count;
    }

    public void CloseTask(int id, string answer)
    {
        tasks[id-1].Answer = answer;
        tasks[id-1].IsResolved = true;
    }

    public List<Task> GetAllUnresolvedTasks()
    {
        List<Task> newList = new List<Task>();
        foreach (Task task in tasks)
        {
            if(task.IsResolved==false)
                newList.Add(task);
        }
        return newList;
    }

    public void CloseAllUnresolvedTasksWithDefaultAnswer(string answer)
    {
        foreach (Task task in tasks)
        {
            if (task.IsResolved == false)
            {
                CloseTask(task.Id, answer);
            }
        }

    }

    public string GetTaskInfo(int id)
    {
        return tasks[id-1].ToString();
    }
}