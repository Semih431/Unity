using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorManager : MonoBehaviour
{
    public GameObject kure;
    private int colorCode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            colorCode = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            colorCode = 2;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            colorCode = 3;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            colorCode = 4;
        }
        switch(colorCode)
        {
            case 1:
                kure.GetComponent<MeshRenderer>().material.color = Color.red;
              break;
            case 2:
                kure.GetComponent<MeshRenderer>().material.color = Color.black;
                break;
            case 3:
                kure.GetComponent<MeshRenderer>().material.color = Color.green;
                break;
            case 4:
                kure.GetComponent<MeshRenderer>().material.color = Color.blue;
                break;
        }

    }
}
