using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefab;
    // Start is called before the first frame update
    private float x,z;
    void Start()
    {
        for(int i=0; i<4; i++){
         Instantiate(prefab[i],funcPos(),prefab[i].transform.rotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 funcPos(){
         x= Random.Range(-9,9);
         z= Random.Range(-9,9);
        Vector3 pos= new Vector3(x,0,z);
        return pos;
    }
}
