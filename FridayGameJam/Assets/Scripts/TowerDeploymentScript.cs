using UnityEngine;
using System.Collections;

public class TowerDeploymentScript : MonoBehaviour {


    public KeyCode DeployTower = KeyCode.Space;
    
    /// <summary>
    /// prodej se provadi v DestroyTowerScript
    /// </summary>
    public KeyCode sellTower = KeyCode.LeftAlt;

    public GameObject tower;
    public int cost = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(DeployTower)&&Resources.golds >= cost)
        {
            Resources.golds -= cost;

            Instantiate(tower,transform.position,Quaternion.identity);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.name == "Range")
        {

            //Application.LoadLevel(Application.loadedLevel);
        }
    }
}
