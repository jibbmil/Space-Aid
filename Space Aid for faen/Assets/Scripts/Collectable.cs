using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider collision)
    {
        collision.transform.localScale += Vector3.one * .2f;
        Destroy(gameObject);
    }
}
