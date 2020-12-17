using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LAttack()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        Debug.Log("Left Attack");
    }

    public void RAttack()
    {
        transform.rotation = Quaternion.Euler(0, 0, 180);
        Debug.Log("Right Attack");
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //if(other.gameObject.CompareTag("Enemy"))
        //{
        //    Debug.Log("게임 오버");
        //}
    }
}
