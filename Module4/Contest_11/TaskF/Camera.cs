using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class Camera
{
    private int id;
    private int maxSpeed;
    private List<Penalty> penalties = new List<Penalty>();

    [JsonPropertyName("id")]
    public int Id
    {
        get => id;
        set => id = value;
    }

    [JsonIgnore]
    public int MaxSpeed
    {
        get => maxSpeed;
        set => maxSpeed = value;
    }

    [JsonPropertyName("penalties")]
    public List<Penalty> Penalties
    {
        get => penalties;
        set => penalties = value;
    }

    public Camera(int id, int maxSpeed)
    {
        this.id = id;
        this.maxSpeed = maxSpeed;
    }

    public void AddPenalty(int carNumber, int speed)
    {
        var cost = (speed - MaxSpeed) * 100;
        Penalties.Add(new Penalty(carNumber, cost));
    }
}