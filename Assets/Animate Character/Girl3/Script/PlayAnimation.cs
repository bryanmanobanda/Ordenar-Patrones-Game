using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {

  
    public Animator Ani;
    public Sprite[] Spr;
    public SpriteRenderer sprR;
   
    public bool onlySpr = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayAni(string str)
    {
       
        Ani.enabled = true;
        Ani.ForceStateNormalizedTime(0.0f);
        Ani.Play(str);

    }




    public void ChangeSpr(int num)
    {
        if (onlySpr)
        {
            
        }
        else {
           
            Ani.ForceStateNormalizedTime(0.0f);
            Ani.enabled = false;           
        }

        sprR.sprite = Spr[num];
    }

  

}
