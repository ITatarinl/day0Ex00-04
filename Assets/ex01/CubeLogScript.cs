using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogScript : MonoBehaviour
{
    public float fallSpeed = 0.07f;
    public KeyCode ACode;
    public KeyCode SCode;
    public KeyCode DCode;

    // Start is called before the first frame update
    void Start()
    {
        fallSpeed = Random.Range(0.02f, 0.05f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, -fallSpeed, 0f);

        if (transform.position.y <= -10) Destroy(gameObject);

        if ((Input.GetKey(ACode) ||
                   Input.GetKey(SCode) ||
                   Input.GetKey(DCode)) && transform.position.y <= -4
                                            && transform.position.y >= -6)
        {
            //spawnCount--;
            //Debug.Log("Good job, brooo ");
            Debug.Log("Precision: " + Mathf.Round((transform.position.y + 6.1f) * 10));
            Destroy(gameObject);
            
        }
        else if ((Input.GetKey(ACode) ||
            Input.GetKey(SCode) ||
            Input.GetKey(DCode)))
        {
            //Debug.Log("brooo, you missing");
        }
    }
}

