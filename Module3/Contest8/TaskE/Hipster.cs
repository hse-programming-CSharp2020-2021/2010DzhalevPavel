using System;

internal class Hipster
{
    public int money;
    private int donate;

    public Hipster(int money, int donate)
    {
        this.money = money;
        this.donate = donate;
    }

    public int GetMoney()
    {
        if (money >= donate)
        {
            money -= donate;
            return donate;
        }

        if (money < donate && money>0)
        {
            int t = money;
            money = 0;
            return t;
        }

        return 0;

    }
}