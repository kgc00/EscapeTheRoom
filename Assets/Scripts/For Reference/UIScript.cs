using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    public Image img;
    Color color = new Color (1, 1, 1, 0);
    bool playHurt;

	// Use this for initialization
	void Start () {
        img = GetComponent<Image>();
        img.color = color;
    }
	
	// Update is called once per frame
	void Update () {
        if (playHurt)
        {
            if (img.color.a < 1)
            {
                img.color += new Color(color.r, color.g, color.b, .2f) * Time.deltaTime;
            }
        } else if (!playHurt)
        {
            if (img.color.a > 0)
            {
                img.color -= new Color(color.r, color.g, color.b, .5f) * Time.deltaTime;
            }
        }
    }

    public void PlayerHurt()
    {        
        playHurt = true;
        //Debug.Log("PlayHurt");
    }

    public void PlayerNotHurt()
    {
        playHurt = false;
        //Debug.Log("PlayNotHurt");
    }
}
