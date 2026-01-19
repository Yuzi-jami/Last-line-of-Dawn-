using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerLife : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private Animator anim;
    
    [SerializeField] private AudioSource deathSound;
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();
     anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Trap")
        {
            deathSound.Play();      
            Die();
        }
    }

    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
