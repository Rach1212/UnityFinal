using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 


// this is the player inventory 
public class PlayerInventory : MonoBehaviour
{
    public int NumberOfBooks {get; private set; }

    public UnityEvent<PlayerInventory> OnBookCollected; 


    public void BooksCollected()
    {
        NumberOfBooks++;
        OnBookCollected.Invoke(this);
    }
}
