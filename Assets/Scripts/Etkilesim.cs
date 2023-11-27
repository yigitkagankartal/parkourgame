using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class YaklasincaRenkDegistir : MonoBehaviour
{
    public float etkilesimMesafesi = 6f; // Etkile�im mesafesi
    public Color normalRenk = Color.white; // Nesnenin normal rengi
    public Color etkilesimRenk = Color.yellow; // Yakla��ld���nda de�i�tirilecek renk

    private Material nesneMaterial; // Nesnenin Material bile�eni

    void Start()
    {
        nesneMaterial = GetComponent<Renderer>().material;
        nesneMaterial.color = normalRenk; // Nesneye ba�lang��ta normal rengi uygula
    }

    void Update()
    {
        // Karakter ile nesne aras�ndaki mesafeyi �l�
        float mesafe = Vector3.Distance(transform.position, Camera.main.transform.position);

        // E�er mesafe etkile�im mesafesinden k���kse
        if (mesafe < etkilesimMesafesi)
        {
            // Rengi de�i�tir
            nesneMaterial.color = etkilesimRenk;
        }
        else
        {
            // E�er mesafe etkile�im mesafesinden b�y�kse, normal rengi geri y�kle
            nesneMaterial.color = normalRenk;
        }
    }
}
