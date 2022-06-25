using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genkan : MonoBehaviour
{
    private Animator _g;
    [Header("‚¦‚Ë")]
    public List<GameObject> _e;
    private float _c;
    int _r = 0;
    public ItemPic _i;

    // Start is called before the first frame update
    void Start()
    {
        _g = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _c += Time.deltaTime;
        GameObject _item= GameObject.FindGameObjectWithTag("Item3");
        if(_i.isKey3 == true)
        {
            _g.SetBool("Genkan", true);
        }
        if(_item == null && _c > 2.5)
        {
            _r = Random.Range(0, 3);
            int _rx = Random.Range(0, 21);
            int _rz = Random.Range(-20, 21);
            Vector3 _spe = new Vector3(_rx, 0, _rz);
            Instantiate(_e[_r], _spe, _e[_r].transform.rotation);
            _c = 0;
        }
    }
}
