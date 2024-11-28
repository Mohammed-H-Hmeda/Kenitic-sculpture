using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float movement = Mathf.Sin(Time.time)* 0.1f + 1f;
        transform.position=new Vector3(23.37f,movement+0.4f,40.44f);


    }
}
