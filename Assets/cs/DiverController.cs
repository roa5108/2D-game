using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiverController : MonoBehaviour
{
    float speed = 0;
    float speed2 = 0;
    Vector2 startPos;
    Vector2 startPos2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = (endPos.x - this.startPos.x);
            this.speed = swipeLength / 500.0f;
        }

        else if (Input.GetMouseButtonDown(1))
        {
            this.startPos2 = Input.mousePosition;
        }

        else if (Input.GetMouseButtonUp(1))
        {
            Vector2 endPos2 = Input.mousePosition;
            float swipeLength2 = (endPos2.y - this.startPos2.y);
            this.speed2 = swipeLength2 / 500.0f;
        }

        else if (Input.GetMouseButtonUp(2))
        {
            Vector3 currentScale = transform.localScale;
            currentScale.x *= -1f;
            transform.localScale = currentScale;
        }

        if (transform.localScale.x < 0 && this.speed < 0)
        {
            transform.Translate(this.speed, 0, 0);
        }
        else if(transform.localScale.x > 0 && this.speed > 0)
        {
            transform.Translate(this.speed, 0, 0);
        }
        transform.Translate(0, this.speed2, 0);

        this.speed *= 0.98f;
        this.speed2 *= 0.98f;
    }
}
