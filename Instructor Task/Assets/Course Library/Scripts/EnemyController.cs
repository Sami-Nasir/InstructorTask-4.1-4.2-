using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed= 1.0f;
    private Rigidbody rb;
    private GameObject gb;
    //public Vector3 look;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        gb=GameObject.Find("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        //look=(;
        rb.AddForce((gb.transform.position - transform.position).normalized * speed);
    }
}
