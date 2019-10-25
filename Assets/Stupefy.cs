using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stupefy : MonoBehaviour {
    public Transform firePoint;
    Vector3 startPos = Vector3.zero;
    bool firstPressed = true;
    bool calcDistance = false;
    float totalDistance = 0f;
    float time = 0f;
    float time2 = 0f;
	// Use this for initialization
	void Start () {
		firePoint = transform.Find("firePoint");
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("RIGHT " + OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger));
        //Debug.Log("LEFT" + OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger));
        if (Input.GetKeyDown("f"))
        {
            Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.cyan);
            GameObject shootObj = Instantiate(Resources.Load("Sphere"), firePoint.position, firePoint.rotation) as GameObject;
            shootObj.GetComponent<Rigidbody>().velocity = firePoint.forward * 15;
        }
        if (OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) > 0.3 && firstPressed)
        {
           // Debug.Log("pressed");
            startPos = transform.position;
            firstPressed = false;
            calcDistance = true;
            time = Time.time;
        }

        if(calcDistance == true && OVRInput.Get(OVRInput.Axis1D.SecondaryIndexTrigger) == 0)
        {
           // Debug.Log("possible spell");
            float distance = Vector3.Distance(transform.position, startPos);
            time2 = Time.time;
            Debug.Log(distance / (time2 - time));

           

            if (distance / (time2 - time) > 0.1)
            {
                Debug.Log("shoot");
                // RaycastHit hit;
                Debug.DrawRay(firePoint.position, firePoint.forward * 100, Color.cyan);
                GameObject shootObj = Instantiate(Resources.Load("Sphere"), firePoint.position, firePoint.rotation) as GameObject;
                shootObj.GetComponent<Rigidbody>().velocity = firePoint.forward * 15;
                //Vector3 direction = shootObj.GetComponent<Rigidbody>().velocity;
                //  direction.z = firePoint.up.z * 15;
                //direction = firePoint.position / 5;
                // shootObj.GetComponent<Rigidbody>().velocity = direction;
            }
            time = 0f;
            time2 = 0f;
            calcDistance = false;
            firstPressed = true;
        }
	}
}
