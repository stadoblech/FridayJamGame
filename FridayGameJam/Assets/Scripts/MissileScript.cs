using UnityEngine;
using System.Collections;

public class MissileScript : MonoBehaviour {

    public float speed = 5;
    public Vector2 targetPosition;

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}
