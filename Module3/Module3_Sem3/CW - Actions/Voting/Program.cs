using System;

namespace Task_Zadachka
{
    class VoteEventArgs : EventArgs
    {
        public string Question { get; set; }
        public uint VoteFor { get; set; }
        public uint VoteAgainst { get; set; }
        public uint VoteAbstained { get; set; }
    }

    class ElectoralComission
    {
        public event EventHandler<VoteEventArgs> OnVote;

        public VoteEventArgs Vote(string question)
        {
            VoteEventArgs e = new VoteEventArgs { Question = question };
            OnVote?.Invoke(this, e);
            return e;
        }
    }

    class Voter
    {
        static readonly Random random = new Random();

        public void VoterHandler(object sender, VoteEventArgs e)
        {
            int number = random.Next(0, 3);

            if (number == 0)
                e.VoteAgainst++;
            else if (number == 1)
                e.VoteFor++;
            else
                e.VoteAbstained++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ElectoralComission comission = new ElectoralComission();

            Voter[] voters = new Voter[10];

            for (int i = 0; i < voters.Length; i++)
            {
                voters[i] = new Voter();
                comission.OnVote += voters[i].VoterHandler;
            }

            VoteEventArgs result = comission.Vote("Хотим в следующем пире создать браузер на базе Хромиум");

            Console.WriteLine($"Проголосовало {voters.Length} смертных. Вопрос: \"{result.Question}\"");
            Console.WriteLine($"За : {result.VoteFor}");
            Console.WriteLine($"Против (расстрелять): {result.VoteAgainst} ");
            Console.WriteLine($"Воздержались (расстрелять): {result.VoteAbstained}");
        }
    }
}