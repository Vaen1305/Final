using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeScena : MonoBehaviour
{
    public string IrEscena;


   public void LoadScene()
   {
      SceneManager.LoadScene(IrEscena);
   }

}