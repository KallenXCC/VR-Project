using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour {
    public Transform firePoint;

	// Use this for initialization
	void Start () {
        firePoint = transform.Find("firePoint");
        if (firePoint == null)
        {
            Debug.LogError("No firepoint");
        }
    }
	
	// Update is called once per frame
	void Update () {
        //Vector3 targetPosition = new Vector3(transform.position.x - 100, transform.position.y, transform.position.z);
        //Vector3 firePointPosition = new Vector3(firePoint.position.x, firePoint.position.y, firePoint.position.z);

        //RaycastHit2D hit = Physics2D.Raycast(firePointPosition, targetPosition - firePointPosition, 50);
        //Debug.DrawLine(firePointPosition, firePoint.forward * 100, Color.cyan);
        //if (hit.collider != null)
        //{
        //    Debug.Log("we hit " + hit.collider.name);
        //}

        RaycastHit hit;
        Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.cyan);
        if(Physics.Raycast(firePoint.position, firePoint.forward, out hit, 100f) && hit.transform.tag == "rock")
        {
            // Debug.Log("we hit a " + hit.transform.name);
            Debug.Log("hit rock");
            StartCoroutine(moveObject(hit));
            //float distance = 3.0f;
            //Vector3 diff = hit.transform.position - firePoint.position;
            //hit.transform.position = firePoint.position + diff.normalized * distance;
        }
    }

    IEnumerator moveObject(RaycastHit hit)
    {
        //Vector3 direction = hit.transform.position;
        //direction.z += 10;
        //direction = direction.normalized;
        //hit.rigidbody.AddForce(direction * 100f);

        //Vector3 targetPos = hit.transform.position;
        //targetPos.z += 10.0f;
        //hit.transform.Translate(Vector3.forward * Time.deltaTime);

        Vector3 direction = hit.rigidbody.velocity;
        direction.z = 5.0f;
        hit.rigidbody.velocity = direction;

        yield return new WaitForSeconds(3);
        hit.rigidbody.velocity = Vector3.zero;
    }
}
