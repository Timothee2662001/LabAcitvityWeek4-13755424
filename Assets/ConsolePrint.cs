using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    // Start is called before the first frame update
    int i = 3;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i += 1;
        Debug.Log(gameObject.name + ":" + i);
    }
}
