using UnityEngine;
using System.Collections;

public class ObjectLifespanScript : MonoBehaviour {

    public float lifeSpan;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        lifeSpan -= Time.deltaTime;

        if (lifeSpan <= 0)
        {
            Destroy(gameObject);
        }
	}
}
