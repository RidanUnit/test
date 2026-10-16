using UnityEngine;
using UnityEngine.Playables;

public class PLayble : MonoBehaviour
{

    public PlayableDirector CutScene;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Hero")
        {
            CutScene.Play();
            collision.gameObject.GetComponent<Hero>().walk.Stop();
            
        }
    }


}
