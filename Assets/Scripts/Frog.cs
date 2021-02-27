using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource hop;
    public static int lives;



    private void Awake()
    {
        lives = PlayerPrefs.GetInt("Lives");
    }
    void Update()
    {
        if (transform.position.x < 6 && transform.position.x > -6)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                rb.MovePosition(rb.position + Vector2.right);
                PlaySFX();
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                rb.MovePosition(rb.position + Vector2.left);
                PlaySFX();
            }

        }
        else if (transform.position.x == 6)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                rb.MovePosition(rb.position + Vector2.left);
                PlaySFX();
            }

        }
        else if (transform.position.x == -6)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                rb.MovePosition(rb.position + Vector2.right);
                PlaySFX();
            }
        }
        if (transform.position.y < 5 && transform.position.y > -5)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                rb.MovePosition(rb.position + Vector2.up);
                PlaySFX();
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                rb.MovePosition(rb.position + Vector2.down);
                PlaySFX();
            }

        }
        else if (transform.position.y == 5)
        {
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                rb.MovePosition(rb.position + Vector2.down);
                PlaySFX();
            }

        }
        else if (transform.position.y == -5)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                rb.MovePosition(rb.position + Vector2.up);
                PlaySFX();
            }
            
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Car")
        {

            if (lives > 1)
            {
                
                lives--;
                PlayerPrefs.SetInt("Lives", lives);
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else
            {
                lives--;
                PlayerPrefs.SetInt("Lives", lives);
                Debug.Log("Game Over!");
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    void PlaySFX()
    {
        if(PlayerPrefs.GetInt("SFX") == 1)
        {
            hop.Play();
        }
        
    }
    public void DestroyFrog()
    {
        Destroy(gameObject);
    }
}
