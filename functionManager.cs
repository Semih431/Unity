using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionManager : MonoBehaviour
{
    public int toplama1;
    public int toplama2;


    
    void Start()
    {
        toplama1 = Topla(3, 5);
        toplama2 = Topla(20, 2);
        
    }

  
    void Update()
    {
        
    }

    private int Topla(int a , int b)
    {
        return a + b;
    }
}
