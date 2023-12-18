using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañopistola : HerenciadePwer
{
    
    void Start()
    {
        daño = 3;
    }
    public override void ApplyPowerUp(PlayerControl player)
    {
        player.AumentarDaño(daño);
    }
}
