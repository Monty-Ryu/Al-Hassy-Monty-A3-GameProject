using System;
using System.Numerics;

namespace MohawkGame2D;

public class Clouds
{
    public void DrawClouds(float x, float y)
    {
        Draw.FillColor = Color.White;
        Draw.Circle(x, y, 75);
    }
    
}
