using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State
{
    public GameManager gM;

    public virtual void OnStateEnter() { }
    public virtual void Update() { }
    public virtual void FixedUpdate() { }
    public virtual void OnStateExit() { }
}
