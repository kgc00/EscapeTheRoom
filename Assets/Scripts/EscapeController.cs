using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscapeController : MonoBehaviour
{

    //CharacterController cc;
    EscapeScript es;
    public Quaternion myRot;

    //public int score = 0;
    //float moveSpeed = 5f;
    public bool canMove = true;
    //public LayerMask interactableMask;
    //public LayerMask puzzleMask;
    //public LayerMask geometryMask;
    //public LayerMask moveMask;

    Vector3 destinationVector;
    public int destinationInt;
    bool hasADestination = false;
    //bool hitSomethingNF;

    public GameObject destinationSparkle;
    public GameObject myPlay;
    public Vector3 myPlayPosition;
    public LayerMask uiMask;

    float tiltValue = 0;


    // Use this for initialization
    void Start()
    {
        //cc = gameObject.GetComponent<CharacterController>();
        es = gameObject.GetComponent<EscapeScript>();
        myPlayPosition = gameObject.transform.position;
    }

    void Update()
    {
        if (es.isDead)
        {
            canMove = false;
        }
        if (canMove)
        {            
            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                bool hitSomething = Physics.Raycast(ray, out hit, 1000);

                if (hitSomething)
                {
                    //Store the position that we clicked (in the 'destination' variable)                   
                    destinationVector = hit.point;
                    hasADestination = true;
                    if (hit.collider.gameObject.tag == "MoveLocation")
                    {
                        //hit.collider.gameObject.GetComponent<MoveLocationScript>().MoveMethod();
                        transform.position = new Vector3(hit.collider.gameObject.GetComponent<MoveLocationScript>().myMoveLocation.x, transform.position.y, hit.collider.gameObject.GetComponent<MoveLocationScript>().myMoveLocation.z);
                    }
                    else
                    {
                        //Instantiate a notification of where you clicked
                        //GameObject sparkle = (GameObject)Instantiate(destinationSparkle, destinationVector, Quaternion.identity);
                        //Destroy(sparkle, 3);
                    }
                }
            }
        }
    }

    public void RightArrowClicked()
    {
        Camera.main.transform.rotation = Quaternion.Euler(0, tiltValue + 30, 0);
        tiltValue = tiltValue + 30;
    }

    public void LeftArrowClicked()
    {
        Camera.main.transform.rotation = Quaternion.Euler(0, tiltValue - 30, 0);
        tiltValue = tiltValue - 30;
    }
}
               
   
   