using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class SceneChanger : MonoBehaviour
{
    public void LoadMap()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Map Scene");
    }

    void Update()
    {
        // Enterキーが押された瞬間
        if (Keyboard.current != null &&
        (Keyboard.current.enterKey.wasPressedThisFrame ||
         Keyboard.current.numpadEnterKey.wasPressedThisFrame))
        {
            LoadMap();
        }
    }
}
