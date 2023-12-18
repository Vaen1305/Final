using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuraVerde : HerenciadePwer
{
    void Start()
    {
        vida = 3;
    }
    public override void ApplyPowerUp(PlayerControl player)
    {
        player.AumentarVida(vida);
    }
}
