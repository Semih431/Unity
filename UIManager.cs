using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text sayiText;


    public int artanDeger;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sayiText.text = artanDeger.ToString();
    }

    public void ButonaTiklandi()
    {

        artanDeger++;
    }
}
