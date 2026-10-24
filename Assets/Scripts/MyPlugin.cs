using System.Runtime.InteropServices;
using UnityEditor.ShaderGraph.Internal;

[StructLayout(LayoutKind.Sequential)]


public struct Vector2D
{
    public float x;
    public float y;
}

public static class MyPlugin
{
    [DllImport("GED&I_LectureSix")]
    private static extern int GetID();

    [DllImport("GED&I_LectureSix")]

    private static extern void SetID(int id);

    [DllImport("GED&I_LectureSix")]
    private static extern Vector2D GetPosition();

    [DllImport("GED&I_LectureSix")]

    private static extern Vector2D GetPosition(float x, float y);


    public static int ID
    {
        get { return GetID(); }
        set { SetID(value); }
    }

    public static Vector2D Position
    {
        get { return GetPosition(); }
    }
}