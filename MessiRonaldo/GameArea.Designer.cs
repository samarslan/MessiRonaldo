namespace MessiRonaldo
{
    partial class GameArea
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameArea));
            this.imageListRonaldo = new System.Windows.Forms.ImageList(this.components);
            this.imageListMessi = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // imageListRonaldo
            // 
            this.imageListRonaldo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListRonaldo.ImageStream")));
            this.imageListRonaldo.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListRonaldo.Images.SetKeyName(0, "r1.png");
            this.imageListRonaldo.Images.SetKeyName(1, "r2.png");
            this.imageListRonaldo.Images.SetKeyName(2, "r3.png");
            this.imageListRonaldo.Images.SetKeyName(3, "r4.png");
            this.imageListRonaldo.Images.SetKeyName(4, "r5.png");
            this.imageListRonaldo.Images.SetKeyName(5, "r6.png");
            this.imageListRonaldo.Images.SetKeyName(6, "r7.png");
            // 
            // imageListMessi
            // 
            this.imageListMessi.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMessi.ImageStream")));
            this.imageListMessi.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMessi.Images.SetKeyName(0, "m1.png");
            this.imageListMessi.Images.SetKeyName(1, "m2.png");
            this.imageListMessi.Images.SetKeyName(2, "m3.png");
            this.imageListMessi.Images.SetKeyName(3, "m4.png");
            this.imageListMessi.Images.SetKeyName(4, "m5.png");
            this.imageListMessi.Images.SetKeyName(5, "m6.png");
            this.imageListMessi.Images.SetKeyName(6, "m7.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GameArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "GameArea";
            this.Size = new System.Drawing.Size(500, 585);
            this.Load += new System.EventHandler(this.GameArea_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListRonaldo;
        private System.Windows.Forms.ImageList imageListMessi;
        private System.Windows.Forms.Timer timer1;
    }
}
