using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base Class for Units like Player and Enemy. Basically things that have health and move.
public class Unit : AdventureObject, IDamageable {
  [SerializeField] int health = 100;
  protected bool isGrounded {
    get {
      return CheckGrounded();
    }
  }
  protected Vector3 velocity;
  protected Vector3 move;

	// Use this for initialization
	protected new void Start () {
		base.Start();
	}
	
	// Update is called once per frame
	protected new void Update () {
    base.Update();
	}

  // CheckGrounded() determines if the AdventureObject is currently standing on ground.
  // Called in Update().
  bool CheckGrounded() 
  {
    if (collider is BoxCollider2D) {
      Ray2D[] groundRays = RayUtility.MakeRaysFromBoxCollider2D((BoxCollider2D)collider, 3, RayUtility.BoxSide.Bottom);
      foreach (Ray2D ray in groundRays) {
        if (Physics2D.Raycast(ray.origin, ray.direction, 0.2f, Game.terrainMask)) {
          return true;
        }
      }
    }

    return false;
  }
  
  public void damage(float amount) {
    health -= (int) amount;
    if (health <= 0) {
      die();
    }
  }
    
  protected void die() {
    Destroy(gameObject);
  }
}
