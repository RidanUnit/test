using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Fireball;

    private void Start()
    {

    }

    void SpawnFireball()
    {
        Instantiate(Fireball, transform.position, Quaternion.identity);
    }


}
