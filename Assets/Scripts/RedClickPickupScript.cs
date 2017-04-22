using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedClickPickupScript : MonoBehaviour {

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
				if (hit.collider.gameObject.tag == "RedSphere") {
					gameObject.SetActive (false);
					inventory.redScore = inventory.redScore + 1;
					Debug.Log ("Red Sphere was collected");
				}
			}
		
	}
}
}