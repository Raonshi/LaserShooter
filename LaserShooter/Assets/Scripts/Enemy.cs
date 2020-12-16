using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EModule emodule = new EModule();
    Player player;
    Transform playerTr;
    public float MoveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        emodule.type = EModule.Type.Enemy1;
        emodule.InitEnemy();
        MoveSpeed = emodule.MoveSpeed;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTr.position, MoveSpeed * Time.deltaTime);
    }
}
