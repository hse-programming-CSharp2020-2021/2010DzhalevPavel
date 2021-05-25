using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

public partial class Program
{
    // Необходимо:
    // 1. Сформировать группы юзеров по их имени, предварительно отсортировав их по возрасту в убывающем порядке (от большего к меньшему).
    // 2. Отфилььзтровать группы: оставить в группах только тех полователей, чей возраст строго больше 10.
    // 3. Из каждой группы взять m пользователей, предварительно отсортировав по Id, и вывести на экран сумму возрастов таких пользователей.
    private static IEnumerable<IGrouping<string, User>> GetGroups(List<User> users)
    {
        var result =
            from user in users
            orderby user.Age descending
            group user by user.Name;
        
        return result;

    }

    private static List<int> GetQueryResult(IEnumerable<IGrouping<string, User>> groups, int m)
    {
        var checkedGroups = groups.Select(group => group.Where(user => user
        .Age > 10));
        
        var endResult = new List<int>();
        foreach (var userGroup in checkedGroups)
        {
            var sortedGroup =
                from user in userGroup
                orderby user.Id
                select user;

            var count = 0;
            if (sortedGroup.Count() > 0)
            {
                if (sortedGroup.Count() < m)
                {
                    foreach (var user in sortedGroup)
                    {
                        count += user.Age;
                    }
                }else
                {
                    var i = 0;
                    foreach (var user in sortedGroup)
                    {
                        if (++i > m)
                            break;
                        count += user.Age;
                    }
                }
            }
            endResult.Add(count);
        }

        return endResult;
    }
}