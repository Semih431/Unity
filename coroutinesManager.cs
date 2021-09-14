using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coroutinesManager : MonoBehaviour
{
    [SerializeField]
    private GameObject kup;

    private void Start()
    {
        StartCoroutine(GorunuruluguKapat());
    }

    IEnumerator GorunuruluguKapat()
    {
        yield return new WaitForSeconds(3f);

        kup.SetActive(false);

        yield return new WaitForSeconds(2f);

        kup.SetActive(true);

    }



}
