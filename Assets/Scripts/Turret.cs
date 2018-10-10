using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Turret : MonoBehaviour {
    public Transform playerTarget;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //Debug.Log("Looking for Camera");
        this.transform.LookAt(playerTarget);
	}
}
