using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BottomController : MonoBehaviour
{
    public GameObject gameOver;
    public GameObject Retry;
   // bool goTitle = false;
    
    public void OnCollisionEnter2D(Collision2D col)
    {
        gameOver.SendMessage("Lose");
      //  goTitle = true;//Update文の実行
        Retry.SetActive(true);
    }
}