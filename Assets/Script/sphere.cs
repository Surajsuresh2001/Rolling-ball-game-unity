using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sphere : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    int count;
    float x;
    float z;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
       

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        Vector3 v = new Vector3(x,0.0f,z);
        rb.AddForce(v * 15);
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);
           

            
            //Destroy(other.gameObject);
        }
    }
}