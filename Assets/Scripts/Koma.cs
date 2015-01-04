using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public enum KomaKind
{
    Fu = 1,
    Ky = 2,
    Ke = 3,
    Gi = 4,
    Ki = 5,
    Ka = 6,
    Hi = 7,
    Ou = 8
};
//純粋仮想関数
public class Koma : MonoBehaviour
{

    private bool isSelect = false;
    private static bool isInputLeft = false;
    private float speed = 1f;
    private bool isEnemy = false;
   
    protected KomaKind komaKind;

    //画像
    SpriteRenderer image;
    //子から移動判定取得
    List<Collider2D> moveCollider;

    //本体の当たり判定
    Collider2D komaCollider;
    //子から攻撃判定取得

    // Use this for initialization
    void Start()
    {
        moveCollider = GetComponentsInChildren<Collider2D>().Where(z=>z.tag=="KomaMove").ToList();
        komaCollider = GetComponent<Collider2D>();
        image = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        isInputLeft = Input.GetMouseButtonDown(0);
        if (isInputLeft) InputAction();
    }

    void InputAction()
    {
        Vector2 worldPoint2d = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //選択判定
        if (komaCollider.OverlapPoint(worldPoint2d) == true)
        {
            Select();
        }
        //移動判定
        else if (isSelect==true&moveCollider.Where(z => z.OverlapPoint(worldPoint2d) == true).ToList().Count != 0)
        {
            Move();
        }
    }
    void Move()
    {
        //移動先へ設定
        //移動制限
        //isSelect = false;

        //移動可能
        // プレイヤーの位置が画面内に収まるように制限をかける
        //pos.x = Mathf.Clamp(pos.x, fieldVector[0].x, fieldVector[1].x);
        //pos.y = Mathf.Clamp(pos.y, fieldVector[1].y, fieldVector[0].y);
        //if (pos != (Vector2)transform.position) isClamp = true;
        // 制限をかけた値をプレイヤーの位置とする
        //transform.position = pos;
        Vector2 worldPoint2d = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //移動判定
            iTween.MoveTo(gameObject, iTween.Hash("x", worldPoint2d.x, "y", worldPoint2d.y, "speed", speed));

            isSelect = false;    
        ChangeColor();

    }

    void Select()
    {
        //クリックで選択状態
            isSelect = !isSelect;
            ChangeColor();
    }
    //select時画像色変更
    void ChangeColor()
    {
        //標準
        if (isSelect)
        {
            image.color = new Color(1f, 0.3f, 0.1f, 1f);
        }
        else
        {
            image.color = new Color(1f, 1f, 1f, 1f);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Koma")
        {

        }
    }



}
