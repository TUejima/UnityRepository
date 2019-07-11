using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonScript : MonoBehaviour {
    public GameObject MenuDisplay;

    public void Buttonclick()
    {
        MenuDisplay.SetActive(true);
    }
}
