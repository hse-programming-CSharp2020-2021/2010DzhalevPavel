using System;
using System.Text.Json.Serialization;

public class Penalty
{
    private int carNumber;
    
    private int cost;

    [JsonPropertyName("car_number")]
    public int CarNumber
    {
        get => carNumber;
        set => carNumber = value;
    }

    [JsonPropertyName("cost")]
    public int Cost
    {
        get => cost;
        set => cost = value;
    }

    public Penalty(int carNumber, int cost)
    {
        this.carNumber = carNumber;
        this.cost = cost;
    }
}