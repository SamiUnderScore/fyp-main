using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;

public static class Data
{
    public static int totalLevels;

    public static int currentLevel
    {
        get { return PlayerPrefs.GetInt("currentLevel", 0); }
        set { PlayerPrefs.SetInt("currentLevel", value); }
    }

    public static int cash
    {
        get { return PlayerPrefs.GetInt("cash", 0); }
        set { PlayerPrefs.SetInt("cash", value); }
    }

    //public static int cash
    //{
    //    get { return PlayerPrefs.GetInt("cash", 0); }
    //    set { PlayerPrefs.SetInt("cash", value); }
    //}

    public static void LoadData()
    {

    }

    public static void SaveData()
    {

    }
}

