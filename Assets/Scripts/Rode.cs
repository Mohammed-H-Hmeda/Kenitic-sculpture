using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Rode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move=Mathf.Sin(Time.time)*10f;
        transform.rotation=Quaternion.Euler(new Vector3(0,76.192f,move*1.2f));
        
    }
}
