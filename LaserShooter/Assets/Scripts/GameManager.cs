using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Singleton
    {
        get
        {
            if (instance == null)
            {
                GameObject obj = GameObject.Find("GameManager");

                if (obj == null)
                {
                    obj = new GameObject("GameManager");
                    obj.AddComponent<GameManager>();
                    DontDestroyOnLoad(obj);
                }

                instance = obj.GetComponent<GameManager>();
            }
            return instance;
        }
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
