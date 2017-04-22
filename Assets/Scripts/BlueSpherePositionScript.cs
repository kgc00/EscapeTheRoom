using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSpherePositionScript : MonoBehaviour {

	public GameObject BlueSphere;

	InventoryScript inventory;

	// Use this for initialization
	void Start () {
		GameObject player = GameObject.Find ("Player");
		inventory = player.GetComponent<InventoryScript> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			bool hitSomething = Physics.Raycast(ray, out hit, 100);
			if (hitSomething) {
				if (hit.collider.gameObject.tag == "BluePosition" && inventory.blueScore == 1) {
					Instantiate (BlueSphere);
				}
		
	}
}
	}
}