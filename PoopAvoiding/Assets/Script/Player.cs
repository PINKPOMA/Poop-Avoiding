using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField]private float moveSpeed;
    [SerializeField]private int hp;
    void Update()
    {
        Move();
        Wall();
    }

    void Wall()
    {
        if (transform.position.x < -8.45)
            transform.position = new Vector2(-8.45f, transform.position.y);
        if (transform.position.x > 8.45)
            transform.position = new Vector2(8.45f, transform.position.y);
    }
    void Move()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Poop"))
        {
            hp--;
            if (hp < 1)
                SceneManager.LoadScene("GameOverScene");
            Destroy(col.gameObject);
        }
    }
}
