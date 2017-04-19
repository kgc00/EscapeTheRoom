using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour {

	CharacterController cc;
    PlayerScript ps;

	float rotateSpeed = 125f;
	float movementSpeed = 8f;

	float gravity = -1f;
	float yVelocity = 0;
	float jumpSpeed = 0.3f;

	public int score = 0;

	// Use this for initialization
	void Start () {
		cc = gameObject.GetComponent<CharacterController> ();
        ps = gameObject.GetComponent<PlayerScript>();
	}

    // Update is called once per frame
    void Update() {
        if (!ps.isDead)
            {
            float hAxis = Input.GetAxis("Horizontal");
            float vAxis = Input.GetAxis("Vertical");

            transform.Rotate(0, hAxis * rotateSpeed * Time.deltaTime, 0);

            if (!cc.isGrounded) {// SAME THING AS: if (cc.isGrounded == false) {
                                 //Apply gravity to the velocity
                yVelocity = yVelocity + gravity * Time.deltaTime;

                //If we are moving upwards, and we have released the space bar, set the upward velocity to 0,
                //this will make it so the player will start falling (from gravity) when the player releases the space bar
                if (Input.GetKeyUp(KeyCode.Space) && yVelocity > 0) {
                    yVelocity = 0;
                }
            } else {
                //Grounded
                if (Input.GetKeyDown(KeyCode.Space)) {
                    //Jump!
                    yVelocity = jumpSpeed * 1.75f;
                }
            }

            Vector3 motion = transform.forward * vAxis * movementSpeed * Time.deltaTime;
            //Set the y velocity value that we have been managing ourselves above
            //In this value, we have accounted for jumping and gravity
            motion.y = yVelocity;

            //Finally, move the player
            cc.Move(motion);
        }
    }

    public void CoinDecrement()
    {
        //ps.coinsLeft--;
        //ps.scoreValue = ps.scoreValue + 10;
    }
}
