using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 8;

    public float endX;
    public float startX;
    


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
        
    }
    /*
    Vector2 pos;
    Vector2 initialPos;
    

    // Start is called before the first frame update
    void Start()
    {
        
        initialPos = transform.position;
        pos.x = transform.position.x;
        
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = pos.x - 0.1f;
        transform.position = pos;
    }


    */
}
