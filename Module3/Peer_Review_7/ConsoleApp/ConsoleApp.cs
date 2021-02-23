using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ManageTasks;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ConsoleApp
{
    static class Program
    {
        // Main storage point.
        public static List<Project> _projects = new List<Project>();
        private static List<User> _users = new List<User>();

        static void Main(string[] args)
        {
            // Welcome message.
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Welcome to my Task Manager Console App!\n" +
                              "If you ever feel lost, type help to view all available commands");

            // Checks for previously saved data and fills _projects and _users if it is available.
            RetrieveData();

            // A try-catch which enables the program to only close if the Esc key is pressed.
            try
            {
                string input = string.Empty;
                do
                {
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Manage tasks: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        input = Console.ReadLine();
                        HandleCommands(input);
                    } while (Exit(input));

                    Console.WriteLine($"Press Esc to exit and any other key to continue...");
                } while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            // Catches all exceptions
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        #region Creation

        /// <summary>
        /// Adds a task to a project.
        /// </summary>
        private static void AddTask()
        {
            if (_projects.Count != 0)
            {
                Console.WriteLine("These are all the projects tha you can add a task to: ");
                DisplayProjects();
                Console.Write("Which project would you like to use? ");
                string project = Console.ReadLine();

                if (_projects.Contains(new Project(project)))
                {
                    Console.Write("Task type (epic, story, task, bug): ");
                    string type = Console.ReadLine();

                    if (type.Split(" ").Length == 1)
                    {
                        switch (type)
                        {
                            case "epic":
                                CreateTask(out var epicName, out var epicDate, out var epicStatus);
                                _projects.Find(x => x.Name == project)?.Tasks
                                    .Add(new Epic(epicName, epicDate, epicStatus));
                                break;
                            case "story":
                                CreateTask(out var storyName, out var storyDate, out var storyStatus);
                                _projects.Find(x => x.Name == project)?.Tasks
                                    .Add(new Story(storyName, storyDate, storyStatus));
                                break;
                            case "task":
                                CreateTask(out var taskName, out var taskDate, out var taskStatus);
                                _projects.Find(x => x.Name == project)?.Tasks
                                    .Add(new Task(taskName, taskDate, taskStatus));
                                break;
                            case "bug":
                                CreateTask(out var bugName, out var bugDate, out var bugStatus);
                                _projects.Find(x => x.Name == project)?.Tasks.Add(new Bug(bugName, bugDate, bugStatus));
                                break;
                            default:
                                Console.WriteLine("You have entered a wrong type. Please check spelling.");
                                break;
                        }
                    }
                    else Console.WriteLine("You have entered a wrong type. Please check spelling.");
                }
                else Console.WriteLine("This project does not exist and thus you cannot add a project to it.");
            }
            else Console.WriteLine("Please add some projects first. If you have no idea how, please refer to help.");
        }

        /// <summary>
        /// Contains data entry and logic for AddTask();
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="status"></param>
        private static void CreateTask(out String name, out DateTime date, out Status status)
        {
            Console.Write("Task name: ");
            name = Console.ReadLine();
            date = DateTime.Now;
            do
            {
                Console.Write("Task date (eg 08/18/2021): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out date));

            status = Status.Open;
        }

        /// <summary>
        /// Adds a user to the list of _users.
        /// </summary>
        public static void AddUser()
        {
            Console.Write("Name of new user: ");
            string name = Console.ReadLine();
            try
            {
                if (name == "")
                    throw new ArgumentException("User name is not valid.");
                _users.Add(new User(name));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Unsuccessful user creation. Error: {e.Message}");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        /// <summary>
        /// Add a new project with no tasks.
        /// </summary>
        public static void CreateProject()
        {
            Console.Write("Enter project name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("Project name cannot be empty.");
                CreateProject();
            }
            else
            {
                _projects.Add(new Project(name));
                Console.WriteLine($"Congratulations! You have successfully added a project named {name}.");
            }
        }

        #endregion

        #region Display

        /// <summary>
        /// Displays all currently available _users.
        /// </summary>
        public static void DisplayUsers()
        {
            if (_users.Count == 0)
                Console.WriteLine("You haven't added any users yet.");
            else
            {
                foreach (var user in _users)
                {
                    Console.WriteLine(user);
                }
            }
        }


        /// < summary>
        /// Displays all _projects.
        /// </summary>
        public static void DisplayProjects()
        {
            if (_projects.Count == 0)
            {
                Console.WriteLine("You have not added any projects yet.");
            }
            else
            {
                foreach (var project in _projects)
                {
                    Console.WriteLine(project);
                }
            }
        }

        /// <summary>
        /// Displays all possible functions of the program.
        /// </summary>
        public static void DisplayHelp()
        {
            Console.WriteLine(
                $"COMMANDS\n" +
                "   new [options] \t Creates a new user, project or task. Options:\n" +
                "     -user \t\t Creates a new user\n" +
                "     -project \t\t Creates a new project\n" +
                "     -task \t\t Creates a new task\n" +
                "   display [options] \t Displays all initiated object of type options\n" +
                "     -users \t\t Displays all users\n" +
                "     -projects \t\t Displays all projects\n" +
                "   task [options] \t Operates with tasks. Options:\n" +
                "     -new \t\t Create a new task\n" +
                "   change \t\t Changes the name of a previously created project\n" +
                "   help \t\t Displays all available functions\n" +
                "   exit \t\t Exits the program");
        }

        public static void DisplayTasks()
        {
            Console.WriteLine("These are all the projects tha you can choose to display: ");
            DisplayProjects();
            Console.Write("Which project would you like to view? ");
            string project = Console.ReadLine();

            if (_projects.Contains(new Project(project)))
            {
                Console.WriteLine($"{project} contains {_projects.Find(x => x.Name == project).Tasks.Count} projects: ");
                foreach (var task in _projects.Find(x => x.Name == project).Tasks)
                {
                    Console.WriteLine(task);
                }
            }else Console.WriteLine("This project does not exist. Please check spelling.");
        }

        #endregion
        
        #region SaveAndRetrieve

        /// <summary>
        /// Saves all the data before closing the app.
        /// </summary>
        public static void Save()
        {
            string userJson = JsonConvert.SerializeObject(_users);
            File.WriteAllText("users.json", userJson);

            string projectJson = JsonConvert.SerializeObject(_projects);
            File.WriteAllText("projects.json", projectJson);
        }

        /// <summary>
        /// Retrieves the data from previous builds.
        /// </summary>
        public static void RetrieveData()
        {
            // If used, add after object
            /*var options = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                PreserveReferencesHandling = PreserveReferencesHandling.All
            };*/
            string userJson = File.ReadAllText("users.json");
            _users = JsonConvert.DeserializeObject<List<User>>(userJson);

            string projectJson = File.ReadAllText("projects.json");
            _projects = JsonConvert.DeserializeObject<List<Project>>(projectJson);
        }

        #endregion

        #region Other

        /// <summary>
        /// Changes the name of the selected project.
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <exception cref="Exception"></exception>
        public static void ChangeProjectName()
        {
            Console.Write("The old name of the project: ");
            var oldName = Console.ReadLine();
            Console.Write("The new name of the project: ");
            var newName = Console.ReadLine();

            if (_projects.Contains(new Project(oldName)) == false)
                Console.WriteLine("This project does not exist and thus cannot be deleted.");
            _projects.Find(x => x.Name == oldName).Name = newName;
        }

        /// <summary>
        /// Handles user console commands.
        /// </summary>
        /// <param name="input"></param>
        public static void HandleCommands(string input)
        {
            var cmds = input.Split(" ");

            if (input != "")
            {
                switch (cmds[0])
                {
                    case "new":
                        switch (cmds[1])
                        {
                            case "-user":
                                AddUser();
                                break;
                            case "-project":
                                CreateProject();
                                break;
                            default:
                                Console.WriteLine("Please check syntax");
                                break;
                        }

                        break;
                    case "display":
                        if (cmds.Length == 2)
                        {
                            switch (cmds[1])
                            {
                                case "-users":
                                    DisplayUsers();
                                    break;
                                case "-projects":
                                    DisplayProjects();
                                    break;
                                case "-tasks":
                                    DisplayTasks();
                                    break;
                                default:
                                    Console.WriteLine("Please check syntax");
                                    break;
                            }
                        }
                        else Console.WriteLine("Operation does not exist. Please check spelling or view help.");

                        break;
                    case "change":
                        ChangeProjectName();
                        break;
                    case "task":
                        if (cmds.Length == 2)
                        {
                            switch (cmds[1])
                            {
                                case "-new":
                                    AddTask();
                                    break;
                                default:
                                    Console.WriteLine("Operation does not exist. Please check spelling or view help.");
                                    break;
                            }
                        }
                        else Console.WriteLine("Operation does not exist. Please check spelling or view help.");

                        break;
                    case "help":
                        DisplayHelp();
                        break;
                    case "exit":
                        Save();
                        Exit(input);
                        break;
                    default:
                        Console.WriteLine("Functionality not implemented. Please check spelling or refer to help");
                        break;
                }
            }
            else Console.WriteLine("Command input cannot be null!");
        }

        /// <summary>
        /// Checks whether the app is closing or not.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Exit(string input)
        {
            if (input.Split(" ")[0] == "exit")
                return false;
            return true;
        }

        #endregion
        
    }
}