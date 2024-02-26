namespace NoiseGenerator.Graphs;

public class SinCosGraph : IGraph
{
    public double At(double x, double y)
    {
        return Math.Sin(x) + Math.Cos(y);
    }
}