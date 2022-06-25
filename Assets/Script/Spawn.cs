using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [Header("‚¦‚Ë")]
    public List<GameObject> _enemy;
    [Header("ww")]
    [SerializeField]private AudioClip _ac;
    private AudioSource _a;
    [Header("te")]
    [SerializeField]private AudioClip _at;
    [Header("img")]
    [SerializeField]private Image _img;
    //bool isImg;

    private void Start()
    {
        _a = GetComponent<AudioSource>();
        //isImg = false;
    }


    void Hand()
    {
        _img.enabled = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            int _sp = Random.Range(0, 6);
            Debug.Log(_sp);

            if (_sp < 2)
            {
                int _r = Random.Range(0, 3);
                int _x = Random.Range(0, 21);
                int _z = Random.Range(-20, 21);
                Vector3 _spe = new Vector3(_x, 0, _z);
                Instantiate(_enemy[_r], _spe, _enemy[_r].transform.rotation);
            }
            else if (_sp < 4)
            {
                _a.PlayOneShot(_ac);
            }
            else if (_sp < 5)
            {

            }
            else if (_sp == 5)
            {
                _img.enabled = true;
                _a.PlayOneShot(_at);
                Invoke("Hand", 1f);
            }
        }
    }
}
