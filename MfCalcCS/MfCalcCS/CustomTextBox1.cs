using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MfCalcCS
{
    public partial class CustomTextBox1 : TextBox
    {
        // 独自の変数を保持するためのプライベートフィールド
        private int _textID = -1;

        // デザイン時やコードからアクセスできるようにするプロパティを定義
        [Category("カスタムプロパティ")] // プロパティウィンドウでの表示カテゴリ
        [DefaultValue(-1)] // プロパティのデフォルト値
        public int textID
        {
            get { return _textID; }
            // set
            // プロパティの値を外部から設定できるようにする場合はsetアクセサーも定義します。
            // 今回は内部でカウントアップするため、setアクセサーは読み取り専用にしても良いですが、
            // デザイン時からの設定を可能にするため、通常はpublic setをつけます。
            set
            {
                // 値のバリデーションが必要であればここに追加
                if (value >= 0)
                {
                    _textID = value;
                    // プロパティが変更されたときにコントロールの再描画などをトリガーすることも可能
                    // this.Invalidate(); 
                }
            }
        }

        public CustomTextBox1()
        {
        }
    }
}