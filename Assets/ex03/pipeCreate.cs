using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pipeCreate : MonoBehaviour
{
    public GameObject pipeM1;
    public GameObject pipe1;
    public GameObject pipe0;
    [HideInInspector] public static bool b = true;
    [HideInInspector] public static int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= -7 && b)
        {
            switch (Random.Range(0,3))
            {
                case 0:
                    Instantiate(pipeM1, new Vector3(10f, -1f, 0), Quaternion.identity);
                    break;
                case 1:
                    Instantiate(pipe1, new Vector3(10f, 1f, 0), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(pipe0, new Vector3(10f, 0f, 0), Quaternion.identity);
                    break;
            }
            Destroy(gameObject);
            score += 5;
        }
        if (b) transform.Translate(-0.005f, 0f, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("You lossing");
        b = false;
    }
}
