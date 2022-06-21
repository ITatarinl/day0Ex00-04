using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScr : MonoBehaviour
{
    public KeyCode spaceCode;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(spaceCode)) && pipeCreate.b)
        {
            transform.Translate(0f, +0.4f, 0);
        }
        else if(pipeCreate.b)
        {
            transform.Translate(0f, -0.005f, 0);
        }
    }
}
