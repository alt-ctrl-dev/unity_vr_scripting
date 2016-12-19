using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTreasure : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10))
            print("There is something in front of the object!");
        else
            print("There is nothing in front of the object!");
    }
}
