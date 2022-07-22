using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] Kosu playerMovement;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "obstacle")
        {
            Debug.Log($"We hit {collisionInfo.collider.tag}");
            playerMovement.enabled = false;
            transform.Translate(new Vector3(0, 0, -5));
        }
    }
}
