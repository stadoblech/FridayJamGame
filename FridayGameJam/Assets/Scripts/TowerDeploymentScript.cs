using UnityEngine;
using System.Collections;

public class TowerDeploymentScript : MonoBehaviour {

    public KeyCode DeployTower = KeyCode.Space;
    public KeyCode sellTower = KeyCode.X;

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
}
