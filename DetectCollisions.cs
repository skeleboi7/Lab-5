using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


    }
        void OnTriggerEnter(Collider Wall){
            Destroy(gameObject);
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
