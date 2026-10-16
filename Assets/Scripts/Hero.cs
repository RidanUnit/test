using UnityEngine;

public class Hero : MonoBehaviour
{
    public float speed;
    public GameObject StopPanel;
    public GameObject StopPanelBridge;
    public Animator animator;
    public bool IsWalk = true;
    public AudioSource walk;

    private void Update()
    {
        Walk();
    }

    void Walk()
    {
        if (IsWalk == true)
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }
        
    }

    void WalkCutscene()
    {
        walk.Play();
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            enemy.gameObject.GetComponent<Enemy>().Death();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Object")
        {
            Debug.Log("Idle");
            StopPanel.SetActive(true);
            animator.Play("Idle");
            IsWalk = false;
            walk.Stop();
        }

        if (collision.gameObject.tag == "Bridge")
        {
            Debug.Log("Idle");
            StopPanelBridge.SetActive(true);
            animator.Play("Idle");
            IsWalk = false;
            walk.Stop();
        }

        if (collision.gameObject.tag == "Tower")
        {
            
        }

        if (collision.gameObject.tag == "Mage")
        {
            collision.gameObject.GetComponent<Mage>().Death();
        }
    }




}
