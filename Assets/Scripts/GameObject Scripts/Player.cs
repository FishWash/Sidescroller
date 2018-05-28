using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Unit {
  [SerializeField] float moveSpeed = 1.0f;
  [SerializeField] float jumpSpeed = 5.0f;
  [SerializeField] float maxJumpTime = 0.5f;
  Timer jumpTimer = new Timer();

  bool facingRight = true;


	protected new void Start() {
    base.Start();
	}

	protected new void Update() {
    base.Update();
    Move();
    Jump();
	}



  void Move() {
    float horizontalInput = Input.GetAxis("Horizontal");
    float xMove = horizontalInput*moveSpeed;

    rigidbody.velocity = new Vector3(xMove, rigidbody.velocity.y);

    // Animation
    if (xMove > 0)
      facingRight = true;
    else if (xMove < 0)
      facingRight = false;

    float xScale = (facingRight ? 1 : -1);
    sprite.transform.localScale = new Vector3(xScale, 1, 1);
    animator.SetFloat("moveSpeed", Mathf.Abs(xMove));
  }

  void Jump() {
    float yMove = 0;
    // Pressing Jump while grounded makes you jump
    if (Input.GetButtonDown("Jump") && isGrounded) {
      yMove = jumpSpeed;
      rigidbody.velocity = new Vector2(rigidbody.velocity.x, yMove);
      jumpTimer.timeLeft = maxJumpTime;
    }
    // Holding Jump for a short period makes you jump higher
    if (Input.GetButton("Jump") && !jumpTimer.isDone) {
      yMove = jumpSpeed;
      rigidbody.velocity = new Vector2(rigidbody.velocity.x, yMove);
    }
    else {
      jumpTimer.timeLeft = 0;
    }
  }
}
