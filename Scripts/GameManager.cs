using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    float deathHeight = 36f; // Þetta virkar ekki og get ekki fattað það þannig ég skil það bara eftir hálf brotið
    Vector3 startPos; // á að spawna player hér þegar hann deyr
    public Text lives;
    int lif = 3;
    bool killed = false;
    public Transform player;

    private void Start()
    {
        startPos = player.position;
    }

    void Update() { // Checkar fyrir hluti á hverju frame
        if (player.position.y < deathHeight) {
            KillPlayer();
            killed = true;
        }
        lives.text = lif.ToString();
        //Debug.Log(player.position.y);
    }

    void KillPlayer() { // Þetta á að virka en eitthvað bug er að láta þetta bila
        if (killed) {
            lif--;
            player.position = startPos;
            killed = false;
        }
    }
    public void AddHealth() { // Bætir við lífi við pickUp
        lif++;
    }
}
