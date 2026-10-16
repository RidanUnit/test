using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    System.Random rand = new System.Random();
    public float CollectingProgress = 0f;
    

    void Start()
    {
        
        int x = rand.Next(-7, 7);
        int y = rand.Next(-7, 7);

        

        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y), ForceMode2D.Impulse);
    }





}
