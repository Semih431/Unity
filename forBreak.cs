using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forBreak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         for(int i=0;i<100;i++)
        {
            Debug.Log(i);

            // De�er 40 a ula��nca d�ng�y� durdurduk
            if(i==40)
            {
                break;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
