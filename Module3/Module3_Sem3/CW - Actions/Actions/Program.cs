using System;

namespace Program
{
    public delegate void AccountDelegateHandler (string s);
    class Account
    {
        public event AccountDelegateHandler onChange;
        // делегат void (string, int, int)
        public Account(int sum)
        {
            Sum = sum;
        }
        // сумма на счете
        public int Sum { get; private set; }
        // добавление средств на счет
        public void Put(int sum)
        {
            Sum += sum;
            onChange?.Invoke($"Put - {sum} - {Sum}");
        }
        // списание средств со счета
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                onChange?.Invoke($"Take - {sum} - {Sum}");
            }else onChange?.Invoke($"Attempt to take - {sum} - {Sum}");
        }
    }
    class Program
    {
        public static void Message(string str) => Console.WriteLine(str);
        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.onChange += Message;
            acc.Put(20);    // добавляем на счет 20
            acc.Take(70);   // пытаемся снять со счета 70
            acc.Take(180);  // пытаемся снять со счета 180
            Console.Read();
        }
    }
}