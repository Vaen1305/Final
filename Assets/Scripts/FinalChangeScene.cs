using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChangeScene : MonoBehaviour
{
    public MovimientoEnemy enemylife;
    public PlayerControl playervida;
    public CambiodeScena escenaDied;
    public CambiodeScena escenaWinLore3;

    void Update()

    {
        float vida = enemylife.GetVida();

        if ( playervida.vidaj <= 0)
        {
            escenaDied.LoadScene();
        }

        if (vida<=0 && playervida.vidaj > 0)
        {
            escenaWinLore3.LoadScene();
        }
    }
}
