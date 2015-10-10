using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIText : MonoBehaviour {

    Canvas text; 
	// Use this for initialization
	void Start () {
        text = GetComponent<Canvas>();
	}
	
	// Update is called once per frame
	void Update () {
        text.GetComponentInChildren<Text>().text = "Golds : " + Resources.golds; 
	}
}
