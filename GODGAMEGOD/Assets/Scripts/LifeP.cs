using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeP : MonoBehaviour {

    private Text texthp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int Count = GameObject.FindGameObjectsWithTag("Destroy").Length;
        this.texthp = this.GetComponent<Text>();
        this.texthp.text = Count + "  MAX 30";
	}

}
