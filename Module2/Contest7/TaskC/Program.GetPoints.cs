using System;
using System.Collections.Generic;
using System.IO;

public partial class Program
{
    /// <summary>
    /// Считывает точки в список.
    /// </summary>
    /// <returns>Список точек.</returns>
    private static List<Point> GetPoints()
    {
        List<Point> list = new List<Point>();
        foreach (string line in File.ReadLines(InputPath))
        {
            int x = int.Parse(line.Split(' ')[0]);
            int y = int.Parse(line.Split(' ')[1]);
            int z = int.Parse(line.Split(' ')[2]);
            
            list.Add(new Point(x, y, z));
        }

        return list;
    }


    /// <summary>
    /// Получает коллекцию уникальных точек.
    /// </summary>
    /// <param name="points">Список исходных точек.</param>
    /// <returns>Коллекция точек.</returns>
    private static HashSet<Point> GetUnique(List<Point> points)
    {
        HashSet<Point> set = new HashSet<Point>();
        foreach (Point p in points)
        {
            if (!set.Contains(p))
                set.Add(p);
        }
        return set;
    }
}