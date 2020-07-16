using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

namespace FiveInRow
{
    public partial class EllipseButton : Control
    {
        /// <summary>
        /// ボタンの縁の表示
        /// </summary>
        [Browsable(true)]
        [Description("ボタンの縁の表示")]
        [Category("表示")]
        public bool DisplayBorder
        {
            get => _DisplayBorder;
            set
            {
                _DisplayBorder = value;
                Refresh();
            }
        }

        /// <summary>
        /// ボタンの縁の色
        /// </summary>
        [Browsable(true)]
        [Description("ボタンの縁の色")]
        [Category("表示")]
        public Color BorderColor
        {
            get => _BorderColor;
            set
            {
                _BorderColor = value;
                Refresh();
            }
        }

        /// <summary>
        /// 角丸の半径
        /// </summary>
        /// <remarks>
        /// getで描画上の制限を加えた状態にする。
        /// setではなんでも入るようにする。
        /// こうすることでIDEでの表示に対応できる。
        /// 
        /// set側で制限をかけると、IDEでの表示時にwidthとheightが0から始まるため、
        /// Radiusの値が強制的に0になり、表示ができない。
        /// </remarks>
        [Browsable(true)]
        [Description("角丸の半径")]
        [Category("表示")]
        public int Radius
        {
            get
            {
                if (_Radius < 0)
                    return 0;

                var diameter = (uint)_Radius * 2;
                if (Width < diameter || Height < diameter)
                    return ((Width < Height) ? Width : Height) / 2;

                return _Radius;
            }
            set
            {
                _Radius = value;
                Refresh();
            }
        }

        bool _DisplayBorder = true;
        Color _BorderColor = Color.Gray;
        int _Radius = int.MaxValue;



        protected override CreateParams CreateParams
        {
            get
            {
                // コントロールの透明化
                // ※親コントロール描画時に、本コントロールのRegion内の領域も描画してくれるようになる
                // ※兄弟関係による最前面、最背面の概念がなくなる
                //     この拡張コントロールと他のコントロールを兄弟関係で重ねると、重ねた領域の描画が後勝ちになる
                // ※ControlStyles.OptimizedDoubleBufferは透明度をサポートしていないため、これと併用するとRegion内を黒で塗りつぶされる
                //     よってバッファリングできないのでちらつくようになる。また、処理毎に描画するので動作が重くなる
                var WS_EX_TRANSPARENT = 0x20;
                var createParams = base.CreateParams;
                createParams.ExStyle = createParams.ExStyle | WS_EX_TRANSPARENT;
                return createParams;
            }
        }
    }
}
