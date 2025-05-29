using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.name == "Player")
       {
          Destroy(gameObject);

       }
    }
}
