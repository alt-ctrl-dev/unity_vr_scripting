using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour {

    public GameObject directionalLight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Quaternion startRotation = Quaternion.Euler(50f, 30f, 0);
        Quaternion endRotation = Quaternion.Euler(200f, 30f, 0);
        directionalLight.transform.rotation = Quaternion.Slerp(startRotation, endRotation, Time.time / 20f);
    }
}
