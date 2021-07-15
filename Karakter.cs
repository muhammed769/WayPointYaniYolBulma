using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    public GameObject[] noktalar;
    Transform gecerliNokta;
    Vector3 pozisyon;

    int DevriyeNoktaSayisi = 0;


    void Start()
    {
        gecerliNokta = noktalar[0].transform;
            
    }


    void Update()
    {
        pozisyon = gecerliNokta.position - transform.position;
        transform.Translate(pozisyon.normalized * 2f * Time.deltaTime,Space.World);

        // Karakteriimin hedeflediðim pozisyona gidip gidemediðini anlamam lazým.Bunuda Þöyle anlarýz : 

        if (Vector3.Distance(transform.position, gecerliNokta.position)<= 0.1f)
        {
            BirsonrakiPozisyonaGit();
        }
    }

    void BirsonrakiPozisyonaGit()
    {
        if (DevriyeNoktaSayisi>=noktalar.Length-1)
        {
            Debug.Log(" Bitti");
            return;
        }
        DevriyeNoktaSayisi++;
        gecerliNokta = noktalar[DevriyeNoktaSayisi].transform;
    }


}
