using UnityEngine;

public class StunEnemy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("si entra xd");
        PlayerPhysics player = other.GetComponent<PlayerPhysics>();
        if (player != null)
        {
            player.Stun();
        }
        
    }
}
