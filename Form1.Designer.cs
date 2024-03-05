namespace XAMPP_Backfast
{
    partial class XAMPP_Backfast
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XAMPP_Backfast));
            this.labelLogo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCopy = new System.Windows.Forms.TextBox();
            this.inputPaste = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonCopy = new System.Windows.Forms.Button();
            this.ButtonPaste = new System.Windows.Forms.Button();
            this.copyPasteBox = new System.Windows.Forms.GroupBox();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.presetsBox = new System.Windows.Forms.GroupBox();
            this.ListboxPresets = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.textEvents = new System.Windows.Forms.Label();
            this.workerBox = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.copyPasteBox.SuspendLayout();
            this.presetsBox.SuspendLayout();
            this.workerBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogo
            // 
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Praetorian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.Location = new System.Drawing.Point(11, 5);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(278, 27);
            this.labelLogo.TabIndex = 0;
            this.labelLogo.Text = "XAMPP Backfast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copy";
            // 
            // inputCopy
            // 
            this.inputCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputCopy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCopy.ForeColor = System.Drawing.Color.White;
            this.inputCopy.Location = new System.Drawing.Point(52, 25);
            this.inputCopy.Name = "inputCopy";
            this.inputCopy.Size = new System.Drawing.Size(236, 26);
            this.inputCopy.TabIndex = 2;
            this.inputCopy.Text = "C:\\";
            // 
            // inputPaste
            // 
            this.inputPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.inputPaste.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPaste.ForeColor = System.Drawing.Color.White;
            this.inputPaste.Location = new System.Drawing.Point(52, 57);
            this.inputPaste.Name = "inputPaste";
            this.inputPaste.Size = new System.Drawing.Size(236, 26);
            this.inputPaste.TabIndex = 4;
            this.inputPaste.Text = "C:\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Paste";
            // 
            // ButtonCopy
            // 
            this.ButtonCopy.BackColor = System.Drawing.Color.Green;
            this.ButtonCopy.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCopy.ForeColor = System.Drawing.Color.White;
            this.ButtonCopy.Location = new System.Drawing.Point(294, 25);
            this.ButtonCopy.Name = "ButtonCopy";
            this.ButtonCopy.Size = new System.Drawing.Size(26, 22);
            this.ButtonCopy.TabIndex = 5;
            this.ButtonCopy.Text = "◢";
            this.ButtonCopy.UseVisualStyleBackColor = false;
            this.ButtonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
            // 
            // ButtonPaste
            // 
            this.ButtonPaste.BackColor = System.Drawing.Color.Green;
            this.ButtonPaste.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPaste.ForeColor = System.Drawing.Color.White;
            this.ButtonPaste.Location = new System.Drawing.Point(294, 57);
            this.ButtonPaste.Name = "ButtonPaste";
            this.ButtonPaste.Size = new System.Drawing.Size(26, 21);
            this.ButtonPaste.TabIndex = 6;
            this.ButtonPaste.Text = "◢";
            this.ButtonPaste.UseVisualStyleBackColor = false;
            this.ButtonPaste.Click += new System.EventHandler(this.ButtonPaste_Click);
            // 
            // copyPasteBox
            // 
            this.copyPasteBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.copyPasteBox.Controls.Add(this.ButtonCreate);
            this.copyPasteBox.Controls.Add(this.ButtonClear);
            this.copyPasteBox.Controls.Add(this.inputCopy);
            this.copyPasteBox.Controls.Add(this.ButtonPaste);
            this.copyPasteBox.Controls.Add(this.label2);
            this.copyPasteBox.Controls.Add(this.ButtonCopy);
            this.copyPasteBox.Controls.Add(this.label3);
            this.copyPasteBox.Controls.Add(this.inputPaste);
            this.copyPasteBox.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyPasteBox.ForeColor = System.Drawing.Color.White;
            this.copyPasteBox.Location = new System.Drawing.Point(16, 36);
            this.copyPasteBox.Name = "copyPasteBox";
            this.copyPasteBox.Size = new System.Drawing.Size(331, 133);
            this.copyPasteBox.TabIndex = 7;
            this.copyPasteBox.TabStop = false;
            this.copyPasteBox.Text = "Copy / paste folders";
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.BackColor = System.Drawing.Color.Green;
            this.ButtonCreate.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreate.ForeColor = System.Drawing.Color.White;
            this.ButtonCreate.Location = new System.Drawing.Point(97, 98);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(223, 27);
            this.ButtonCreate.TabIndex = 13;
            this.ButtonCreate.Text = "Copy";
            this.ButtonCreate.UseVisualStyleBackColor = false;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.Maroon;
            this.ButtonClear.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.Color.White;
            this.ButtonClear.Location = new System.Drawing.Point(9, 98);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(82, 27);
            this.ButtonClear.TabIndex = 14;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // presetsBox
            // 
            this.presetsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.presetsBox.Controls.Add(this.ListboxPresets);
            this.presetsBox.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presetsBox.ForeColor = System.Drawing.Color.White;
            this.presetsBox.Location = new System.Drawing.Point(353, 36);
            this.presetsBox.Name = "presetsBox";
            this.presetsBox.Size = new System.Drawing.Size(142, 133);
            this.presetsBox.TabIndex = 8;
            this.presetsBox.TabStop = false;
            this.presetsBox.Text = "Presets";
            // 
            // ListboxPresets
            // 
            this.ListboxPresets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ListboxPresets.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListboxPresets.ForeColor = System.Drawing.Color.White;
            this.ListboxPresets.FormattingEnabled = true;
            this.ListboxPresets.ItemHeight = 18;
            this.ListboxPresets.Location = new System.Drawing.Point(6, 21);
            this.ListboxPresets.Name = "ListboxPresets";
            this.ListboxPresets.Size = new System.Drawing.Size(130, 112);
            this.ListboxPresets.TabIndex = 0;
            this.ListboxPresets.SelectedIndexChanged += new System.EventHandler(this.ListboxPresets_SelectedIndexChanged);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBar.Location = new System.Drawing.Point(6, 25);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(389, 18);
            this.progressBar.TabIndex = 9;
            // 
            // textEvents
            // 
            this.textEvents.AutoSize = true;
            this.textEvents.BackColor = System.Drawing.Color.Black;
            this.textEvents.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEvents.ForeColor = System.Drawing.Color.White;
            this.textEvents.Location = new System.Drawing.Point(401, 25);
            this.textEvents.Name = "textEvents";
            this.textEvents.Size = new System.Drawing.Size(58, 18);
            this.textEvents.TabIndex = 10;
            this.textEvents.Text = "Waiting";
            // 
            // workerBox
            // 
            this.workerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.workerBox.Controls.Add(this.progressBar);
            this.workerBox.Controls.Add(this.textEvents);
            this.workerBox.Font = new System.Drawing.Font("Omega Flight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerBox.ForeColor = System.Drawing.Color.White;
            this.workerBox.Location = new System.Drawing.Point(16, 175);
            this.workerBox.Name = "workerBox";
            this.workerBox.Size = new System.Drawing.Size(479, 54);
            this.workerBox.TabIndex = 14;
            this.workerBox.TabStop = false;
            this.workerBox.Text = "Worker";
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.Color.Maroon;
            this.ButtonExit.Font = new System.Drawing.Font("Omega Flight Title", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.White;
            this.ButtonExit.Location = new System.Drawing.Point(435, 5);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(63, 27);
            this.ButtonExit.TabIndex = 15;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // XAMPP_Backfast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(509, 238);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.workerBox);
            this.Controls.Add(this.presetsBox);
            this.Controls.Add(this.copyPasteBox);
            this.Controls.Add(this.labelLogo);
            this.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(509, 238);
            this.MinimumSize = new System.Drawing.Size(509, 238);
            this.Name = "XAMPP_Backfast";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wrapped Chicken";
            this.copyPasteBox.ResumeLayout(false);
            this.copyPasteBox.PerformLayout();
            this.presetsBox.ResumeLayout(false);
            this.workerBox.ResumeLayout(false);
            this.workerBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCopy;
        private System.Windows.Forms.TextBox inputPaste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonCopy;
        private System.Windows.Forms.Button ButtonPaste;
        private System.Windows.Forms.GroupBox copyPasteBox;
        private System.Windows.Forms.GroupBox presetsBox;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label textEvents;
        private System.Windows.Forms.GroupBox workerBox;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.ListBox ListboxPresets;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button ButtonClear;
    }
}

