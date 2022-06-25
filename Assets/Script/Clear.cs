using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    private Collider _c;
    private GameObject _i;
    public float _time;
    private int _m;
    public ItemPic _pic;

    // Start is called before the first frame update
    void Start()
    {
        _c = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
       if(_pic.isKey3 == true)
        {
            _c.enabled = true;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == ("Player"))
        {
            Debug.Log("ÉNÉäÉA");
            _time = Time.timeScale = 0;
            SceneManager.LoadScene("ResultScene");
        }
    }
}
