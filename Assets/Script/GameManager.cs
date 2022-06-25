using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //private float _time;
    //private int _m;
    //public Clear _c;
    //[SerializeField] private Text _text;
    //public ItemPic _key;
    [SerializeField] GameObject _p;
    


    // Start is called before the first frame update
    void Start()
    {
        //_text = GetComponent<Text>();
        _p.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _p.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Made()
    {
        _p.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    /*private void Times()
    {
        _time += Time.deltaTime;
        Debug.Log(_time);
        if (_time > 60)
        {
            _m++;
            _time = 0;
        }
        
    }*/
}
