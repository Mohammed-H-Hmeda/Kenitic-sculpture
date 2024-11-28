using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Unity.Mathematics;
using UnityEngine;

public class Stick : MonoBehaviour
{
    float counter=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        counter+=1;
        float move=Mathf.Sin(Time.time)*20f;
        transform.rotation=Quaternion.Euler(new Vector3(0,200.385f+move,0));
        
        
    }
}
