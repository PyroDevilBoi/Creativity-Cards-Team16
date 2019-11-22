using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
      //  pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -5f)
            SceneManager.LoadScene("gameOver");
    }
}
