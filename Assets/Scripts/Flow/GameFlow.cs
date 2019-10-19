using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFlow 
{
    #region singleton
    // Start is called before the first frame update
    public static GameFlow Instance
    {
        get
        {
            if (instance == null)
                instance = new GameFlow();
            return instance;
        }
    }
    #endregion
    private static GameFlow instance;
    public void Initialize()
    {
        PlayerManager.Instance.Initialize();
    }

    public void PhysicsRefresh()
    {
        PlayerManager.Instance.PhysicsRefresh();
    }

    public void PostInitialize()
    {
        PlayerManager.Instance.PostInitialize();
    }

    public void Refresh()
    {
        PlayerManager.Instance.PostInitialize();
    }
}
