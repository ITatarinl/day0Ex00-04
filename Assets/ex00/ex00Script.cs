using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ex00Script : MonoBehaviour
{
    public KeyCode spaceCode;
    private double airInLungs = 100.0;
    private float timePassed = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(spaceCode) && airInLungs > 25)
        {
            airInLungs -= 30;
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
        }
        else
        {
            transform.localScale -= new Vector3(0.002f, 0.002f, 0.002f);
        }
        if (transform.localScale.x >= 10)
        {
            Debug.Log("Balloon life time: " + Mathf.RoundToInt(timePassed) + "s");
            transform.localScale = new Vector3(20f, 20f, 20f);
        }
        if (transform.localScale.x <= 0) {
            transform.localScale = new Vector3(0f, 0f, 0f);
            Debug.Log("you lossing");
        }
        if (airInLungs < 25)
        {
            transform.localScale -= new Vector3(0.002f, 0.002f, 0.002f);
        }
        if (airInLungs < 100)
        {
            airInLungs += 0.25f;
        }
        timePassed += Time.deltaTime;
    }
}
