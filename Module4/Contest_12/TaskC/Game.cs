using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Game : IEnumerable<string>
{
    private readonly LinkedList<int> first;
    private readonly LinkedList<int> second;
    private string _turn = "first";

    public Game(LinkedList<int> first, LinkedList<int> second)
    {
        this.first = first;                            
        this.second = second;
    }

    public IEnumerator<string> GetEnumerator()
    {
        while(true)
        {
            var flag = false;
            if (_turn == "first")
            {
                if (second.Count == 0)
                {
                    yield return "Second win!";
                    break;
                }
                if (first.Count(x => x >= second.First.Value) == 0)
                {
                    yield return "Second win!";
                    break;
                }
                
                for(var i =0 ;i < first.Count;i++){
                    var card = first.First;
                    if (card.Value >= second.First.Value)
                    {
                        first.Remove(card);
                        _turn = "second";
                        yield return $"First: {card.Value}";
                        flag = true;
                        break;
                    }

                    first.AddLast(card.Value);
                    first.RemoveFirst();
                }
                if(flag) continue;
                yield return "Second win!";
                break;
            } if (_turn == "second")
            {
                if (first.Count == 0)
                {
                    yield return "First win!";
                    break;
                }
                if (second.Count(x => x >= first.First.Value) == 0)
                {
                    yield return "First win!";
                    break;
                }
                
                for(var i =0 ;i < second.Count;i++){
            
                    var card = second.First;
                    if (card.Value >= first.First.Value)
                    {
                        second.Remove(card);
                        _turn = "first";
                        yield return $"Second: {card.Value}";
                        flag = true;
                        break;

                    }
                    second.AddLast(card.Value);
                    second.RemoveFirst();
                }
                
                if(flag) continue;
                yield return "First win!";
                break;
            }
        }
        
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

/*public class GameEnumerator : IEnumerator<string>
{
    private readonly LinkedList<int> first;
    private readonly LinkedList<int> second;
    private string _turn = "first";

    public GameEnumerator(LinkedList<int> first, LinkedList<int> second)
    {
        this.first = first;
        this.second = second;
    }
    public bool MoveNext()
    {
        if (_turn == "over" || first.Count == 0 || second.Count == 0)
            return false;
        if (_turn == "first")
        {
            if (first.Count(x => x >= second.First.Value) == 0)
            {
                Current = "Second win!";
                _turn = "over";
            }

            if (first.First.Value < second.First.Value)
            {
                first.AddLast(first.First.Value);
                first.RemoveFirst();
                MoveNext();
            }
            else
            {
                Current = $"First: {first.First.Value}";
                first.RemoveFirst();
                if (first.Count == 0)
                {
                    Current = "First win!";
                    _turn = "over";
                }
                _turn = "second";
            }
            
        }
        else if(_turn == "second")
        {
            if (second.Count(x => x >= first.First.Value) == 0)
            {
                Current = "First win!";
                _turn = "over";
            }
            if (second.First.Value < first.First.Value)
            {
                
                second.AddLast(second.First.Value);
                second.RemoveFirst();
                MoveNext();
            }
            else
            {
                Current = $"Second: {second.First.Value}";
                second.RemoveFirst();
                if (second.Count == 0)
                {
                    Current = "Second win!";
                    _turn = "over";
                }
                _turn = "first";
            }
        }
        return true;
    }

    public void Reset()
    {
    }

    public string Current { get; private set; } = string.Empty;

    object IEnumerator.Current => Current;

    public void Dispose()
    {}
}*/