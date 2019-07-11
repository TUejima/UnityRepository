using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneLoadScript : MonoBehaviour
{

    public void SceneLoad()
    {
        SceneManager.LoadScene("Menu");
    }
}