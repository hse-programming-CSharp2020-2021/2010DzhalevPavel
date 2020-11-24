using System;
using System.Security.Principal;

public static class GiftCreator
{
    public static int PhoneCounter;
    public static int PlaystationCounter;
    public static Gift CreateGift(string giftName)
    {
        Gift result = null;
        if (giftName=="Phone")
        {
            result = new Phone(PhoneCounter);
            PhoneCounter++;
        }
        if (giftName=="PlayStation")
        {
            result = new PlayStation(PlaystationCounter);
            PlaystationCounter++;
        }

        return result;
    }
}

public class Phone : Gift
{
    private new int ID;
    public Phone(int id) : base(id)
    {
        ID = id;
    }
}

public class PlayStation : Gift
{
    private new int ID;
    public PlayStation(int id) : base(id)
    {
        ID = id;
    }
    
}

