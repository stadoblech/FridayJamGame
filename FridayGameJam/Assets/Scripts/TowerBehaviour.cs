using UnityEngine;
using System.Collections;

public class TowerBehaviour : MonoBehaviour {

    public GameObject missile;
    public float shotCooldown;

    bool isShotFired = false;
    float shotTimer;

    GameObject towerRange;
	void Start () {
        towerRange = transform.GetChild(0).gameObject;
        shotTimer = shotCooldown;
	}
	
	// Update is called once per frame
	void Update () {
        if (!towerRange.GetComponent<DestroyTowerScript>().alive)
        {
            Destroy(gameObject);
        }

        if (isShotFired)
        {
            shotTimer -= Time.deltaTime;

            if (shotTimer <= 0)
            {
                shotTimer = shotCooldown;
                isShotFired = false;
            }
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy" && !isShotFired)
        {
            missile.GetComponent<MissileScript>().targetPosition = coll.transform.position;
            Instantiate(missile,transform.position,Quaternion.identity);
        }
    }

    
}
