using UnityEngine;
using System.Collections;

public class drawPhysicsLine : MonoBehaviour
{

    public GameObject linePrefab;
    public float lineLength = 0.2f;
    public float lineWidth = 0.1f;
    public int count;

    private Vector3 touchPos;

    void Start()
    {

    }

    void Update()
    {
        drawLine();
        if (Input.GetKey(KeyCode.Space))
        {
            gameObject.GetComponent<drawPhysicsLine>().enabled = false;
        }
    }

    void drawLine()
    {

        if (Input.GetMouseButtonDown(0))
        {
            touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            touchPos.z = 0;
        }

        if (Input.GetMouseButton(0))
        {

            Vector3 startPos = touchPos;
            Vector3 endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            endPos.z = 0;
            //if (count < 1)
            //    return;
            //count -= 1;

            if ((endPos - startPos).magnitude > lineLength)
            {
                if (count < 1)
                    return;
                count -= 1;

                GameObject obj = Instantiate(linePrefab, transform.position, transform.rotation) as GameObject;
                obj.transform.position = (startPos + endPos) / 2;
                obj.transform.right = (endPos - startPos).normalized;
                endPos.z = 0;
                obj.transform.localScale = new Vector3((endPos - startPos).magnitude, lineWidth, lineWidth);

                obj.transform.parent = this.transform;

                touchPos = endPos;
              
            }
        }
    }
}