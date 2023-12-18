using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuraRojo : HerenciadePwer
{
    void Start()
    {
        vida = 5;
    }
    public override void ApplyPowerUp(PlayerControl player)
    {
        player.AumentarVida(vida);

    }
}