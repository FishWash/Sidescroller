using UnityEngine;
using System.Collections;

public class RayUtility
{

  public static Ray2D[] MakeRaysFromLine2D(int numRays, Vector2 startPosition, Vector2 endPosition, Vector2 rayDirection) 
  {
    if (numRays < 2) {
      return null;
    }

    Ray2D[] rays = new Ray2D[numRays];
    Vector2 positionLine = endPosition - startPosition;
    float distanceBetweenRays = positionLine.magnitude / (numRays-1);
    Debug.Log(distanceBetweenRays);

    for (int i=0; i<numRays; i++) {
      Vector2 rayPos = startPosition + i*distanceBetweenRays*positionLine.normalized;
      rays[i] = new Ray2D(rayPos, rayDirection);
      Debug.DrawRay(rayPos, rayDirection);
    }

    return rays;
  }

  public enum BoxSide {Bottom, Top, Left, Right}
  public static Ray2D[] MakeRaysFromBoxCollider2D(BoxCollider2D boxCollider, int numRays, BoxSide side) {
    Vector2 startPosition = Vector2.zero, 
            endPosition = Vector2.zero, 
            rayDirection = Vector2.zero,
            boxColliderPosition = (Vector2)boxCollider.gameObject.transform.position + boxCollider.offset;

    switch(side) {
      case BoxSide.Bottom:
        startPosition = boxColliderPosition + new Vector2(-boxCollider.size.x/2, -boxCollider.size.y/2);
        endPosition = boxColliderPosition + new Vector2(boxCollider.size.x/2, -boxCollider.size.y/2);
        rayDirection = Vector2.down;
        break;

      case BoxSide.Top:
        startPosition = boxColliderPosition + new Vector2(boxCollider.size.x/2, boxCollider.size.y/2);
        endPosition = boxColliderPosition + new Vector2(-boxCollider.size.x/2, boxCollider.size.y/2);
        rayDirection = Vector2.up;
        break;

      case BoxSide.Left:
        startPosition = boxColliderPosition + new Vector2(-boxCollider.size.x/2, -boxCollider.size.y/2);
        endPosition = boxColliderPosition + new Vector2(-boxCollider.size.x/2, boxCollider.size.y/2);
        rayDirection = Vector2.left;
        break;

      case BoxSide.Right:
        startPosition = boxColliderPosition + new Vector2(boxCollider.size.x/2, boxCollider.size.y/2);
        endPosition = boxColliderPosition + new Vector2(boxCollider.size.x/2, -boxCollider.size.y/2);
        rayDirection = Vector2.right;
        break;
    }

    return MakeRaysFromLine2D(numRays, startPosition, endPosition, rayDirection);
  }
}