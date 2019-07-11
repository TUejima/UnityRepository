using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectbig1 : MonoBehaviour
{
    [SerializeField]
    private float interval = 3f;
    [SerializeField]
    private float tmpTime = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("Loop");
    }

    IEnumerator Loop()
    {
        tmpTime += Time.deltaTime;

        if (tmpTime >= interval)
        {
            this.transform.localScale = new Vector3(2, 2, 1);
            yield return new WaitForSeconds(3);
            this.transform.localScale = new Vector3(1, 1, 1);
            tmpTime = 0;
        }
    }
}
