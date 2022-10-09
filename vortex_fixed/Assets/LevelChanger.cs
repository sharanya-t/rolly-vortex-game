using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChanger : MonoBehaviour
{
    private string leveltoload;
    public Animator animator;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeToLevel(string name)
    {
        leveltoload = name;
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeComplete()
    {
        SceneManager.LoadScene("Vortex");
    }
}
