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
        
    }

    // Use this for initialization
    void Start () {
        projectileTarget = GameObject.FindGameObjectWithTag("Follow").transform;
        StartCoroutine(Life());

        projectileRigidBody.velocity = (projectileTarget.transform.position - transform.position).normalized * projectileVelocity;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator Life()
    {
        yield return new WaitForSeconds(8);
        Destroy(this.gameObject);
    }
}
