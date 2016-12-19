using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour {

    public GameObject directionalLight;

    float startTime = 0f;
    bool isPressed = false;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (GvrViewer.Instance.Triggered && !isPressed)
            ActivateRotation();

        Quaternion startRotation = Quaternion.Euler(50f, 30f, 0);
        Quaternion endRotation = Quaternion.Euler(200f, 30f, 0);
        if (isPressed)
        {
            directionalLight.transform.rotation = Quaternion.Slerp(startRotation, endRotation, startTime / 20f);
            startTime += Time.deltaTime;
        }
    }

    public void ActivateRotation() {
        isPressed = true;
    }
}
