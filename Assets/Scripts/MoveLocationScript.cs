using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLocationScript : MonoBehaviour {

    //public int myMoveInt;
    public Vector3 myMoveLocation;
    public EscapeController ec;
    public EscapeScript es;
    public GameObject myPlay;

	// Use this for initialization
	void Start () {
        myMoveLocation = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MoveMethod()
    {
        Debug.Log(myPlay.transform.position);
        myPlay.transform.position += new Vector3 (20,0,10);       
    }    
}
