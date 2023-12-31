using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cprnPrefabを入れる
    public GameObject conePrefab;
    //スターと地点
    private int startPos = 80;        
    //ゴール地点
    private int goalPos = 360;
    //アイテムを出すｘ方向の範囲
    private float posRange = 3.4f; 
    //試す　z範囲
    private float posRangeZ =40;
    private int TopGenerationRange = 0;
    private GameObject unitychan;

    // Start is called before the first frame update
    void Start()
    {
        /*
        
        //一定の距離ごとにアイテムを生成
        for (int i =startPos; i < goalPos; i+=15)
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range (1,11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate (conePrefab);
                    cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, i);

                }
            }
            else
            {
                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1,11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5,6);
                    //60%コイン配置：３０％車配置：10％何もなし
                    if (1 <= item && item <=6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate (coinPrefab);
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                        

                    }
                    else if (7<= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate (carPrefab);
                        car.transform.position = new Vector3 (posRange * j,car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }*/
        this.unitychan = GameObject.Find("unitychan");
        this.TopGenerationRange = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        if (TopGenerationRange < goalPos && TopGenerationRange < (unitychan.transform.position.z+posRangeZ) )
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range (1,11);
            if (num <= 2)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate (conePrefab);
                    cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, TopGenerationRange);

                }
            }
            else
            {
                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1,11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5,6);
                    //60%コイン配置：３０％車配置：10％何もなし
                    if (1 <= item && item <=6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate (coinPrefab);
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, TopGenerationRange + offsetZ);
                        

                    }
                    else if (7<= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate (carPrefab);
                        car.transform.position = new Vector3 (posRange * j,car.transform.position.y, TopGenerationRange + offsetZ);
                    }
                }
            }
            TopGenerationRange+=15;
        }
 
        
    }
}
