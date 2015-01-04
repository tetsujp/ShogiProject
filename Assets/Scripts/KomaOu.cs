using UnityEngine;
using System.Collections;

public class KomaOu : Koma {

    void Start()
    {
        komaKind = KomaKind.Ou;
        SetDirection();
    }
    void SetDirection(){

        Direction.SetDirection("leftUp","up","rightUp","left","right","leftDown","down","rightDown");
    }
}
