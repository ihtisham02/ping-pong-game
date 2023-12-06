using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PandleController : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       Movement(); 
    }

    private void Movement()
    {
        foreach(Touch touch in Input.touches)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Vector2 myPosition = rb.position;

            if(Mathf.Abs(touchPosition.x - myPosition.x)<=2)
            {
                myPosition.y = Mathf.Lerp(myPosition.y, touchPosition.y, 10);
                myPosition.y = Mathf.Clamp(myPosition.y, -3.7f, 3.7f);
                rb.position = myPosition;
            }
        }
       
       
       
    }
}
