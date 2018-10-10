using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour {

    public Transform projectileTarget;
    public Rigidbody projectileRigidBody;

    public float turn;
    public float projectileVelocity;

    private void FixedUpdate()
    {
        projectileRigidBody.velocity = transform.forward * projectileVelocity;

        var projectileTargetRotation = Quaternion.LookRotation(projectileTarget.position - transform.position);

        projectileRigidBody.MoveRotation(Quaternion.RotateTowards(transform.rotation, projectileTargetRotation, turn));
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
