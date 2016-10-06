using UnityEngine;

namespace XJ.Unity3D.Extensions
{
    /// <summary>
    /// Gizmos のユーティリティメソッドを実装します。
    /// </summary>
    public static class GizmosEx
    {
        /// <summary>
        /// 十字を描画します。
        /// </summary>
        /// <param name="position">
        /// 十字を描画する場所。
        /// </param>
        /// <param name="lineLength">
        /// 十字の線の長さ。
        /// </param>
        public static void DrawCross(Vector3 position, float lineLength)
        {
            Vector3 from = position;
            Vector3 to = position;
            float halfLength = lineLength / 2f;

            from.x = from.x - halfLength;
            to.x = to.x + halfLength;

            Gizmos.DrawLine(from, to);

            from = position;
            to = position;

            from.y = from.y - halfLength;
            to.y = to.y + halfLength;

            Gizmos.DrawLine(from, to);
        }
    }
}