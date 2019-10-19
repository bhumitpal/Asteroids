using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : IManager

{
    // Start is called before the first frame update
    #region singleton
    public static Player Instance
    {
        get
        {
            return instance ?? (instance = new Player());
        }
    }
    #endregion
    private static Player instance;

    public void Initialize()
    {
        
    }

    public void PostInitialize()
    {
        
    }

    public void Refresh()
    {
        
    }

    public void PhysicsRefresh()
    {
        
    }
    
}
