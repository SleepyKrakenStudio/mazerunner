using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshComp;
    Rigidbody obstacleBody;
    float dropTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        meshComp = GetComponent<MeshRenderer>();
        meshComp.enabled = false;
        obstacleBody = GetComponent<Rigidbody>();
        obstacleBody.useGravity = false;
        Vector3 localVector = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= dropTime)
        {
            meshComp.enabled = true;
            obstacleBody.useGravity = true;
        }
    }

    void AddTestMethod()
    {
        //test method
    }
}
