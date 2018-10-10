using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class Turret : MonoBehaviour {
    public GameObject Bullet;
    public Transform playerTarget;
    public GameObject Cannon;
    // Use this for initialization
    void Start () {
        StartCoroutine(ShootCoroutine());
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        //Debug.Log("Looking for Camera");
        this.transform.LookAt(playerTarget);
	}

    IEnumerator ShootCoroutine() {
        while (true)
        {
            yield return new WaitForSeconds(5);
            Shoot();
        }
    }

    void Shoot() {
        Instantiate(Bullet, Cannon.transform.position, Quaternion.LookRotation(Cannon.transform.forward, Cannon.transform.up));
    }

}
