using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Coin" || target.tag == "Bomb")
        {
            Destroy(target.gameObject);
        }
    }
}
