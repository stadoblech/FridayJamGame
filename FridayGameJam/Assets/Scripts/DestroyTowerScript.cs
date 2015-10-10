using UnityEngine;
using System.Collections;

public class DestroyTowerScript : MonoBehaviour {

    public bool alive = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy")
        {
            alive = false;
        }
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.tag == "Player" && Input.GetKeyDown(coll.gameObject.GetComponent<TowerDeploymentScript>().sellTower))
        {
            // ZMENIT
            Resources.golds += 3;
            alive = false;
        }
    }
}
