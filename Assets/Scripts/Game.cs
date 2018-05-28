using UnityEngine;
using System.Collections;

// This is pretty much just for holding static variables for other classes
public class Game
{
  // Physics
  public static Vector3 gravity = new Vector2(0, -0.1f);
  public static LayerMask terrainMask = LayerMask.GetMask("Terrain");
}

