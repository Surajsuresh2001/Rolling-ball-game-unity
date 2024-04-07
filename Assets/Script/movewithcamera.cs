using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewithcamera : MonoBehaviour
{
    Vector3 distance;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - ball.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.transform.position + distance;
    }
}