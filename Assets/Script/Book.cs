using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this is the script for when the character collides with the book 
public class Book : MonoBehaviour
{
    // detect collisions between the player and the character 
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.BooksCollected();
            gameObject.SetActive(false);
        }
    }
}
