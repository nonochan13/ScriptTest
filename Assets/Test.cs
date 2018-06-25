using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //use this for initialization
    void Start()
    {
        //要素数5の配列を初期化する
        int[] array = { 2, 5, 7, 1, 6, };

        //配列の要素をすべて表示する
        for (int i=array.Length -1; 0<=i;i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update() {

        }
    
}


public class Boss
{
    private int mp = 53;          // 

    // 
    public void Attack()
    {
        Debug.Log(this.power + "魔法を攻撃をした。残りMPは〇〇");
    }

    // mpが足りない場合の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "MPが足りないため魔法が使えない。");
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言する
        Boss lastboss = new Boss();

        // 魔法攻撃用の関数を呼び出す
        lastboss.Attack();
        // 10回処理を繰り返す
        for (int i = 1; i < 10; i++)
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
    }

    // Update is called once per frame
    void Update()
    {

    }
}