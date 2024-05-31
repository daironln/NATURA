using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : PersistentSingleton<GameManager>
{
    [SerializeField] private int[] contCorrectAns;
    private string actualProblem;

    private void Start()
    {
        contCorrectAns = new []{0,0,0,0,0,0,0};
    }

    protected override void Awake()
    {
        base.Awake();
    }

    public int getContCorrectAns(int scen)
    {
        return contCorrectAns[scen];
    }

    public void sumContCorrectAns(int idx)
    {
        contCorrectAns[idx]++;
    }
    public void setContCorrectAnsto0(int idx)
    {
        contCorrectAns[idx]=0;
    }

    public string getActualProblem()
    {
        return actualProblem;
    }
    
    public void setActualProblem(string val)
    {
        actualProblem = val;
    }
}
