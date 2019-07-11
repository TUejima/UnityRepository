using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTitle : MonoBehaviour {

    public void SceneLoad()
    {
        SceneManager.LoadScene("title");
    }
}
