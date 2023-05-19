using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

public abstract class States
{
    public virtual IEnumerator Start()
    {
        yield break;
    }
    public virtual IEnumerator Play()
    {
        yield break;
    }public virtual IEnumerator Pause()
    {
        yield break;
    }public virtual IEnumerator Stop()
    {
        yield break;
    }
}
