using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wandRay : MonoBehaviour {
    public Transform firePoint;

	// Use this for initialization
	void Awake () {
        firePoint = transform.Find("Arnis/wandSphere");
        if (firePoint == null)
        {
            Debug.LogError("No firepoint");
        }
    }
	
	// Update is called once per frame
	void Update () {
        RaycastHit2D hit;


	}
}

/*
 * Vector3 targetPosition = new Vector3(transform.position.x - 100, transform.position.y, transform.position.z);
    Vector3 firePointPosition = new Vector3(firePoint.position.x, firePoint.position.y, firePoint.position.z);
    RaycastHit2D hit = Physics2D.Raycast(firePointPosition, targetPosition - firePointPosition, 50, whatToHit);
    Effect();
    Debug.DrawLine(firePointPosition, (targetPosition - firePointPosition) * 100, Color.cyan);
    if (hit.collider != null)
    {
        Debug.DrawLine(firePointPosition, hit.point, Color.red);
    }
 */
