using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCollectorScript : MonoBehaviour {

    //public PlaneController pc;
    //public EthanScript[] es;
    public static int numOfCollectors;
    public int esScore;
    public int speedScore;
    public int healthPenalty;

    // Use this for initialization
    void Start()
    {
        //es = FindObjectsOfType<EthanScript>();
        //pc = FindObjectOfType<PlaneController>();
    }

    private void Awake()
    {
        numOfCollectors++;

        if (numOfCollectors > 1)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void StoreScore()
    {
        //es = FindObjectsOfType<EthanScript>();
        //esScore = es.Length * 500;
        //speedScore = Mathf.RoundToInt(pc.speed);
        //healthPenalty = Mathf.RoundToInt(pc.maxHealth - pc.health);

    }
}
