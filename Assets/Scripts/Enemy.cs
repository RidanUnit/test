using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Hit;
    public Animator animator;
    public GameObject[] Item;

    public void Death()
    {
        Hit.SetActive(true);
        animator.Play("Death");
        Debug.Log("Enemy is find");
    }

    public void Active()
    {
        gameObject.SetActive(false);
    }

    System.Random rand = new System.Random();

    public void DropItem()
    {
        Vector3 pos = transform.position;
        for (int i = 0; i < Item.Length; i++)
        {
            Debug.Log("Drop item" + Item[i]);
            Instantiate(Item[i], pos, Quaternion.identity);
            int x = rand.Next(2, 5);
            int y = rand.Next(2, 5);

            Item[i].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y), ForceMode2D.Impulse);
        }
        //Item[0].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(500, 500, 0));
    }



}
