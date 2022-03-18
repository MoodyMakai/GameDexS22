
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

   public Transform player;


    void Update()
    {
      //  Debug.Log(player.);
       GetComponent<TMPro.TextMeshProUGUI>().text = GameData.Score.ToString();
    }
}
