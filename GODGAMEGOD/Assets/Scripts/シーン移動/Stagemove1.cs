using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Stagemove1 : MonoBehaviour
{

    public void SceneLoad()
    {
        SceneManager.LoadScene("Stage1");
    }
}