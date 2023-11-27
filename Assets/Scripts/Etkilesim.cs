using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YaklasincaRenkDegistir : MonoBehaviour
{
    public float etkilesimMesafesi = 6f; // Etkileþim mesafesi
    public Color normalRenk = Color.white; // Nesnenin normal rengi
    public Color etkilesimRenk = Color.yellow; // Yaklaþýldýðýnda deðiþtirilecek renk

    private Material nesneMaterial; // Nesnenin Material bileþeni

    void Start()
    {
        nesneMaterial = GetComponent<Renderer>().material;
        nesneMaterial.color = normalRenk; // Nesneye baþlangýçta normal rengi uygula
    }

    void Update()
    {
        // Karakter ile nesne arasýndaki mesafeyi ölç
        float mesafe = Vector3.Distance(transform.position, Camera.main.transform.position);

        // Eðer mesafe etkileþim mesafesinden küçükse
        if (mesafe < etkilesimMesafesi)
        {
            // Rengi deðiþtir
            nesneMaterial.color = etkilesimRenk;
        }
        else
        {
            // Eðer mesafe etkileþim mesafesinden büyükse, normal rengi geri yükle
            nesneMaterial.color = normalRenk;
        }
    }
}
