using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Checker : MonoBehaviour
{
    [Header("‚¦‚Ë")]
    public List<GameObject> _enemy;
    public DeleteObject target;
   // public DeleteObject _i;
    int _sp;
    int _r;
    

    private AudioSource _audio;
    //[Header("enemyBGM")]
    //private AudioClip _a;

    private void Start()
    {
        //_audio = GetComponent<AudioSource>();
        /*GameObject[] _tag = GameObject.FindGameObjectsWithTag("item");
        GameObject[] _tag1 = GameObject.FindGameObjectsWithTag("Item1");
       _iL = _tag.Length;
        _t.text = $"{_iL}";
        _iL1 = _tag1.Length;*/
    }


    void OnEnable()
    {
        target.OnDestroyed.AddListener(() => {
            Debug.Log("target‚ªDestroy‚³‚ê‚Ü‚µ‚½");
            // ‚±‚±‚Éˆ—‚ğ’Ç‰Á
            _sp = Random.Range(0, 2);
            Debug.Log(_sp);

            if (_sp < 1)
            {
                _r = Random.Range(0, 3);
                int _rx = Random.Range(0, 21);
                int _rZ = Random.Range(-20, 20);
                Vector3 _spe = new Vector3(_rx, 0, _rZ);
                Instantiate(_enemy[_r], _spe, _enemy[_r].transform.rotation);
            }
            
        });

            /*_i.OnDestroyed.AddListener(() => {
                Debug.Log("target‚ªDestroy‚³‚ê‚Ü‚µ‚½2");
                // ‚±‚±‚Éˆ—‚ğ’Ç‰Á

                if (_count > 3)
                {
                    Debug.Log("enm");
                    Vector3 _spe = new Vector3(0, 0, 0);
                    Instantiate(_enemy, _spe, _enemy.transform.rotation);
                }
            
        });*/
        
    }
    
}
/*if(_iL > 0)
            {
                _iL -= 1;
                _t.text = $"{_iL}";
            }
            if(_iL == 0)
            {
                isIL = true;
            }
            if(isIL == true && _iL1 > 0)
            {
                _iL1 -= 1;
                _t.text = $"{_iL1}";
            }*/