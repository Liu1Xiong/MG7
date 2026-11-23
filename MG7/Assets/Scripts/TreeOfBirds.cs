using UnityEngine;

// Step 1: write the TreeOfBirds class in this file!
public class TreeOfBirds : MonoBehaviour
{
    [SerializeField] private GameObject[] _sparrows;
    [SerializeField] private float _interactionDistance = 5.0f;
    [SerializeField] private Transform _player;
    void Update()
    {
        foreach (GameObject bird in _sparrows)
        {
            if (bird != null && _player != null)
            {
                float distance = Vector3.Distance(bird.transform.position, _player.position);
                if (distance <= _interactionDistance)
                {
                    bird.SetActive(true);
                }
            }
        }
    }
}