using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    void Start()
    {
        LevelsManager.instance.LoadLevel();
    }


    void Update()
    {
        
    }
}
