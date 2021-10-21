using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetPlane : MonoBehaviour
{
    const int ID = 5;
    int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Object name: " + this.name + "\tTag: " + this.tag + "\tID: " + ID + "\tcounter: " + counter++);  
    }
}
