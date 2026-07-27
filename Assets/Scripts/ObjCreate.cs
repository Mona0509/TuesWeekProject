using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjCreate : MonoBehaviour
{
    [SerializeField] private GameObject notesPrefab;
    private bool isCreate = true;

    public void CreateNotes()
    {
        Instantiate(notesPrefab);
    }

}
