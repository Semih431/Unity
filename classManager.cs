using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogrenci
{
    public string isim;
    public int kimlikNo;
    public string memleket;

    public Ogrenci(string isim, int kimlikNo, string memleket)
    {
        this.isim = isim;
        this.kimlikNo = kimlikNo;
        this.memleket = memleket;
    }

}

public class classManager : MonoBehaviour
{

    public Ogrenci yeniOgrenci = new Ogrenci("semih", 1245, "aydýn");
    public Ogrenci ikinciOgrenci = new Ogrenci("ahmet", 1234, "denizli");

    private void Start()
    {
        Debug.Log(ikinciOgrenci.isim);

    }






}