using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Boss
{
    private int mp = 53;          // 
    private int power = 30;
    // 
    public void Attack()
    {
        Debug.Log(this.power + "魔法を攻撃をした。残りMPは〇〇");
    }
    // mpが足りない場合の関数
    public void Magic(int cost)
    {

        if (mp<cost)
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
        else
        {
            // mpを5減らす
            this.mp = mp - cost;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }

    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        //要素数5の配列を初期化する
        int[] array = { 2, 5, 7, 1, 6, };

        //配列の要素をすべて表示する
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        //配列の要素をすべて逆表示する
        for (int i = array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }

        // Bossクラスの変数を宣言する
        Boss lastboss = new Boss();

        // 魔法攻撃用の関数を呼び出す
        lastboss.Attack();

        // 10回処理を繰り返す
        for (int i = 0; i < 11; i++)
        {
            // 防御用の関数を呼び出す
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}