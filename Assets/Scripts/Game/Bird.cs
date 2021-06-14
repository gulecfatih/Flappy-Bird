using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    public bool isDead;
    public bool stop;
   [SerializeField] float velocity;
    Rigidbody2D myrigidbody2D;

    public GameManager gameManager;
    public GameObject deadScreen;
    public GameObject týklama;
    public Button playbutton;
    public Button stopbutton;
   
    bool deger = true;

    void Start()
    {
        myrigidbody2D = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }

    public void Stop()
    {
        if (!isDead)
        {
            Time.timeScale = 0;
            stopbutton.gameObject.SetActive(false);
            playbutton.gameObject.SetActive(true);

        }
        
    }
    public void Play()
    {
        if (!isDead)
        {
        Time.timeScale = 1;
        stopbutton.gameObject.SetActive(true);
        playbutton.gameObject.SetActive(false);
        }
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            if (deger)
            {
                deger = false;
                týklama.SetActive(false);
                Time.timeScale = 1;
            }
            FindObjectOfType<SesKontrol>().ZiplamaSes();
            myrigidbody2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            gameManager.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeadArea")
        {

            FindObjectOfType<SesKontrol>().OyunBittiSes();
            deadScreen.SetActive(true);
            isDead = true;
            Time.timeScale = 0;
        }
    }
}
