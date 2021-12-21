using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Pin : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    Rigidbody2D rb;

    bool isPinned = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == KeyWords.rotatetag)
        {
            isPinned = true;
            Score.pinCount += 1 ;
            transform.SetParent(collision.transform);
        }
        else if (collision.tag == KeyWords.pintag)
        {
            Debug.Log("Game End");
            FindObjectOfType<LevelManager>().EndGame();
        }
    }
}
