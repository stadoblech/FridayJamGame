using UnityEngine;
using System.Collections;

public class MissileScript : MonoBehaviour {

    public float speed = 5;
    public int strenght = 5;
    public GameObject target;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (target == null)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        }   
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
