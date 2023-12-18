using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConvertidoraTexto : MonoBehaviour
{


    public Text textocasa;
    public CasaControl vidacasa;

    void Update()
        {
            textocasa.text = vidacasa.vida.ToString();
        }
    
}
