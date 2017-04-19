using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    //public int lives = 3;
    //public int health = 2;
    //public Text healthText;
    //public Text livesText;
    //public GameObject hurtfx;
    //public int coinsLeft;
    //public GameObject coinos;
    //public Text coinsText;
    //public Text scoreText;
    //public int scoreValue;
    //public Image endIMG;
    //public Image deadIMG;
    public bool isDead = false;
    bool end = false;

    // Use this for initialization  
    void Start () {
        //lives = 3;
        //coinsLeft = FindObjectsOfType<CoinScript>().Length;
        //endIMG.enabled = false;
        //deadIMG.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        //healthText.text = health.ToString();
        //livesText.text = lives.ToString();
        //coinsText.text = coinsLeft.ToString();
        //scoreText.text = scoreValue.ToString();

        //if (coinsLeft <= 0 && !end)
        //{
        //    endIMG.enabled = true;
        //    isDead = true;
        //    end = true;
        //}

        //if (health <= 0)
        //{
        //    lives--;
        //    health = 2;
        //}
        //else if (lives < 0 )
        //{
        //    isDead = true;
        //    deadIMG.enabled = true;            
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{ coinsLeft = 0; }
    }

    //public void hurt()
    //{
    //    health--;
    //    GameObject hurt = Instantiate(hurtfx, transform.position, transform.rotation);
    //}
}
