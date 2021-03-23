using System;

class Singleton<T> where T : new()
{
    private static T instance = new T();
    public static T Instance
    {
        get => instance;
        set=> throw new NotSupportedException("This operation is not supported");
    }
}
