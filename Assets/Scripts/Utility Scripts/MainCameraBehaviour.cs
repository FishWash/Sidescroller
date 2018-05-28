using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraBehaviour : MonoBehaviour 
{

// -Class Variables
	[SerializeField] float smoothTime = 0;
	GameObject target;
	Vector3 velocity;
 
// -MonoBehaviour Methods
	void Start () {
    velocity = Vector3.zero;
	}

  void Update() {
    followTarget();
  }

  void followTarget() {
    if (target != null) {
      Vector3 targetPosition = target.transform.position;
      transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
    else {
      target = TryFindPlayer();
    }
  }

// -Other Methods
	GameObject TryFindPlayer()
	{
    Debug.Log("Camera: Looking for a Player...");
		GameObject _player = GameObject.FindGameObjectWithTag("Player");
    return _player;
	}
}
