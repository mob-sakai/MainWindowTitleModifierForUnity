using System;
using UnityEditor;

namespace MainWindowTitleModifier
{
    // To compile this assembly:
    //   1. Select MainWindowTitleModifier.asmdef in project view
    //   2. Right click and select 'Internal Accessible > Compile'
    //   3. MainWindowTitleModifier.dll will be regenerated and reloaded.
    //   4. Enjoy!
    public class Solution3_IgnoresAccessChecksToAttribute
    {
        [MenuItem("MainWindowTitleModifier/Solution3_IgnoresAccessChecksToAttribute", priority = 3)]
        static void Update()
        {
            Action<ApplicationTitleDescriptor> cb = x => x.title = "Solution3_IgnoresAccessChecksToAttribute";
            EditorApplication.updateMainWindowTitle += cb;
            EditorApplication.UpdateMainWindowTitle();
            EditorApplication.updateMainWindowTitle -= cb;
        }
    }
}
