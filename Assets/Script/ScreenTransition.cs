using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenTransition : MonoBehaviour
{
    [SerializeField] string _s = "Title";
    [SerializeField] float _c = 2f;
    private float timer = 0f;
    bool istimer = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(istimer)
        {
            Debug.Log(timer);
            Debug.Log(istimer);
            timer += Time.deltaTime;
            if(_c < timer)
            {
                SceneManager.LoadScene(_s);
            }
        }
    }
    public void _st()
    {
        istimer = true;
    }

    //’Ç‰Á‚µ‚½
    //ƒ{ƒ^ƒ“‚ð‰Ÿ‚µ‚½Žž‚Ìˆ—
    public void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void LoadTitelScene()
    {
        SceneManager.LoadScene("Title");
    }
    public void LoadGameOverScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    public void LoadResultScene()
    {
        SceneManager.LoadScene("ResultScene");
    }
}