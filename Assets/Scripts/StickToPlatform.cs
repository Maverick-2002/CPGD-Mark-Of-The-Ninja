using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ninja")
        {
            collision.gameObject.transform.SetParent(transform);
        }
        if (collision.gameObject.name == "Ronin")
        {
            collision.gameObject.transform.SetParent(transform);
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ninja")
        {
            collision.gameObject.transform.SetParent(null);
        }
        if (collision.gameObject.name == "Ronin")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }


}
