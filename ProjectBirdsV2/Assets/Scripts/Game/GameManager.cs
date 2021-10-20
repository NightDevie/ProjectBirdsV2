using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gM;
    public static State state;
    public ProfileData profileData;

    public string stateName;
    public Bird bird;
    public ObstacleManager obstacleManager;

    private void Awake()
    {
        if (gM == null)
        {
            gM = this;
        }
    }

    private void Start()
    {
        state = new StartState();
        state.gM = this;
        state?.OnStateEnter();
    }

    private void Update()
    {
        state?.Update();
    }
    private void FixedUpdate()
    {
        state?.FixedUpdate();
    }

    public void SwitchState(State newState)
    {
        state?.OnStateExit();
        state = newState;
        stateName = state.ToString();
        state.gM = this;
        state?.OnStateEnter();
    }
}
