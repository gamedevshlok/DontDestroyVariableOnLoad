using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamedevshlok : Monobehaviour
{
    private void Awake()
    {
        //Calling Object.DontDestroyOnLoad to preserve an object during scene loading
        DontDestroyOnLoad(gameObject);
    }
}
















