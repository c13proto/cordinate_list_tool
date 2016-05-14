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
            SaveFileDialog sfd = new SaveFileDialog();//SaveFileDialogクラスのインスタンスを作成
            sfd.Filter = "csvファイル|*.csv|全てのファイル|*.*";//[ファイルの種類]に表示される選択肢を指定する
            sfd.FilterIndex = 1;//[ファイルの種類]ではじめに「画像ファイル」が選択されているようにする
            sfd.Title = "保存先のファイルを選択してください";//タイトルを設定する
            sfd.RestoreDirectory = true;//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            sfd.OverwritePrompt = true;//既に存在するファイル名を指定したとき警告する．デフォルトでTrueなので指定する必要はない
            sfd.CheckPathExists = true;//存在しないパスが指定されたとき警告を表示する．デフォルトでTrueなので指定する必要はない


            DialogResult result = sfd.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                String 結果 = textBox_list.Text;

                using (StreamWriter w = new StreamWriter(sfd.FileName))
                {
                    w.Write(結果);
                    w.Dispose();
                }
            }

        }
    }
}
