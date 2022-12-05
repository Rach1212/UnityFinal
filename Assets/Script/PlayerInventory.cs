using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 


// this is the player inventory 
public class PlayerInventory : MonoBehaviour
{
    [SerializeField] AudioSource collectSound;
    public int NumberOfBooks {get; private set; }

    public UnityEvent<PlayerInventory> OnBookCollected; 


    public void BooksCollected()
    {
        NumberOfBooks++;
        OnBookCollected.Invoke(this);
        collectSound.Play();
    }
}
