using System.Collections;
using System.Collections.Generic;
using UnityEngine;
usinf UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currenthealth = 10
    public int maxHealth = 10
    public AudioSource audioSource;
    public AudioClip damageSound;

    public void TakeDamage(int damage){
        currenthealth -= damage

        if(currenthealth > 0){
            audioSource.PlayOneShot(damageSound);
        }
    
        else{
            int escenaInicio = SceneManager.GetActiveScene().buldIndex;
            SceneManager.LoadScene(escenaInicio);
        }
    }

}
