using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoScopeta : HerenciadePwer
{
    void Start()
    {
        daño = 5;
    }
    public override void ApplyPowerUp(PlayerControl player)
    {
        player.AumentarDaño(daño);
    }
}
