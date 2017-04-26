using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeScript : MonoBehaviour
{

    //public int lives = 3;
    //public int health = 2;
    public bool isDead = false;
    //public Text healthText;
    //public Text livesText;
    //public GameObject hurtfx;
    ////public int coinsLeft;
    //public string inventoryString;
    //public GameObject coinos;
    //public Text inventoryText;
    //public Text scoreText;
    //public Text click;
    //public int scoreValue;
    //public Image endIMG;
    //public Image deadIMG;
    //public Text npcTextComponent;
    public NPCScript myNPC;
    //public Text goalText;
    //public string goalCantLeave;
    //public string pickupText;
    //public bool hasKey = false;
    bool end = false;
    float timer;
    float dialogueTimer;
    public float dialogueWaitTime = 5f;
    float msgWaitTime = 1.5f;
    public string npcDialogueText;
    //EndCubeScript endCube;

    // Use this for initialization  
    void Start()
    {
        //lives = 3;
        ////coinsLeft = FindObjectsOfType<CoinScript>().Length;
        ////endCube = FindObjectOfType<EndCubeScript>();
        //endIMG.enabled = false;
        //deadIMG.enabled = false;
        //click.enabled = false;
        //goalText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //healthText.text = health.ToString();
        //livesText.text = lives.ToString();
        //inventoryText.text = inventoryString;
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
        //else if (lives < 0)
        //{
        //    isDead = true;
        //    deadIMG.enabled = true;            
        //} 

        //if (Input.GetKeyDown(KeyCode.Space))
        //{ Debug.Log(transform.position.normalized); }

        //Timer for Cant Reach
        //if (click.enabled)
        //{
        //    timer = timer + Time.deltaTime;
        //    if (timer >= msgWaitTime)
        //    {
        //        click.enabled = false;
        //        timer = 0f;
        //    }
        //}
        //Timer for NPC Dialogue 
    //    if (npcTextComponent.enabled)
    //    {
    //        dialogueTimer = dialogueTimer + Time.deltaTime;
    //        if (dialogueTimer >= dialogueWaitTime)
    //        {
    //            npcTextComponent.enabled = false;
    //            dialogueTimer = 0f;
    //        }
    //    }
    }

    //public void hurt()
    //{
    //    health--;
    //    GameObject hurt = Instantiate(hurtfx, transform.position, transform.rotation);
    //}

    //public void Interact()
    //{
    //    dialogueTimer = 0f;
    //    npcTextComponent.text = npcDialogueText;
    //    npcTextComponent.color = Color.blue;
    //    npcTextComponent.enabled = true;
    //    npcTextComponent.transform.position = Camera.main.WorldToScreenPoint(transform.position);
    //}

    //public void Pickup()
    //{
    //    npcTextComponent.text = pickupText;
    //    dialogueWaitTime = 4f;
    //    npcTextComponent.color = Color.green;
    //    npcTextComponent.enabled = true;
    //    npcTextComponent.transform.position = Camera.main.WorldToScreenPoint(transform.position);
    //}

    //public void noKeyCantLeave()
    //{
    //    npcTextComponent.text = goalCantLeave;
    //    dialogueWaitTime = 4f;
    //    npcTextComponent.color = goalText.color;
    //    npcTextComponent.enabled = true;
    //    npcTextComponent.transform.position = Camera.main.WorldToScreenPoint(transform.position);
    //}

    //public void CantReach()
    //{
    //    click.text = "Can't Reach";
    //    click.enabled = true;
    //    click.transform.position = Camera.main.WorldToScreenPoint(transform.position);
    //}

    //public void NotFloor()
    //{
    //    click.text = "That's A NotFloor.";
    //    click.enabled = true;
    //    click.transform.position = Camera.main.WorldToScreenPoint(transform.position);
    //}

    //public void End()
    //{
    //    endIMG.enabled = true;        
    //}
}
