using UnityEngine;
using System.Collections;

public class Koma : MonoBehaviour {

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


    public KomaKind kind;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        //相手の攻撃内
        if (other.tag == "Attack")
        {

        }
    }

}
