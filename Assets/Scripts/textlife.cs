using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textlife : MonoBehaviour
{
    public Text textovida;
    public PlayerControl vidaplayer;

    
    // Update is called once per frame
    void Update()
    {
        textovida.text = vidaplayer.vidaj.ToString();
    }
}
