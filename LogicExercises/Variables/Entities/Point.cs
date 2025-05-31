namespace LogicExercises.Entities;

public struct Point
{
    public int X;
    public int Y;

    public override string ToString()
    {
        return $"(X: {X}, Y: {Y})";
    }
}