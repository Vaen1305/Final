using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidabossText : MonoBehaviour
{
    public Text textovidaboss;
    public MovimientoEnemy vidaboss;
    // Update is called once
    // per frame
   
        void Update()

    {
        float vida = vidaboss.GetVida();
    
    textovidaboss.text = vida.ToString();
    }
}
