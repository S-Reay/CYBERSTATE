using UnityEngine;
using UnityEditor;

public class SpawnRatesEditorWindow : EditorWindow
{
    public Object objectToEdit;
    public float vSbarValue;

    [MenuItem("CYBERSTATE/Enemy Spawn Rates")]
    public static void ShowWindow()
    {
        GetWindow<SpawnRatesEditorWindow>("Enemy Spawn Rates");
    }

    private void OnGUI()
    {
        objectToEdit = EditorGUILayout.ObjectField("Spawner: ", objectToEdit, typeof(GameObject), true);

        if (objectToEdit != null)
        {
            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < 92; i++)
            {
                GUILayout.Label((i + 1).ToString());
            }
            EditorGUILayout.EndHorizontal();
        }
    }
}
