using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 座標リスト作成ツール
{
    public partial class Main : Form
    {
        public static Bitmap 入力画像;
        public static TextBox 座標リスト;
        public static Label ポジション;

        public Main()
        {
            InitializeComponent();
            座標リスト = textBox_list;
            ポジション = label_pos;
        }

        private void Click_Open(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Multiselect = false,  // 複数選択の可否
                Filter =  // フィルタ
            "画像ファイル|*.bmp;*.gif;*.jpg;*.png|全てのファイル|*.*",
            };
            //ダイアログを表示
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // ファイル名をタイトルバーに設定
                this.Text = dialog.SafeFileName;
                //OpenCV処理
                if (入力画像 != null) 入力画像.Dispose();
                入力画像 = new Bitmap(dialog.FileName);
                //画像画面.Instance.Show();
                
            }
            
            写真画面.Instance.Show();
        }
        

        private void Click_Save(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
            };
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String 結果 = textBox_list.Text;

                using (StreamWriter w = new StreamWriter(dialog.FileName))
                {
                    w.Write(結果);
                    w.Dispose();
                }
            }

        }
    }
}
