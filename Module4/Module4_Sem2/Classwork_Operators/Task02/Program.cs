using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State();
            State state2 =new State();
            State state3 = state1 + state2;
            bool isGreater = state1 > state2;
        }
    }

    class State
    {
        public decimal Population{get;set;}
        public decimal Area { get; set; }

        public static State operator +(State state1, State state2)
        {
            var newState = new State();
            newState.Area = state1.Area + state2.Area;
            newState.Population = state1.Population + state2.Population;
            return newState;
        }

        //State objects are compared by their area.
        public static bool operator >(State state1, State state2)
        {
            if (state1.Area > state2.Area)
                return true;
            return false;
        }
        public static bool operator <(State state1, State state2)
        {
            if (state1.Area < state2.Area)
                return true;
            return false;
        }
    }
}