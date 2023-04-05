using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneDirector : MonoBehaviour
{
    public GameObject PrefabCircle;
    public GameObject PrefabCross;
    public GameObject Result;
    public GameObject TextResult;

    int nowPlayer;

    int[] board =
    {
        -1, -1, -1,
        -1, -1, -1,
        -1, -1, -1,
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 次のモードへ行くかどうか
        bool next = false;


        // 置く処理
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (null != hit.collider)
            {
                Vector3 pos = hit.collider.gameObject.transform.position;

                //取得した座標から配列番号に戻す
                int x = (int)pos.x + 1;
                int y = (int)pos.y + 1;

            }

        }
    }
}
