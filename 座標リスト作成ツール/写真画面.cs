using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 座標リスト作成ツール
{
    public partial class 写真画面 : Form
    {
        private static 写真画面 _instance;
        Bitmap 入力画像;
        Bitmap 表示画像;


        public 写真画面()
        {
            InitializeComponent();
            if (入力画像 != null) 入力画像.Dispose();
            if (表示画像 != null) 表示画像.Dispose();
            入力画像 = (Bitmap)Main.入力画像.Clone();
            表示画像 = (Bitmap)入力画像.Clone();
            pictureBox.Image = 表示画像;
        }


        public static 写真画面 Instance
        {
            get
            {
                //_instanceがnullまたは破棄されているときは、
                //新しくインスタンスを作成する
                if (_instance == null || _instance.IsDisposed)
                    _instance = new 写真画面();
                return _instance;
            }
        }

        private void Click_PictureBox(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                //テキストボックスに座標入れ込む処理
                double 倍率 = (double)表示画像.Width / (double)入力画像.Width;
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                System.Drawing.Point cp = this.PointToClient(sp);

                Main.座標リスト.Text += (int)((cp.X - pictureBox.Location.X) / 倍率) + ","
                                            + (int)((cp.Y - pictureBox.Location.Y) / 倍率) + "\n";

                ////描画させる処理
                //表示画像.SetPixel(cp.X - pictureBox.Location.X, cp.Y - pictureBox.Location.Y, Color.Green);
                //pictureBox.Image = 表示画像;
            }
        }

        private void Click_Resize(object sender, EventArgs e)
        {
            if (表示画像 != null) 表示画像.Dispose();
            double 倍率 = double.Parse(textBox_Resize.Text);

            表示画像 = new Bitmap((int)(入力画像.Width * 倍率), (int)(入力画像.Height * 倍率));

            Graphics g = Graphics.FromImage(表示画像);
            g.DrawImage(入力画像, 0, 0, 表示画像.Width, 表示画像.Height);

            //Graphicsオブジェクトのリソースを解放する
            g.Dispose();
            //PictureBoxに表示する
            pictureBox.Image = 表示画像;
        }

        private void MouseMove_pictureBox(object sender, MouseEventArgs e)
        {
            if (pictureBox.Image != null)
            {
                double 倍率 = (double)表示画像.Width / (double)入力画像.Width;
                System.Drawing.Point sp = System.Windows.Forms.Cursor.Position;
                System.Drawing.Point cp = this.PointToClient(sp);
                Main.ポジション.Text = +(int)((cp.X - pictureBox.Location.X) / 倍率) + ","
                                                + (int)((cp.Y - pictureBox.Location.Y) / 倍率);
            }
        }
    }
}
