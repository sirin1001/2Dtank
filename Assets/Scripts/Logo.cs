using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var pos = transform.position;
        var scl = transform.localScale;

        pos.x = 0;
        pos.y = 0;
        pos.z = 0;

        scl.x = (float)3.7;
        scl.y = (float)3.7;
        scl.z = 1;

        transform.position = pos;
        transform.localScale = scl;
    }

    // Update is called once per frame
    void Update()
    {
        var scl = transform.localScale;
        
        if (scl.x >= 0.1 && scl.y >= 0.1)
        {
            scl.x *= (float)0.95;
            scl.y *= (float)0.95;
        }
        if(scl.x < 0.1 && scl.y < 0.1)
        {
            scl.x = 0;
            scl.y = 0;
        }

        transform.localScale = scl;
        

    }
}
