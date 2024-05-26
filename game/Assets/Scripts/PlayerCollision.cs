using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour 
{

    public PlayerMvt movement;
    public GameObject[] quizPanels;
    public List<GameObject> cylinders;
    private bool[] quizActivated;

    private void Start()
    {
        quizActivated = new bool[quizPanels.Length];
    }

    void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        else if (collision.collider.tag == "Question")
        {

            string cylinderName = collision.collider.gameObject.name;
            int cylinderNumber;
            if (int.TryParse(cylinderName.Replace("Cylinder", ""), out cylinderNumber))
            {
                if (cylinderNumber > 0 && cylinderNumber <= quizPanels.Length)
                {

                    if (!quizActivated[cylinderNumber - 1])
                    {
                        movement.enabled = false;
                        Time.timeScale = 0;

                        foreach (GameObject panel in quizPanels)
                        {
                            panel.SetActive(false);
                        }

                        quizPanels[cylinderNumber - 1].SetActive(true);
                        quizActivated[cylinderNumber - 1] = true;

                    }
                }
                else
                {
                    Debug.LogError("Cylinder number out of range: " + cylinderNumber);
                }
            }
            else
            {
                Debug.LogError("Failed to parse cylinder number from name: " + cylinderName);
            }
           

        }
    }

}
