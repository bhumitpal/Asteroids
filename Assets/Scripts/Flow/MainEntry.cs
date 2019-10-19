using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainEntry : MonoBehaviour
{
    private void Awake()
    {
        GameFlow.Instance.Initialize();
    }

    void Start()
    {
        GameFlow.Instance.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        GameFlow.Instance.Refresh();
    }

    void FixedUpdate()
    {
        GameFlow.Instance.PhysicsRefresh();
    }
}
