using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager 
{
    #region singleton
    public static PlayerManager Instance
    {
        get
        {
            return instance ?? (instance = new PlayerManager());
        }
    }
    #endregion

    private static PlayerManager instance;
    public void Initialize()
    {
        Player.Instance.Initialize();
    }

    public void PhysicsRefresh()
    {
        Player.Instance.PhysicsRefresh();
    }

    public void PostInitialize()
    {
        Player.Instance.PostInitialize();
    }

    public void Refresh()
    {
        Player.Instance.Refresh();
    }

  
  
}
