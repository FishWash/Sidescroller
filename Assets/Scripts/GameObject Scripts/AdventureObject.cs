using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base Class for most GameObjects used in my games.
public class AdventureObject : MonoBehaviour {
  Collider2D myCollider;
  Rigidbody2D myRigidbody;
  SpriteRenderer mySprite;
  Animator myAnimator;

  public new Rigidbody2D rigidbody {
    get {
      if (myRigidbody == null) {
        myRigidbody = GetComponent<Rigidbody2D>();
      }
      return myRigidbody;
    }
  }

  public new Collider2D collider {
    get {
      if (myCollider == null) {
        myCollider = transform.Find("Collider").GetComponent<Collider2D>();
      }
      return myCollider;
    }
  }

  public SpriteRenderer sprite {
    get {
      if (mySprite == null) {
        mySprite = transform.Find("Sprite").GetComponent<SpriteRenderer>();
      }
      return mySprite;
    }
  }

  public Animator animator {
    get {
      if (myAnimator == null) {
        myAnimator = transform.Find("Sprite").GetComponent<Animator>();
      }
      return myAnimator;
    }
  }

  protected void Start() {
    // nothing here yet
  }

  protected void Update() {
    // nothing here yet
  }
}
