using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocationScript : MonoBehaviour {

    public int myMoveInt;
    public Vector3 myMoveLocation;
    public EscapeController ec;
    public EscapeScript es;

	// Use this for initialization
	void Start () {
        myMoveLocation = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Player noticed me");
        }
    }
}
