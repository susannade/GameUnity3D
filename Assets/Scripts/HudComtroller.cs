using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudComtroller : MonoBehaviour 
{
    public GameObject Hp;
    public Sprite FullHp;
    public Sprite MidHp;
    public Sprite LowHp;
    public Sprite Dead;
    public Text score;
    public Text stars;

    
    void Start()
{

}

    // Update is called once per frame
    void Update()
    {
        
        if (PlayerController.health==3){
            Hp.GetComponent<Image>().sprite=FullHp;
        }
        else if(PlayerController.health==2){
            Hp.GetComponent<Image>().sprite=MidHp;
        }
        else if(PlayerController.health==1){
            Hp.GetComponent<Image>().sprite=LowHp;
        }
        else{
            Hp.GetComponent<Image>().sprite=Dead;
        }
        score.text=PlayerController.score.ToString();
        stars.text=PlayerController.stars.ToString();

    }
}
