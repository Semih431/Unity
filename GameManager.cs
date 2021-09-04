using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int quiz1, quiz2, quiz3, quiz4;
    float ortalama;

    // Start is called before the first frame update
    void Start()
    {
        quiz1 = Random.Range(0, 101);
        quiz2 = Random.Range(0, 101);
        quiz3 = Random.Range(0, 101);
        quiz4 = Random.Range(0, 101);

        ortalama = (quiz1 + quiz2 + quiz3 + quiz4) / 4;

        Debug.Log("Ortalamanýz =" + ortalama);

        if (ortalama >= 85)
        {
            Debug.Log("Notunuz A");
        }
        else if (ortalama >= 70 && ortalama < 85)
        {
            Debug.Log("Notunuz B");
        }
        else if (ortalama >= 50 && ortalama < 70)
        {
            Debug.Log("Notunuz C");
        }
        else
        {
            Debug.Log("Sýnavdan Kaldýnýz");
        }


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
