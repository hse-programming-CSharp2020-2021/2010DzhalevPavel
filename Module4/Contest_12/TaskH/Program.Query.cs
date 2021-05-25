using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

public partial class Program
{
    // Сортируем по возрастанию лексикографическому города и создаём на основе их группы.
    // Далее сортируем такие группы по количеству в них пользователей. Сортировка убавающая
    // Берём пять первых групп, не включая первую.
    // В каждой такой группе необходимо сгруппировать пользователей по имени, и уже каждую такую группу преобразовать в число, равное среднему возрасту этой группы.

    private static double GetAverage(IEnumerable<User> users)
    {
        var res1 = users.OrderBy(x => x.City).GroupBy(x => x.City);
        
        var res2 = res1.OrderByDescending(x => x.Count()).Skip(1).Take(5);

        var res3 = res2.Select(x => x.GroupBy(x => x.Name).OrderBy(x=>x.Key));
        
        var res4 = res3.Select(x => x.Select(x => x.Sum(x => x.Age)));

        var res5 = res4.Select(x=>x.Max()).Reverse().Distinct();

        return res5.Average();
    }
}