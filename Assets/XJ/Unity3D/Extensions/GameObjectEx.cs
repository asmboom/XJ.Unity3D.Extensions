using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// GameObject 型の拡張メソッドやユーティリティメソッドを実装します。
    /// </summary>
    public static class GameObjectEx
    {
        /// <summary>
        /// この GameObject に追加されたコンポーネントから、指定した型のコンポーネントのみを削除します。
        /// </summary>
        /// <typeparam name="T">
        /// Component Type.
        /// </typeparam>
        /// <param name="self">
        /// GameObject.
        /// </param>
        public static void RemoveComponent<T>(this GameObject self) where T : Component
        {
            GameObject.Destroy(self.GetComponent<T>());
        }

        /// <summary>
        /// この GameObject に追加された、すべての Component を削除します。
        /// </summary>
        /// <param name="self">
        /// GameObject.
        /// </param>
        public static void RemoveAllComponent(this GameObject self)
        {
            Component[] components = self.GetComponents<Component>();

            for (int i = 0; i < components.Length; i++)
            {
                GameObject.DestroyImmediate(components[i]);
            }
        }
    }
}