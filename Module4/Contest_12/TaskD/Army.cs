using System;
using System.Collections;
using System.Collections.Generic;

public class Army : IEnumerable<int>
{
    private (int, bool)[] _soldiers;
    private List<int> _newOrder = new List<int>();
    private int _n;
    public Army(int[] soldiers, int n)
    {
        if (n <= 0 || n > soldiers.Length)
            throw new ArgumentException("N is not valid");
        //_soldiers = soldiers;
        _soldiers = new (int, bool)[soldiers.Length];
        for (int i = 0; i < soldiers.Length; i++)
        {
            _soldiers[i] = (soldiers[i], false);
        }
        _n = n;
    }

    public IEnumerator<int> GetEnumerator()
    {
        int i = 1;
        while (true)
        {
            if(_newOrder.Count == _soldiers.Length)
                break;
            int onTurn = i * _n;
            //int student;
            if (onTurn > _soldiers.Length)
            {
                onTurn = onTurn % _soldiers.Length;
                /*student = _soldiers[onTurn].Item1;*/
            }
            else
            {
                --onTurn;
                /*student = _soldiers[onTurn-1].Item1;
                _soldiers[onTurn - 1].Item2 = false;*/
            }
            
            while (_newOrder.Count == _soldiers.Length ||
                   _soldiers[onTurn].Item2)
            {
                ++onTurn;
            }
            
            _newOrder.Add(_soldiers[onTurn].Item1);
            _soldiers[onTurn].Item2 = true;
            
            i++;
            yield return _soldiers[onTurn].Item1;

        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}