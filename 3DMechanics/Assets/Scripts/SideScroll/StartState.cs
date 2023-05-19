using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : States
{
    private Canvas HUD;
    public override IEnumerator Start()
    {
        HUD = GameObject.Find("Canvas").GetComponent<Canvas>();
        HUD.enabled = true;

        
        return base.Start();
    }

}
