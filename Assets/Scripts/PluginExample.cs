using UnityEngine;

public class PluginExample : MonoBehaviour
{
    private void Start()
    {
        MyPlugin.ID = 10;
        Debug.Log("ID: " + MyPlugin.ID);
    }
}
