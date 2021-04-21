using UnityEngine;
using UnityEditor;

public class SpawnRatesEditorWindow : EditorWindow
{
    private Vector2 scrollPosition = Vector2.zero;

    private SpawnWalkingBot walkSpawnL, walkSpawnR;
    private SpawnFlyingBot flySpawnL, flySpawnR;
    private int[] spawnRates_Fly_L = new int[92];
    private int[] spawnRates_Walk_L = new int[92];
    private int[] spawnRates_Walk_R = new int[92];
    private int[] spawnRates_Fly_R = new int[92];

    [MenuItem("CYBERSTATE/Enemy Spawn Rates")]
    public static void ShowWindow()
    {
        GetWindow<SpawnRatesEditorWindow>("Enemy Spawn Rates");
    }

    private void OnGUI()
    {
        walkSpawnL = GameObject.FindGameObjectWithTag("Walk_Spawn_L").GetComponent<SpawnWalkingBot>();
        walkSpawnR = GameObject.FindGameObjectWithTag("Walk_Spawn_R").GetComponent<SpawnWalkingBot>();
        flySpawnL = GameObject.FindGameObjectWithTag("Fly_Spawn_L").GetComponent<SpawnFlyingBot>();
        flySpawnR = GameObject.FindGameObjectWithTag("Fly_Spawn_R").GetComponent<SpawnFlyingBot>();

        if (walkSpawnL != null && walkSpawnR != null && flySpawnL != null && flySpawnR)
        {
            scrollPosition = GUILayout.BeginScrollView(scrollPosition, false, false);

            EditorGUILayout.BeginVertical();

            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < 92; i++)
            {
                GUILayout.BeginVertical();
                spawnRates_Fly_L[i] = EditorGUILayout.IntField(spawnRates_Fly_L[i], GUILayout.Width(20));
                //GUILayout.Label((i + 1).ToString());
                GUILayout.EndVertical();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < 92; i++)
            {
                GUILayout.BeginVertical();
                spawnRates_Walk_L[i] = EditorGUILayout.IntField(spawnRates_Walk_L[i], GUILayout.Width(20));
                //GUILayout.Label((i + 1).ToString());
                GUILayout.EndVertical();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < 92; i++)
            {
                GUILayout.BeginVertical();
                spawnRates_Walk_R[i] = EditorGUILayout.IntField(spawnRates_Walk_R[i], GUILayout.Width(20));
                //GUILayout.Label((i + 1).ToString());
                GUILayout.EndVertical();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();

            EditorGUILayout.BeginHorizontal();
            for (int i = 0; i < 92; i++)
            {
                GUILayout.BeginVertical();
                spawnRates_Fly_R[i] = EditorGUILayout.IntField(spawnRates_Fly_R[i], GUILayout.Width(20));
                GUILayout.Label((i + 1).ToString());
                GUILayout.EndVertical();
            }
            EditorGUILayout.EndHorizontal();
            EditorGUILayout.Space();

            EditorGUILayout.EndVertical();
            GUILayout.EndScrollView();

        }
        else
        {
            GUILayout.Label
                ("Error: could not locate spawners.\n" +
                "Please ensure the scene has 4 empty objects, each with one of the following tags:\n" +
                "Walk_Spawn_L\n" +
                "Walk_Spawn_R\n" +
                "Fly_Spawn_L\n" +
                "Fly_Spawn_R");
        }
    }

    private void Update()
    {
        walkSpawnL.spawnRates = spawnRates_Walk_L;
        walkSpawnR.spawnRates = spawnRates_Walk_R;
        flySpawnL.spawnRates = spawnRates_Fly_L;
        flySpawnR.spawnRates = spawnRates_Fly_R;
    }
}
