using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if(other.collider.tag == "Player")
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

}
