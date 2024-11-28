using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waves : MonoBehaviour
{
    public Transform[] blocks12;
    public Transform[] block34;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int num = 0; num < blocks12.Length; num++)
    {
        Vector3 blockPosition = blocks12[num].position;
        float movement = Mathf.Sin(Time.time*2f ) * 0.1f; 
        blockPosition.y = movement + 1f; 
        blocks12[num].position = blockPosition;
    }

    for (int num = 0; num < block34.Length; num++)
    {
        Vector3 blockPosition = block34[num].position;
        float movement = Mathf.Sin(Time.time*2f) * -0.1f; 
        blockPosition.y = movement + 1f; 
        block34[num].position = blockPosition;
    }
    }
}
