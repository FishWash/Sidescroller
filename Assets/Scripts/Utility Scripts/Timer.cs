using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
	float endTime;
	public bool isEnabled;

	public bool isDone {
    get {
    	if (isEnabled) 
    		return (Time.realtimeSinceStartup >= endTime);
    	else
    		return false;
    }
  }

  public float timeLeft {
  	get {
			return Mathf.Max(endTime - Time.realtimeSinceStartup, 0);
    }

    set {
			endTime = Time.realtimeSinceStartup + value;
			isEnabled = true;
    }
  }

	public Timer() {
		endTime = 0;
		isEnabled = true;
	}
}