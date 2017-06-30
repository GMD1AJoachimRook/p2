using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScytheMovement : MonoBehaviour {
    public Animator whack;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.E))
        {
            whack.SetTrigger("Attack");
        }
		
	}
}
