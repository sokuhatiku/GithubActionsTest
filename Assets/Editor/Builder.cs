using UnityEditor;

public static class Builder 
{
    public static void Build()
    {
        AssetDatabase.ExportPackage("Assets/Scenes", "Build.unitypackage");
    }
}
