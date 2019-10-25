using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collide : MonoBehaviour {
    public GameObject gm;

	// Use this for initialization
	void Start () {
        gm = GameObject.Find("GameManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("triggered");
    //    if (collision.gameObject.tag == "enemy")
    //    {
    //        Debug.Log("hit enemy njksGAUSAiusAa");
    //        //GameObject skeleton = other.gameObject;
    //        collision.collider.GetComponent<EnemyMove>().Die();
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("triggered");
        if(other.gameObject.tag == "enemy")
        {
            gm.GetComponent<gameManager>().incrementScore();
            Debug.Log("hit enemy njksGAUSAiusAa");
            //GameObject skeleton = other.gameObject;
            other.GetComponent<EnemyMove>().Die();
            Debug.Log("calling function");
         //   gm.GetComponent<gameManager>().incrementScore();
        }
    }
}
