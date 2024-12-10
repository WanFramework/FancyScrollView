using FancyScrollView;
using UnityEngine;
using UnityEditor;

// 使用UnityEditor命名空间创建自定义编辑器
[CustomEditor(typeof(FancyScrollRect<,>), true)]
public class FancyScrollRectEditor : Editor
{
    // 重写OnInspectorGUI方法以自定义检查器
    public override void OnInspectorGUI()
    {
        // 绘制默认检查器
        DrawDefaultInspector();
        // 获取目标对象的引用
        var iFancyScrollRect = (IFancyScrollRect)target;
        // 在检查器中添加一个按钮
        if (GUILayout.Button("ReLayout"))
        {
            // 按钮被点击时，调用Relayout方法
            iFancyScrollRect.RefreshLayout();
        }
    }
}
