using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class textbullet : MonoBehaviour
{
  
    public Text textobalas;
    public PlayerControl balas;

    // Update is called once per frame
    void Update()
    {
        textobalas.text = balas.balasRestantes.ToString();
    }
}