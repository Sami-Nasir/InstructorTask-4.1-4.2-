using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed= 1.0f;
    public float verticalInput;
    public Rigidbody rbody;
    private GameObject fpoint;
    void Start()
    {
        rbody=GetComponent<Rigidbody>();
        fpoint= GameObject.Find("Focal Point");
    }
    // Update is called once per frame
    void Update()
    {
      if(!(transform.position.x >15 || transform.position.x<-18 || transform.position.z >15 || transform.position.z<-15)){
        verticalInput= Input.GetAxis("Vertical");
        rbody.AddForce(fpoint.transform.forward * verticalInput * speed);
    }
    }
}
