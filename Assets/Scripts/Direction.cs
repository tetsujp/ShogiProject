using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Direction : MonoBehaviour
{

    Vector2 blockSize = new Vector2(1f,1f);
    static Dictionary<string, Vector2> directionTable = new Dictionary<string, Vector2>();
    Direction()
    {
        //前
        directionTable["leftUp"] = new Vector2(-1, 1);
        directionTable["up"] = new Vector2(0, 1);
        directionTable["rightUp"] = new Vector2(1, 1);

        //左右
        directionTable["left"] = new Vector2(-1, 0);
        directionTable["right"] = new Vector2(1, 0);

        //後ろ
        directionTable["leftDown"] = new Vector2(-1, -1);
        directionTable["down"] = new Vector2(0, -1);
        directionTable["rightDown"] = new Vector2(-1, -1);

        //桂馬
        directionTable["leftUpUp"] = new Vector2(-1, 2);
        directionTable["rightUpUp"] = new Vector2(1, 2);

    }
    //引数として文字列を渡し、移動方向をセットする
    public static List<Vector2> SetDirection(params string[] dir)
    {
        List<Vector2> list = new List<Vector2>();
        foreach (var s in dir)
        {
            list.Add(directionTable[s]);
        }
        return list;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
