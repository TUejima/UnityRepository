using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectmove1 : MonoBehaviour
{
    bool m_xPlus = true;  // x 軸プラス方向に移動中か？
    Rigidbody2D rb;
    void Start()
    {
       
    }
    void Update()
    {
        if( m_xPlus)
        {
            transform.position += new Vector3(2f * Time.deltaTime, 0f, 0f);
            if (transform.position.x >= 3)
                m_xPlus = false;
        } else
        {
            transform.position -= new Vector3(2f * Time.deltaTime, 0f, 0f);
            if (transform.position.x <= -3)
                m_xPlus = true;
        }
    }
}