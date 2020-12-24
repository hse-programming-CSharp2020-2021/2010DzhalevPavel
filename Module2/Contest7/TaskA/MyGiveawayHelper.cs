using System;

internal class MyGiveawayHelper
{
    private string[] logins;
    private string[] prizes;

    public MyGiveawayHelper(string[] logins, string[] prizes)
    {
        this.logins = logins;
        this.prizes = prizes;
    }

    public bool HasPrizes => prizes != null;

    public (string prize, string login) GetPrizeLogin()
    {
        if (logins.Length.ToString().Length == 4)
        {

        }

        throw new NotImplementedException();
    }
}