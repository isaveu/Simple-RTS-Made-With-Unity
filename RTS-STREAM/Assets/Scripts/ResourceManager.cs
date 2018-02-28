﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    [SerializeField]
    int Resources;
    public int resources
    {
        get { return Resources; }
        set
        {
            Resources = value;
            whenResourcesChanges.Invoke(Resources);
        }
    }
    public MyIntEvent whenResourcesChanges;

    public static ResourceManager singleton;

    void Awake()
    {
        if (singleton != null)
        {
            Destroy(gameObject);
            return;
        }
        singleton = this;
    }
}
