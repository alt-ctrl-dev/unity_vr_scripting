using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTreasure : MonoBehaviour {

    public Animator openChest;
    private bool watched = false;
    // Use this for initialization
    void Start ()
    {
        openChest.StartPlayback();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10) && !watched)
            ActivateChestAnimation();

        if (watched)
        {
            openChest.StopPlayback();
        }
    }

    public void ActivateChestAnimation()
    {
        watched = true;
        openChest.SetBool("OpenLid", true);
    }
}
