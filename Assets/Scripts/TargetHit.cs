using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetHit : MonoBehaviour
{
    [SerializeField]
    GameManager gameManager;

    private void OnCollisionEnter(Collision collision)
    {
       if(collision.collider.tag == "food")
        {
            Destroy(collision.gameObject);

            gameManager.AddtoScore();
        }

       
    }
}
