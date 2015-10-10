using UnityEngine;
using System.Collections;

public class BaseLife : MonoBehaviour {

    public int lives = 20;

	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {

        if (lives <= 0)
        {
            Application.LoadLevel(Application.loadedLevel);
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
