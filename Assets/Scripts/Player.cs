using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Animator animator;
    public AudioSource run;

    private void Update()
    {
        Run();
    }

    void Run()
    {
        if (Input.GetButton("Horizontal"))
        {
            run.Play();
            if (Input.GetAxis("Horizontal") <= 0.1f)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }else if(Input.GetAxis("Horizontal") >= 0.1f)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }


            animator.SetBool("IsRunning", true);
            transform.position = new Vector3(transform.position.x + Input.GetAxis("Horizontal") * speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        else { animator.SetBool("IsRunning", false); run.Stop(); }

        

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire");
        }
    }

    public GameObject Hero;
    public GameObject DeathPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-5, 5), ForceMode2D.Impulse);
        }

        if (collision.gameObject.tag == "Fireball")
        {
            Hero.gameObject.GetComponent<Hero>().IsWalk = false;
            Hero.gameObject.GetComponent<Hero>().walk.Stop();
            Hero.gameObject.GetComponent<Hero>().animator.Play("Idle");
            DeathPanel.SetActive(true);

            gameObject.SetActive(false);
        }
    }


}
