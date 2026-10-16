using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    
    public float DistanceRay;
    public GameObject Portal;


    private void Update()
    {
        RayDraw();
    }

    public GameObject Hit;
    public Animator animator;

    public void Death()
    {
        Hit.SetActive(true);
        animator.Play("Death");
    }

    public void Active()
    {
        gameObject.SetActive(false);
    }

    void RayDraw()
    {

        
        Ray ray = new Ray(transform.position, new Vector2(transform.position.x, -2f) * DistanceRay);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(transform.position.x, -2f) * DistanceRay);
        Debug.DrawRay(transform.position, new Vector2(transform.position.x, -2f) * DistanceRay, Color.yellow);



        if (hit.collider.tag == "Hero")
        {
            Portal.SetActive(true);
        }

    }
}
