using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltinAlgilayicisi : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ayaklar")
        {
            GetComponentInParent<Altin>().AltinKapat();
            FindObjectOfType<Puan>().AltinKazan();
        }
    }
}
