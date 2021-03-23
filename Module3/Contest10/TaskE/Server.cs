#nullable enable
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;

public class Server
{
    private class Client
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime LoginTime { get; set; }

        public Client(string name, string password, DateTime loginTime)
        {
            Name = name;
            Password = password;
            LoginTime = loginTime;
        }
        public Client(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Client anotherClient = obj as Client;
            if (anotherClient == null) return false;
            else return anotherClient.Name == Name;
        }
    }
    public static void ProcessAuthorization(string requestsPath, string requestsResultsPath)
    {
        //TODO: Implement some sort of way to know when the user logged in, out, etc
        List<Client> clients = new List<Client>();
        List<Client?> oneWrongPass = new List<Client?>();
        List<Client> bannedClients = new List<Client>();
        
        using (var sr = new StreamReader(File.Open(requestsPath, FileMode.Open, FileAccess.Read)))
        using (var sw = new StreamWriter(File.Open(requestsResultsPath, FileMode.Create, FileAccess.Write)))
        {
            while (sr.Peek() != -1 || sr.ReadLine()?.Split().Length > 2)
            {
                var client = sr.ReadLine().Split(' ');
                if (!bannedClients.Contains(new Client(client[1])))
                {
                    var existingClient = clients.Find(x => x.Name == client[1]);

                    if (client[0] == "SI" && client.Length == 5)
                    {
                        //User does not exist
                        if (!UserDb.Users.ContainsKey(client[1]))
                        {
                            sw.WriteLine(
                                $"{client[1]}> no user with such login");
                            continue;
                        }

                        //Incorrect password
                        if (UserDb.Users[client[1]] != client[2])
                        {

                            if (existingClient != null)
                            {
                                var oneWrongPassClient = oneWrongPass.Find(x =>
                                    x.Name ==
                                    client[1]);
                                if (oneWrongPassClient == null)
                                {
                                    oneWrongPass.Add(oneWrongPassClient);
                                }
                                else
                                {
                                    sw.WriteLine(
                                        $"{client[1]}> account blocked due suspicious login attempt");
                                    bannedClients.Add(oneWrongPassClient);
                                    continue;
                                }
                            }

                            sw.WriteLine($"{client[1]}> incorrect password");
                            continue;
                        }

                        //Login successful
                        if (existingClient != null)
                        {
                            var dif =
                                DateTime.Parse(client[3] + " " + client[4],
                                    new CultureInfo("ru-RU")) -
                                existingClient.LoginTime;
                            if (dif.Hours < 24)
                            {
                                clients.Remove(new Client(client[1], client[2],
                                    DateTime.Parse(client[3] + " " + client[4],
                                        new CultureInfo("ru-RU"))));
                                sw.WriteLine(
                                    $"{client[1]}> account blocked due suspicious login attempt");
                                bannedClients.Add(new Client(client[1],
                                    client[2],
                                    DateTime.Parse(client[3] + " " + client[4],
                                        new CultureInfo("ru-RU"))));
                                continue;
                            }
                        }

                        clients.Add(new Client(client[1], client[2],
                            DateTime.Parse(client[3] + " " + client[4],
                                new CultureInfo("ru-RU"))));
                        sw.WriteLine($"{client[1]}> sign in successful");
                        continue;
                    }
                    else if (client[0] == "SO" && client.Length == 4)
                    {
                        //Sign out logic
                        //Remove from list
                        //User does not exist
                        if (!UserDb.Users.ContainsKey(client[1]))
                        {
                            sw.WriteLine(
                                $"{client[1]}> no user with such login");
                            continue;
                        }

                        sw.WriteLine($"{client[1]}> sign out successful");
                        clients.Remove(new Client(client[1], " ", DateTime
                            .Parse(client[2] + " " + client[3],
                                new CultureInfo("ru-RU"))));
                    }
                }
            }
        }
        }
    }
}