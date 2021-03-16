using System;
using System.Collections.Generic;

public class TeamLead : Programmer
{
    private readonly List<Programmer> programmers;

    public TeamLead(int id, List<Programmer> programmers) : base(id)
    {
        this.programmers = programmers;
    }

    public List<Programmer> Programmers => programmers;

    public void HuntProgrammers(List<TeamLead> teamLeads)
    {
        foreach (var teamLead in teamLeads)
        {
            if(teamLead.Id == Id) continue;
            foreach (var programmer in teamLead.programmers)
            {
                if (programmer.LinesOfCode % (Id + 1) != 0) continue;
                teamLead.programmers.Remove(programmer);
                programmers.Add(programmer);
                break;
            }
        }   
    }

    public int GetWrittenLinesOfCode()
    {
        int sum = 0;
        foreach (var programmer in programmers)
        {
            sum += programmer.LinesOfCode;
        }

        sum += LinesOfCode;

        return sum;
    }

    public override string ToString()
    {
        return $"Team lead #{Id}\nAmount of programmers in team: {programmers.Count}";
    }
}