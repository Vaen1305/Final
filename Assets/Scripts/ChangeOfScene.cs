using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeOfScene : MonoBehaviour
{
    public CasaControl casavida;
    public PlayerControl playervida;
    public CambiodeScena escenaDied;
    public CambiodeScena escenaLore;
    public Timer timer;

    void Update()
    {
        if (casavida.vida <= 0 || playervida.vidaj <= 0)
        {
            escenaDied.LoadScene();
        }

        if (casavida.vida > 0 && playervida.vidaj> 0 && timer.timer <= 0)
        {
            escenaLore.LoadScene();
        }
    }
}