﻿using UnityEngine;
using System.Collections;

public class BaseLife : MonoBehaviour {

    public static int lives;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {

        if (lives <= 0)
        {
            //Application.LoadLevel(Application.loadedLevel);
            GameLogicScript.restartGame();
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy")
        {
            lives--;
        }
    }
}
