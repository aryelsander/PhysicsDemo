using System;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public Action<GameObject> OnEnterColission;
    public string collisionTag;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(collisionTag))
        {
            Debug.Log($"Boost {collision.gameObject}");
           OnEnterColission(collision.gameObject);
        }
    }

}
