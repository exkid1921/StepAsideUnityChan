using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //削除ラインとの距離
    private float Distance;


    // Use this for initialization
    void Start()
    {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんと削除ラインの位置（z座標）の差を求める
        this.Distance = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせて削除ラインの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - Distance);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
