using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    public float BGspeed;
    public Renderer bgRend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset= bgRend.material.mainTextureOffset + new Vector2(BGspeed * Time.deltaTime, 0f);
    }
}
