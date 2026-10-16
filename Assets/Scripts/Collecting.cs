using UnityEngine;
using UnityEngine.UI;

public class Collecting : MonoBehaviour
{
    public float CollectingSpeed;
    public Text Count;
    public Player player;
    public GameObject bridge;
    public GameObject bridgeTable;
    public GameObject coll;
    public GameObject build;


    

    private void Start()
    {
        Count = GameObject.Find("Count").GetComponent<Text>();
    }
    private void OnTriggerStay2D(Collider2D Item)
    {
        /*
        if (Item.gameObject.tag == "Item")
        {
            player.animator.SetBool("IsCollecting", true);
            coll.SetActive(true);

            Item.gameObject.GetComponent<Item>().CollectingProgress += CollectingSpeed / 1200;
            if (Item.gameObject.GetComponent<Item>().CollectingProgress >= 1f)
            {
                int a = int.Parse(Count.text);
                a += 1000;
                Count.text = a.ToString();
                Destroy(Item.gameObject);
            }
        }

        if (Item.gameObject.tag == "Object")
        {
            player.animator.SetBool("IsCollecting", true);
            coll.SetActive(true);

            Item.gameObject.GetComponent<Object>().CollectingProgress += CollectingSpeed / 1200;
            if (Item.gameObject.GetComponent<Object>().CollectingProgress >= 1f)
            {
                Destroy(Item.gameObject);
            }
        }

        if (Item.gameObject.tag == "Bridge")
        {
            player.animator.SetBool("IsCollecting", true);
            build.SetActive(true);

            Item.gameObject.GetComponent<Bridge>().CollectingProgress += CollectingSpeed / 1200;
            if (Item.gameObject.GetComponent<Bridge>().CollectingProgress >= 1f)
            {
                bridge.SetActive(true);
                Destroy(bridgeTable);
            }
        }

        */
        switch (Item.gameObject.tag)
        {
            case "Item":
                player.animator.SetBool("IsCollecting", true);
                coll.SetActive(true);

                transform.position = new Vector3(transform.position.x + 0.0001f, transform.position.y, 0);

                Item.gameObject.GetComponent<Item>().CollectingProgress += CollectingSpeed / 1000;
                if (Item.gameObject.GetComponent<Item>().CollectingProgress >= 1f)
                {
                    int a = int.Parse(Count.text);
                    a += 1000;
                    Count.text = a.ToString();
                    Destroy(Item.gameObject);
                }
                Debug.Log("Collecting");
                break;

            case "Object":
                player.animator.SetBool("IsCollecting", true);
                coll.SetActive(true);

                transform.position = new Vector3(transform.position.x + 0.0001f, transform.position.y, 0);

                Item.gameObject.GetComponent<Object>().CollectingProgress += CollectingSpeed / 1200;
                if (Item.gameObject.GetComponent<Object>().CollectingProgress >= 1f)
                {
                    Destroy(Item.gameObject);
                }
                break;

            case "Bridge":
                player.animator.SetBool("IsCollecting", true);
                build.SetActive(true);

                transform.position = new Vector3(transform.position.x + 0.0001f, transform.position.y, 0);

                Item.gameObject.GetComponent<Bridge>().CollectingProgress += CollectingSpeed / 2500;
                if (Item.gameObject.GetComponent<Bridge>().CollectingProgress >= 1f)
                {
                    bridge.SetActive(true);
                    Destroy(bridgeTable);
                }
                break;
        }




    }

    private void OnTriggerExit2D(Collider2D Item)
    {
        if (Item.gameObject.tag == "Item")
        {
            coll.SetActive(false);
            player.animator.SetBool("IsCollecting", false);
            transform.position = new Vector3(transform.position.x - 0.006f, transform.position.y, 0f);
            Item.gameObject.GetComponent<Item>().CollectingProgress = 0f;
        }
        if (Item.gameObject.tag == "Object")
        {
            coll.SetActive(false);
            player.animator.SetBool("IsCollecting", false);
            transform.position = new Vector3(transform.position.x - 0.006f, transform.position.y, 0);
            Item.gameObject.GetComponent<Object>().CollectingProgress = 0f;
        }
        if (Item.gameObject.tag == "Bridge")
        {
            build.SetActive(false);
            player.animator.SetBool("IsCollecting", false);
            transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, 0f);
            Item.gameObject.GetComponent<Bridge>().CollectingProgress = 0f;
        }
        
    }


    

}
