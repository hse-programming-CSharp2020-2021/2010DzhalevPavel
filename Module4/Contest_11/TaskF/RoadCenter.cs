using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

public class RoadCenter : ITrackingCenter
{
    
    private List<Camera> cameras = new List<Camera>();
    [JsonPropertyName("cameras")]
    public List<Camera> Cameras
    {
        get => cameras;
        set => cameras = value;
    }

    public void AddCamera(int id, int maxSpeed)
    {
        cameras.Add(new Camera(id, maxSpeed));
    }

    public void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed)
    {
        var cam = cameras.Find(x => x.Id == forCameraId);
        if (cam != null && cam.MaxSpeed < carSpeed)
        {
            cam.AddPenalty(carNumber, carSpeed);
        }
    }

    public void GetData(string inFilePath)
    {
        using (var fs = new StreamWriter("data.json"))
        {
            fs.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}