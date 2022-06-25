using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{
    //private Transform _t;
    [Header("追いかける対象")]
    public GameObject player;
    private NavMeshAgent nav;
    private GameObject t;

    // Start is called before the first frame update
    void Start()
    {
        //navMEを保持
        nav = GetComponent<NavMeshAgent>();
        t = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = t.transform.position;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "P_item")
        {
            Destroy(gameObject);
        }
    }
   /* private IEnumerator Corou1() //コルーチン関数の名前
    {
        //コルーチンの内容
        Debug.Log("スタート");
        yield return new WaitForSeconds(5.0f);
        Debug.Log("スタートから5秒後");
    }*/
}
