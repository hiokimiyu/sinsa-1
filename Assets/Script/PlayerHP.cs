using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int life = 5;
    public Text _life;
    

    // Start is called before the first frame update
    void Start()
    {
        life = 5;
        _life.GetComponent<UnityEngine.UI.Text>().text = $"HPF{life}";
        Time.timeScale = 1;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            --life;
            if (life > 0)
            {
                _life.GetComponent<UnityEngine.UI.Text>().text = $"HP:{life}";
            }
            else
            {
                life = 0;
                //Time.timeScale = 0;
                _life.GetComponent<UnityEngine.UI.Text>().text = $"HP:{life}";
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
