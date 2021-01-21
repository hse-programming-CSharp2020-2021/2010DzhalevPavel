using System;

namespace Robots
{
    class Robot {
        // класс для представления робота
        int x, y; // положение робота на плоскости 

        public void Right() { x++; }      // направо
        public void Left() { x--; }      // налево
        public void Forward() { y++; }  // вперед
        public void Backward() { y--; }  // назад

        public string Position() {  // сообщить координаты
            return String.Format("The Robot's position: x={0}, y={1}", x, y);
        }
    }

    delegate void Steps(); // делегат-тип

    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter robot commands: ");
            var commands = Console.ReadLine();
            
            Robot rob = new Robot();    // конкретный робот 
            Steps[] trace = new Steps[commands.Length];

            int count = 0;
            foreach (char cmd in commands.ToCharArray())
            {
                if (cmd == 'R') trace[count] = rob.Right;
                if (cmd == 'L') trace[count] = rob.Left;
                if (cmd == 'F') trace[count] = rob.Forward;
                if (cmd == 'B') trace[count] = rob.Backward;
                count++;
            }
            
            // сообщить координаты
            Console.WriteLine("Start:" + rob.Position());    
 
            for (int i = 0; i < trace.Length; i++) {
                Console.WriteLine("Method={0}, Target={1}",
                    trace[i].Method, trace[i].Target);
                trace[i]();
            }

            Console.WriteLine(rob.Position());     // сообщить координаты

            /*//Robot rob = new Robot();    // конкретный робот 
            Steps delR = new Steps(rob.Right);      // направо
            Steps delL = new Steps(rob.Left);       // налево
            Steps delF = new Steps(rob.Forward);    // вперед
            Steps delB = new Steps(rob.Backward);   // назад
            
            // шаги по диагоналям (многоадресные делегаты):
            Steps delRF = delR + delF;
            Steps delRB = delR + delB;
            Steps delLF = delL + delF;
            Steps delLB = delL + delB;
            delLB();
            Console.WriteLine(rob.Position());     // сообщить координаты
            delRB();
            Console.WriteLine(rob.Position());     // сообщить координаты*/
            
            
            Console.WriteLine("To exit this application, click any button.");
            Console.ReadKey();

        }
    }
}