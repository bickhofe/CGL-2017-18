using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class TweenObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.transform.DOLocalMoveY(4, 2).SetEase(Ease.OutElastic).SetLoops(-1, LoopType.Yoyo);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
