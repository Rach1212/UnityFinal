using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cross : MonoBehaviour
{
    void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "penguin")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
