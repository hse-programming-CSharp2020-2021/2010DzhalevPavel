using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Hipster
{
    int departureDay;
    int arrivalDay;

    public int PostsRead { get; private set; }

    private List<Blogger> subscribedTo;

    public Hipster(int departureDay, int arrivalDay)
    {
        this.departureDay = departureDay;
        this.arrivalDay = arrivalDay;
    }

    public void ReadPost(DateTime date)
    {
        if(date.Day<departureDay || date.Day > arrivalDay)
            foreach (var blogger in subscribedTo)
            {
            }
    }

    public void Subscribe(Blogger blogger)
    {
        subscribedTo.Add(blogger);
    }
}

