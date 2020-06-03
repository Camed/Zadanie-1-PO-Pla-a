namespace Kopakabana
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.ShowOgnieTeam = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.ShowLinaTeam = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ShowPlazowaTeam = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.siatkowkaNameBox = new System.Windows.Forms.TextBox();
            this.removeSiatkowkaButton = new System.Windows.Forms.Button();
            this.addSiatkowkaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listDwaOgnie = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listLina = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listSiatkowka = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(692, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.saveChangesButton);
            this.tabPage1.Controls.Add(this.ShowOgnieTeam);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.ShowLinaTeam);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.ShowPlazowaTeam);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.siatkowkaNameBox);
            this.tabPage1.Controls.Add(this.removeSiatkowkaButton);
            this.tabPage1.Controls.Add(this.addSiatkowkaButton);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listDwaOgnie);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.listLina);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listSiatkowka);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(684, 395);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Druzyny";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Location = new System.Drawing.Point(594, 334);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(75, 50);
            this.saveChangesButton.TabIndex = 22;
            this.saveChangesButton.Text = "Zapisz zmiany";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // ShowOgnieTeam
            // 
            this.ShowOgnieTeam.Location = new System.Drawing.Point(464, 335);
            this.ShowOgnieTeam.Name = "ShowOgnieTeam";
            this.ShowOgnieTeam.Size = new System.Drawing.Size(61, 23);
            this.ShowOgnieTeam.TabIndex = 21;
            this.ShowOgnieTeam.Text = "Pokaz";
            this.ShowOgnieTeam.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(531, 335);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Usun";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(397, 335);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Dodaj";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // ShowLinaTeam
            // 
            this.ShowLinaTeam.Location = new System.Drawing.Point(267, 335);
            this.ShowLinaTeam.Name = "ShowLinaTeam";
            this.ShowLinaTeam.Size = new System.Drawing.Size(61, 23);
            this.ShowLinaTeam.TabIndex = 18;
            this.ShowLinaTeam.Text = "Pokaz";
            this.ShowLinaTeam.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(334, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Usun";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(200, 335);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "Dodaj";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ShowPlazowaTeam
            // 
            this.ShowPlazowaTeam.Location = new System.Drawing.Point(70, 335);
            this.ShowPlazowaTeam.Name = "ShowPlazowaTeam";
            this.ShowPlazowaTeam.Size = new System.Drawing.Size(61, 23);
            this.ShowPlazowaTeam.TabIndex = 15;
            this.ShowPlazowaTeam.Text = "Pokaz";
            this.ShowPlazowaTeam.UseVisualStyleBackColor = true;
            this.ShowPlazowaTeam.Click += new System.EventHandler(this.ShowPlazowaTeam_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(397, 364);
            this.textBox3.MaxLength = 128;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 364);
            this.textBox2.MaxLength = 128;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 13;
            // 
            // siatkowkaNameBox
            // 
            this.siatkowkaNameBox.Location = new System.Drawing.Point(3, 364);
            this.siatkowkaNameBox.MaxLength = 128;
            this.siatkowkaNameBox.Name = "siatkowkaNameBox";
            this.siatkowkaNameBox.Size = new System.Drawing.Size(191, 20);
            this.siatkowkaNameBox.TabIndex = 12;
            // 
            // removeSiatkowkaButton
            // 
            this.removeSiatkowkaButton.Location = new System.Drawing.Point(137, 335);
            this.removeSiatkowkaButton.Name = "removeSiatkowkaButton";
            this.removeSiatkowkaButton.Size = new System.Drawing.Size(57, 23);
            this.removeSiatkowkaButton.TabIndex = 7;
            this.removeSiatkowkaButton.Text = "Usun";
            this.removeSiatkowkaButton.UseVisualStyleBackColor = true;
            this.removeSiatkowkaButton.Click += new System.EventHandler(this.removeSiatkowkaButton_Click);
            // 
            // addSiatkowkaButton
            // 
            this.addSiatkowkaButton.Location = new System.Drawing.Point(3, 335);
            this.addSiatkowkaButton.Name = "addSiatkowkaButton";
            this.addSiatkowkaButton.Size = new System.Drawing.Size(61, 23);
            this.addSiatkowkaButton.TabIndex = 6;
            this.addSiatkowkaButton.Text = "Dodaj";
            this.addSiatkowkaButton.UseVisualStyleBackColor = true;
            this.addSiatkowkaButton.Click += new System.EventHandler(this.addSiatkowkaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dwa Ognie:";
            // 
            // listDwaOgnie
            // 
            this.listDwaOgnie.FormattingEnabled = true;
            this.listDwaOgnie.Location = new System.Drawing.Point(397, 26);
            this.listDwaOgnie.Name = "listDwaOgnie";
            this.listDwaOgnie.Size = new System.Drawing.Size(191, 303);
            this.listDwaOgnie.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Przeciaganie liny:";
            // 
            // listLina
            // 
            this.listLina.FormattingEnabled = true;
            this.listLina.Location = new System.Drawing.Point(200, 26);
            this.listLina.Name = "listLina";
            this.listLina.Size = new System.Drawing.Size(191, 303);
            this.listLina.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Siatkowka plazowa:";
            // 
            // listSiatkowka
            // 
            this.listSiatkowka.FormattingEnabled = true;
            this.listSiatkowka.Location = new System.Drawing.Point(3, 26);
            this.listSiatkowka.Name = "listSiatkowka";
            this.listSiatkowka.Size = new System.Drawing.Size(191, 303);
            this.listSiatkowka.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(684, 395);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sedziowie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(684, 395);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mecze";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 421);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.Text = "Turniej Kopakabana";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listSiatkowka;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button removeSiatkowkaButton;
        private System.Windows.Forms.Button addSiatkowkaButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listDwaOgnie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listLina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox siatkowkaNameBox;
        private System.Windows.Forms.Button ShowOgnieTeam;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button ShowLinaTeam;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ShowPlazowaTeam;
        private System.Windows.Forms.Button saveChangesButton;
    }
}

