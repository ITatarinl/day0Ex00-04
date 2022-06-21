using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftPlayerScr : MonoBehaviour // по началу хотел в разных скриптах сделать, потом передумал :)
{
    public KeyCode WCode;
    public KeyCode SCode;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(WCode)) && transform.position.y < 3.8f && gameObject.name == "leftPlayer")
        {
            transform.Translate(0f, +0.01f, 0);
        }
        if ((Input.GetKey(SCode)) && transform.position.y > -3.8f && gameObject.name == "leftPlayer")
        {
            transform.Translate(0f, -0.01f, 0);
        }
        if ((Input.GetKey(WCode)) && transform.position.y < 3.8f && gameObject.name == "rightPlayer")
        {
            transform.Translate(0f, +0.01f, 0);
        }
        if ((Input.GetKey(SCode)) && transform.position.y > -3.8f && gameObject.name == "rightPlayer")
        {
            transform.Translate(0f, -0.01f, 0);
        }
    }
}
