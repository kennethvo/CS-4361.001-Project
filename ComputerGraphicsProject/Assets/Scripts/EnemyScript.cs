using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{

    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision");
        if (other.collider.tag == "Player")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
