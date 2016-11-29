using UnityEngine; //Unityに準備されている機能
using System.Collections;//データを格納する型を使うための宣言をしている

public class Boss{
	private int hp = 100; //自分のHP
	private int power = 25; //自分の攻撃力
	private int mp = 53; //自分のマジックポイント

	//攻撃用の関数
	public void Attack(int plus){
		Debug.Log (this.power + plus + "のダメージを与えた");
	}


	//防御用の関数

	public void Defence(int damage){
		Debug.Log (damage + "のダメージを受けた");

		//残りのHPを減らす
		this.hp -= damage;

		//残りのHPを表示
		Debug.Log ("残りのhpは" + hp + "!");
	}

	//魔法攻撃の関数
	public void Magic(){

		//1回の魔法でmpを5消費する
		this.mp -= 5;

			Debug.Log ( "魔法攻撃をした。残りのMPは" + mp + "。");

		if (mp <= 5) {
			
			Debug.Log ("MPが足りないので魔法が使えない。");

		}

	}
		

}
	
public class Test : MonoBehaviour {  //スクリプト名とクラス名は同じでなくてはならない

	// Use this for initialization


	void Start(){
		//Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss();

		//攻撃用の関数を呼び出す
		lastboss.Attack(5);

		//防御用の関数を呼び出す
		lastboss.Defence(3);

		//魔法攻撃用の関数を呼び出す。*10回
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
		lastboss.Magic();
	

	}




	// Update is called once per frame
	void Update () {
	
	}
}