using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn: MonoBehaviour
{
    [Header("‚¦‚Ë")]
    public List<GameObject> _enmy;



    void OnEnable()
    {
        target.OnDestroyed.AddListener(() => {
            Debug.Log("target‚ªDestroy‚³‚ê‚Ü‚µ‚½");
            // ‚±‚±‚Éˆ—‚ğ’Ç‰Á
            int _sp = Random.Range(0, 2);
            Debug.Log(_sp);

            if (_sp < 2)
            {
                Vector3 _spe = new Vector3(0, 0, 0);
                Instantiate(_enmy[2], _spe, _enmy[1].transform.rotation);
            }
        });
    }

    public DeleteObject target;
    void OnDisable()
    {
        target.OnDestroyed.RemoveAllListeners();
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*int _sp = Random.Range(0, 2);
        Debug.Log(_sp);
        if (_sp < 2)
        {
            Vector3 _spe = new Vector3(0, 0, 0);
            Instantiate(_enmy, _spe, _enmy.transform.rotation);
        }*/
    }
}
