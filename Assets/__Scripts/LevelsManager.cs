using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    public static LevelsManager instance;
    public LevelData[] levelsData;

    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void LoadLevel()
    {

    }
}
