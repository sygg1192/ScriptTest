﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// 要素数5の配列を初期化する
		int[] array = new int[5];

		// 配列の各要素に値を代入する
		array [0] = 10;
		array [1] = 20;
		array [2] = 30;
		array [3] = 40;
		array [4] = 50;

		// 配列の要素を順に表示する
		for (int i = 0; i < 5; i++) {
			Debug.Log (array [i]);
		}

		// 配列の要素を逆順に表示する
		for (int k = 5 -1; k >= 0; k--) {
			Debug.Log (array [k]);
		}
	}
	// Update is called once per frame
	void Update (){
	}
}
