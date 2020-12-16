using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EModule
{
    public float MoveSpeed;

    public enum Type
    {
        Enemy1,
        Enemy2,
        Enemy3
    }

    public Type type;

    public void InitEnemy()
    {
        switch (type)
        {
            case Type.Enemy1:
                MoveSpeed = 1f;
                break;
            case Type.Enemy2:
                MoveSpeed = 2f;
                break;
            case Type.Enemy3:
                MoveSpeed = 3f;
                break;
        }
    }
}
