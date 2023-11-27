using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;

    void Start()
    {
        // Oyun baþladýðýnda baþlangýç zamanýný kaydet
        startTime = Time.time;
    }

    void Update()
    {
        // Geçen süreyi hesapla
        float t = Time.time - startTime;

        // Saat, dakika ve saniyeyi hesapla
        int hours = (int)(t / 3600);
        int minutes = (int)(t / 60) % 60;
        int seconds = (int)(t % 60);

        // Zamaný formatla ve göster
        timerText.text = string.Format("Time:{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
    }
}