using UnityEngine;
using System.Collections;

public class EnemyLife : MonoBehaviour {

    public int Lives = 15;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Lives <= 0)
        {
            Resources.golds += 3; 
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Missile")
        {
            Lives -= coll.transform.GetComponent<MissileScript>().strenght;
        }
    }
}
