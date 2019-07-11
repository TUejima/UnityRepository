using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearNext : MonoBehaviour {

    GameObject GameClear;
    public GameObject clearreturn;
    public GameObject clearnext;

    private void Start()
    {
        GameClear = GameObject.Find("GameClear");
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "player")
        {
            GameClear.SendMessage("Win");
            clearreturn.SetActive(true);
            clearnext.SetActive(true);
        }
    }
}
