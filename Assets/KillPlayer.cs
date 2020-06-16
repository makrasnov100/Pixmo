using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.gameObject.tag == "Enamy")
        {
            GameController.instance.ShowGameOver();
            Destroy(gameObject);
        }

        if (collision.rigidbody.gameObject.tag == "End")
        {
            GameController.instance.ShowGameOver();
        }
    }
}
