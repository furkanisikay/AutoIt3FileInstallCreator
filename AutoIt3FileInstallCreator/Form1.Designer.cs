namespace AutoIt3FileInstallCreator
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGozat = new MaterialSkin.Controls.MaterialButton();
            this.txtKlasor = new MaterialSkin.Controls.MaterialTextBox();
            this.chckKaynakDahil = new MaterialSkin.Controls.MaterialSwitch();
            this.txtHedefDizinFormat = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOrnekCikti = new MaterialSkin.Controls.MaterialTextBox();
            this.btnOlustur = new MaterialSkin.Controls.MaterialButton();
            this.chckSubFolderCreate = new MaterialSkin.Controls.MaterialSwitch();
            this.chckHedefAnaDizinDahil = new MaterialSkin.Controls.MaterialSwitch();
            this.SuspendLayout();
            // 
            // btnGozat
            // 
            this.btnGozat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGozat.Depth = 0;
            this.btnGozat.DrawShadows = true;
            this.btnGozat.HighEmphasis = true;
            this.btnGozat.Icon = null;
            this.btnGozat.Location = new System.Drawing.Point(511, 81);
            this.btnGozat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGozat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(69, 36);
            this.btnGozat.TabIndex = 0;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGozat.UseAccentColor = false;
            this.btnGozat.UseVisualStyleBackColor = true;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // txtKlasor
            // 
            this.txtKlasor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKlasor.Depth = 0;
            this.txtKlasor.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtKlasor.Hint = "Dosyaların Bulunduğu Klasör";
            this.txtKlasor.Location = new System.Drawing.Point(12, 74);
            this.txtKlasor.MaxLength = 32767;
            this.txtKlasor.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKlasor.Multiline = false;
            this.txtKlasor.Name = "txtKlasor";
            this.txtKlasor.Size = new System.Drawing.Size(492, 50);
            this.txtKlasor.TabIndex = 1;
            this.txtKlasor.Text = "";
            // 
            // chckKaynakDahil
            // 
            this.chckKaynakDahil.AutoSize = true;
            this.chckKaynakDahil.Depth = 0;
            this.chckKaynakDahil.Location = new System.Drawing.Point(11, 130);
            this.chckKaynakDahil.Margin = new System.Windows.Forms.Padding(0);
            this.chckKaynakDahil.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckKaynakDahil.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckKaynakDahil.Name = "chckKaynakDahil";
            this.chckKaynakDahil.Ripple = true;
            this.chckKaynakDahil.Size = new System.Drawing.Size(299, 37);
            this.chckKaynakDahil.TabIndex = 3;
            this.chckKaynakDahil.Text = "Ana klasörü kaynak dizine dahil et";
            this.chckKaynakDahil.UseVisualStyleBackColor = true;
            this.chckKaynakDahil.CheckedChanged += new System.EventHandler(this.chckKaynakDahil_CheckedChanged);
            // 
            // txtHedefDizinFormat
            // 
            this.txtHedefDizinFormat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHedefDizinFormat.Depth = 0;
            this.txtHedefDizinFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtHedefDizinFormat.Hint = "Hedef dosya dizini formatı";
            this.txtHedefDizinFormat.Location = new System.Drawing.Point(12, 250);
            this.txtHedefDizinFormat.MaxLength = 50;
            this.txtHedefDizinFormat.MouseState = MaterialSkin.MouseState.OUT;
            this.txtHedefDizinFormat.Multiline = false;
            this.txtHedefDizinFormat.Name = "txtHedefDizinFormat";
            this.txtHedefDizinFormat.Size = new System.Drawing.Size(569, 50);
            this.txtHedefDizinFormat.TabIndex = 4;
            this.txtHedefDizinFormat.Text = "\"{0}\"";
            this.txtHedefDizinFormat.TextChanged += new System.EventHandler(this.txtHedefDizinFormat_TextChanged);
            // 
            // txtOrnekCikti
            // 
            this.txtOrnekCikti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOrnekCikti.Depth = 0;
            this.txtOrnekCikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOrnekCikti.Hint = "Örnek Çıktı";
            this.txtOrnekCikti.Location = new System.Drawing.Point(12, 306);
            this.txtOrnekCikti.MaxLength = 50;
            this.txtOrnekCikti.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOrnekCikti.Multiline = false;
            this.txtOrnekCikti.Name = "txtOrnekCikti";
            this.txtOrnekCikti.ReadOnly = true;
            this.txtOrnekCikti.Size = new System.Drawing.Size(569, 50);
            this.txtOrnekCikti.TabIndex = 4;
            this.txtOrnekCikti.Text = "{0}";
            // 
            // btnOlustur
            // 
            this.btnOlustur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOlustur.Depth = 0;
            this.btnOlustur.DrawShadows = true;
            this.btnOlustur.HighEmphasis = true;
            this.btnOlustur.Icon = null;
            this.btnOlustur.Location = new System.Drawing.Point(246, 404);
            this.btnOlustur.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOlustur.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(86, 36);
            this.btnOlustur.TabIndex = 0;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOlustur.UseAccentColor = false;
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // chckSubFolderCreate
            // 
            this.chckSubFolderCreate.AutoSize = true;
            this.chckSubFolderCreate.Depth = 0;
            this.chckSubFolderCreate.Location = new System.Drawing.Point(11, 207);
            this.chckSubFolderCreate.Margin = new System.Windows.Forms.Padding(0);
            this.chckSubFolderCreate.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckSubFolderCreate.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckSubFolderCreate.Name = "chckSubFolderCreate";
            this.chckSubFolderCreate.Ripple = true;
            this.chckSubFolderCreate.Size = new System.Drawing.Size(305, 37);
            this.chckSubFolderCreate.TabIndex = 3;
            this.chckSubFolderCreate.Text = "Ana klasördeki alt klasörleri oluştur";
            this.chckSubFolderCreate.UseVisualStyleBackColor = true;
            this.chckSubFolderCreate.CheckedChanged += new System.EventHandler(this.chckKaynakDahil_CheckedChanged);
            // 
            // chckHedefAnaDizinDahil
            // 
            this.chckHedefAnaDizinDahil.AutoSize = true;
            this.chckHedefAnaDizinDahil.Depth = 0;
            this.chckHedefAnaDizinDahil.Location = new System.Drawing.Point(9, 167);
            this.chckHedefAnaDizinDahil.Margin = new System.Windows.Forms.Padding(0);
            this.chckHedefAnaDizinDahil.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckHedefAnaDizinDahil.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckHedefAnaDizinDahil.Name = "chckHedefAnaDizinDahil";
            this.chckHedefAnaDizinDahil.Ripple = true;
            this.chckHedefAnaDizinDahil.Size = new System.Drawing.Size(288, 37);
            this.chckHedefAnaDizinDahil.TabIndex = 3;
            this.chckHedefAnaDizinDahil.Text = "Ana klasörü hedef dizine dahil et";
            this.chckHedefAnaDizinDahil.UseVisualStyleBackColor = true;
            this.chckHedefAnaDizinDahil.CheckedChanged += new System.EventHandler(this.chckHedefAnaDizinDahil_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 455);
            this.Controls.Add(this.txtOrnekCikti);
            this.Controls.Add(this.txtHedefDizinFormat);
            this.Controls.Add(this.chckHedefAnaDizinDahil);
            this.Controls.Add(this.chckSubFolderCreate);
            this.Controls.Add(this.chckKaynakDahil);
            this.Controls.Add(this.txtKlasor);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.btnGozat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoIt3 FileInstall Oluşturucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnGozat;
        private MaterialSkin.Controls.MaterialTextBox txtKlasor;
        private MaterialSkin.Controls.MaterialSwitch chckKaynakDahil;
        private MaterialSkin.Controls.MaterialTextBox txtHedefDizinFormat;
        private MaterialSkin.Controls.MaterialTextBox txtOrnekCikti;
        private MaterialSkin.Controls.MaterialButton btnOlustur;
        private MaterialSkin.Controls.MaterialSwitch chckSubFolderCreate;
        private MaterialSkin.Controls.MaterialSwitch chckHedefAnaDizinDahil;
    }
}

