using System;

class Kikstarter
{
    // Данный тип необходимо обязательно использовать
    public delegate int GetMoneyDelegate();

    GetMoneyDelegate[] getMoney;
    private int m;

    public Kikstarter(int m, Hipster[] hipsters)
    {
        if (hipsters.Length == 0) throw new ArgumentException("Not enough hipsters");
        this.m = m;
        getMoney = new GetMoneyDelegate[hipsters.Length];
        for (int i = 0; i < getMoney.Length; i++)
        {
            getMoney[i] = hipsters[i].GetMoney;
        }
        int temp =0;
        foreach (var hip in hipsters)
        {
            temp += hip.money;
        }

        if (temp < m)
            throw new InvalidOperationException("Not enough money");

    }

    public int Run()
    {
        //good try, didn't work
        //if (m == 0) return 1;
        
        int c=0;
        while (m > 0)
        {
            foreach (var hip in getMoney)
            {
                m -= hip();
            }

            c++;
        }

        return c;
    }
}