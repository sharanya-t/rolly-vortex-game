using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Credits : MonoBehaviour
{
    
   
    public void Restart()
    {
        Spawner.score = 0;
        Audiomanager.Instance.gameObject.GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Vortex");
    }

    public void Quitapp()

    {
        Application.Quit();

    }
}
