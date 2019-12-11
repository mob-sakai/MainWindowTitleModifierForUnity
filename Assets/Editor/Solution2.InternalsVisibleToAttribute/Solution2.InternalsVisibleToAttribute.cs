using System;
using UnityEditor;

namespace MainWindowTitleModifier
{
    public class Solution2_InternalsVisibleToAttribute
    {
        [MenuItem("MainWindowTitleModifier/Solution2_InternalsVisibleToAttribute", priority = 2)]
        static void Update()
        {
            Action<ApplicationTitleDescriptor> cb = x => x.title = "Solution2_InternalsVisibleToAttribute";
            EditorApplication.updateMainWindowTitle += cb;
            EditorApplication.UpdateMainWindowTitle();
            EditorApplication.updateMainWindowTitle -= cb;
        }
    }
}
