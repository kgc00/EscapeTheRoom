using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggerScript : MonoBehaviour {

    public CameraScript cam;
    public int triggerNum;


	// Use this for initialization
	void Start () {
        cam = GameObject.FindObjectOfType<CameraScript>();
    }
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKeyDown(KeyCode.Space)) {
          //  cam.camNum += 1;
            //cam.ChangeCamera();
        //}
	}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        if (triggerNum == 1)
    //        {
    //            cam.camNum = 1;
    //            cam.ChangeCamera();
    //        }
    //        else if (triggerNum == 2)
    //        {
    //            cam.camNum = 2;
    //            cam.ChangeCamera();
    //        }
    //        else if (triggerNum == 3)
    //        {
    //            cam.camNum = 3;
    //            cam.ChangeCamera();
    //        }
    //        else if (triggerNum == 4)
    //        {
    //            cam.camNum = 4;
    //            cam.ChangeCamera();
    //        }
    //    }
    //}
}
